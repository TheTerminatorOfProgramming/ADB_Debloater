﻿using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADB_Debloater
{
    public partial class frmMain : Form
    {
        #region Declarations

        private clsFunctions functions;
        public ArrayList deviceNames = new ArrayList();
        public ArrayList deviceSerial = new ArrayList();
        private ArrayList edited = new ArrayList();
        private ArrayList uninstalled = new ArrayList();
        private DataTable apps = new DataTable();
        private string filterField;
        private string position = "";
        private string APKSavePath = Directory.GetCurrentDirectory() + "\\APK\\Saves";
        private string adbPath = Directory.GetCurrentDirectory() + "\\Tools\\ADB";
        private string Configs = Directory.GetCurrentDirectory() + "\\Config";
        private System.Threading.Timer temp;
        private DateTime startTime;
        private int time;
        private string ip;
        private string comboValue;
        private string value;
        #endregion Declarations

        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            functions = new clsFunctions();

            var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            var key = hklm.OpenSubKey(@"SOFTWARE\Cygwin");

            ArrayList controls = new ArrayList();
            controls.Add(dgvApps);

            functions.SetTheme(this, controls);

            SetReloadColor();

            using (hklm)
            {
                using (key)
                {
                    if (key != null)
                    {
                        edited.Clear();

                        apps.Columns.Add("Package Name", typeof(string));
                        apps.Columns.Add("Status", typeof(string));

                        dgvApps.DataSource = apps;

                        dgvApps.Columns["Package Name"].Width = 334;
                        dgvApps.Columns["Status"].Width = 83;

                        dgvApps.Columns["Package Name"].ReadOnly = true;
                        dgvApps.Columns["Status"].ReadOnly = true;

                        functions.GetDevices();

#if DEBUG
                        MessageBox.Show(deviceNames.Count.ToString()); //Debug Only
#endif

                        for (int i = 0; i < deviceNames.Count; i++)
                        {
                            if (i > 0)
                            {
                                if (deviceNames[i].ToString() == deviceNames[i - 1].ToString())
                                {
                                    MessageBox.Show("Please Unplug USB Cable When in ADB Wireless\n\nDevices Connected by Multiple Methods (USB\\ADB Wifi) Will Only have the ADB Wifi Mode Added!");

                                    if (!deviceSerial[i].ToString().Contains(":"))
                                    {
                                        deviceSerial.RemoveAt(i - 1);
                                        deviceNames.RemoveAt(i - 1);

                                        cmbDevices.Items.Add(deviceNames[i].ToString());
                                    }
                                    else
                                    {
                                        deviceSerial.RemoveAt(i);
                                        deviceNames.RemoveAt(i);

                                        cmbDevices.Items.Add(deviceNames[i - 1].ToString());
                                    }
                                }
                                else
                                {
                                    cmbDevices.Items.Add(deviceNames[i].ToString());
                                }
                            }
                            else
                            {
                                cmbDevices.Items.Add(deviceNames[i].ToString());
                            }
                        }

                        if (cmbDevices.Items.Count > 0)
                        {
                            cmbDevices.SelectedIndex = 0;
                        }

                        functions.CheckForDevice(deviceSerial, deviceNames);

                        dgvApps.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        foreach (DataGridViewColumn col in dgvApps.Columns)
                        {
                            col.SortMode = DataGridViewColumnSortMode.NotSortable;
                        }

                        dgvApps.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        if (Properties.Settings.Default.Filter != "")
                        {
                            filterField = Properties.Settings.Default.Filter;
                        }
                        else
                        {
                            filterField = "Package Name";
                        }

                    }
                    else
                    {
                        if (MessageBox.Show("Cygwin Not Installed, Install The Cygwin with the Grep Command and Try Again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                }
            }
        }

        private void BtnDeviceInfo_Click(object sender, EventArgs e)
        {
            if (deviceNames.Count > 0)
            {
                frmDeviceInfo info = new frmDeviceInfo(cmbDevices.Text);
                info.ShowDialog();
            }
            else
            {
                MessageBox.Show("This Function is Unavailable due to No Devices Connected!");
            }
        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            frmOptions options = new frmOptions();
            options.ShowDialog();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void CmbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            functions.SetSerial(deviceSerial[cmbDevices.SelectedIndex].ToString());

            if (deviceSerial.Count == 0 && deviceNames.Count == 0)
            {
                lblConnectedStatus.Text = "No Device Connected";
                txtSearch.Enabled = false;
                cmbSearchCriteria.Enabled = false;
                btnExport.Enabled = false;
                btnImport.Enabled = false;
                btnInstallAPK.Enabled = false;
                btnReinstall.Enabled = false;
                btnCreateScript.Enabled = false;
                btnStdPackages.Enabled = false;
                btnUpdtPackages.Enabled = false;
                btnExportApk.Enabled = false;
                btnCopyPkgName.Enabled = false;
                btnLookupPkgName.Enabled = false;
                btnEnableDisable.Enabled = false;
                btnUninstall.Enabled = false;
                btnRefreshList.Enabled = false;
            }
            else
            {
                txtSearch.Enabled = true;
                cmbSearchCriteria.Enabled = true;
                btnExport.Enabled = true;
                btnImport.Enabled = true;
                btnInstallAPK.Enabled = true;
                btnReinstall.Enabled = true;
                btnCreateScript.Enabled = true;
                btnStdPackages.Enabled = true;
                btnUpdtPackages.Enabled = true;
                btnExportApk.Enabled = true;
                btnCopyPkgName.Enabled = true;
                btnLookupPkgName.Enabled = true;
                btnEnableDisable.Enabled = true;
                btnUninstall.Enabled = true;
                btnRefreshList.Enabled = true;

                functions.GetApps(apps);
                dgvApps.ClearSelection();

                if (Properties.Settings.Default.Filter != "")
                {
                    filterField = Properties.Settings.Default.Filter;
                }
                else
                {
                    filterField = "Package Name";
                }

                if (!cmbSearchCriteria.Items.Contains(filterField))
                {
                    filterField = "Package Name";
                    cmbSearchCriteria.SelectedItem = filterField;
                }
                else
                {
                    cmbSearchCriteria.SelectedItem = filterField;
                }
            }
        }

        private void BtnReloadDevice_Click(object sender, EventArgs e)
        {
            cmbDevices.Items.Clear();
            deviceNames.Clear();
            deviceSerial.Clear();

            functions.GetDevices();

#if DEBUG
            MessageBox.Show(deviceNames.Count.ToString()); //Debug Only
#endif

            for (int i = 0; i < deviceNames.Count; i++)
            {
                if (i > 0)
                {
                    if (deviceNames[i].ToString() == deviceNames[i - 1].ToString())
                    {
                        MessageBox.Show("Please Unplug USB Cable When in ADB Wireless\n\nDevices Connected by Multiple Methods (USB\\ADB Wifi) Will Only have the ADB Wifi Mode Added!");

                        if (!deviceSerial[i].ToString().Contains(":"))
                        {
                            deviceSerial.RemoveAt(i - 1);
                            deviceNames.RemoveAt(i - 1);

                            cmbDevices.Items.Add(deviceNames[i].ToString());
                        }
                        else
                        {
                            deviceSerial.RemoveAt(i);
                            deviceNames.RemoveAt(i);

                            cmbDevices.Items.Add(deviceNames[i - 1].ToString());
                        }
                    }
                    else
                    {
                        cmbDevices.Items.Add(deviceNames[i].ToString());
                    }
                }
                else
                {
                    cmbDevices.Items.Add(deviceNames[i].ToString());
                }
            }

            if (cmbDevices.Items.Count > 0)
            {
                cmbDevices.SelectedIndex = 0;
            }

            functions.CheckForDevice(deviceSerial, deviceNames);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            apps.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cmbSearchCriteria.Text, txtSearch.Text);
            dgvApps.ClearSelection();
        }

        private void BtnAdbWifi_Click(object sender, EventArgs e)
        {
            frmConnectWirelessDebug wirelessdebug;
            if (cmbDevices.Items.Count != 0)
            {
                functions.NewADBCommand(" shell ip addr show wlan0 | grep 'inet ' | cut -d' ' -f6|cut -d/ -f1", false, true);
                ip = functions.getOutput();
                wirelessdebug = new frmConnectWirelessDebug(ip, deviceSerial, deviceSerial[cmbDevices.SelectedIndex].ToString());
            }
            else
            {
                wirelessdebug = new frmConnectWirelessDebug();
            }
            wirelessdebug.ShowDialog();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            frmListConfirm confirm = new frmListConfirm(edited, cmbDevices.Text);
            confirm.ShowDialog();
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImport = new OpenFileDialog();

            ofdImport.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            ofdImport.Filter = "ADB Config Files (*.acfg)|*.acfg";
            ofdImport.FilterIndex = 1;
            ofdImport.FileName = "";
            ofdImport.RestoreDirectory = false;

            if (ofdImport.ShowDialog() == DialogResult.OK)
            {
                foreach (string line in File.ReadLines(ofdImport.FileName, Encoding.UTF8))
                {
                    if (line != "")
                    {
                        foreach (DataGridViewRow row in dgvApps.Rows)
                        {
                            if (row.Cells[0].Value.ToString().Equals(line))
                            {
                                if (!edited.Contains(line))
                                {
                                    edited.Add(line);
                                }

                                dgvApps.Rows[row.Index].Selected = true;
                            }
                        }
                    }
                }
            }
        }

        private void BtnInstallAPK_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdAPK = new OpenFileDialog();

            ofdAPK.InitialDirectory = @"C:\Users\" + Environment.UserName + @"\Downloads";
            ofdAPK.Title = "Browse APK Files";
            ofdAPK.Filter = "apk files (*.apk)|*.apk";
            ofdAPK.FilterIndex = 1;
            ofdAPK.Multiselect = false;
            ofdAPK.FileName = "";

            if (ofdAPK.ShowDialog() == DialogResult.OK)
            {
                functions.InstallAPK(ofdAPK.FileName);
            }

            functions.GetApps(apps);

            dgvApps.ClearSelection();
        }

        private void BtnReinstall_Click(object sender, EventArgs e)
        {
            ArrayList multiChoice = new ArrayList();
            multiChoice.Add("Choose From Current Session");
            multiChoice.Add("Manually Input Package Name");

            if (ShowComboDialog(multiChoice, "Select How to Reinstall Package") == DialogResult.OK)
            {
                if (GetComboValue() == "Choose From Current Session")
                {
                    if (uninstalled.Count > 0)
                    {
                        if (ShowComboDialog(edited, "Select Package to Reinstall") == DialogResult.OK)
                        {
                            functions.ReinstallApp(GetComboValue());

                            functions.GetApps(apps);

                            dgvApps.ClearSelection();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Packages Available to Reinstall");
                    }
                }
                else
                {
                    string input = "";
                    if (ShowInputDialog(ref input, "Input Package Name!") == DialogResult.OK)
                    {
                        functions.ReinstallApp(GetValue());

                        functions.GetApps(apps);

                        dgvApps.ClearSelection();
                    }
                }
            }
        }

        private void BtnCreateScript_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            ofd.Filter = "ADB Config Files (*.acfg)|*.acfg";
            ofd.FilterIndex = 1;
            ofd.FileName = "";
            ofd.RestoreDirectory = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                frmCreateScript createScript = new frmCreateScript(ofd.FileName, Path.GetDirectoryName(ofd.FileName));
                createScript.ShowDialog();
            }
        }

        private void BtnStdPackages_Click(object sender, EventArgs e)
        {
            if (dgvApps.Rows.Count > 0)
            {
                dgvApps.ClearSelection();

                foreach (var line in File.ReadLines(Configs + @"\" + "Standard.packageConfig"))
                {
                    if (line != "")
                    {
                        functions.SelectPackage(line.ToString());
                    }
                }
            }
        }

        private void BtnUpdtPackages_Click(object sender, EventArgs e)
        {
            if (dgvApps.Rows.Count > 0)
            {
                dgvApps.ClearSelection();

                foreach (var line in File.ReadLines(Configs + @"\" + "SoftUpd.packageConfig"))
                {
                    if (line != "")
                    {
                        functions.SelectPackage(line.ToString());
                    }
                }
            }
        }

        private void BtnExportApk_Click(object sender, EventArgs e)
        {
            if (dgvApps.SelectedRows.Count > 1)
            {
                for (int i = 0; i < dgvApps.SelectedRows.Count; i++)
                {
                    functions.SaveAPK(dgvApps.SelectedRows[i].Cells["Package Name"].Value.ToString());
                }

                Process.Start("explorer.exe", APKSavePath);
            }
            else if (dgvApps.SelectedRows.Count == 1)
            {
                functions.SaveAPK(dgvApps.SelectedRows[0].Cells["Package Name"].Value.ToString());

                Process.Start("explorer.exe", APKSavePath);
            }
        }

        private void BtnLookupPkgName_Click(object sender, EventArgs e)
        {
            string searchRequest = dgvApps.SelectedRows[0].Cells["Package Name"].Value.ToString();

            Process.Start("http://www.google.com.au/search?q=" + Uri.EscapeDataString(searchRequest));
        }

        private void BtnCopyPkgName_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dgvApps.SelectedRows[0].Cells["Package Name"].Value.ToString());
        }

        private void BtnEnableDisable_Click(object sender, EventArgs e)
        {
            if (dgvApps.SelectedRows.Count == 1)
            {
                string app = dgvApps.SelectedRows[0].Cells["Status"].Value.ToString();

                if (app == "Enabled")
                {
                    if (!edited.Contains(dgvApps.SelectedRows[0].Cells["Package Name"].Value.ToString()))
                    {
                        edited.Add(dgvApps.SelectedRows[0].Cells["Package Name"].Value.ToString());
                    }

                    functions.DisableApp(dgvApps.SelectedRows[0].Cells["Package Name"].Value.ToString());

                    functions.GetApps(apps);
                    dgvApps.ClearSelection();
                }
                else
                {
                    if (!edited.Contains(dgvApps.SelectedRows[0].Cells["Package Name"].Value.ToString()))
                    {
                        edited.Add(dgvApps.SelectedRows[0].Cells["Package Name"].Value.ToString());
                    }

                    functions.EnableApp(dgvApps.SelectedRows[0].Cells["Package Name"].Value.ToString());

                    functions.GetApps(apps);
                    dgvApps.ClearSelection();
                }
            }
            else if (dgvApps.SelectedRows.Count > 1)
            {
                for (int i = 0; i < dgvApps.SelectedRows.Count; i++)
                {
                    string app = dgvApps.SelectedRows[i].Cells["Status"].Value.ToString();

                    if (app == "Enabled")
                    {
                        if (!edited.Contains(dgvApps.SelectedRows[i].Cells["Package Name"].Value.ToString()))
                        {
                            edited.Add(dgvApps.SelectedRows[i].Cells["Package Name"].Value.ToString());
                        }

                        functions.DisableApp(dgvApps.SelectedRows[i].Cells["Package Name"].Value.ToString());
                    }
                    else
                    {
                        if (!edited.Contains(dgvApps.SelectedRows[0].Cells["Package Name"].Value.ToString()))
                        {
                            edited.Add(dgvApps.SelectedRows[0].Cells["Package Name"].Value.ToString());
                        }

                        functions.EnableApp(dgvApps.SelectedRows[i].Cells["Package Name"].Value.ToString());
                    }
                }

                functions.GetApps(apps);

                dgvApps.ClearSelection();
            }
        }

        private void BtnUninstall_Click(object sender, EventArgs e)
        {
            if (dgvApps.SelectedRows.Count == 1)
            {
                if (!edited.Contains(dgvApps.SelectedRows[0].Cells["Package Name"].Value.ToString()))
                {
                    edited.Add(dgvApps.SelectedRows[0].Cells["Package Name"].Value.ToString());
                }

                if (!uninstalled.Contains(dgvApps.SelectedRows[0].Cells["Package Name"].Value.ToString()))
                {
                    uninstalled.Add(dgvApps.SelectedRows[0].Cells["Package Name"].Value.ToString());
                }

                functions.UninstallApp(dgvApps.SelectedRows[0].Cells["Package Name"].Value.ToString());
            }
            else if (dgvApps.SelectedRows.Count > 1)
            {
                for (int i = 0; i < dgvApps.SelectedRows.Count; i++)
                {
                    if (!edited.Contains(dgvApps.SelectedRows[i].Cells["Package Name"].Value.ToString()))
                    {
                        edited.Add(dgvApps.SelectedRows[i].Cells["Package Name"].Value.ToString());
                    }

                    if (!uninstalled.Contains(dgvApps.SelectedRows[i].Cells["Package Name"].Value.ToString()))
                    {
                        uninstalled.Add(dgvApps.SelectedRows[i].Cells["Package Name"].Value.ToString());
                    }

                    functions.UninstallApp(dgvApps.SelectedRows[i].Cells["Package Name"].Value.ToString());
                }
            }

            functions.GetApps(apps);

            dgvApps.ClearSelection();
        }

        private void BtnRefreshList_Click(object sender, EventArgs e)
        {
            functions.GetApps(apps);
            dgvApps.ClearSelection();
        }

        private void DgvApps_SelectionChanged(object sender, EventArgs e)
        {
            lblSelected.Text = "Selected: " + dgvApps.SelectedRows.Count.ToString();
        }

        private DialogResult ShowInputDialog(ref string input, string title)
        {
            Size size = new Size(250, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = title;
            inputBox.StartPosition = FormStartPosition.CenterScreen;
            inputBox.ControlBox = false;

            TextBox textBox = new TextBox();
            textBox.Size = new Size(size.Width - 10, 23);
            textBox.Location = new Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            clsFunctions functions = new clsFunctions();
            ArrayList controls = new ArrayList();
            controls.Add(inputBox);
            controls.Add(okButton);
            controls.Add(cancelButton);

            functions.SetTheme(inputBox, controls);

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;

            SetValue(textBox.Text);

            return result;
        }

        private DialogResult ShowComboDialog(ArrayList list, string title)
        {
            Size size = new Size(250, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = title;
            inputBox.StartPosition = FormStartPosition.CenterScreen;
            inputBox.ControlBox = false;

            ComboBox comboBox = new ComboBox();
            comboBox.Size = new Size(size.Width - 10, 23);
            comboBox.Location = new Point(5, 5);
            comboBox.DataSource = list;
            comboBox.SelectedIndex = -1;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            inputBox.Controls.Add(comboBox);

            Button okButton = new Button();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            clsFunctions functions = new clsFunctions();
            ArrayList controls = new ArrayList();
            controls.Add(comboBox);
            controls.Add(okButton);
            controls.Add(cancelButton);

            functions.SetTheme(inputBox, controls);

            DialogResult result = inputBox.ShowDialog();
            SetComboValue(comboBox.SelectedItem.ToString());
            return result;
        }

        public void SetComboValue(string value)
        {
            comboValue = value;
        }

        public String GetComboValue()
        {
            return comboValue;
        }

        public void SetValue(string value)
        {
            this.value = value;
        }

        public String GetValue()
        {
            return value;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                functions.closeProcess("adb");
                functions.closeProcess("scrcpy");
                functions.closeProcess("conhost");
            }
            catch
            {
                Application.Exit();
            }
        }

        public void SetReloadColor()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"))
            {
                if (key != null)
                {
                    Object o = key.GetValue("SystemUsesLightTheme");
                    if (o != null)
                    {
                        if (o.ToString() == "0")
                        {
                            if (Properties.Settings.Default.Theme == 0)
                            {
                                btnReloadDevice.Image = Properties.Resources.refresh_white;
                            }

                            if (Properties.Settings.Default.Theme == 1)
                            {
                                btnReloadDevice.Image = Properties.Resources.refresh_white;
                            }
                        }
                        else
                        {
                            btnReloadDevice.Image = Properties.Resources.refresh_black;
                        }
                    }
                }
            }
        }
    }
}