namespace FriedProxy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblProxyStatus = new System.Windows.Forms.Label();
            this.bttnStartStop = new System.Windows.Forms.Button();
            this.txtbxLocalPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxServerPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxServerIP = new System.Windows.Forms.TextBox();
            this.tabAdvanced = new System.Windows.Forms.TabPage();
            this.tabCapture = new System.Windows.Forms.TabPage();
            this.lblCaptureStatus = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstbxCaptured = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstbxPackets = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packetCapturingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startCapturingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopCapturingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCapturedPacketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeCapturedPacketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.chkbxClient = new System.Windows.Forms.CheckBox();
            this.chkbxServer = new System.Windows.Forms.CheckBox();
            this.numMinimal = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numMaximal = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chkbxFilterServer = new System.Windows.Forms.CheckBox();
            this.chkbxFilterClient = new System.Windows.Forms.CheckBox();
            this.txtbxSizeFilter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSizeFilterPreview = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabCapture.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximal)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Controls.Add(this.tabAdvanced);
            this.tabControl1.Controls.Add(this.tabCapture);
            this.tabControl1.Location = new System.Drawing.Point(1, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(511, 418);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.panel1);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(503, 392);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 386);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblProxyStatus);
            this.groupBox2.Controls.Add(this.bttnStartStop);
            this.groupBox2.Controls.Add(this.txtbxLocalPort);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtbxServerPort);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtbxServerIP);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 256);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
            // 
            // lblProxyStatus
            // 
            this.lblProxyStatus.AutoSize = true;
            this.lblProxyStatus.Location = new System.Drawing.Point(7, 217);
            this.lblProxyStatus.Name = "lblProxyStatus";
            this.lblProxyStatus.Size = new System.Drawing.Size(92, 13);
            this.lblProxyStatus.TabIndex = 7;
            this.lblProxyStatus.Text = "Proxy not running.";
            // 
            // bttnStartStop
            // 
            this.bttnStartStop.Location = new System.Drawing.Point(6, 156);
            this.bttnStartStop.Name = "bttnStartStop";
            this.bttnStartStop.Size = new System.Drawing.Size(223, 52);
            this.bttnStartStop.TabIndex = 6;
            this.bttnStartStop.Text = "Start Proxy";
            this.bttnStartStop.UseVisualStyleBackColor = true;
            this.bttnStartStop.Click += new System.EventHandler(this.bttnStartStop_Click);
            // 
            // txtbxLocalPort
            // 
            this.txtbxLocalPort.Location = new System.Drawing.Point(6, 130);
            this.txtbxLocalPort.Name = "txtbxLocalPort";
            this.txtbxLocalPort.Size = new System.Drawing.Size(100, 20);
            this.txtbxLocalPort.TabIndex = 5;
            this.txtbxLocalPort.Text = "25565";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Local port:";
            // 
            // txtbxServerPort
            // 
            this.txtbxServerPort.Location = new System.Drawing.Point(6, 80);
            this.txtbxServerPort.Name = "txtbxServerPort";
            this.txtbxServerPort.Size = new System.Drawing.Size(100, 20);
            this.txtbxServerPort.TabIndex = 3;
            this.txtbxServerPort.Text = "25565";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server ip:";
            // 
            // txtbxServerIP
            // 
            this.txtbxServerIP.Location = new System.Drawing.Point(6, 36);
            this.txtbxServerIP.Name = "txtbxServerIP";
            this.txtbxServerIP.Size = new System.Drawing.Size(100, 20);
            this.txtbxServerIP.TabIndex = 0;
            this.txtbxServerIP.Text = "legitimoose.com";
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvanced.Size = new System.Drawing.Size(503, 392);
            this.tabAdvanced.TabIndex = 1;
            this.tabAdvanced.Text = "Advanced";
            this.tabAdvanced.UseVisualStyleBackColor = true;
            // 
            // tabCapture
            // 
            this.tabCapture.Controls.Add(this.lblCaptureStatus);
            this.tabCapture.Controls.Add(this.groupBox4);
            this.tabCapture.Controls.Add(this.groupBox3);
            this.tabCapture.Location = new System.Drawing.Point(4, 22);
            this.tabCapture.Name = "tabCapture";
            this.tabCapture.Size = new System.Drawing.Size(503, 392);
            this.tabCapture.TabIndex = 2;
            this.tabCapture.Text = "Packet capturing";
            this.tabCapture.UseVisualStyleBackColor = true;
            // 
            // lblCaptureStatus
            // 
            this.lblCaptureStatus.AutoSize = true;
            this.lblCaptureStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptureStatus.Location = new System.Drawing.Point(7, 16);
            this.lblCaptureStatus.Name = "lblCaptureStatus";
            this.lblCaptureStatus.Size = new System.Drawing.Size(193, 20);
            this.lblCaptureStatus.TabIndex = 2;
            this.lblCaptureStatus.Text = "Capturing has not started.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstbxCaptured);
            this.groupBox4.Location = new System.Drawing.Point(261, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 373);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Captured packets";
            // 
            // lstbxCaptured
            // 
            this.lstbxCaptured.FormattingEnabled = true;
            this.lstbxCaptured.Location = new System.Drawing.Point(6, 19);
            this.lstbxCaptured.Name = "lstbxCaptured";
            this.lstbxCaptured.Size = new System.Drawing.Size(227, 342);
            this.lstbxCaptured.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numMaximal);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.numMinimal);
            this.groupBox3.Controls.Add(this.chkbxServer);
            this.groupBox3.Controls.Add(this.chkbxClient);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(7, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 339);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Constraints";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSizeFilterPreview);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtbxSizeFilter);
            this.groupBox1.Controls.Add(this.chkbxFilterClient);
            this.groupBox1.Controls.Add(this.chkbxFilterServer);
            this.groupBox1.Controls.Add(this.lstbxPackets);
            this.groupBox1.Location = new System.Drawing.Point(514, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 420);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raw packets";
            // 
            // lstbxPackets
            // 
            this.lstbxPackets.FormattingEnabled = true;
            this.lstbxPackets.Location = new System.Drawing.Point(3, 107);
            this.lstbxPackets.Name = "lstbxPackets";
            this.lstbxPackets.Size = new System.Drawing.Size(268, 303);
            this.lstbxPackets.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.packetCapturingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // packetCapturingToolStripMenuItem
            // 
            this.packetCapturingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startCapturingToolStripMenuItem,
            this.stopCapturingToolStripMenuItem,
            this.clearCapturedPacketsToolStripMenuItem,
            this.executeCapturedPacketsToolStripMenuItem});
            this.packetCapturingToolStripMenuItem.Name = "packetCapturingToolStripMenuItem";
            this.packetCapturingToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.packetCapturingToolStripMenuItem.Text = "Packet Capturing";
            // 
            // startCapturingToolStripMenuItem
            // 
            this.startCapturingToolStripMenuItem.Name = "startCapturingToolStripMenuItem";
            this.startCapturingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.startCapturingToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.startCapturingToolStripMenuItem.Text = "Start capturing";
            this.startCapturingToolStripMenuItem.Click += new System.EventHandler(this.startCapturingToolStripMenuItem_Click);
            // 
            // stopCapturingToolStripMenuItem
            // 
            this.stopCapturingToolStripMenuItem.Name = "stopCapturingToolStripMenuItem";
            this.stopCapturingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Z)));
            this.stopCapturingToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.stopCapturingToolStripMenuItem.Text = "Stop capturing";
            this.stopCapturingToolStripMenuItem.Click += new System.EventHandler(this.stopCapturingToolStripMenuItem_Click);
            // 
            // clearCapturedPacketsToolStripMenuItem
            // 
            this.clearCapturedPacketsToolStripMenuItem.Name = "clearCapturedPacketsToolStripMenuItem";
            this.clearCapturedPacketsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.clearCapturedPacketsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.clearCapturedPacketsToolStripMenuItem.Text = "Clear captured packets";
            this.clearCapturedPacketsToolStripMenuItem.Click += new System.EventHandler(this.clearCapturedPacketsToolStripMenuItem_Click);
            // 
            // executeCapturedPacketsToolStripMenuItem
            // 
            this.executeCapturedPacketsToolStripMenuItem.Name = "executeCapturedPacketsToolStripMenuItem";
            this.executeCapturedPacketsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.executeCapturedPacketsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.executeCapturedPacketsToolStripMenuItem.Text = "Execute captured packets";
            this.executeCapturedPacketsToolStripMenuItem.Click += new System.EventHandler(this.executeCapturedPacketsToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "From device:";
            // 
            // chkbxClient
            // 
            this.chkbxClient.AutoSize = true;
            this.chkbxClient.Checked = true;
            this.chkbxClient.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbxClient.Location = new System.Drawing.Point(10, 37);
            this.chkbxClient.Name = "chkbxClient";
            this.chkbxClient.Size = new System.Drawing.Size(52, 17);
            this.chkbxClient.TabIndex = 1;
            this.chkbxClient.Text = "Client";
            this.chkbxClient.UseVisualStyleBackColor = true;
            // 
            // chkbxServer
            // 
            this.chkbxServer.AutoSize = true;
            this.chkbxServer.Checked = true;
            this.chkbxServer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbxServer.Location = new System.Drawing.Point(10, 61);
            this.chkbxServer.Name = "chkbxServer";
            this.chkbxServer.Size = new System.Drawing.Size(57, 17);
            this.chkbxServer.TabIndex = 2;
            this.chkbxServer.Text = "Server";
            this.chkbxServer.UseVisualStyleBackColor = true;
            // 
            // numMinimal
            // 
            this.numMinimal.Location = new System.Drawing.Point(10, 101);
            this.numMinimal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMinimal.Name = "numMinimal";
            this.numMinimal.Size = new System.Drawing.Size(120, 20);
            this.numMinimal.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Minimal bytes:";
            // 
            // numMaximal
            // 
            this.numMaximal.Location = new System.Drawing.Point(10, 148);
            this.numMaximal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMaximal.Name = "numMaximal";
            this.numMaximal.Size = new System.Drawing.Size(120, 20);
            this.numMaximal.TabIndex = 5;
            this.numMaximal.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Maximal bytes:";
            // 
            // chkbxFilterServer
            // 
            this.chkbxFilterServer.AutoSize = true;
            this.chkbxFilterServer.Checked = true;
            this.chkbxFilterServer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbxFilterServer.Location = new System.Drawing.Point(7, 20);
            this.chkbxFilterServer.Name = "chkbxFilterServer";
            this.chkbxFilterServer.Size = new System.Drawing.Size(128, 17);
            this.chkbxFilterServer.TabIndex = 1;
            this.chkbxFilterServer.Text = "Show Server packets";
            this.chkbxFilterServer.UseVisualStyleBackColor = true;
            // 
            // chkbxFilterClient
            // 
            this.chkbxFilterClient.AutoSize = true;
            this.chkbxFilterClient.Checked = true;
            this.chkbxFilterClient.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbxFilterClient.Location = new System.Drawing.Point(6, 43);
            this.chkbxFilterClient.Name = "chkbxFilterClient";
            this.chkbxFilterClient.Size = new System.Drawing.Size(123, 17);
            this.chkbxFilterClient.TabIndex = 2;
            this.chkbxFilterClient.Text = "Show Client packets";
            this.chkbxFilterClient.UseVisualStyleBackColor = true;
            // 
            // txtbxSizeFilter
            // 
            this.txtbxSizeFilter.Location = new System.Drawing.Point(10, 84);
            this.txtbxSizeFilter.Name = "txtbxSizeFilter";
            this.txtbxSizeFilter.Size = new System.Drawing.Size(203, 20);
            this.txtbxSizeFilter.TabIndex = 3;
            this.txtbxSizeFilter.TextChanged += new System.EventHandler(this.txtbxSizeFilter_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Size Filter:";
            // 
            // lblSizeFilterPreview
            // 
            this.lblSizeFilterPreview.AutoSize = true;
            this.lblSizeFilterPreview.Location = new System.Drawing.Point(60, 68);
            this.lblSizeFilterPreview.Name = "lblSizeFilterPreview";
            this.lblSizeFilterPreview.Size = new System.Drawing.Size(29, 13);
            this.lblSizeFilterPreview.TabIndex = 5;
            this.lblSizeFilterPreview.Text = "NUL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "FriedProxy@legitimoose.com:25565 -> localhost:25565";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabCapture.ResumeLayout(false);
            this.tabCapture.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxServerIP;
        private System.Windows.Forms.TabPage tabAdvanced;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstbxPackets;
        private System.Windows.Forms.Label lblProxyStatus;
        private System.Windows.Forms.Button bttnStartStop;
        private System.Windows.Forms.TextBox txtbxLocalPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxServerPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabCapture;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstbxCaptured;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packetCapturingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCapturedPacketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeCapturedPacketsToolStripMenuItem;
        private System.Windows.Forms.Label lblCaptureStatus;
        private System.Windows.Forms.ToolStripMenuItem startCapturingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopCapturingToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numMaximal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numMinimal;
        private System.Windows.Forms.CheckBox chkbxServer;
        private System.Windows.Forms.CheckBox chkbxClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkbxFilterClient;
        private System.Windows.Forms.CheckBox chkbxFilterServer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbxSizeFilter;
        private System.Windows.Forms.Label lblSizeFilterPreview;
    }
}

