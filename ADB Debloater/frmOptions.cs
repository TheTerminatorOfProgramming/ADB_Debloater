using JR.Utils.GUI.Forms;
using Microsoft.Win32;
using OSVersionExtension;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
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
        private string Configs = Directory.GetCurrentDirectory() + "\\config";
        private string Fonts = Directory.GetCurrentDirectory() + "\\fonts";
        private string WorkDir = Directory.GetCurrentDirectory();
        private string Theme = "";
        private string NewTheme = "";
        private string Font = "";
        private string NewFont = "";

        private void FrmOptions_Load(object sender, EventArgs e)
        {
            functions = new clsFunctions();

            Properties.Settings.Default.DialogShown = false;
            Properties.Settings.Default.Save();

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

            Font = Properties.Settings.Default.Font;

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

            ArrayList controls = new ArrayList
            {
                lblStandard,
                lblSWUpdate,
                lblTheme,
                lstStandard,
                lstSWUpdate,
                btnResetStandard,
                btnResetSWUpdate,
                btnSelectStandard,
                btnSelectSWUpdate,
                btnReset
            };

            if (OSVersion.GetOSVersion().Version.Build < 18362)
            {
                cmbTheme.Items.RemoveAt(0);
            }

            functions.SetTheme(this, controls);

            if (File.Exists(WorkDir + @"\" + "fonts-config.ini"))
            {
                string[] lines = File.ReadAllLines(WorkDir + @"\" + "fonts-config.ini");
                foreach (var line in lines)
                {
                    if (line != "")
                    {
                        string font = line.Remove(line.Length - 4);
                        cmbFont.Items.Add(font);
                    }
                }
            }

            cmbFont.Items.Insert(0, "System Default");

            cmbFont.SelectedItem = Properties.Settings.Default.Font;

            ArrayList ctrls = new ArrayList
            {
                Controls
            };

            functions.setFont(this, Properties.Settings.Default.FontIndex, ctrls, null);
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
            FlexibleMessageBox.FONT = functions.setMessageBoxFont(Properties.Settings.Default.FontIndex);
            if (FlexibleMessageBox.Show("Standard Items will be Deleted", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
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
            FlexibleMessageBox.FONT = functions.setMessageBoxFont(Properties.Settings.Default.FontIndex);
            if (FlexibleMessageBox.Show("Software Update Items will be Deleted", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
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

            NewFont = Properties.Settings.Default.Font;

            if (NewTheme != Theme || NewFont != Font)
            {
                if (!Properties.Settings.Default.DialogShown)
                {
                    MessageBox.Show("Application will now Restart following changes made.");
                    Properties.Settings.Default.DialogShown = true;
                    Properties.Settings.Default.Save();
                }
               
                Application.Restart();
            }
        }

        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Font = cmbFont.SelectedItem.ToString();
            Properties.Settings.Default.FontIndex = cmbFont.SelectedIndex;
            Properties.Settings.Default.Save();

            ArrayList ctrls = new ArrayList
            {
                Controls
            };
            functions.setFont(this, cmbFont.SelectedIndex, ctrls, null);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FlexibleMessageBox.FONT = functions.setMessageBoxFont(Properties.Settings.Default.FontIndex);
            if (FlexibleMessageBox.Show("This Will Reset all Settings to Default. Do you Want to Continue?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
            }
        }
    }
}
