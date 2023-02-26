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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPackageCount = new System.Windows.Forms.Label();
            this.pnlAppControls = new System.Windows.Forms.Panel();
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
            this.lblPackageCount.Location = new System.Drawing.Point(686, 336);
            this.lblPackageCount.Name = "lblPackageCount";
            this.lblPackageCount.Size = new System.Drawing.Size(67, 13);
            this.lblPackageCount.TabIndex = 26;
            this.lblPackageCount.Text = "Packages: 0";
            // 
            // pnlAppControls
            // 
            this.pnlAppControls.Controls.Add(this.pnlAPK);
            this.pnlAppControls.Controls.Add(this.btnCreateScript);
            this.pnlAppControls.Location = new System.Drawing.Point(689, 78);
            this.pnlAppControls.Name = "pnlAppControls";
            this.pnlAppControls.Size = new System.Drawing.Size(250, 243);
            this.pnlAppControls.TabIndex = 25;
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
            this.lblSearch.Location = new System.Drawing.Point(3, 6);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(65, 21);
            this.lblSearch.TabIndex = 28;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Enabled = false;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(85, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(157, 25);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // btnInstallAPK
            // 
            this.btnInstallAPK.Enabled = false;
            this.btnInstallAPK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstallAPK.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallAPK.Location = new System.Drawing.Point(18, 133);
            this.btnInstallAPK.Name = "btnInstallAPK";
            this.btnInstallAPK.Size = new System.Drawing.Size(214, 29);
            this.btnInstallAPK.TabIndex = 26;
            this.btnInstallAPK.Text = "Install APK";
            this.btnInstallAPK.UseVisualStyleBackColor = true;
            this.btnInstallAPK.Click += new System.EventHandler(this.BtnInstallAPK_Click);
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
            this.btnExport.Text = "Export List";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // btnCreateScript
            // 
            this.btnCreateScript.Enabled = false;
            this.btnCreateScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateScript.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateScript.Location = new System.Drawing.Point(18, 209);
            this.btnCreateScript.Name = "btnCreateScript";
            this.btnCreateScript.Size = new System.Drawing.Size(214, 29);
            this.btnCreateScript.TabIndex = 23;
            this.btnCreateScript.Text = "Create ADB Script";
            this.btnCreateScript.UseVisualStyleBackColor = true;
            this.btnCreateScript.Click += new System.EventHandler(this.BtnCreateScript_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(686, 365);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(61, 13);
            this.lblSelected.TabIndex = 24;
            this.lblSelected.Text = "Selected: 0";
            // 
            // pnlDev
            // 
            this.pnlDev.BackColor = System.Drawing.Color.Transparent;
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
            // btnAbout
            // 
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(847, 26);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(85, 29);
            this.btnAbout.TabIndex = 51;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.Location = new System.Drawing.Point(744, 26);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(85, 29);
            this.btnOptions.TabIndex = 50;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
            // 
            // btnDeviceInfo
            // 
            this.btnDeviceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeviceInfo.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeviceInfo.Location = new System.Drawing.Point(624, 26);
            this.btnDeviceInfo.Name = "btnDeviceInfo";
            this.btnDeviceInfo.Size = new System.Drawing.Size(102, 29);
            this.btnDeviceInfo.TabIndex = 49;
            this.btnDeviceInfo.Text = "Device Info";
            this.btnDeviceInfo.UseVisualStyleBackColor = true;
            this.btnDeviceInfo.Click += new System.EventHandler(this.BtnDeviceInfo_Click);
            // 
            // cmbDevices
            // 
            this.cmbDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevices.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(49, 40);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(224, 25);
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
            this.btnReloadDevice.UseVisualStyleBackColor = true;
            this.btnReloadDevice.Click += new System.EventHandler(this.BtnReloadDevice_Click);
            // 
            // lblConnectedStatus
            // 
            this.lblConnectedStatus.AutoSize = true;
            this.lblConnectedStatus.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectedStatus.Location = new System.Drawing.Point(45, 12);
            this.lblConnectedStatus.Name = "lblConnectedStatus";
            this.lblConnectedStatus.Size = new System.Drawing.Size(156, 21);
            this.lblConnectedStatus.TabIndex = 45;
            this.lblConnectedStatus.Text = "No Device Connect";
            // 
            // btnAdbWifi
            // 
            this.btnAdbWifi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdbWifi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdbWifi.Location = new System.Drawing.Point(346, 26);
            this.btnAdbWifi.Name = "btnAdbWifi";
            this.btnAdbWifi.Size = new System.Drawing.Size(156, 29);
            this.btnAdbWifi.TabIndex = 44;
            this.btnAdbWifi.Text = "Enable Wireless Debugging";
            this.btnAdbWifi.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApps.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvApps.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvApps.EnableHeadersVisualStyles = false;
            this.dgvApps.Location = new System.Drawing.Point(0, 77);
            this.dgvApps.Name = "dgvApps";
            this.dgvApps.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApps.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApps.RowHeadersVisible = false;
            this.dgvApps.RowHeadersWidth = 47;
            this.dgvApps.RowTemplate.Height = 50;
            this.dgvApps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvApps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApps.ShowEditingIcon = false;
            this.dgvApps.ShowRowErrors = false;
            this.dgvApps.Size = new System.Drawing.Size(672, 597);
            this.dgvApps.TabIndex = 28;
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
            this.btnLookupPkgName.Text = "Lookup Package Name";
            this.btnLookupPkgName.UseVisualStyleBackColor = true;
            this.btnLookupPkgName.Click += new System.EventHandler(this.BtnLookupPkgName_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Enabled = false;
            this.btnRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshList.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshList.Location = new System.Drawing.Point(810, 334);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(129, 51);
            this.btnRefreshList.TabIndex = 35;
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
            this.btnCopyPkgName.Text = "Copy Package Name";
            this.btnCopyPkgName.UseVisualStyleBackColor = true;
            this.btnCopyPkgName.Click += new System.EventHandler(this.BtnCopyPkgName_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADB Debloater";
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
    }
}

