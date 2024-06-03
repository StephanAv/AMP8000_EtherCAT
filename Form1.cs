using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TCatSysManagerLib;
using TwinCAT.Ads;
using System.Reflection;
using System.Threading;
using System.Xml;
using System.Net.NetworkInformation;
using TwinCAT.TypeSystem;



namespace AMP8000_EtherCAT
{
    public partial class Form1 : Form
    {
        //Visual Studio Instance
        static EnvDTE.DTE _dte;
        //Solution Instance
        static EnvDTE.Solution _solution;
        //Project Instance
        static EnvDTE.Project _project;
        //SystemManager Object
        static ITcSysManager10 _systemManager;
        // Path to home folder
        static string _home = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        static string _target_dir = _home + "\\Temp\\AMP8000_EtherCAT";
        static string _tmp_dir = System.IO.Path.GetTempPath() + "\\AMP8000_EtherCAT";
        static string ipv4EcMaster;
        static string ipb4EcGateway = "192.168.67.254";

        static bool isUnlocked = false;

        AdsClient clientEcMaster;
        AdsClient clientEcSlave;
        AdsClient clientRouter;

        static AmsAddress amsAddrEcMaster;
        CancellationToken cancel = CancellationToken.None;

        static byte[] rawBufferEcMasterState = new byte[2];
        static Memory<byte> memBufferEcMasterState = new Memory<byte>(rawBufferEcMasterState);
        static MemoryStream memStreamEcMasterState = new MemoryStream(rawBufferEcMasterState);
        static BinaryReader binReaderEcMasterState = new BinaryReader(memStreamEcMasterState);
        public Form1()
        {
            InitializeComponent();
            AmsNetId localIdMaster = new AmsNetId(AmsNetId.Local);
            localIdMaster[4] = 2;
            amsAddrEcMaster = new AmsAddress(localIdMaster, 0xFFFF);

            clientEcMaster = new AdsClient();
            clientEcMaster.Connect(amsAddrEcMaster);

            clientEcSlave = new AdsClient();
            clientEcSlave.Connect(localIdMaster, 1001);

            tbState.AppendText(String.Format("ADS instance for EtherCAT Slave on client port {0}\r\n", clientEcSlave.ClientAddress.Port));
            clientRouter = new AdsClient();
            clientRouter.Connect(AmsNetId.Local, 10000);
        }
        private string num_to_ec_state(uint n_ec_state)
        {
            switch (n_ec_state)
            {
                case 0:
                    return "Init";
                case 2:
                    return "PreOp";
                case 3:
                    return "Boot";
                case 4:
                    return "SafeOp";
                case 8:
                    return "Op";
                default:
                    return "";
            }
        }
        private async void btnUpdateEcState_Click(object sender, EventArgs e)
        {
            bool readEcMasterState = true;
            try
            {
                ResultReadDeviceState resultRtState = await clientRouter.ReadStateAsync(cancel);

                if (resultRtState.Succeeded)
                {

                    tbRuntimeState.Text = resultRtState.State.AdsState.ToString();
                    if (resultRtState.State.AdsState == AdsState.Run)
                    {
                        readEcMasterState = true;
                    }

                }
            }
            catch (Exception)
            {
                tbState.AppendText("Exception reading runtime state - TODO\r\n");
            }


            if (readEcMasterState)
            {
                // Read EtherCAT Master state
                try
                {
                    ResultValue<UInt16> resultRead = await clientEcMaster.ReadAnyAsync<UInt16>(0x00000003, 0x00000100, cancel);

                    if (resultRead.Succeeded)
                    {
                        tblEcMasterState.Text = num_to_ec_state((uint)resultRead.Value);
                    }
                }
                catch (Exception)
                {
                    tbState.AppendText("Exception reading EcMaster state - TODO\r\n");
                }

                // Read device Name
                try
                {
                    // Read ANSI String string[80]
                    int byteSize = 81; // Size of 80 ANSI chars + /0 (STRING[80])
                    PrimitiveTypeMarshaler converter = new PrimitiveTypeMarshaler(StringMarshaler.DefaultEncoding);
                    byte[] buffer = new byte[byteSize];

                    ResultRead resultRead = await clientEcSlave.ReadAsync(0x0000F302, 0x10080000, buffer.AsMemory(), cancel);

                    if (resultRead.Succeeded)
                    {
                        string value = null;
                        converter.Unmarshal<string>(buffer.AsSpan(), out value);
                        tbAmpName.Text = value;
                        decodeAmpName(value);
                    }
                }
                catch (Exception)
                {
                    tbState.AppendText("Exception reading EcMaster state - TODO\r\n");
                }
                // Read FSoE Address
                try
                {
                    ResultValue<UInt16> resultRead = await clientEcSlave.ReadAnyAsync<UInt16>(0x0000F302, 0xF9800001, cancel);

                    if (resultRead.Succeeded)
                    {
                        tbFSoEaddr.Text = resultRead.Value.ToString();
                    }
                }
                catch (Exception)
                {
                    tbState.AppendText("Exception reading FSoE Address - TODO\r\n");
                }
                // Read Safety Serial Number
                try
                {
                    ResultValue<UInt32> resultRead = await clientEcSlave.ReadAnyAsync<UInt32>(0x0000F302, 0xF9800002, cancel);

                    if (resultRead.Succeeded)
                    {
                        tbSerialNo.Text = resultRead.Value.ToString("X");
                    }
                }
                catch (Exception)
                {
                    tbState.AppendText("Exception reading Safety serial number - TODO\r\n");
                }
                // Read Safety CRC
                try
                {
                    ResultValue<UInt16> resultRead = await clientEcSlave.ReadAnyAsync<UInt16>(0x0000F302, 0xF9800003, cancel);

                    if (resultRead.Succeeded)
                    {
                        tbSafetyCRC.Text = resultRead.Value.ToString("X");
                    }
                }
                catch (Exception)
                {
                    tbState.AppendText("Exception reading Safety CRC - TODO\r\n");
                }
            }
        }

        private async void readBreakeState()
        {
            // Read break state
            try
            {
                ResultValue<bool> resultRead = await clientEcSlave.ReadAnyAsync<bool>(0x0000F302, 0x30010007, cancel);

                if (resultRead.Succeeded)
                {
                    isUnlocked = resultRead.Value; // true == unlocked // false == locked
                    if (isUnlocked)
                    {
                        btnBrakeCtrl.Text = "Lock";
                    }
                    else
                    {
                        btnBrakeCtrl.Text = "Unlock";
                    }
                }
            }
            catch (Exception)
            {
                tbState.AppendText("Exception reading brake state - TODO\r\n");
            }
        }
        private void decodeAmpName(string deviceName)
        {
            char rpm = deviceName[8];
            char shaft = deviceName[9];
            char encoder = deviceName[10];
            char brake = deviceName[11];

            switch (rpm)
            {
                case 'D':
                    rb3000.Checked = true; break;
                case 'E':
                    rb6000.Checked = true; break;
                case 'H':
                    rb9000.Checked = true; break;

            }

            switch (shaft)
            {
                case '0':
                    rbShaftOption0.Checked = true; break;
                case '1':
                    rbShaftOption1.Checked = true; break;
                case '2':
                    rbShaftOption2.Checked = true; break;
                case '3':
                    rbShaftOption3.Checked = true; break;
                case '4':
                    rbShaftOption4.Checked = true; break;
                case '5':
                    rbShaftOption5.Checked = true; break;
            }

            switch (encoder)
            {
                case '1':
                    rbSingleTurn.Checked = true;
                    rbStoSs1.Checked = true; break;
                case '2':
                    rbMultiTurn.Checked = true;
                    rbStoSs1.Checked = true; break;
                case '3':
                    rbSingleTurn.Checked = true;
                    rbSafeMotion.Checked = true; break;
                case '4':
                    rbMultiTurn.Checked = true;
                    rbSafeMotion.Checked = true; break;
            }

            if (brake == '1')
            {
                cbHoldingBrake.Checked = true;
                btnBrakeCtrl.Enabled = true;
                readBreakeState();
            }
            else
            {
                cbHoldingBrake.Checked = false;
                btnBrakeCtrl.Enabled = false;
            }


        }
        private void btnScan_Click(object sender, EventArgs e)
        {
            tbState.AppendText("Start scanning network devices...\r\n");


            using (AdsClient client = new AdsClient())
            {
                tbState.AppendText("Attempting to connect to TwinCAT System Servce...\r\n");
                client.Connect(AmsNetId.Local, 10000);

                tbState.AppendText("Checking runtime state...\r\n");

                StateInfo stateInfo = client.ReadState();

                if (stateInfo.AdsState != AdsState.Config)
                {
                    tbState.AppendText("Switch runtime to Config mode...\r\n");
                    client.WriteControl(new StateInfo(AdsState.Reconfig, 0));
                }
                else
                {
                    tbState.AppendText("Runtime state OK (Config)\r\n");
                }

            }




            tbState.AppendText("Creating configuration...\r\n");
            Type t = System.Type.GetTypeFromProgID("TcXaeShell.DTE.15.0");
            _dte = (EnvDTE.DTE)System.Activator.CreateInstance(t);

            if (cbHideTcXae.Checked)
            {
                _dte.SuppressUI = true;
                _dte.MainWindow.Visible = false;
            }
            else
            {
                _dte.SuppressUI = false;
                _dte.MainWindow.Visible = true;
            }


            if (Directory.Exists(_tmp_dir))
                Directory.Delete(_tmp_dir, true);

            Directory.CreateDirectory(_tmp_dir);

            dynamic solution = _dte.Solution;
            solution.Create(_tmp_dir, "AMP8_BrakeCtrl");
            solution.SaveAs(_tmp_dir + "\\AMP8000_EtherCAT.sln");
            //string template = @"C:\Users\StephanA\Documents\Visual Studio 2013\Projects\AMP8_BrakeCtrl\AMP8_BrakeCtrl\AMP8_BrakeCtrl.tsproj";
            string template = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\template\AMP8000_EtherCAT\AMP8000_EtherCAT.tsproj";

            _project = solution.AddFromTemplate(template, _tmp_dir + @"\AMP8000_EtherCAT", "AMP8000_EtherCAT");
            tbState.AppendText("Wait for project to be created...\r\n");
            Thread.Sleep(5000);
            _systemManager = (ITcSysManager10)_project.Object;

            tbState.AppendText("Start scanning local hardware devices...\r\n");
            ITcSmTreeItem ioDevicesItem = _systemManager.LookupTreeItem("TIID");

            string scannedXml = ioDevicesItem.ProduceXml(false);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(scannedXml);
            XmlNodeList xmlDeviceList = xmlDoc.SelectNodes("TreeItem/DeviceGrpDef/FoundDevices/Device");

            ITcSmTreeItem EcMasterDevice;
            bool ecMasterFound = false;

            foreach (XmlElement xmlNode in xmlDeviceList)
            {

                string typeName = xmlNode.SelectSingleNode("ItemSubTypeName").InnerText;


                if (typeName == "EtherCAT Master")
                {
                    ecMasterFound = true;
                    int itemSubType = int.Parse(xmlNode.SelectSingleNode("ItemSubType").InnerText);
                    XmlNode xmlAddress = xmlNode.SelectSingleNode("AddressInfo");
                    XmlNode macAddress = xmlAddress.FirstChild["DeviceData"];

                    // Mac address to byte array
                    byte[] bMacAddr = new byte[6];

                    bMacAddr[0] = byte.Parse(macAddress.InnerText.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                    bMacAddr[1] = byte.Parse(macAddress.InnerText.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                    bMacAddr[2] = byte.Parse(macAddress.InnerText.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                    bMacAddr[3] = byte.Parse(macAddress.InnerText.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
                    bMacAddr[4] = byte.Parse(macAddress.InnerText.Substring(8, 2), System.Globalization.NumberStyles.HexNumber);
                    bMacAddr[5] = byte.Parse(macAddress.InnerText.Substring(10, 2), System.Globalization.NumberStyles.HexNumber);

                    var interfaces = NetworkInterface.GetAllNetworkInterfaces();

                    foreach (var @interface in interfaces)
                    {
                        var macaddr = @interface.GetPhysicalAddress();
                        var ipv4Properties = @interface.GetIPProperties().GetIPv4Properties();
                        if (bMacAddr.SequenceEqual(macaddr.GetAddressBytes()))
                        {

                            foreach (UnicastIPAddressInformation ip in @interface.GetIPProperties().UnicastAddresses)
                            {
                                if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                                {
                                    ipv4EcMaster = ip.Address.ToString();
                                    tbEcMasterIP.Text = ipv4EcMaster;

                                    tbRouteToGw.Text = String.Format("route add 192.168.67.0 mask 255.255.255.0 {0}", ipv4EcMaster);
                                }
                            }
                        }
                    }
                    // Specify EcMaster Ethernet adapter mapping
                    string adapterInfo = xmlAddress.FirstChild["DeviceDesc"].InnerText;
                    string xmlAddr = string.Format("<TreeItem><DeviceDef>{0}</DeviceDef></TreeItem >", xmlAddress.OuterXml);
                    tbState.AppendText(String.Format("EtherCAT Master found at {0}\r\n", adapterInfo));

                    //EcMasterDevice = ioDevicesItem.CreateChild("EtherCAT Master", itemSubType, string.Empty, null);

                    // Import preconfigured EtherCAT Master with mailbox gateway enabled
                    string ecMasterTemplatePath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\template\EtherCAT Master.xti";
                    EcMasterDevice = ioDevicesItem.ImportChild(ecMasterTemplatePath, "", false, "EtherCAT Master");

                    EcMasterDevice.ConsumeXml(xmlAddr);

                    tbState.AppendText("Start EtherCAT scan...\r\n");
                    string xmlScanCmd = "<TreeItem><DeviceDef><ScanBoxes>1</ScanBoxes></DeviceDef></TreeItem>";
                    EcMasterDevice.ConsumeXml(xmlScanCmd);

                    // Disable revision check
                    var childCnt = EcMasterDevice.ChildCount;

                    ITcSmTreeItem Amp_motor = EcMasterDevice.Child[1];
                    string ampxml = Amp_motor.ProduceXml(false);


                    XmlDocument ampxmlDoc = new XmlDocument();
                    ampxmlDoc.LoadXml(ampxml);

                    XmlNode ampxmlSettings = ampxmlDoc.SelectSingleNode("TreeItem/EtherCAT/Slave/Settings");
                    XmlNode ampxml_revCheck = ampxmlSettings.FirstChild["CheckRevisionNo"];

                    string defaultRevCheckSetting = ampxml_revCheck.OuterXml;

                    // Erease revision check

                    ampxml_revCheck.InnerText = "";

                    string newRevCheckSettings = ampxml_revCheck.OuterXml;

                    string ampDefaultXMl = Amp_motor.ProduceXml();

                    // Find and replace XML

                    string ampNewXml = ampDefaultXMl.Replace(defaultRevCheckSetting, newRevCheckSettings);

                    Amp_motor.ConsumeXml(ampNewXml);

                    break;
                }
                tbState.AppendText(String.Format("...found {0}\r\n", typeName));
            }


            if (!ecMasterFound)
            {
                tbState.AppendText("No EtherCAT Master found\r\n");
                return;
            }

            string Task_in = @"TIRT^Task 1^Inputs^Var 1";
            string EcMaster_in = @"TIID^EtherCAT Master^Inputs^Frm0State";
            _systemManager.LinkVariables(Task_in, EcMaster_in);


            tbState.AppendText(">>> Confirm pop-ups and activate a trial license (if necessary) <<<\r\n");

            _dte.ExecuteCommand("TwinCAT.Konfigurationaktivieren", "");


            tbState.AppendText("Waiting for Run mode\r\n");
        }

        private async void btnBrakeCtrl_Click(object sender, EventArgs e)
        {
            UInt16 valueToWrite = 0;

            if (isUnlocked)
            {
                valueToWrite = 1;
            } else
            {
                valueToWrite = 2;
            }
            try
            {
                
                ResultWrite resultWrite = await clientEcSlave.WriteAnyAsync(0x0000F302, 0x30000007, valueToWrite, cancel);
                bool succeeded = resultWrite.Succeeded;
            }
            catch (Exception)
            {
                tbState.AppendText("Exception writing brake state - TODO\r\n");
            }
            
            readBreakeState();
        }
    }
}
