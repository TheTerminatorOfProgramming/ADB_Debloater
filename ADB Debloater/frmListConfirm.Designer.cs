namespace ADB_Debloater
{
    partial class frmListConfirm
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
            this.dgvApps = new System.Windows.Forms.DataGridView();
            this.Package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApps)).BeginInit();
            this.SuspendLayout();
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
            this.dgvApps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Package});
            this.dgvApps.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvApps.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvApps.EnableHeadersVisualStyles = false;
            this.dgvApps.Location = new System.Drawing.Point(0, 0);
            this.dgvApps.MultiSelect = false;
            this.dgvApps.Name = "dgvApps";
            this.dgvApps.ReadOnly = true;
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
            this.dgvApps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvApps.ShowEditingIcon = false;
            this.dgvApps.ShowRowErrors = false;
            this.dgvApps.Size = new System.Drawing.Size(406, 477);
            this.dgvApps.TabIndex = 16;
            // 
            // Package
            // 
            this.Package.HeaderText = "Package";
            this.Package.MinimumWidth = 6;
            this.Package.Name = "Package";
            this.Package.ReadOnly = true;
            this.Package.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Package.Width = 407;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(228, 483);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(133, 32);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(45, 483);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(133, 32);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // frmListConfirm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(406, 527);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvApps);
            this.Controls.Add(this.btnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListConfirm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm Packages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListConfirm_FormClosing);
            this.Load += new System.EventHandler(this.FrmListConfirm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApps;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Package;
    }
}