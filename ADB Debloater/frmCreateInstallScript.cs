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
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ADB_Debloater
{
    public partial class frmCreateInstallScript : Form
    {
        private string name = "";
        public frmCreateInstallScript()
        {
            InitializeComponent();
        }

        public frmCreateInstallScript(string deviceName)
        {
            InitializeComponent();
            name = deviceName;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdInstall = new SaveFileDialog();

            sfdInstall.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            sfdInstall.Title = "Save APK File";
            sfdInstall.CheckFileExists = false;
            sfdInstall.CheckPathExists = true;
            sfdInstall.DefaultExt = "bat";
            sfdInstall.Filter = "ADB Batch File (*.bat)|*.bat";
            sfdInstall.FilterIndex = 2;
            sfdInstall.RestoreDirectory = false;
            sfdInstall.FileName = name + " APK Script";

            if (sfdInstall.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfdInstall.FileName))
                {
                    File.Delete(sfdInstall.FileName);
                }

                for (int i = 0; i < lstPackages.Items.Count; i++)
                {
                    using (StreamWriter writer = new StreamWriter(sfdInstall.FileName, append: true))
                    {
                        writer.WriteLine("adb install " + lstPackages.Items[i].ToString());
                    }
                }
            }

            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdAPK = new OpenFileDialog();

            ofdAPK.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            ofdAPK.Filter = "APK Files (*.apk)|*.apk";
            ofdAPK.FilterIndex = 1;
            ofdAPK.FileName = "";
            ofdAPK.RestoreDirectory = false;

            if (ofdAPK.ShowDialog() == DialogResult.OK)
            {
                lstPackages.Items.Add(ofdAPK.FileName);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstPackages.Items.Remove(lstPackages.SelectedItem);
        }

        private void frmCreateInstallScript_Load(object sender, EventArgs e)
        {
            clsFunctions functions = new clsFunctions();

            ArrayList controls = new ArrayList();
            controls.Add(lstPackages);
            controls.Add(btnAdd);
            controls.Add(btnRemove);
            controls.Add(btnCreate);

            functions.SetTheme(this, controls);

            ArrayList ctrls = new ArrayList
            {
                Controls
            };

            functions.setFont(this, Properties.Settings.Default.FontIndex, ctrls, null);
        }
    }
}
