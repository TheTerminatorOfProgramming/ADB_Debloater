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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.lblPackageCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblSearch = new System.Windows.Forms.ToolStripLabel();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.cmbSearchCriteria = new System.Windows.Forms.ToolStripComboBox();
            this.txtProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvApps = new System.Windows.Forms.DataGridView();
            this.pnlDev = new System.Windows.Forms.Panel();
            this.txtPair = new Windows.Forms.HintTextBox(this.components);
            this.txtPort = new Windows.Forms.HintTextBox(this.components);
            this.txtIP = new Windows.Forms.HintTextBox(this.components);
            this.chkPair = new System.Windows.Forms.CheckBox();
            this.lblPairCode = new System.Windows.Forms.Label();
            this.btnCreateInstallScript = new System.Windows.Forms.Button();
            this.btnCreateScript = new System.Windows.Forms.Button();
            this.btnReinstall = new System.Windows.Forms.Button();
            this.btnCopyPkgName = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.btnLookupPkgName = new System.Windows.Forms.Button();
            this.btnInstallAPK = new System.Windows.Forms.Button();
            this.btnEnableDisable = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnUpdtPackages = new System.Windows.Forms.Button();
            this.btnStdPackages = new System.Windows.Forms.Button();
            this.btnExportApk = new System.Windows.Forms.Button();
            this.lblQuickPort = new System.Windows.Forms.Label();
            this.lblQuickIP = new System.Windows.Forms.Label();
            this.btnQuickGetIP = new System.Windows.Forms.Button();
            this.btnQuickConnectWlDebug = new System.Windows.Forms.Button();
            this.lblQuickConnectWlDebug = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnDeviceInfo = new System.Windows.Forms.Button();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.btnReloadDevice = new System.Windows.Forms.Button();
            this.lblConnectedStatus = new System.Windows.Forms.Label();
            this.btnAdbWifi = new System.Windows.Forms.Button();
            this.ssStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApps)).BeginInit();
            this.pnlDev.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPackageCount,
            this.lblSelected,
            this.toolStripSeparator1,
            this.lblSearch,
            this.txtSearch,
            this.cmbSearchCriteria,
            this.txtProgress});
            this.ssStatus.Location = new System.Drawing.Point(0, 651);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(954, 23);
            this.ssStatus.TabIndex = 37;
            this.ssStatus.Text = "statusStrip1";
            // 
            // lblPackageCount
            // 
            this.lblPackageCount.Name = "lblPackageCount";
            this.lblPackageCount.Size = new System.Drawing.Size(68, 18);
            this.lblPackageCount.Text = "Packages: 0";
            // 
            // lblSelected
            // 
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(63, 18);
            this.lblSelected.Text = "Selected: 0";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // lblSearch
            // 
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(45, 21);
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 23);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbSearchCriteria
            // 
            this.cmbSearchCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchCriteria.Items.AddRange(new object[] {
            "Package Name",
            "Status"});
            this.cmbSearchCriteria.Name = "cmbSearchCriteria";
            this.cmbSearchCriteria.Size = new System.Drawing.Size(121, 23);
            // 
            // txtProgress
            // 
            this.txtProgress.Margin = new System.Windows.Forms.Padding(25, 3, 0, 2);
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.Size = new System.Drawing.Size(0, 18);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApps.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvApps.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvApps.EnableHeadersVisualStyles = false;
            this.dgvApps.Location = new System.Drawing.Point(0, 0);
            this.dgvApps.Name = "dgvApps";
            this.dgvApps.ReadOnly = true;
            this.dgvApps.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApps.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvApps.RowHeadersVisible = false;
            this.dgvApps.RowHeadersWidth = 47;
            this.dgvApps.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvApps.RowTemplate.Height = 50;
            this.dgvApps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvApps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApps.ShowEditingIcon = false;
            this.dgvApps.ShowRowErrors = false;
            this.dgvApps.Size = new System.Drawing.Size(954, 364);
            this.dgvApps.TabIndex = 41;
            this.dgvApps.TabStop = false;
            this.dgvApps.SelectionChanged += new System.EventHandler(this.dgvApps_SelectionChanged);
            // 
            // pnlDev
            // 
            this.pnlDev.BackColor = System.Drawing.Color.SlateBlue;
            this.pnlDev.Controls.Add(this.txtPair);
            this.pnlDev.Controls.Add(this.txtPort);
            this.pnlDev.Controls.Add(this.txtIP);
            this.pnlDev.Controls.Add(this.chkPair);
            this.pnlDev.Controls.Add(this.lblPairCode);
            this.pnlDev.Controls.Add(this.btnCreateInstallScript);
            this.pnlDev.Controls.Add(this.btnCreateScript);
            this.pnlDev.Controls.Add(this.btnReinstall);
            this.pnlDev.Controls.Add(this.btnCopyPkgName);
            this.pnlDev.Controls.Add(this.btnRefreshList);
            this.pnlDev.Controls.Add(this.btnLookupPkgName);
            this.pnlDev.Controls.Add(this.btnInstallAPK);
            this.pnlDev.Controls.Add(this.btnEnableDisable);
            this.pnlDev.Controls.Add(this.btnImport);
            this.pnlDev.Controls.Add(this.btnUninstall);
            this.pnlDev.Controls.Add(this.btnExport);
            this.pnlDev.Controls.Add(this.btnUpdtPackages);
            this.pnlDev.Controls.Add(this.btnStdPackages);
            this.pnlDev.Controls.Add(this.btnExportApk);
            this.pnlDev.Controls.Add(this.lblQuickPort);
            this.pnlDev.Controls.Add(this.lblQuickIP);
            this.pnlDev.Controls.Add(this.btnQuickGetIP);
            this.pnlDev.Controls.Add(this.btnQuickConnectWlDebug);
            this.pnlDev.Controls.Add(this.lblQuickConnectWlDebug);
            this.pnlDev.Controls.Add(this.btnAbout);
            this.pnlDev.Controls.Add(this.btnOptions);
            this.pnlDev.Controls.Add(this.btnDeviceInfo);
            this.pnlDev.Controls.Add(this.cmbDevices);
            this.pnlDev.Controls.Add(this.btnReloadDevice);
            this.pnlDev.Controls.Add(this.lblConnectedStatus);
            this.pnlDev.Controls.Add(this.btnAdbWifi);
            this.pnlDev.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDev.Location = new System.Drawing.Point(0, 336);
            this.pnlDev.Name = "pnlDev";
            this.pnlDev.Size = new System.Drawing.Size(954, 315);
            this.pnlDev.TabIndex = 42;
            // 
            // txtPair
            // 
            this.txtPair.Enabled = false;
            this.txtPair.EnterToTab = false;
            this.txtPair.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPair.ForeColor = System.Drawing.Color.Gray;
            this.txtPair.HintColor = System.Drawing.Color.Gray;
            this.txtPair.HintValue = "12345";
            this.txtPair.Location = new System.Drawing.Point(463, 261);
            this.txtPair.Name = "txtPair";
            this.txtPair.Size = new System.Drawing.Size(48, 25);
            this.txtPair.TabIndex = 78;
            this.txtPair.Text = "12345";
            this.txtPair.TextForeColor = System.Drawing.Color.Black;
            this.txtPair.Value = "";
            // 
            // txtPort
            // 
            this.txtPort.EnterToTab = false;
            this.txtPort.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPort.ForeColor = System.Drawing.Color.Gray;
            this.txtPort.HintColor = System.Drawing.Color.Gray;
            this.txtPort.HintValue = "99999";
            this.txtPort.Location = new System.Drawing.Point(417, 261);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(40, 25);
            this.txtPort.TabIndex = 77;
            this.txtPort.Text = "99999";
            this.txtPort.TextForeColor = System.Drawing.Color.Black;
            this.txtPort.Value = "";
            // 
            // txtIP
            // 
            this.txtIP.EnterToTab = false;
            this.txtIP.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtIP.ForeColor = System.Drawing.Color.Gray;
            this.txtIP.HintColor = System.Drawing.Color.Gray;
            this.txtIP.HintValue = "10.0.0.189";
            this.txtIP.Location = new System.Drawing.Point(305, 261);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(105, 25);
            this.txtIP.TabIndex = 76;
            this.txtIP.Text = "10.0.0.189";
            this.txtIP.TextForeColor = System.Drawing.Color.Black;
            this.txtIP.Value = "";
            // 
            // chkPair
            // 
            this.chkPair.AutoSize = true;
            this.chkPair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.chkPair.Location = new System.Drawing.Point(517, 265);
            this.chkPair.Name = "chkPair";
            this.chkPair.Size = new System.Drawing.Size(47, 19);
            this.chkPair.TabIndex = 74;
            this.chkPair.Text = "Pair";
            this.chkPair.UseVisualStyleBackColor = true;
            this.chkPair.CheckedChanged += new System.EventHandler(this.chkPair_CheckedChanged);
            // 
            // lblPairCode
            // 
            this.lblPairCode.AutoSize = true;
            this.lblPairCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPairCode.Location = new System.Drawing.Point(460, 289);
            this.lblPairCode.Name = "lblPairCode";
            this.lblPairCode.Size = new System.Drawing.Size(76, 15);
            this.lblPairCode.TabIndex = 73;
            this.lblPairCode.Text = "Pairing Code";
            // 
            // btnCreateInstallScript
            // 
            this.btnCreateInstallScript.AllowDrop = true;
            this.btnCreateInstallScript.Enabled = false;
            this.btnCreateInstallScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateInstallScript.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateInstallScript.Location = new System.Drawing.Point(250, 136);
            this.btnCreateInstallScript.Name = "btnCreateInstallScript";
            this.btnCreateInstallScript.Size = new System.Drawing.Size(214, 29);
            this.btnCreateInstallScript.TabIndex = 24;
            this.btnCreateInstallScript.TabStop = false;
            this.btnCreateInstallScript.Text = "Create ADB Install Script";
            this.btnCreateInstallScript.UseVisualStyleBackColor = true;
            this.btnCreateInstallScript.Click += new System.EventHandler(this.btnCreateInstallScript_Click);
            // 
            // btnCreateScript
            // 
            this.btnCreateScript.AllowDrop = true;
            this.btnCreateScript.Enabled = false;
            this.btnCreateScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateScript.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateScript.Location = new System.Drawing.Point(10, 136);
            this.btnCreateScript.Name = "btnCreateScript";
            this.btnCreateScript.Size = new System.Drawing.Size(214, 29);
            this.btnCreateScript.TabIndex = 23;
            this.btnCreateScript.TabStop = false;
            this.btnCreateScript.Text = "Create ADB Script";
            this.btnCreateScript.UseVisualStyleBackColor = true;
            this.btnCreateScript.Click += new System.EventHandler(this.BtnCreateScript_Click);
            this.btnCreateScript.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnCreateScript_DragDrop);
            this.btnCreateScript.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnCreateScript_DragEnter);
            // 
            // btnReinstall
            // 
            this.btnReinstall.Enabled = false;
            this.btnReinstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReinstall.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinstall.Location = new System.Drawing.Point(490, 34);
            this.btnReinstall.Name = "btnReinstall";
            this.btnReinstall.Size = new System.Drawing.Size(214, 29);
            this.btnReinstall.TabIndex = 29;
            this.btnReinstall.TabStop = false;
            this.btnReinstall.Text = "Reinstall Package";
            this.btnReinstall.UseVisualStyleBackColor = true;
            this.btnReinstall.Click += new System.EventHandler(this.BtnReinstall_Click);
            // 
            // btnCopyPkgName
            // 
            this.btnCopyPkgName.Enabled = false;
            this.btnCopyPkgName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyPkgName.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyPkgName.Location = new System.Drawing.Point(730, 85);
            this.btnCopyPkgName.Name = "btnCopyPkgName";
            this.btnCopyPkgName.Size = new System.Drawing.Size(214, 29);
            this.btnCopyPkgName.TabIndex = 71;
            this.btnCopyPkgName.TabStop = false;
            this.btnCopyPkgName.Text = "Copy Package Name";
            this.btnCopyPkgName.UseVisualStyleBackColor = true;
            this.btnCopyPkgName.Click += new System.EventHandler(this.BtnCopyPkgName_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Enabled = false;
            this.btnRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshList.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshList.Location = new System.Drawing.Point(490, 184);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(454, 29);
            this.btnRefreshList.TabIndex = 70;
            this.btnRefreshList.TabStop = false;
            this.btnRefreshList.Text = "Refresh App List";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.BtnRefreshList_Click);
            // 
            // btnLookupPkgName
            // 
            this.btnLookupPkgName.Enabled = false;
            this.btnLookupPkgName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookupPkgName.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookupPkgName.Location = new System.Drawing.Point(730, 34);
            this.btnLookupPkgName.Name = "btnLookupPkgName";
            this.btnLookupPkgName.Size = new System.Drawing.Size(214, 29);
            this.btnLookupPkgName.TabIndex = 69;
            this.btnLookupPkgName.TabStop = false;
            this.btnLookupPkgName.Text = "Lookup Package Name";
            this.btnLookupPkgName.UseVisualStyleBackColor = true;
            this.btnLookupPkgName.Click += new System.EventHandler(this.BtnLookupPkgName_Click);
            // 
            // btnInstallAPK
            // 
            this.btnInstallAPK.AllowDrop = true;
            this.btnInstallAPK.Enabled = false;
            this.btnInstallAPK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstallAPK.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallAPK.Location = new System.Drawing.Point(10, 184);
            this.btnInstallAPK.Name = "btnInstallAPK";
            this.btnInstallAPK.Size = new System.Drawing.Size(454, 29);
            this.btnInstallAPK.TabIndex = 26;
            this.btnInstallAPK.TabStop = false;
            this.btnInstallAPK.Text = "Install APK";
            this.btnInstallAPK.UseVisualStyleBackColor = true;
            this.btnInstallAPK.Click += new System.EventHandler(this.BtnInstallAPK_Click);
            this.btnInstallAPK.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnInstallAPK_DragDrop);
            this.btnInstallAPK.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnInstallAPK_DragEnter);
            // 
            // btnEnableDisable
            // 
            this.btnEnableDisable.Enabled = false;
            this.btnEnableDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnableDisable.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnableDisable.Location = new System.Drawing.Point(490, 85);
            this.btnEnableDisable.Name = "btnEnableDisable";
            this.btnEnableDisable.Size = new System.Drawing.Size(214, 29);
            this.btnEnableDisable.TabIndex = 68;
            this.btnEnableDisable.TabStop = false;
            this.btnEnableDisable.Text = "Enable/Disable";
            this.btnEnableDisable.UseVisualStyleBackColor = true;
            this.btnEnableDisable.Click += new System.EventHandler(this.BtnEnableDisable_Click);
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(10, 34);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(214, 29);
            this.btnImport.TabIndex = 24;
            this.btnImport.TabStop = false;
            this.btnImport.Text = "Import List";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // btnUninstall
            // 
            this.btnUninstall.Enabled = false;
            this.btnUninstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUninstall.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUninstall.Location = new System.Drawing.Point(490, 136);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(214, 29);
            this.btnUninstall.TabIndex = 67;
            this.btnUninstall.TabStop = false;
            this.btnUninstall.Text = "Uninstall";
            this.btnUninstall.UseVisualStyleBackColor = true;
            this.btnUninstall.Click += new System.EventHandler(this.BtnUninstall_Click);
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(10, 85);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(214, 29);
            this.btnExport.TabIndex = 23;
            this.btnExport.TabStop = false;
            this.btnExport.Text = "Export List";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // btnUpdtPackages
            // 
            this.btnUpdtPackages.Enabled = false;
            this.btnUpdtPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdtPackages.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdtPackages.Location = new System.Drawing.Point(250, 85);
            this.btnUpdtPackages.Name = "btnUpdtPackages";
            this.btnUpdtPackages.Size = new System.Drawing.Size(214, 29);
            this.btnUpdtPackages.TabIndex = 66;
            this.btnUpdtPackages.TabStop = false;
            this.btnUpdtPackages.Text = "Select Update Packages";
            this.btnUpdtPackages.UseVisualStyleBackColor = true;
            this.btnUpdtPackages.Click += new System.EventHandler(this.BtnUpdtPackages_Click);
            // 
            // btnStdPackages
            // 
            this.btnStdPackages.Enabled = false;
            this.btnStdPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStdPackages.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdPackages.Location = new System.Drawing.Point(250, 34);
            this.btnStdPackages.Name = "btnStdPackages";
            this.btnStdPackages.Size = new System.Drawing.Size(214, 29);
            this.btnStdPackages.TabIndex = 65;
            this.btnStdPackages.TabStop = false;
            this.btnStdPackages.Text = "Select Standard Packages";
            this.btnStdPackages.UseVisualStyleBackColor = true;
            this.btnStdPackages.Click += new System.EventHandler(this.BtnStdPackages_Click);
            // 
            // btnExportApk
            // 
            this.btnExportApk.Enabled = false;
            this.btnExportApk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportApk.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportApk.Location = new System.Drawing.Point(730, 136);
            this.btnExportApk.Name = "btnExportApk";
            this.btnExportApk.Size = new System.Drawing.Size(214, 29);
            this.btnExportApk.TabIndex = 64;
            this.btnExportApk.TabStop = false;
            this.btnExportApk.Text = "Export APK";
            this.btnExportApk.UseVisualStyleBackColor = true;
            this.btnExportApk.Click += new System.EventHandler(this.BtnExportApk_Click);
            // 
            // lblQuickPort
            // 
            this.lblQuickPort.AutoSize = true;
            this.lblQuickPort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickPort.Location = new System.Drawing.Point(416, 289);
            this.lblQuickPort.Name = "lblQuickPort";
            this.lblQuickPort.Size = new System.Drawing.Size(31, 15);
            this.lblQuickPort.TabIndex = 59;
            this.lblQuickPort.Text = "Port";
            // 
            // lblQuickIP
            // 
            this.lblQuickIP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickIP.Location = new System.Drawing.Point(302, 289);
            this.lblQuickIP.Name = "lblQuickIP";
            this.lblQuickIP.Size = new System.Drawing.Size(108, 17);
            this.lblQuickIP.TabIndex = 58;
            this.lblQuickIP.Text = "IP Address";
            // 
            // btnQuickGetIP
            // 
            this.btnQuickGetIP.AutoSize = true;
            this.btnQuickGetIP.BackColor = System.Drawing.Color.Transparent;
            this.btnQuickGetIP.Enabled = false;
            this.btnQuickGetIP.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnQuickGetIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickGetIP.Font = new System.Drawing.Font("Segoe UI", 7.854546F);
            this.btnQuickGetIP.Location = new System.Drawing.Point(570, 232);
            this.btnQuickGetIP.Name = "btnQuickGetIP";
            this.btnQuickGetIP.Size = new System.Drawing.Size(85, 29);
            this.btnQuickGetIP.TabIndex = 56;
            this.btnQuickGetIP.TabStop = false;
            this.btnQuickGetIP.Text = "Get Device IP";
            this.btnQuickGetIP.UseVisualStyleBackColor = false;
            this.btnQuickGetIP.Click += new System.EventHandler(this.btnQuickGetIP_Click);
            // 
            // btnQuickConnectWlDebug
            // 
            this.btnQuickConnectWlDebug.BackColor = System.Drawing.Color.Transparent;
            this.btnQuickConnectWlDebug.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnQuickConnectWlDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickConnectWlDebug.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickConnectWlDebug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(88)))), ((int)(((byte)(42)))));
            this.btnQuickConnectWlDebug.Location = new System.Drawing.Point(570, 268);
            this.btnQuickConnectWlDebug.Name = "btnQuickConnectWlDebug";
            this.btnQuickConnectWlDebug.Size = new System.Drawing.Size(232, 29);
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
            this.lblQuickConnectWlDebug.Location = new System.Drawing.Point(301, 233);
            this.lblQuickConnectWlDebug.Name = "lblQuickConnectWlDebug";
            this.lblQuickConnectWlDebug.Size = new System.Drawing.Size(196, 21);
            this.lblQuickConnectWlDebug.TabIndex = 52;
            this.lblQuickConnectWlDebug.Text = "Wireless Debug Connect";
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 7.854546F);
            this.btnAbout.Location = new System.Drawing.Point(825, 233);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(121, 29);
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
            this.btnOptions.Location = new System.Drawing.Point(825, 268);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(121, 29);
            this.btnOptions.TabIndex = 50;
            this.btnOptions.TabStop = false;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
            // 
            // btnDeviceInfo
            // 
            this.btnDeviceInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnDeviceInfo.Enabled = false;
            this.btnDeviceInfo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeviceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeviceInfo.Font = new System.Drawing.Font("Segoe UI", 7.854546F);
            this.btnDeviceInfo.Location = new System.Drawing.Point(681, 233);
            this.btnDeviceInfo.Name = "btnDeviceInfo";
            this.btnDeviceInfo.Size = new System.Drawing.Size(121, 29);
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
            this.cmbDevices.Location = new System.Drawing.Point(49, 261);
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
            this.btnReloadDevice.Location = new System.Drawing.Point(14, 233);
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
            this.lblConnectedStatus.Location = new System.Drawing.Point(45, 233);
            this.lblConnectedStatus.Name = "lblConnectedStatus";
            this.lblConnectedStatus.Size = new System.Drawing.Size(175, 21);
            this.lblConnectedStatus.TabIndex = 45;
            this.lblConnectedStatus.Text = "No Device Connected";
            // 
            // btnAdbWifi
            // 
            this.btnAdbWifi.BackColor = System.Drawing.Color.Transparent;
            this.btnAdbWifi.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdbWifi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdbWifi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdbWifi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(88)))), ((int)(((byte)(42)))));
            this.btnAdbWifi.Location = new System.Drawing.Point(681, 268);
            this.btnAdbWifi.Name = "btnAdbWifi";
            this.btnAdbWifi.Size = new System.Drawing.Size(121, 29);
            this.btnAdbWifi.TabIndex = 44;
            this.btnAdbWifi.TabStop = false;
            this.btnAdbWifi.Text = "Wireless Debug";
            this.btnAdbWifi.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(954, 674);
            this.Controls.Add(this.dgvApps);
            this.Controls.Add(this.pnlDev);
            this.Controls.Add(this.ssStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADB Debloater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApps)).EndInit();
            this.pnlDev.ResumeLayout(false);
            this.pnlDev.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblPackageCount;
        private System.Windows.Forms.ToolStripStatusLabel lblSelected;
        private System.Windows.Forms.ToolStripLabel lblSearch;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripComboBox cmbSearchCriteria;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dgvApps;
        private System.Windows.Forms.Panel pnlDev;
        private System.Windows.Forms.CheckBox chkPair;
        private System.Windows.Forms.Label lblPairCode;
        private System.Windows.Forms.Button btnCreateInstallScript;
        private System.Windows.Forms.Button btnCreateScript;
        private System.Windows.Forms.Button btnReinstall;
        private System.Windows.Forms.Button btnCopyPkgName;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Button btnLookupPkgName;
        private System.Windows.Forms.Button btnInstallAPK;
        private System.Windows.Forms.Button btnEnableDisable;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnUpdtPackages;
        private System.Windows.Forms.Button btnStdPackages;
        private System.Windows.Forms.Button btnExportApk;
        private System.Windows.Forms.Label lblQuickPort;
        private System.Windows.Forms.Label lblQuickIP;
        private System.Windows.Forms.Button btnQuickGetIP;
        private System.Windows.Forms.Button btnQuickConnectWlDebug;
        private System.Windows.Forms.Label lblQuickConnectWlDebug;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnDeviceInfo;
        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.Button btnReloadDevice;
        private System.Windows.Forms.Label lblConnectedStatus;
        private System.Windows.Forms.Button btnAdbWifi;
        private Windows.Forms.HintTextBox txtPair;
        private Windows.Forms.HintTextBox txtPort;
        private Windows.Forms.HintTextBox txtIP;
        private System.Windows.Forms.ToolStripStatusLabel txtProgress;
    }
}

