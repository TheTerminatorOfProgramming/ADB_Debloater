using JR.Utils.GUI.Forms;
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
    public partial class frmCreateScript : Form
    {
        private string uninstallString = "adb shell pm uninstall -k --user 0 ";
        private string enableString = "adb shell pm enable ";
        private string disableString = "adb shell pm disable-user --user 0 ";
        private string reinstallstring = "adb shell cmd package install-existing ";
        string file = "";
        string dir = "";
        string name = "";
        clsFunctions functions = new clsFunctions();
        public frmCreateScript(string filePath, string directory)
        {
            InitializeComponent();
            file = filePath;
            dir = directory;
            name = Path.GetFileNameWithoutExtension(filePath);
        }

        private void frmCreateScript_Load(object sender, EventArgs e)
        {
            ArrayList apps = new ArrayList();

            var lines = File.ReadAllLines(file);
            for (var i = 0; i < lines.Length; i += 1)
            {
                if (lines != null)
                {
                    var line = lines[i].Replace("\n\r", "");

                    apps.Add(line);
                }
            }

            apps.Sort();

            foreach (string line in apps)
            {
                dgvApps.Rows.Add(line, "Uninstall");
            }

            dgvApps.ClearSelection();

            ArrayList controls = new ArrayList();
            controls.Add(dgvApps);
            controls.Add(btnAllDisable);
            controls.Add(btnAllEnable);
            controls.Add(btnAllReinstall);
            controls.Add(btnAllUninstall);
            controls.Add(btnCreate);

            functions.SetTheme(this, controls);

            ArrayList ctrls = new ArrayList
            {
                Controls
            };

            functions.setFont(this, Properties.Settings.Default.FontIndex, ctrls, null);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (File.Exists(dir + @"\" + name + " Script.bat"))
            {
                File.Delete(dir + @"\" + name + " Script.bat");
            }

            for (int i = 0; i < dgvApps.Rows.Count; i++)
            {
                using (StreamWriter writer = new StreamWriter(dir + @"\" + name + " Script.bat", append: true))
                {
                    if (dgvApps.Rows[i].Cells["Action"].Value.ToString() == "Uninstall")
                    {
                        writer.WriteLine(uninstallString + dgvApps.Rows[i].Cells["Package"].Value.ToString());
                    }
                    else if (dgvApps.Rows[i].Cells["Action"].Value.ToString() == "Disable")
                    {
                        writer.WriteLine(disableString + dgvApps.Rows[i].Cells["Package"].Value.ToString());
                    }
                    else if (dgvApps.Rows[i].Cells["Action"].Value.ToString() == "Enable")
                    {
                        writer.WriteLine(enableString + dgvApps.Rows[i].Cells["Package"].Value.ToString());
                    }
                    else if (dgvApps.Rows[i].Cells["Action"].Value.ToString() == "Reinstall")
                    {
                        writer.WriteLine(reinstallstring + dgvApps.Rows[i].Cells["Package"].Value.ToString());
                    }
                }
            }

            if (File.Exists(dir + @"\" + name + " Script.bat"))
            {
                using (var tw = new StreamWriter(dir + @"\" + name + " Script.bat", append: true))
                {
                    tw.WriteLine("");
                    tw.Write("timeout /t 10");
                }

                FlexibleMessageBox.FONT = functions.setMessageBoxFont(Properties.Settings.Default.FontIndex);
                FlexibleMessageBox.Show("Success: Script Created!");
            }
            else
            {
                FlexibleMessageBox.FONT = functions.setMessageBoxFont(Properties.Settings.Default.FontIndex);
                FlexibleMessageBox.Show("Error: Script Not Created!");
            }

            Close();
        }

        private void dgvApps_SelectionChanged(object sender, EventArgs e)
        {
            dgvApps.ClearSelection();
        }

        private void dgvApps_SelectionChanged_1(object sender, EventArgs e)
        {
            dgvApps.ClearSelection();
        }

        private void btnAllEnable_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvApps.Rows)
            {
                row.Cells[dgvApps.Columns["Action"].Index].Value = "Enable";
            }
        }

        private void btnAllDisable_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvApps.Rows)
            {
                row.Cells[dgvApps.Columns["Action"].Index].Value = "Disable";
            }
        }

        private void btnAllUninstall_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvApps.Rows)
            {
                row.Cells[dgvApps.Columns["Action"].Index].Value = "Uninstall";
            }
        }

        private void btnAllReinstall_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvApps.Rows)
            {
                row.Cells[dgvApps.Columns["Action"].Index].Value = "Reinstall";
            }
        }
    }
}
