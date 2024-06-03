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
            tblEcMasterState = new TextBox();
            tbRuntimeState = new TextBox();
            lblEcMasterState = new Label();
            lblRuntimeState = new Label();
            gbAMPInfo = new GroupBox();
            rbSafeMotion = new RadioButton();
            rbStoSs1 = new RadioButton();
            rbMultiTurn = new RadioButton();
            rbSingleTurn = new RadioButton();
            cbHoldingBrake = new CheckBox();
            rb9000 = new RadioButton();
            lblHoldingBrake = new Label();
            rb6000 = new RadioButton();
            rb3000 = new RadioButton();
            lblTwinSAFEMotion = new Label();
            lblEncoder = new Label();
            lblRpm = new Label();
            tbAmpName = new TextBox();
            lblAmpName = new Label();
            rbShaftOption5 = new RadioButton();
            rbShaftOption4 = new RadioButton();
            rbShaftOption3 = new RadioButton();
            rbShaftOption2 = new RadioButton();
            rbShaftOption1 = new RadioButton();
            rbShaftOption0 = new RadioButton();
            tbState = new TextBox();
            lblSafeCrc = new Label();
            tbSafetyCRC = new TextBox();
            lblSerialNo = new Label();
            tbSerialNo = new TextBox();
            lblFSoEaddr = new Label();
            tbFSoEaddr = new TextBox();
            grpSafetyParameter = new GroupBox();
            gbMotorShaft = new GroupBox();
            btnBrakeCtrl = new Button();
            gbGateway.SuspendLayout();
            gbRtState.SuspendLayout();
            gbAMPInfo.SuspendLayout();
            grpSafetyParameter.SuspendLayout();
            gbMotorShaft.SuspendLayout();
            SuspendLayout();
            // 
            // btnScan
            // 
            btnScan.Location = new Point(24, 122);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(212, 23);
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
            cbHideTcXae.Location = new Point(73, 151);
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
            // tblEcMasterState
            // 
            tblEcMasterState.Location = new Point(156, 59);
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
            lblEcMasterState.Location = new Point(19, 63);
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
            gbAMPInfo.Controls.Add(rb9000);
            gbAMPInfo.Controls.Add(lblHoldingBrake);
            gbAMPInfo.Controls.Add(rb6000);
            gbAMPInfo.Controls.Add(rb3000);
            gbAMPInfo.Controls.Add(lblTwinSAFEMotion);
            gbAMPInfo.Controls.Add(lblEncoder);
            gbAMPInfo.Controls.Add(lblRpm);
            gbAMPInfo.Controls.Add(tbAmpName);
            gbAMPInfo.Controls.Add(lblAmpName);
            gbAMPInfo.Location = new Point(24, 359);
            gbAMPInfo.Name = "gbAMPInfo";
            gbAMPInfo.Size = new Size(541, 231);
            gbAMPInfo.TabIndex = 5;
            gbAMPInfo.TabStop = false;
            gbAMPInfo.Text = "General";
            // 
            // rbSafeMotion
            // 
            rbSafeMotion.AutoCheck = false;
            rbSafeMotion.AutoSize = true;
            rbSafeMotion.Location = new Point(271, 198);
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
            rbStoSs1.Location = new Point(196, 198);
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
            rbMultiTurn.Location = new Point(197, 161);
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
            rbSingleTurn.Location = new Point(197, 136);
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
            cbHoldingBrake.Location = new Point(198, 97);
            cbHoldingBrake.Name = "cbHoldingBrake";
            cbHoldingBrake.Size = new Size(15, 14);
            cbHoldingBrake.TabIndex = 11;
            cbHoldingBrake.UseVisualStyleBackColor = true;
            // 
            // rb9000
            // 
            rb9000.AutoCheck = false;
            rb9000.AutoSize = true;
            rb9000.Location = new Point(375, 58);
            rb9000.Name = "rb9000";
            rb9000.Size = new Size(84, 19);
            rb9000.TabIndex = 9;
            rb9000.TabStop = true;
            rb9000.Text = "9000 min-1";
            rb9000.UseVisualStyleBackColor = true;
            // 
            // lblHoldingBrake
            // 
            lblHoldingBrake.AutoSize = true;
            lblHoldingBrake.Location = new Point(20, 97);
            lblHoldingBrake.Name = "lblHoldingBrake";
            lblHoldingBrake.Size = new Size(82, 15);
            lblHoldingBrake.TabIndex = 10;
            lblHoldingBrake.Text = "Holding brake";
            // 
            // rb6000
            // 
            rb6000.AutoCheck = false;
            rb6000.AutoSize = true;
            rb6000.Location = new Point(281, 58);
            rb6000.Name = "rb6000";
            rb6000.Size = new Size(84, 19);
            rb6000.TabIndex = 8;
            rb6000.TabStop = true;
            rb6000.Text = "6000 min-1";
            rb6000.UseVisualStyleBackColor = true;
            // 
            // rb3000
            // 
            rb3000.AutoCheck = false;
            rb3000.AutoSize = true;
            rb3000.Location = new Point(196, 58);
            rb3000.Name = "rb3000";
            rb3000.Size = new Size(84, 19);
            rb3000.TabIndex = 7;
            rb3000.TabStop = true;
            rb3000.Text = "3000 min-1";
            rb3000.UseVisualStyleBackColor = true;
            // 
            // lblTwinSAFEMotion
            // 
            lblTwinSAFEMotion.AutoSize = true;
            lblTwinSAFEMotion.Location = new Point(20, 202);
            lblTwinSAFEMotion.Name = "lblTwinSAFEMotion";
            lblTwinSAFEMotion.Size = new Size(99, 15);
            lblTwinSAFEMotion.TabIndex = 8;
            lblTwinSAFEMotion.Text = "TwinSAFE Motion";
            // 
            // lblEncoder
            // 
            lblEncoder.AutoSize = true;
            lblEncoder.Location = new Point(20, 151);
            lblEncoder.Name = "lblEncoder";
            lblEncoder.Size = new Size(50, 15);
            lblEncoder.TabIndex = 6;
            lblEncoder.Text = "Encoder";
            // 
            // lblRpm
            // 
            lblRpm.AutoSize = true;
            lblRpm.Location = new Point(20, 62);
            lblRpm.Name = "lblRpm";
            lblRpm.Size = new Size(32, 15);
            lblRpm.TabIndex = 2;
            lblRpm.Text = "RPM";
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
            // rbShaftOption5
            // 
            rbShaftOption5.AutoCheck = false;
            rbShaftOption5.AutoSize = true;
            rbShaftOption5.Location = new Point(18, 149);
            rbShaftOption5.Name = "rbShaftOption5";
            rbShaftOption5.Size = new Size(435, 19);
            rbShaftOption5.TabIndex = 21;
            rbShaftOption5.TabStop = true;
            rbShaftOption5.Text = "IP65 sealing ring, shaft with groove and feather key and sealing air connection";
            rbShaftOption5.UseVisualStyleBackColor = true;
            // 
            // rbShaftOption4
            // 
            rbShaftOption4.AutoCheck = false;
            rbShaftOption4.AutoSize = true;
            rbShaftOption4.Location = new Point(18, 121);
            rbShaftOption4.Name = "rbShaftOption4";
            rbShaftOption4.Size = new Size(329, 19);
            rbShaftOption4.TabIndex = 20;
            rbShaftOption4.TabStop = true;
            rbShaftOption4.Text = "IP65 sealing ring, smooth shaft and sealing air connection";
            rbShaftOption4.UseVisualStyleBackColor = true;
            // 
            // rbShaftOption3
            // 
            rbShaftOption3.AutoCheck = false;
            rbShaftOption3.AutoSize = true;
            rbShaftOption3.Location = new Point(18, 96);
            rbShaftOption3.Name = "rbShaftOption3";
            rbShaftOption3.Size = new Size(293, 19);
            rbShaftOption3.TabIndex = 19;
            rbShaftOption3.TabStop = true;
            rbShaftOption3.Text = "IP65 sealing ring, shaft with groove and feather key";
            rbShaftOption3.UseVisualStyleBackColor = true;
            // 
            // rbShaftOption2
            // 
            rbShaftOption2.AutoCheck = false;
            rbShaftOption2.AutoSize = true;
            rbShaftOption2.Location = new Point(18, 71);
            rbShaftOption2.Name = "rbShaftOption2";
            rbShaftOption2.Size = new Size(207, 19);
            rbShaftOption2.TabIndex = 18;
            rbShaftOption2.TabStop = true;
            rbShaftOption2.Text = "IP65 sealing ring and smooth shaft";
            rbShaftOption2.UseVisualStyleBackColor = true;
            // 
            // rbShaftOption1
            // 
            rbShaftOption1.AutoCheck = false;
            rbShaftOption1.AutoSize = true;
            rbShaftOption1.Location = new Point(18, 46);
            rbShaftOption1.Name = "rbShaftOption1";
            rbShaftOption1.Size = new Size(267, 19);
            rbShaftOption1.TabIndex = 17;
            rbShaftOption1.TabStop = true;
            rbShaftOption1.Text = "Groove and feather key according to DIN 6885";
            rbShaftOption1.UseVisualStyleBackColor = true;
            // 
            // rbShaftOption0
            // 
            rbShaftOption0.AutoCheck = false;
            rbShaftOption0.AutoSize = true;
            rbShaftOption0.Location = new Point(18, 21);
            rbShaftOption0.Name = "rbShaftOption0";
            rbShaftOption0.Size = new Size(67, 19);
            rbShaftOption0.TabIndex = 16;
            rbShaftOption0.TabStop = true;
            rbShaftOption0.Text = "Smooth";
            rbShaftOption0.UseVisualStyleBackColor = true;
            // 
            // tbState
            // 
            tbState.Location = new Point(24, 805);
            tbState.Multiline = true;
            tbState.Name = "tbState";
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
            tbFSoEaddr.Location = new Point(142, 25);
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
            // gbMotorShaft
            // 
            gbMotorShaft.Controls.Add(rbShaftOption4);
            gbMotorShaft.Controls.Add(rbShaftOption5);
            gbMotorShaft.Controls.Add(rbShaftOption0);
            gbMotorShaft.Controls.Add(rbShaftOption1);
            gbMotorShaft.Controls.Add(rbShaftOption2);
            gbMotorShaft.Controls.Add(rbShaftOption3);
            gbMotorShaft.Location = new Point(24, 607);
            gbMotorShaft.Name = "gbMotorShaft";
            gbMotorShaft.Size = new Size(541, 182);
            gbMotorShaft.TabIndex = 22;
            gbMotorShaft.TabStop = false;
            gbMotorShaft.Text = "Motor Shaft";
            // 
            // btnBrakeCtrl
            // 
            btnBrakeCtrl.Enabled = false;
            btnBrakeCtrl.Location = new Point(244, 93);
            btnBrakeCtrl.Name = "btnBrakeCtrl";
            btnBrakeCtrl.Size = new Size(208, 23);
            btnBrakeCtrl.TabIndex = 0;
            btnBrakeCtrl.Text = "Unlock";
            btnBrakeCtrl.UseVisualStyleBackColor = true;
            btnBrakeCtrl.Click += btnBrakeCtrl_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 942);
            Controls.Add(gbMotorShaft);
            Controls.Add(grpSafetyParameter);
            Controls.Add(tbState);
            Controls.Add(gbAMPInfo);
            Controls.Add(gbRtState);
            Controls.Add(gbGateway);
            Controls.Add(cbHideTcXae);
            Controls.Add(btnUpdateEcState);
            Controls.Add(btnScan);
            Name = "Form1";
            Text = "3000 min-1";
            gbGateway.ResumeLayout(false);
            gbGateway.PerformLayout();
            gbRtState.ResumeLayout(false);
            gbRtState.PerformLayout();
            gbAMPInfo.ResumeLayout(false);
            gbAMPInfo.PerformLayout();
            grpSafetyParameter.ResumeLayout(false);
            grpSafetyParameter.PerformLayout();
            gbMotorShaft.ResumeLayout(false);
            gbMotorShaft.PerformLayout();
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
        private Label lblRpm;
        private Label lblEncoder;
        private Label lblTwinSAFEMotion;
        private Label lblHoldingBrake;
        private RadioButton rb3000;
        private RadioButton rb6000;
        private RadioButton rb9000;
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
        private RadioButton rbShaftOption4;
        private RadioButton rbShaftOption3;
        private RadioButton rbShaftOption2;
        private RadioButton rbShaftOption1;
        private RadioButton rbShaftOption0;
        private RadioButton rbShaftOption5;
        private GroupBox gbMotorShaft;
        private Button btnBrakeCtrl;
    }
}
