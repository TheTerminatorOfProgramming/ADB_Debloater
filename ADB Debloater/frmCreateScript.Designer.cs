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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvApps = new System.Windows.Forms.DataGridView();
            this.Package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewComboBoxColumn();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            "Uninstall"});
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.Width = 95;
            // 
            // frmCreateScript
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(485, 386);
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
    }
}