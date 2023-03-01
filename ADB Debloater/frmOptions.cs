using Microsoft.Win32;
using OSVersionExtension;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADB_Debloater
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        clsFunctions functions;
        private string Configs = Directory.GetCurrentDirectory() + "\\Config";
        private string Theme = "";
        private string NewTheme = "";
        private void FrmOptions_Load(object sender, EventArgs e)
        {
            functions = new clsFunctions();

            if (Properties.Settings.Default.Theme == 0)
            {
                Theme = "Auto";
            }

            if (Properties.Settings.Default.Theme == 1)
            {
                Theme = "Light";
            }

            if (Properties.Settings.Default.Theme == 2)
            {
                Theme = "Dark";
            }

            if (OSVersion.GetOSVersion().Version.Build >= 18362)
            {
                if (Properties.Settings.Default.Theme == 0)
                {
                    cmbTheme.SelectedIndex = 1;
                }

                if (Properties.Settings.Default.Theme == 1)
                {
                    cmbTheme.SelectedIndex = 2;
                }

                if (Properties.Settings.Default.Theme == 2)
                {
                    cmbTheme.SelectedIndex = 0;
                }
            }
            else
            {
                cmbTheme.SelectedIndex = Properties.Settings.Default.Theme;
            }

            GetPackages();

            ArrayList controls = new ArrayList();
            controls.Add(lblStandard);
            controls.Add(lblSWUpdate);
            controls.Add(lblTheme);
            controls.Add(lstStandard);
            controls.Add(lstSWUpdate);
            controls.Add(btnResetStandard);
            controls.Add(btnResetSWUpdate);
            controls.Add(btnSelectStandard);
            controls.Add(btnSelectSWUpdate);

            if (OSVersion.GetOSVersion().Version.Build < 18362)
            {
                cmbTheme.Items.RemoveAt(0);
            }

            functions.SetTheme(this, controls);
        }

        public void GetPackages()
        {
            lstStandard.Items.Clear();
            lstSWUpdate.Items.Clear();

            if (File.Exists(Configs + @"\" + "Standard.packageConfig"))
            {
                string[] lines = File.ReadAllLines(Configs + @"\" + "Standard.packageConfig");
                foreach (var line in lines)
                {
                    if (line != "")
                    {
                        lstStandard.Items.Add(line);
                    }
                }
            }

            if (File.Exists(Configs + @"\" + "SoftUpd.packageConfig"))
            {
                string[] lines = File.ReadAllLines(Configs + @"\" + "SoftUpd.packageConfig");
                foreach (var line in lines)
                {
                    if (line != "")
                    {
                        lstSWUpdate.Items.Add(line);
                    }
                }
            }
        }

        private void BtnSelectStandard_Click(object sender, EventArgs e)
        {
            frmSelectPackages select = new frmSelectPackages(true);

            select.ShowDialog();
        }

        private void BtnSelectSWUpdate_Click(object sender, EventArgs e)
        {
            frmSelectPackages select = new frmSelectPackages(true);

            select.ShowDialog();
        }

        private void BtnResetStandard_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Standard Items will be Deleted", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (File.Exists(Configs + @"\" + "Standard.packageConfig"))
                {
                    File.Delete(Configs + @"\" + "Standard.packageConfig");
                }

                GetPackages();
            }
        }

        private void BtnResetSWUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Software Update Items will be Deleted", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (File.Exists(Configs + @"\" + "SoftUpd.packageConfig"))
                {
                    File.Delete(Configs + @"\" + "SoftUpd.packageConfig");
                }

                GetPackages();
            }
        }

        private void CmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OSVersion.GetOSVersion().Version.Build >= 18362)
            {
                if (cmbTheme.SelectedIndex == 0)
                {
                    Properties.Settings.Default.Theme = 2;
                }

                if (cmbTheme.SelectedIndex == 1)
                {
                    Properties.Settings.Default.Theme = 0;
                }

                if (cmbTheme.SelectedIndex == 2)
                {
                    Properties.Settings.Default.Theme = 1;
                }
            }
            else
            {
                Properties.Settings.Default.Theme = cmbTheme.SelectedIndex;
            }

            Properties.Settings.Default.Save();
        }

        private void frmOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.Theme == 0)
            {
                NewTheme = "Auto";
            }

            if (Properties.Settings.Default.Theme == 1)
            {
                NewTheme = "Light";
            }

            if (Properties.Settings.Default.Theme == 2)
            {
                NewTheme = "Dark";
            }

            if (NewTheme != Theme)
            {
                MessageBox.Show("Any Changes Will Take Effect the next time ADB Debloater is started");
            }
        }
    }
}
