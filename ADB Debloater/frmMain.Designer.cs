using System;

namespace ADB_Debloater
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPackageCount = new System.Windows.Forms.Label();
            this.pnlAppControls = new System.Windows.Forms.Panel();
            this.btnCreateInstallScript = new System.Windows.Forms.Button();
            this.pnlAPK = new System.Windows.Forms.Panel();
            this.btnReinstall = new System.Windows.Forms.Button();
            this.cmbSearchCriteria = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnInstallAPK = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCreateScript = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.pnlDev = new System.Windows.Forms.Panel();
            this.lblQuickPort = new System.Windows.Forms.Label();
            this.lblQuickIP = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnQuickGetIP = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnQuickConnectWlDebug = new System.Windows.Forms.Button();
            this.lblQuickConnectWlDebug = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnDeviceInfo = new System.Windows.Forms.Button();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.btnReloadDevice = new System.Windows.Forms.Button();
            this.lblConnectedStatus = new System.Windows.Forms.Label();
            this.btnAdbWifi = new System.Windows.Forms.Button();
            this.dgvApps = new System.Windows.Forms.DataGridView();
            this.btnExportApk = new System.Windows.Forms.Button();
            this.btnStdPackages = new System.Windows.Forms.Button();
            this.btnUpdtPackages = new System.Windows.Forms.Button();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.btnEnableDisable = new System.Windows.Forms.Button();
            this.btnLookupPkgName = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.btnCopyPkgName = new System.Windows.Forms.Button();
            this.pnlAppControls.SuspendLayout();
            this.pnlAPK.SuspendLayout();
            this.pnlDev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApps)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPackageCount
            // 
            this.lblPackageCount.AutoSize = true;
            this.lblPackageCount.Location = new System.Drawing.Point(686, 339);
            this.lblPackageCount.Name = "lblPackageCount";
            this.lblPackageCount.Size = new System.Drawing.Size(67, 13);
            this.lblPackageCount.TabIndex = 26;
            this.lblPackageCount.Text = "Packages: 0";
            // 
            // pnlAppControls
            // 
            this.pnlAppControls.Controls.Add(this.btnCreateInstallScript);
            this.pnlAppControls.Controls.Add(this.pnlAPK);
            this.pnlAppControls.Controls.Add(this.btnCreateScript);
            this.pnlAppControls.Location = new System.Drawing.Point(689, 78);
            this.pnlAppControls.Name = "pnlAppControls";
            this.pnlAppControls.Size = new System.Drawing.Size(250, 250);
            this.pnlAppControls.TabIndex = 25;
            // 
            // btnCreateInstallScript
            // 
            this.btnCreateInstallScript.AllowDrop = true;
            this.btnCreateInstallScript.Enabled = false;
            this.btnCreateInstallScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateInstallScript.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateInstallScript.Location = new System.Drawing.Point(144, 208);
            this.btnCreateInstallScript.Name = "btnCreateInstallScript";
            this.btnCreateInstallScript.Size = new System.Drawing.Size(88, 38);
            this.btnCreateInstallScript.TabIndex = 24;
            this.btnCreateInstallScript.TabStop = false;
            this.btnCreateInstallScript.Text = "Create ADB Install Script";
            this.btnCreateInstallScript.UseVisualStyleBackColor = true;
            this.btnCreateInstallScript.Click += new System.EventHandler(this.btnCreateInstallScript_Click);
            // 
            // pnlAPK
            // 
            this.pnlAPK.Controls.Add(this.btnReinstall);
            this.pnlAPK.Controls.Add(this.cmbSearchCriteria);
            this.pnlAPK.Controls.Add(this.lblSearch);
            this.pnlAPK.Controls.Add(this.txtSearch);
            this.pnlAPK.Controls.Add(this.btnInstallAPK);
            this.pnlAPK.Controls.Add(this.btnImport);
            this.pnlAPK.Controls.Add(this.btnExport);
            this.pnlAPK.Location = new System.Drawing.Point(0, 0);
            this.pnlAPK.Name = "pnlAPK";
            this.pnlAPK.Size = new System.Drawing.Size(250, 205);
            this.pnlAPK.TabIndex = 19;
            // 
            // btnReinstall
            // 
            this.btnReinstall.Enabled = false;
            this.btnReinstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReinstall.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinstall.Location = new System.Drawing.Point(18, 171);
            this.btnReinstall.Name = "btnReinstall";
            this.btnReinstall.Size = new System.Drawing.Size(214, 29);
            this.btnReinstall.TabIndex = 29;
            this.btnReinstall.TabStop = false;
            this.btnReinstall.Text = "Reinstall Package";
            this.btnReinstall.UseVisualStyleBackColor = true;
            this.btnReinstall.Click += new System.EventHandler(this.BtnReinstall_Click);
            // 
            // cmbSearchCriteria
            // 
            this.cmbSearchCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchCriteria.Enabled = false;
            this.cmbSearchCriteria.FormattingEnabled = true;
            this.cmbSearchCriteria.Items.AddRange(new object[] {
            "Package Name",
            "Status"});
            this.cmbSearchCriteria.Location = new System.Drawing.Point(3, 48);
            this.cmbSearchCriteria.Name = "cmbSearchCriteria";
            this.cmbSearchCriteria.Size = new System.Drawing.Size(244, 21);
            this.cmbSearchCriteria.TabIndex = 25;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(15, 14);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(65, 18);
            this.lblSearch.TabIndex = 28;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Enabled = false;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(85, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(157, 25);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.TabStop = false;
            this.txtSearch.WordWrap = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // btnInstallAPK
            // 
            this.btnInstallAPK.AllowDrop = true;
            this.btnInstallAPK.Enabled = false;
            this.btnInstallAPK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstallAPK.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallAPK.Location = new System.Drawing.Point(18, 133);
            this.btnInstallAPK.Name = "btnInstallAPK";
            this.btnInstallAPK.Size = new System.Drawing.Size(214, 29);
            this.btnInstallAPK.TabIndex = 26;
            this.btnInstallAPK.TabStop = false;
            this.btnInstallAPK.Text = "Install APK";
            this.btnInstallAPK.UseVisualStyleBackColor = true;
            this.btnInstallAPK.Click += new System.EventHandler(this.BtnInstallAPK_Click);
            this.btnInstallAPK.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnInstallAPK_DragDrop);
            this.btnInstallAPK.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnInstallAPK_DragEnter);
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(132, 93);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(100, 29);
            this.btnImport.TabIndex = 24;
            this.btnImport.TabStop = false;
            this.btnImport.Text = "Import List";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(18, 93);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(95, 29);
            this.btnExport.TabIndex = 23;
            this.btnExport.TabStop = false;
            this.btnExport.Text = "Export List";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // btnCreateScript
            // 
            this.btnCreateScript.AllowDrop = true;
            this.btnCreateScript.Enabled = false;
            this.btnCreateScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateScript.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateScript.Location = new System.Drawing.Point(18, 208);
            this.btnCreateScript.Name = "btnCreateScript";
            this.btnCreateScript.Size = new System.Drawing.Size(120, 38);
            this.btnCreateScript.TabIndex = 23;
            this.btnCreateScript.TabStop = false;
            this.btnCreateScript.Text = "Create ADB Script";
            this.btnCreateScript.UseVisualStyleBackColor = true;
            this.btnCreateScript.Click += new System.EventHandler(this.BtnCreateScript_Click);
            this.btnCreateScript.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnCreateScript_DragDrop);
            this.btnCreateScript.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnCreateScript_DragEnter);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(686, 368);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(61, 13);
            this.lblSelected.TabIndex = 24;
            this.lblSelected.Text = "Selected: 0";
            // 
            // pnlDev
            // 
            this.pnlDev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlDev.Controls.Add(this.lblQuickPort);
            this.pnlDev.Controls.Add(this.lblQuickIP);
            this.pnlDev.Controls.Add(this.txtPort);
            this.pnlDev.Controls.Add(this.btnQuickGetIP);
            this.pnlDev.Controls.Add(this.txtIP);
            this.pnlDev.Controls.Add(this.btnQuickConnectWlDebug);
            this.pnlDev.Controls.Add(this.lblQuickConnectWlDebug);
            this.pnlDev.Controls.Add(this.btnAbout);
            this.pnlDev.Controls.Add(this.btnOptions);
            this.pnlDev.Controls.Add(this.btnDeviceInfo);
            this.pnlDev.Controls.Add(this.cmbDevices);
            this.pnlDev.Controls.Add(this.btnReloadDevice);
            this.pnlDev.Controls.Add(this.lblConnectedStatus);
            this.pnlDev.Controls.Add(this.btnAdbWifi);
            this.pnlDev.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDev.Location = new System.Drawing.Point(0, 0);
            this.pnlDev.Name = "pnlDev";
            this.pnlDev.Size = new System.Drawing.Size(954, 77);
            this.pnlDev.TabIndex = 27;
            // 
            // lblQuickPort
            // 
            this.lblQuickPort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickPort.Location = new System.Drawing.Point(414, 56);
            this.lblQuickPort.Name = "lblQuickPort";
            this.lblQuickPort.Size = new System.Drawing.Size(82, 17);
            this.lblQuickPort.TabIndex = 59;
            this.lblQuickPort.Text = "Port Number";
            // 
            // lblQuickIP
            // 
            this.lblQuickIP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickIP.Location = new System.Drawing.Point(311, 56);
            this.lblQuickIP.Name = "lblQuickIP";
            this.lblQuickIP.Size = new System.Drawing.Size(68, 17);
            this.lblQuickIP.TabIndex = 58;
            this.lblQuickIP.Text = "IP Address";
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(417, 28);
            this.txtPort.MaxLength = 5;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(40, 25);
            this.txtPort.TabIndex = 57;
            this.txtPort.Text = "99999";
            // 
            // btnQuickGetIP
            // 
            this.btnQuickGetIP.BackColor = System.Drawing.Color.Transparent;
            this.btnQuickGetIP.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnQuickGetIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickGetIP.Font = new System.Drawing.Font("Segoe UI", 7.854546F);
            this.btnQuickGetIP.Location = new System.Drawing.Point(544, 28);
            this.btnQuickGetIP.Name = "btnQuickGetIP";
            this.btnQuickGetIP.Size = new System.Drawing.Size(95, 25);
            this.btnQuickGetIP.TabIndex = 56;
            this.btnQuickGetIP.TabStop = false;
            this.btnQuickGetIP.Text = "Get Device IP";
            this.btnQuickGetIP.UseVisualStyleBackColor = false;
            this.btnQuickGetIP.Click += new System.EventHandler(this.btnQuickGetIP_Click);
            // 
            // txtIP
            // 
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(311, 28);
            this.txtIP.MaxLength = 15;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 25);
            this.txtIP.TabIndex = 55;
            this.txtIP.Text = "192.168.196.365";
            this.txtIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIP_KeyPress);
            this.txtIP.Leave += new System.EventHandler(this.txtIP_Leave);
            // 
            // btnQuickConnectWlDebug
            // 
            this.btnQuickConnectWlDebug.BackColor = System.Drawing.Color.Transparent;
            this.btnQuickConnectWlDebug.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnQuickConnectWlDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickConnectWlDebug.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickConnectWlDebug.Location = new System.Drawing.Point(463, 28);
            this.btnQuickConnectWlDebug.Name = "btnQuickConnectWlDebug";
            this.btnQuickConnectWlDebug.Size = new System.Drawing.Size(75, 25);
            this.btnQuickConnectWlDebug.TabIndex = 54;
            this.btnQuickConnectWlDebug.TabStop = false;
            this.btnQuickConnectWlDebug.Text = "Connect";
            this.btnQuickConnectWlDebug.UseVisualStyleBackColor = false;
            this.btnQuickConnectWlDebug.Click += new System.EventHandler(this.btnQuickConnectWlDebug_Click);
            // 
            // lblQuickConnectWlDebug
            // 
            this.lblQuickConnectWlDebug.AutoSize = true;
            this.lblQuickConnectWlDebug.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Bold);
            this.lblQuickConnectWlDebug.Location = new System.Drawing.Point(310, 4);
            this.lblQuickConnectWlDebug.Name = "lblQuickConnectWlDebug";
            this.lblQuickConnectWlDebug.Size = new System.Drawing.Size(229, 18);
            this.lblQuickConnectWlDebug.TabIndex = 52;
            this.lblQuickConnectWlDebug.Text = "Quick Connect Wireless ADB";
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 7.854546F);
            this.btnAbout.Location = new System.Drawing.Point(825, 6);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(102, 29);
            this.btnAbout.TabIndex = 51;
            this.btnAbout.TabStop = false;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.Transparent;
            this.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Segoe UI", 7.854546F);
            this.btnOptions.Location = new System.Drawing.Point(825, 41);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(102, 29);
            this.btnOptions.TabIndex = 50;
            this.btnOptions.TabStop = false;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
            // 
            // btnDeviceInfo
            // 
            this.btnDeviceInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnDeviceInfo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeviceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeviceInfo.Font = new System.Drawing.Font("Segoe UI", 7.854546F);
            this.btnDeviceInfo.Location = new System.Drawing.Point(681, 6);
            this.btnDeviceInfo.Name = "btnDeviceInfo";
            this.btnDeviceInfo.Size = new System.Drawing.Size(102, 29);
            this.btnDeviceInfo.TabIndex = 49;
            this.btnDeviceInfo.TabStop = false;
            this.btnDeviceInfo.Text = "Device Info";
            this.btnDeviceInfo.UseVisualStyleBackColor = false;
            this.btnDeviceInfo.Click += new System.EventHandler(this.BtnDeviceInfo_Click);
            // 
            // cmbDevices
            // 
            this.cmbDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevices.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(49, 40);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(224, 23);
            this.cmbDevices.Sorted = true;
            this.cmbDevices.TabIndex = 47;
            this.cmbDevices.SelectedIndexChanged += new System.EventHandler(this.CmbDevices_SelectedIndexChanged);
            // 
            // btnReloadDevice
            // 
            this.btnReloadDevice.FlatAppearance.BorderSize = 0;
            this.btnReloadDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReloadDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnReloadDevice.Image")));
            this.btnReloadDevice.Location = new System.Drawing.Point(14, 12);
            this.btnReloadDevice.Name = "btnReloadDevice";
            this.btnReloadDevice.Size = new System.Drawing.Size(25, 25);
            this.btnReloadDevice.TabIndex = 46;
            this.btnReloadDevice.TabStop = false;
            this.btnReloadDevice.UseVisualStyleBackColor = true;
            this.btnReloadDevice.Click += new System.EventHandler(this.BtnReloadDevice_Click);
            // 
            // lblConnectedStatus
            // 
            this.lblConnectedStatus.AutoSize = true;
            this.lblConnectedStatus.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectedStatus.Location = new System.Drawing.Point(45, 12);
            this.lblConnectedStatus.Name = "lblConnectedStatus";
            this.lblConnectedStatus.Size = new System.Drawing.Size(154, 18);
            this.lblConnectedStatus.TabIndex = 45;
            this.lblConnectedStatus.Text = "No Device Connect";
            // 
            // btnAdbWifi
            // 
            this.btnAdbWifi.BackColor = System.Drawing.Color.Transparent;
            this.btnAdbWifi.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdbWifi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdbWifi.Font = new System.Drawing.Font("Segoe UI", 7.854546F);
            this.btnAdbWifi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(88)))), ((int)(((byte)(42)))));
            this.btnAdbWifi.Location = new System.Drawing.Point(681, 41);
            this.btnAdbWifi.Name = "btnAdbWifi";
            this.btnAdbWifi.Size = new System.Drawing.Size(102, 29);
            this.btnAdbWifi.TabIndex = 44;
            this.btnAdbWifi.TabStop = false;
            this.btnAdbWifi.Text = "Wireless Debug";
            this.btnAdbWifi.UseVisualStyleBackColor = false;
            this.btnAdbWifi.Click += new System.EventHandler(this.BtnAdbWifi_Click);
            // 
            // dgvApps
            // 
            this.dgvApps.AllowUserToAddRows = false;
            this.dgvApps.AllowUserToDeleteRows = false;
            this.dgvApps.AllowUserToResizeColumns = false;
            this.dgvApps.AllowUserToResizeRows = false;
            this.dgvApps.BackgroundColor = System.Drawing.Color.White;
            this.dgvApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvApps.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvApps.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApps.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvApps.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvApps.EnableHeadersVisualStyles = false;
            this.dgvApps.Location = new System.Drawing.Point(0, 77);
            this.dgvApps.Name = "dgvApps";
            this.dgvApps.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApps.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvApps.RowHeadersVisible = false;
            this.dgvApps.RowHeadersWidth = 47;
            this.dgvApps.RowTemplate.Height = 50;
            this.dgvApps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvApps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApps.ShowEditingIcon = false;
            this.dgvApps.ShowRowErrors = false;
            this.dgvApps.Size = new System.Drawing.Size(672, 597);
            this.dgvApps.TabIndex = 28;
            this.dgvApps.TabStop = false;
            this.dgvApps.SelectionChanged += new System.EventHandler(this.DgvApps_SelectionChanged);
            // 
            // btnExportApk
            // 
            this.btnExportApk.Enabled = false;
            this.btnExportApk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportApk.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportApk.Location = new System.Drawing.Point(716, 558);
            this.btnExportApk.Name = "btnExportApk";
            this.btnExportApk.Size = new System.Drawing.Size(194, 29);
            this.btnExportApk.TabIndex = 29;
            this.btnExportApk.TabStop = false;
            this.btnExportApk.Text = "Export APK";
            this.btnExportApk.UseVisualStyleBackColor = true;
            this.btnExportApk.Click += new System.EventHandler(this.BtnExportApk_Click);
            // 
            // btnStdPackages
            // 
            this.btnStdPackages.Enabled = false;
            this.btnStdPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStdPackages.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdPackages.Location = new System.Drawing.Point(716, 398);
            this.btnStdPackages.Name = "btnStdPackages";
            this.btnStdPackages.Size = new System.Drawing.Size(194, 29);
            this.btnStdPackages.TabIndex = 30;
            this.btnStdPackages.TabStop = false;
            this.btnStdPackages.Text = "Select Standard Packages";
            this.btnStdPackages.UseVisualStyleBackColor = true;
            this.btnStdPackages.Click += new System.EventHandler(this.BtnStdPackages_Click);
            // 
            // btnUpdtPackages
            // 
            this.btnUpdtPackages.Enabled = false;
            this.btnUpdtPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdtPackages.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdtPackages.Location = new System.Drawing.Point(716, 438);
            this.btnUpdtPackages.Name = "btnUpdtPackages";
            this.btnUpdtPackages.Size = new System.Drawing.Size(194, 29);
            this.btnUpdtPackages.TabIndex = 31;
            this.btnUpdtPackages.TabStop = false;
            this.btnUpdtPackages.Text = "Select Update Packages";
            this.btnUpdtPackages.UseVisualStyleBackColor = true;
            this.btnUpdtPackages.Click += new System.EventHandler(this.BtnUpdtPackages_Click);
            // 
            // btnUninstall
            // 
            this.btnUninstall.Enabled = false;
            this.btnUninstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUninstall.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUninstall.Location = new System.Drawing.Point(716, 518);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(194, 29);
            this.btnUninstall.TabIndex = 32;
            this.btnUninstall.TabStop = false;
            this.btnUninstall.Text = "Uninstall";
            this.btnUninstall.UseVisualStyleBackColor = true;
            this.btnUninstall.Click += new System.EventHandler(this.BtnUninstall_Click);
            // 
            // btnEnableDisable
            // 
            this.btnEnableDisable.Enabled = false;
            this.btnEnableDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnableDisable.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnableDisable.Location = new System.Drawing.Point(716, 478);
            this.btnEnableDisable.Name = "btnEnableDisable";
            this.btnEnableDisable.Size = new System.Drawing.Size(194, 29);
            this.btnEnableDisable.TabIndex = 33;
            this.btnEnableDisable.TabStop = false;
            this.btnEnableDisable.Text = "Enable/Disable";
            this.btnEnableDisable.UseVisualStyleBackColor = true;
            this.btnEnableDisable.Click += new System.EventHandler(this.BtnEnableDisable_Click);
            // 
            // btnLookupPkgName
            // 
            this.btnLookupPkgName.Enabled = false;
            this.btnLookupPkgName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookupPkgName.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookupPkgName.Location = new System.Drawing.Point(716, 598);
            this.btnLookupPkgName.Name = "btnLookupPkgName";
            this.btnLookupPkgName.Size = new System.Drawing.Size(194, 29);
            this.btnLookupPkgName.TabIndex = 34;
            this.btnLookupPkgName.TabStop = false;
            this.btnLookupPkgName.Text = "Lookup Package Name";
            this.btnLookupPkgName.UseVisualStyleBackColor = true;
            this.btnLookupPkgName.Click += new System.EventHandler(this.BtnLookupPkgName_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Enabled = false;
            this.btnRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshList.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshList.Location = new System.Drawing.Point(810, 337);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(129, 51);
            this.btnRefreshList.TabIndex = 35;
            this.btnRefreshList.TabStop = false;
            this.btnRefreshList.Text = "Refresh App List";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.BtnRefreshList_Click);
            // 
            // btnCopyPkgName
            // 
            this.btnCopyPkgName.Enabled = false;
            this.btnCopyPkgName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyPkgName.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyPkgName.Location = new System.Drawing.Point(716, 638);
            this.btnCopyPkgName.Name = "btnCopyPkgName";
            this.btnCopyPkgName.Size = new System.Drawing.Size(194, 29);
            this.btnCopyPkgName.TabIndex = 36;
            this.btnCopyPkgName.TabStop = false;
            this.btnCopyPkgName.Text = "Copy Package Name";
            this.btnCopyPkgName.UseVisualStyleBackColor = true;
            this.btnCopyPkgName.Click += new System.EventHandler(this.BtnCopyPkgName_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(954, 674);
            this.Controls.Add(this.btnCopyPkgName);
            this.Controls.Add(this.btnRefreshList);
            this.Controls.Add(this.btnLookupPkgName);
            this.Controls.Add(this.btnEnableDisable);
            this.Controls.Add(this.btnUninstall);
            this.Controls.Add(this.btnUpdtPackages);
            this.Controls.Add(this.btnStdPackages);
            this.Controls.Add(this.btnExportApk);
            this.Controls.Add(this.dgvApps);
            this.Controls.Add(this.pnlDev);
            this.Controls.Add(this.lblPackageCount);
            this.Controls.Add(this.pnlAppControls);
            this.Controls.Add(this.lblSelected);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ADB Debloater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlAppControls.ResumeLayout(false);
            this.pnlAPK.ResumeLayout(false);
            this.pnlAPK.PerformLayout();
            this.pnlDev.ResumeLayout(false);
            this.pnlDev.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPackageCount;
        private System.Windows.Forms.Panel pnlAppControls;
        private System.Windows.Forms.Panel pnlAPK;
        private System.Windows.Forms.Button btnReinstall;
        private System.Windows.Forms.ComboBox cmbSearchCriteria;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnInstallAPK;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCreateScript;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Panel pnlDev;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnDeviceInfo;
        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.Button btnReloadDevice;
        private System.Windows.Forms.Label lblConnectedStatus;
        private System.Windows.Forms.Button btnAdbWifi;
        private System.Windows.Forms.DataGridView dgvApps;
        private System.Windows.Forms.Button btnExportApk;
        private System.Windows.Forms.Button btnStdPackages;
        private System.Windows.Forms.Button btnUpdtPackages;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.Button btnEnableDisable;
        private System.Windows.Forms.Button btnLookupPkgName;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Button btnCopyPkgName;
        private System.Windows.Forms.Button btnQuickConnectWlDebug;
        private System.Windows.Forms.Label lblQuickConnectWlDebug;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnQuickGetIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblQuickPort;
        private System.Windows.Forms.Label lblQuickIP;
        private System.Windows.Forms.Button btnCreateInstallScript;
    }
}

