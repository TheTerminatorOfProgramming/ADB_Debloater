namespace ADB_Debloater
{
    partial class frmConnectWirelessDebug
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
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.chkPair = new System.Windows.Forms.CheckBox();
            this.txtPairingCode = new System.Windows.Forms.TextBox();
            this.lblPair = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.chkManual = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(155, 86);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(40, 17);
            this.lblPort.TabIndex = 32;
            this.lblPort.Text = "Port:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.Location = new System.Drawing.Point(155, 19);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(84, 17);
            this.lblIP.TabIndex = 33;
            this.lblIP.Text = "IP Address:";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(158, 106);
            this.txtPort.MaxLength = 5;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(86, 22);
            this.txtPort.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(168, 238);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // chkPair
            // 
            this.chkPair.AutoSize = true;
            this.chkPair.Location = new System.Drawing.Point(260, 174);
            this.chkPair.Name = "chkPair";
            this.chkPair.Size = new System.Drawing.Size(44, 18);
            this.chkPair.TabIndex = 2;
            this.chkPair.Text = "Pair";
            this.chkPair.UseVisualStyleBackColor = true;
            this.chkPair.CheckedChanged += new System.EventHandler(this.chkPair_CheckedChanged);
            // 
            // txtPairingCode
            // 
            this.txtPairingCode.Enabled = false;
            this.txtPairingCode.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPairingCode.Location = new System.Drawing.Point(158, 172);
            this.txtPairingCode.MaxLength = 6;
            this.txtPairingCode.Name = "txtPairingCode";
            this.txtPairingCode.Size = new System.Drawing.Size(86, 22);
            this.txtPairingCode.TabIndex = 3;
            // 
            // lblPair
            // 
            this.lblPair.AutoSize = true;
            this.lblPair.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPair.Location = new System.Drawing.Point(155, 152);
            this.lblPair.Name = "lblPair";
            this.lblPair.Size = new System.Drawing.Size(100, 17);
            this.lblPair.TabIndex = 39;
            this.lblPair.Text = "Pairing Code:";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(158, 39);
            this.txtIP.MaxLength = 15;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(86, 22);
            this.txtIP.TabIndex = 0;
            // 
            // chkManual
            // 
            this.chkManual.AutoSize = true;
            this.chkManual.Location = new System.Drawing.Point(260, 41);
            this.chkManual.Name = "chkManual";
            this.chkManual.Size = new System.Drawing.Size(111, 18);
            this.chkManual.TabIndex = 40;
            this.chkManual.Text = "Enter IP Manually";
            this.chkManual.UseVisualStyleBackColor = true;
            this.chkManual.CheckedChanged += new System.EventHandler(this.ChkManual_CheckedChanged);
            // 
            // frmConnectWirelessDebug
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(410, 273);
            this.Controls.Add(this.chkManual);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtPairingCode);
            this.Controls.Add(this.lblPair);
            this.Controls.Add(this.chkPair);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.lblPort);
            this.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConnectWirelessDebug";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect to Wireless Debug";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConnectWirelessDebug_FormClosed);
            this.Load += new System.EventHandler(this.frmConnectWirelessDebug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.CheckBox chkPair;
        private System.Windows.Forms.TextBox txtPairingCode;
        private System.Windows.Forms.Label lblPair;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.CheckBox chkManual;
    }
}