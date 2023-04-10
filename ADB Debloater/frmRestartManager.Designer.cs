namespace ADB_Debloater
{
    partial class frmRestartManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestartManager));
            this.mtRebootRecovery = new MetroFramework.Controls.MetroTile();
            this.mtReboot = new MetroFramework.Controls.MetroTile();
            this.mtRebootDownload = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtRebootRecovery
            // 
            this.mtRebootRecovery.BackColor = System.Drawing.Color.Gray;
            this.mtRebootRecovery.CustomBackground = true;
            this.mtRebootRecovery.Location = new System.Drawing.Point(55, 123);
            this.mtRebootRecovery.Name = "mtRebootRecovery";
            this.mtRebootRecovery.Size = new System.Drawing.Size(181, 77);
            this.mtRebootRecovery.TabIndex = 37;
            this.mtRebootRecovery.Text = "Reboot To Recovery";
            this.mtRebootRecovery.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtRebootRecovery.TileImage = ((System.Drawing.Image)(resources.GetObject("mtRebootRecovery.TileImage")));
            this.mtRebootRecovery.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtRebootRecovery.UseTileImage = true;
            this.mtRebootRecovery.Click += new System.EventHandler(this.mtRebootRecovery_Click);
            // 
            // mtReboot
            // 
            this.mtReboot.BackColor = System.Drawing.Color.Gray;
            this.mtReboot.CustomBackground = true;
            this.mtReboot.Location = new System.Drawing.Point(55, 27);
            this.mtReboot.Name = "mtReboot";
            this.mtReboot.Size = new System.Drawing.Size(181, 77);
            this.mtReboot.TabIndex = 38;
            this.mtReboot.Text = "Reboot Device";
            this.mtReboot.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtReboot.TileImage = ((System.Drawing.Image)(resources.GetObject("mtReboot.TileImage")));
            this.mtReboot.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtReboot.UseTileImage = true;
            this.mtReboot.Click += new System.EventHandler(this.mtReboot_Click);
            // 
            // mtRebootDownload
            // 
            this.mtRebootDownload.BackColor = System.Drawing.Color.Gray;
            this.mtRebootDownload.CustomBackground = true;
            this.mtRebootDownload.Location = new System.Drawing.Point(55, 219);
            this.mtRebootDownload.Name = "mtRebootDownload";
            this.mtRebootDownload.Size = new System.Drawing.Size(181, 77);
            this.mtRebootDownload.TabIndex = 39;
            this.mtRebootDownload.Text = "Reboot To Bootloader";
            this.mtRebootDownload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtRebootDownload.TileImage = ((System.Drawing.Image)(resources.GetObject("mtRebootDownload.TileImage")));
            this.mtRebootDownload.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtRebootDownload.UseTileImage = true;
            this.mtRebootDownload.Visible = false;
            this.mtRebootDownload.Click += new System.EventHandler(this.mtRebootDownload_Click);
            // 
            // frmRestartManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 323);
            this.ControlBox = false;
            this.Controls.Add(this.mtRebootDownload);
            this.Controls.Add(this.mtReboot);
            this.Controls.Add(this.mtRebootRecovery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRestartManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restart Menu";
            this.Load += new System.EventHandler(this.frmRestartManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtRebootRecovery;
        private MetroFramework.Controls.MetroTile mtReboot;
        private MetroFramework.Controls.MetroTile mtRebootDownload;
    }
}