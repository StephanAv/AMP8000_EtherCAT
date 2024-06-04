namespace AMP8000_EtherCAT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnScan = new Button();
            btnUpdateEcState = new Button();
            cbHideTcXae = new CheckBox();
            gbGateway = new GroupBox();
            tbRouteToGw = new TextBox();
            tbEcMasterIP = new TextBox();
            lblGatewayIP_b = new Label();
            lnlRouteToGw = new Label();
            lblEcMasterIP = new Label();
            lblGatewayIP_a = new Label();
            gbRtState = new GroupBox();
            tblEcSlaveState = new TextBox();
            lblEcSlaveState = new Label();
            tblEcMasterState = new TextBox();
            tbRuntimeState = new TextBox();
            lblEcMasterState = new Label();
            lblRuntimeState = new Label();
            gbAMPInfo = new GroupBox();
            btnBrakeCtrl = new Button();
            rbSafeMotion = new RadioButton();
            rbStoSs1 = new RadioButton();
            rbMultiTurn = new RadioButton();
            rbSingleTurn = new RadioButton();
            cbHoldingBrake = new CheckBox();
            lblHoldingBrake = new Label();
            lblTwinSAFEMotion = new Label();
            lblEncoder = new Label();
            tbAmpName = new TextBox();
            lblAmpName = new Label();
            tbState = new TextBox();
            lblSafeCrc = new Label();
            tbSafetyCRC = new TextBox();
            lblSerialNo = new Label();
            tbSerialNo = new TextBox();
            lblFSoEaddr = new Label();
            tbFSoEaddr = new TextBox();
            grpSafetyParameter = new GroupBox();
            gbGateway.SuspendLayout();
            gbRtState.SuspendLayout();
            gbAMPInfo.SuspendLayout();
            grpSafetyParameter.SuspendLayout();
            SuspendLayout();
            // 
            // btnScan
            // 
            btnScan.Location = new Point(24, 101);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(212, 35);
            btnScan.TabIndex = 0;
            btnScan.Text = "Create Configuration";
            btnScan.UseVisualStyleBackColor = true;
            btnScan.Click += btnScan_Click;
            // 
            // btnUpdateEcState
            // 
            btnUpdateEcState.Location = new Point(24, 24);
            btnUpdateEcState.Name = "btnUpdateEcState";
            btnUpdateEcState.Size = new Size(212, 55);
            btnUpdateEcState.TabIndex = 1;
            btnUpdateEcState.Text = "Update";
            btnUpdateEcState.UseVisualStyleBackColor = true;
            btnUpdateEcState.Click += btnUpdateEcState_Click;
            // 
            // cbHideTcXae
            // 
            cbHideTcXae.AutoSize = true;
            cbHideTcXae.Location = new Point(74, 151);
            cbHideTcXae.Name = "cbHideTcXae";
            cbHideTcXae.Size = new Size(109, 19);
            cbHideTcXae.TabIndex = 2;
            cbHideTcXae.Text = "Hide TcXaeShell";
            cbHideTcXae.UseVisualStyleBackColor = true;
            // 
            // gbGateway
            // 
            gbGateway.Controls.Add(tbRouteToGw);
            gbGateway.Controls.Add(tbEcMasterIP);
            gbGateway.Controls.Add(lblGatewayIP_b);
            gbGateway.Controls.Add(lnlRouteToGw);
            gbGateway.Controls.Add(lblEcMasterIP);
            gbGateway.Controls.Add(lblGatewayIP_a);
            gbGateway.Location = new Point(242, 12);
            gbGateway.Name = "gbGateway";
            gbGateway.Size = new Size(324, 175);
            gbGateway.TabIndex = 3;
            gbGateway.TabStop = false;
            gbGateway.Text = "Gateway";
            // 
            // tbRouteToGw
            // 
            tbRouteToGw.Location = new Point(25, 133);
            tbRouteToGw.Name = "tbRouteToGw";
            tbRouteToGw.ReadOnly = true;
            tbRouteToGw.Size = new Size(286, 23);
            tbRouteToGw.TabIndex = 5;
            // 
            // tbEcMasterIP
            // 
            tbEcMasterIP.Location = new Point(211, 56);
            tbEcMasterIP.Name = "tbEcMasterIP";
            tbEcMasterIP.ReadOnly = true;
            tbEcMasterIP.Size = new Size(100, 23);
            tbEcMasterIP.TabIndex = 4;
            tbEcMasterIP.TextAlign = HorizontalAlignment.Right;
            // 
            // lblGatewayIP_b
            // 
            lblGatewayIP_b.AutoSize = true;
            lblGatewayIP_b.Location = new Point(224, 32);
            lblGatewayIP_b.Name = "lblGatewayIP_b";
            lblGatewayIP_b.Size = new Size(82, 15);
            lblGatewayIP_b.TabIndex = 3;
            lblGatewayIP_b.Text = "192.168.67.254";
            // 
            // lnlRouteToGw
            // 
            lnlRouteToGw.AutoSize = true;
            lnlRouteToGw.Location = new Point(24, 101);
            lnlRouteToGw.Name = "lnlRouteToGw";
            lnlRouteToGw.Size = new Size(257, 15);
            lnlRouteToGw.TabIndex = 2;
            lnlRouteToGw.Text = "Route to gateway (enter in administrator CMD):";
            // 
            // lblEcMasterIP
            // 
            lblEcMasterIP.AutoSize = true;
            lblEcMasterIP.Location = new Point(25, 67);
            lblEcMasterIP.Name = "lblEcMasterIP";
            lblEcMasterIP.Size = new Size(107, 15);
            lblEcMasterIP.TabIndex = 1;
            lblEcMasterIP.Text = "EtherCAT Master IP";
            // 
            // lblGatewayIP_a
            // 
            lblGatewayIP_a.AutoSize = true;
            lblGatewayIP_a.Location = new Point(24, 28);
            lblGatewayIP_a.Name = "lblGatewayIP_a";
            lblGatewayIP_a.Size = new Size(65, 15);
            lblGatewayIP_a.TabIndex = 0;
            lblGatewayIP_a.Text = "Gateway IP";
            // 
            // gbRtState
            // 
            gbRtState.Controls.Add(tblEcSlaveState);
            gbRtState.Controls.Add(lblEcSlaveState);
            gbRtState.Controls.Add(tblEcMasterState);
            gbRtState.Controls.Add(tbRuntimeState);
            gbRtState.Controls.Add(lblEcMasterState);
            gbRtState.Controls.Add(lblRuntimeState);
            gbRtState.Location = new Point(24, 204);
            gbRtState.Name = "gbRtState";
            gbRtState.Size = new Size(249, 138);
            gbRtState.TabIndex = 4;
            gbRtState.TabStop = false;
            gbRtState.Text = "State";
            // 
            // tblEcSlaveState
            // 
            tblEcSlaveState.Location = new Point(156, 101);
            tblEcSlaveState.Name = "tblEcSlaveState";
            tblEcSlaveState.ReadOnly = true;
            tblEcSlaveState.Size = new Size(83, 23);
            tblEcSlaveState.TabIndex = 5;
            tblEcSlaveState.TextAlign = HorizontalAlignment.Right;
            // 
            // lblEcSlaveState
            // 
            lblEcSlaveState.AutoSize = true;
            lblEcSlaveState.Location = new Point(19, 104);
            lblEcSlaveState.Name = "lblEcSlaveState";
            lblEcSlaveState.Size = new Size(114, 15);
            lblEcSlaveState.TabIndex = 4;
            lblEcSlaveState.Text = "EtherCAT Slave State";
            // 
            // tblEcMasterState
            // 
            tblEcMasterState.Location = new Point(156, 64);
            tblEcMasterState.Name = "tblEcMasterState";
            tblEcMasterState.ReadOnly = true;
            tblEcMasterState.Size = new Size(83, 23);
            tblEcMasterState.TabIndex = 3;
            tblEcMasterState.TextAlign = HorizontalAlignment.Right;
            // 
            // tbRuntimeState
            // 
            tbRuntimeState.Location = new Point(157, 26);
            tbRuntimeState.Name = "tbRuntimeState";
            tbRuntimeState.ReadOnly = true;
            tbRuntimeState.Size = new Size(82, 23);
            tbRuntimeState.TabIndex = 2;
            tbRuntimeState.TextAlign = HorizontalAlignment.Right;
            // 
            // lblEcMasterState
            // 
            lblEcMasterState.AutoSize = true;
            lblEcMasterState.Location = new Point(19, 68);
            lblEcMasterState.Name = "lblEcMasterState";
            lblEcMasterState.Size = new Size(123, 15);
            lblEcMasterState.TabIndex = 1;
            lblEcMasterState.Text = "EtherCAT Master State";
            // 
            // lblRuntimeState
            // 
            lblRuntimeState.AutoSize = true;
            lblRuntimeState.Location = new Point(19, 26);
            lblRuntimeState.Name = "lblRuntimeState";
            lblRuntimeState.Size = new Size(81, 15);
            lblRuntimeState.TabIndex = 0;
            lblRuntimeState.Text = "Runtime State";
            // 
            // gbAMPInfo
            // 
            gbAMPInfo.Controls.Add(btnBrakeCtrl);
            gbAMPInfo.Controls.Add(rbSafeMotion);
            gbAMPInfo.Controls.Add(rbStoSs1);
            gbAMPInfo.Controls.Add(rbMultiTurn);
            gbAMPInfo.Controls.Add(rbSingleTurn);
            gbAMPInfo.Controls.Add(cbHoldingBrake);
            gbAMPInfo.Controls.Add(lblHoldingBrake);
            gbAMPInfo.Controls.Add(lblTwinSAFEMotion);
            gbAMPInfo.Controls.Add(lblEncoder);
            gbAMPInfo.Controls.Add(tbAmpName);
            gbAMPInfo.Controls.Add(lblAmpName);
            gbAMPInfo.Location = new Point(24, 359);
            gbAMPInfo.Name = "gbAMPInfo";
            gbAMPInfo.Size = new Size(541, 197);
            gbAMPInfo.TabIndex = 5;
            gbAMPInfo.TabStop = false;
            gbAMPInfo.Text = "General";
            // 
            // btnBrakeCtrl
            // 
            btnBrakeCtrl.Enabled = false;
            btnBrakeCtrl.Location = new Point(244, 54);
            btnBrakeCtrl.Name = "btnBrakeCtrl";
            btnBrakeCtrl.Size = new Size(208, 23);
            btnBrakeCtrl.TabIndex = 0;
            btnBrakeCtrl.Text = "Unlock";
            btnBrakeCtrl.UseVisualStyleBackColor = true;
            btnBrakeCtrl.Click += btnBrakeCtrl_Click;
            // 
            // rbSafeMotion
            // 
            rbSafeMotion.AutoCheck = false;
            rbSafeMotion.AutoSize = true;
            rbSafeMotion.Enabled = false;
            rbSafeMotion.Location = new Point(271, 159);
            rbSafeMotion.Name = "rbSafeMotion";
            rbSafeMotion.Size = new Size(89, 19);
            rbSafeMotion.TabIndex = 15;
            rbSafeMotion.TabStop = true;
            rbSafeMotion.Text = "Safe Motion";
            rbSafeMotion.UseVisualStyleBackColor = true;
            // 
            // rbStoSs1
            // 
            rbStoSs1.AutoCheck = false;
            rbStoSs1.AutoSize = true;
            rbStoSs1.Enabled = false;
            rbStoSs1.Location = new Point(196, 159);
            rbStoSs1.Name = "rbStoSs1";
            rbStoSs1.Size = new Size(69, 19);
            rbStoSs1.TabIndex = 14;
            rbStoSs1.TabStop = true;
            rbStoSs1.Text = "STO, SS1";
            rbStoSs1.UseVisualStyleBackColor = true;
            // 
            // rbMultiTurn
            // 
            rbMultiTurn.AutoCheck = false;
            rbMultiTurn.AutoSize = true;
            rbMultiTurn.Enabled = false;
            rbMultiTurn.Location = new Point(197, 122);
            rbMultiTurn.Name = "rbMultiTurn";
            rbMultiTurn.Size = new Size(174, 19);
            rbMultiTurn.TabIndex = 13;
            rbMultiTurn.TabStop = true;
            rbMultiTurn.Text = "Multi-turn absolute encoder";
            rbMultiTurn.UseVisualStyleBackColor = true;
            // 
            // rbSingleTurn
            // 
            rbSingleTurn.AutoCheck = false;
            rbSingleTurn.AutoSize = true;
            rbSingleTurn.Enabled = false;
            rbSingleTurn.Location = new Point(197, 97);
            rbSingleTurn.Name = "rbSingleTurn";
            rbSingleTurn.Size = new Size(178, 19);
            rbSingleTurn.TabIndex = 12;
            rbSingleTurn.TabStop = true;
            rbSingleTurn.Text = "Single-turn absolute encoder";
            rbSingleTurn.UseVisualStyleBackColor = true;
            // 
            // cbHoldingBrake
            // 
            cbHoldingBrake.AutoCheck = false;
            cbHoldingBrake.AutoSize = true;
            cbHoldingBrake.Enabled = false;
            cbHoldingBrake.Location = new Point(197, 58);
            cbHoldingBrake.Name = "cbHoldingBrake";
            cbHoldingBrake.Size = new Size(15, 14);
            cbHoldingBrake.TabIndex = 11;
            cbHoldingBrake.UseVisualStyleBackColor = true;
            // 
            // lblHoldingBrake
            // 
            lblHoldingBrake.AutoSize = true;
            lblHoldingBrake.Location = new Point(20, 58);
            lblHoldingBrake.Name = "lblHoldingBrake";
            lblHoldingBrake.Size = new Size(82, 15);
            lblHoldingBrake.TabIndex = 10;
            lblHoldingBrake.Text = "Holding brake";
            // 
            // lblTwinSAFEMotion
            // 
            lblTwinSAFEMotion.AutoSize = true;
            lblTwinSAFEMotion.Location = new Point(20, 163);
            lblTwinSAFEMotion.Name = "lblTwinSAFEMotion";
            lblTwinSAFEMotion.Size = new Size(99, 15);
            lblTwinSAFEMotion.TabIndex = 8;
            lblTwinSAFEMotion.Text = "TwinSAFE Motion";
            // 
            // lblEncoder
            // 
            lblEncoder.AutoSize = true;
            lblEncoder.Location = new Point(20, 112);
            lblEncoder.Name = "lblEncoder";
            lblEncoder.Size = new Size(50, 15);
            lblEncoder.TabIndex = 6;
            lblEncoder.Text = "Encoder";
            // 
            // tbAmpName
            // 
            tbAmpName.Location = new Point(196, 23);
            tbAmpName.Name = "tbAmpName";
            tbAmpName.ReadOnly = true;
            tbAmpName.Size = new Size(256, 23);
            tbAmpName.TabIndex = 1;
            tbAmpName.TextAlign = HorizontalAlignment.Right;
            // 
            // lblAmpName
            // 
            lblAmpName.AutoSize = true;
            lblAmpName.Location = new Point(18, 23);
            lblAmpName.Name = "lblAmpName";
            lblAmpName.Size = new Size(39, 15);
            lblAmpName.TabIndex = 0;
            lblAmpName.Text = "Name";
            // 
            // tbState
            // 
            tbState.Location = new Point(24, 575);
            tbState.Multiline = true;
            tbState.Name = "tbState";
            tbState.ReadOnly = true;
            tbState.ScrollBars = ScrollBars.Vertical;
            tbState.Size = new Size(542, 121);
            tbState.TabIndex = 6;
            // 
            // lblSafeCrc
            // 
            lblSafeCrc.AutoSize = true;
            lblSafeCrc.Location = new Point(25, 107);
            lblSafeCrc.Name = "lblSafeCrc";
            lblSafeCrc.Size = new Size(65, 15);
            lblSafeCrc.TabIndex = 7;
            lblSafeCrc.Text = "Safety CRC";
            // 
            // tbSafetyCRC
            // 
            tbSafetyCRC.Location = new Point(142, 104);
            tbSafetyCRC.Name = "tbSafetyCRC";
            tbSafetyCRC.ReadOnly = true;
            tbSafetyCRC.Size = new Size(100, 23);
            tbSafetyCRC.TabIndex = 8;
            tbSafetyCRC.TextAlign = HorizontalAlignment.Right;
            // 
            // lblSerialNo
            // 
            lblSerialNo.AutoSize = true;
            lblSerialNo.Location = new Point(24, 67);
            lblSerialNo.Name = "lblSerialNo";
            lblSerialNo.Size = new Size(82, 15);
            lblSerialNo.TabIndex = 9;
            lblSerialNo.Text = "Serial Number";
            // 
            // tbSerialNo
            // 
            tbSerialNo.Location = new Point(142, 64);
            tbSerialNo.Name = "tbSerialNo";
            tbSerialNo.ReadOnly = true;
            tbSerialNo.Size = new Size(100, 23);
            tbSerialNo.TabIndex = 10;
            tbSerialNo.TextAlign = HorizontalAlignment.Right;
            // 
            // lblFSoEaddr
            // 
            lblFSoEaddr.AutoSize = true;
            lblFSoEaddr.Location = new Point(24, 28);
            lblFSoEaddr.Name = "lblFSoEaddr";
            lblFSoEaddr.Size = new Size(77, 15);
            lblFSoEaddr.TabIndex = 11;
            lblFSoEaddr.Text = "FSoE Address";
            // 
            // tbFSoEaddr
            // 
            tbFSoEaddr.Location = new Point(142, 26);
            tbFSoEaddr.Name = "tbFSoEaddr";
            tbFSoEaddr.ReadOnly = true;
            tbFSoEaddr.Size = new Size(100, 23);
            tbFSoEaddr.TabIndex = 12;
            tbFSoEaddr.TextAlign = HorizontalAlignment.Right;
            // 
            // grpSafetyParameter
            // 
            grpSafetyParameter.Controls.Add(lblFSoEaddr);
            grpSafetyParameter.Controls.Add(tbFSoEaddr);
            grpSafetyParameter.Controls.Add(lblSafeCrc);
            grpSafetyParameter.Controls.Add(tbSafetyCRC);
            grpSafetyParameter.Controls.Add(tbSerialNo);
            grpSafetyParameter.Controls.Add(lblSerialNo);
            grpSafetyParameter.Location = new Point(306, 204);
            grpSafetyParameter.Name = "grpSafetyParameter";
            grpSafetyParameter.Size = new Size(260, 138);
            grpSafetyParameter.TabIndex = 13;
            grpSafetyParameter.TabStop = false;
            grpSafetyParameter.Text = "Safety Parameter";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 715);
            Controls.Add(grpSafetyParameter);
            Controls.Add(tbState);
            Controls.Add(gbAMPInfo);
            Controls.Add(gbRtState);
            Controls.Add(gbGateway);
            Controls.Add(cbHideTcXae);
            Controls.Add(btnUpdateEcState);
            Controls.Add(btnScan);
            Name = "Form1";
            Text = "AMP8000 EtherCAT 0.10";
            gbGateway.ResumeLayout(false);
            gbGateway.PerformLayout();
            gbRtState.ResumeLayout(false);
            gbRtState.PerformLayout();
            gbAMPInfo.ResumeLayout(false);
            gbAMPInfo.PerformLayout();
            grpSafetyParameter.ResumeLayout(false);
            grpSafetyParameter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnScan;
        private Button btnUpdateEcState;
        private CheckBox cbHideTcXae;
        private GroupBox gbGateway;
        private GroupBox gbRtState;
        private GroupBox gbAMPInfo;
        private TextBox tbState;
        private Label lnlRouteToGw;
        private Label lblEcMasterIP;
        private Label lblGatewayIP_a;
        private Label lblEcMasterState;
        private Label lblRuntimeState;
        private Label lblAmpName;
        private Label lblGatewayIP_b;
        private TextBox tbRouteToGw;
        private TextBox tbEcMasterIP;
        private TextBox tblEcMasterState;
        private TextBox tbRuntimeState;
        private TextBox tbAmpName;
        private Label lblEncoder;
        private Label lblTwinSAFEMotion;
        private Label lblHoldingBrake;
        private CheckBox cbHoldingBrake;
        private RadioButton rbSingleTurn;
        private RadioButton rbMultiTurn;
        private RadioButton rbSafeMotion;
        private RadioButton rbStoSs1;
        private Label lblSafeCrc;
        private TextBox tbSafetyCRC;
        private Label lblSerialNo;
        private TextBox tbSerialNo;
        private Label lblFSoEaddr;
        private TextBox tbFSoEaddr;
        private GroupBox grpSafetyParameter;
        private Button btnBrakeCtrl;
        private TextBox tblEcSlaveState;
        private Label lblEcSlaveState;
    }
}
