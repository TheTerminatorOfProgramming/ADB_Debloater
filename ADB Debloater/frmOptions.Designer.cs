namespace ADB_Debloater
{
    partial class frmOptions
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
            this.btnResetSWUpdate = new System.Windows.Forms.Button();
            this.btnResetStandard = new System.Windows.Forms.Button();
            this.lblTheme = new System.Windows.Forms.Label();
            this.cmbTheme = new System.Windows.Forms.ComboBox();
            this.lblSWUpdate = new System.Windows.Forms.Label();
            this.btnSelectStandard = new System.Windows.Forms.Button();
            this.btnSelectSWUpdate = new System.Windows.Forms.Button();
            this.lblStandard = new System.Windows.Forms.Label();
            this.lstSWUpdate = new System.Windows.Forms.ListBox();
            this.lstStandard = new System.Windows.Forms.ListBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnResetSWUpdate
            // 
            this.btnResetSWUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnResetSWUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetSWUpdate.Location = new System.Drawing.Point(581, 418);
            this.btnResetSWUpdate.Name = "btnResetSWUpdate";
            this.btnResetSWUpdate.Size = new System.Drawing.Size(329, 34);
            this.btnResetSWUpdate.TabIndex = 25;
            this.btnResetSWUpdate.Text = "Reset Software Update Packages";
            this.btnResetSWUpdate.UseVisualStyleBackColor = false;
            this.btnResetSWUpdate.Click += new System.EventHandler(this.BtnResetSWUpdate_Click);
            // 
            // btnResetStandard
            // 
            this.btnResetStandard.BackColor = System.Drawing.Color.Transparent;
            this.btnResetStandard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetStandard.Location = new System.Drawing.Point(228, 418);
            this.btnResetStandard.Name = "btnResetStandard";
            this.btnResetStandard.Size = new System.Drawing.Size(329, 34);
            this.btnResetStandard.TabIndex = 24;
            this.btnResetStandard.Text = "Reset Standard Packages";
            this.btnResetStandard.UseVisualStyleBackColor = false;
            this.btnResetStandard.Click += new System.EventHandler(this.BtnResetStandard_Click);
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheme.Location = new System.Drawing.Point(12, 147);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(46, 12);
            this.lblTheme.TabIndex = 23;
            this.lblTheme.Text = "Theme:";
            // 
            // cmbTheme
            // 
            this.cmbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTheme.FormattingEnabled = true;
            this.cmbTheme.Items.AddRange(new object[] {
            "Auto",
            "Light",
            "Dark"});
            this.cmbTheme.Location = new System.Drawing.Point(15, 167);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(121, 21);
            this.cmbTheme.TabIndex = 22;
            this.cmbTheme.SelectedIndexChanged += new System.EventHandler(this.CmbTheme_SelectedIndexChanged);
            // 
            // lblSWUpdate
            // 
            this.lblSWUpdate.Font = new System.Drawing.Font("Segoe UI", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSWUpdate.Location = new System.Drawing.Point(581, 15);
            this.lblSWUpdate.Name = "lblSWUpdate";
            this.lblSWUpdate.Size = new System.Drawing.Size(329, 45);
            this.lblSWUpdate.TabIndex = 21;
            this.lblSWUpdate.Text = "SW Update Packages";
            this.lblSWUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelectStandard
            // 
            this.btnSelectStandard.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectStandard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectStandard.Location = new System.Drawing.Point(228, 365);
            this.btnSelectStandard.Name = "btnSelectStandard";
            this.btnSelectStandard.Size = new System.Drawing.Size(329, 36);
            this.btnSelectStandard.TabIndex = 20;
            this.btnSelectStandard.Text = "Select Standard Packages";
            this.btnSelectStandard.UseVisualStyleBackColor = false;
            this.btnSelectStandard.Click += new System.EventHandler(this.BtnSelectStandard_Click);
            // 
            // btnSelectSWUpdate
            // 
            this.btnSelectSWUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectSWUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSWUpdate.Location = new System.Drawing.Point(581, 365);
            this.btnSelectSWUpdate.Name = "btnSelectSWUpdate";
            this.btnSelectSWUpdate.Size = new System.Drawing.Size(329, 36);
            this.btnSelectSWUpdate.TabIndex = 19;
            this.btnSelectSWUpdate.Text = "Select Software Update Packages";
            this.btnSelectSWUpdate.UseVisualStyleBackColor = false;
            this.btnSelectSWUpdate.Click += new System.EventHandler(this.BtnSelectSWUpdate_Click);
            // 
            // lblStandard
            // 
            this.lblStandard.Font = new System.Drawing.Font("Segoe UI", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandard.Location = new System.Drawing.Point(228, 15);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.Size = new System.Drawing.Size(329, 45);
            this.lblStandard.TabIndex = 18;
            this.lblStandard.Text = "Standard Packages";
            this.lblStandard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstSWUpdate
            // 
            this.lstSWUpdate.FormattingEnabled = true;
            this.lstSWUpdate.Location = new System.Drawing.Point(581, 63);
            this.lstSWUpdate.Name = "lstSWUpdate";
            this.lstSWUpdate.Size = new System.Drawing.Size(329, 264);
            this.lstSWUpdate.TabIndex = 17;
            // 
            // lstStandard
            // 
            this.lstStandard.FormattingEnabled = true;
            this.lstStandard.Location = new System.Drawing.Point(228, 63);
            this.lstStandard.Name = "lstStandard";
            this.lstStandard.Size = new System.Drawing.Size(329, 264);
            this.lstStandard.TabIndex = 16;
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFont.Location = new System.Drawing.Point(13, 221);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(33, 12);
            this.lblFont.TabIndex = 27;
            this.lblFont.Text = "Font:";
            // 
            // cmbFont
            // 
            this.cmbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFont.FormattingEnabled = true;
            this.cmbFont.Location = new System.Drawing.Point(16, 241);
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(142, 21);
            this.cmbFont.TabIndex = 26;
            this.cmbFont.SelectedIndexChanged += new System.EventHandler(this.cmbFont_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(12, 411);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 36);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset to Default";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 459);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.cmbFont);
            this.Controls.Add(this.btnResetSWUpdate);
            this.Controls.Add(this.btnResetStandard);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.cmbTheme);
            this.Controls.Add(this.lblSWUpdate);
            this.Controls.Add(this.btnSelectStandard);
            this.Controls.Add(this.btnSelectSWUpdate);
            this.Controls.Add(this.lblStandard);
            this.Controls.Add(this.lstSWUpdate);
            this.Controls.Add(this.lstStandard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOptions_FormClosing);
            this.Load += new System.EventHandler(this.FrmOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnResetSWUpdate;
        private System.Windows.Forms.Button btnResetStandard;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.ComboBox cmbTheme;
        private System.Windows.Forms.Label lblSWUpdate;
        private System.Windows.Forms.Button btnSelectStandard;
        private System.Windows.Forms.Button btnSelectSWUpdate;
        private System.Windows.Forms.Label lblStandard;
        private System.Windows.Forms.ListBox lstSWUpdate;
        private System.Windows.Forms.ListBox lstStandard;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.ComboBox cmbFont;
        private System.Windows.Forms.Button btnReset;
    }
}