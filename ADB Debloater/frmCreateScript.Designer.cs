namespace ADB_Debloater
{
    partial class frmCreateScript
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvApps = new System.Windows.Forms.DataGridView();
            this.Package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnAllEnable = new System.Windows.Forms.Button();
            this.btnAllDisable = new System.Windows.Forms.Button();
            this.btnAllUninstall = new System.Windows.Forms.Button();
            this.btnAllReinstall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApps)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(176, 346);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(133, 32);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
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
            this.dgvApps.ColumnHeadersVisible = false;
            this.dgvApps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Package,
            this.Action});
            this.dgvApps.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvApps.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvApps.EnableHeadersVisualStyles = false;
            this.dgvApps.Location = new System.Drawing.Point(0, 0);
            this.dgvApps.MultiSelect = false;
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
            this.dgvApps.RowTemplate.Height = 25;
            this.dgvApps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvApps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApps.ShowEditingIcon = false;
            this.dgvApps.ShowRowErrors = false;
            this.dgvApps.Size = new System.Drawing.Size(485, 336);
            this.dgvApps.TabIndex = 14;
            this.dgvApps.SelectionChanged += new System.EventHandler(this.dgvApps_SelectionChanged_1);
            // 
            // Package
            // 
            this.Package.HeaderText = "Package";
            this.Package.MinimumWidth = 6;
            this.Package.Name = "Package";
            this.Package.ReadOnly = true;
            this.Package.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Package.Width = 370;
            // 
            // Action
            // 
            this.Action.AutoComplete = false;
            this.Action.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Action.HeaderText = "Action";
            this.Action.Items.AddRange(new object[] {
            "Enable",
            "Disable",
            "Uninstall",
            "Reinstall"});
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.Width = 95;
            // 
            // btnAllEnable
            // 
            this.btnAllEnable.Location = new System.Drawing.Point(13, 353);
            this.btnAllEnable.Name = "btnAllEnable";
            this.btnAllEnable.Size = new System.Drawing.Size(72, 18);
            this.btnAllEnable.TabIndex = 15;
            this.btnAllEnable.Text = "All Enable";
            this.btnAllEnable.UseVisualStyleBackColor = true;
            this.btnAllEnable.Click += new System.EventHandler(this.btnAllEnable_Click);
            // 
            // btnAllDisable
            // 
            this.btnAllDisable.Location = new System.Drawing.Point(91, 353);
            this.btnAllDisable.Name = "btnAllDisable";
            this.btnAllDisable.Size = new System.Drawing.Size(72, 18);
            this.btnAllDisable.TabIndex = 16;
            this.btnAllDisable.Text = "All Disable";
            this.btnAllDisable.UseVisualStyleBackColor = true;
            this.btnAllDisable.Click += new System.EventHandler(this.btnAllDisable_Click);
            // 
            // btnAllUninstall
            // 
            this.btnAllUninstall.Location = new System.Drawing.Point(321, 353);
            this.btnAllUninstall.Name = "btnAllUninstall";
            this.btnAllUninstall.Size = new System.Drawing.Size(72, 18);
            this.btnAllUninstall.TabIndex = 17;
            this.btnAllUninstall.Text = "All Uninstall";
            this.btnAllUninstall.UseVisualStyleBackColor = true;
            this.btnAllUninstall.Click += new System.EventHandler(this.btnAllUninstall_Click);
            // 
            // btnAllReinstall
            // 
            this.btnAllReinstall.Location = new System.Drawing.Point(399, 353);
            this.btnAllReinstall.Name = "btnAllReinstall";
            this.btnAllReinstall.Size = new System.Drawing.Size(72, 18);
            this.btnAllReinstall.TabIndex = 18;
            this.btnAllReinstall.Text = "All Reinstall";
            this.btnAllReinstall.UseVisualStyleBackColor = true;
            this.btnAllReinstall.Click += new System.EventHandler(this.btnAllReinstall_Click);
            // 
            // frmCreateScript
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(485, 386);
            this.Controls.Add(this.btnAllReinstall);
            this.Controls.Add(this.btnAllUninstall);
            this.Controls.Add(this.btnAllDisable);
            this.Controls.Add(this.btnAllEnable);
            this.Controls.Add(this.dgvApps);
            this.Controls.Add(this.btnCreate);
            this.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCreateScript";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create ADB Script";
            this.Load += new System.EventHandler(this.frmCreateScript_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvApps;
        private System.Windows.Forms.DataGridViewTextBoxColumn Package;
        private System.Windows.Forms.DataGridViewComboBoxColumn Action;
        private System.Windows.Forms.Button btnAllEnable;
        private System.Windows.Forms.Button btnAllDisable;
        private System.Windows.Forms.Button btnAllUninstall;
        private System.Windows.Forms.Button btnAllReinstall;
    }
}