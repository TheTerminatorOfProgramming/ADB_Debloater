using Microsoft.Win32;
using OSVersionExtension;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ADB_Debloater
{
    class clsFunctions
    {
        private string output = "";
        private string adb = Directory.GetCurrentDirectory() + "\\Tools\\ADB\\adb.exe";
        private string Configs = Directory.GetCurrentDirectory() + "\\Config";
        private string APKSavePath = Directory.GetCurrentDirectory() + "\\APK\\Saves";
        private string Temp = Directory.GetCurrentDirectory() + "\\Temp";
        private string selectedSerial = "";
        ArrayList disabled;
        string sdSerial = "";
        string phoneTotal = "";
        string phoneUsed = "";
        string phoneAvail = "";
        string phonePercent = "";
        string SdTotal = "";
        string SdUsed = "";
        string SdAvail = "";
        string SdPercent = "";
        private List<string> tempApps = new List<string>();
        private Button refresh = Application.OpenForms["frmMain"].Controls.Find("btnReloadDevice", true)[0] as Button;
        private Label packagecount = Application.OpenForms["frmMain"].Controls.Find("lblPackageCount", true)[0] as Label;
        private Label deviceconnected = Application.OpenForms["frmMain"].Controls.Find("lblConnectedStatus", true)[0] as Label;
        private TextBox search = Application.OpenForms["frmMain"].Controls.Find("txtSearch", true)[0] as TextBox;
        private DataGridView dgv = Application.OpenForms["frmMain"].Controls.Find("dgvApps", true)[0] as DataGridView;     
        private ComboBox searchquery = Application.OpenForms["frmMain"].Controls.Find("cmbSearchCriteria", true)[0] as ComboBox;
        public string GetName()
        {
            string name = AssemblyProduct;
            return name;
        }

        public string GetVersion()
        {
            string version = String.Format("Version {0}", AssemblyVersion);
            return version;
        }

        public string GetCopyright()
        {
            string cpyrt = AssemblyCopyright;
            return cpyrt;
        }

        public string GetCompanyName()
        {
            string companyname = AssemblyCompany;
            return companyname;
        }

        public string GetDesc()
        {
            string desc = AssemblyDescription;
            return desc;
        }

        public Icon GetIcon()
        {
            Icon appIcon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
            return appIcon;
        }

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        public void SetTheme(Form frm, ArrayList controls)
        {



            if (Properties.Settings.Default.Theme == 0)
            {
                frm.BackColor = Color.White;
                frm.ForeColor = Color.Black;

                foreach (Control c in controls)
                {
                    if (c is TextBox || c is Label || c is Button)
                    {
                        c.BackColor = Color.White;
                        c.ForeColor = Color.Black;
                    }

                    if (c is DataGridView)
                    {
                        c.BackColor = Color.White;
                        c.ForeColor = Color.Black;

                        ((DataGridView)c).DefaultCellStyle.BackColor = Color.White;
                        ((DataGridView)c).DefaultCellStyle.ForeColor = Color.Black;
                    }

                    if (c is ListBox)
                    {
                        c.BackColor = Color.White;
                        c.ForeColor = Color.Black;
                    }

                    if (c is GroupBox)
                    {
                        c.BackColor = Color.White;
                        c.ForeColor = Color.Black;
                    }
                }
            }

            if (Properties.Settings.Default.Theme == 1)
            {
                frm.BackColor = Color.FromArgb(56, 56, 56);
                frm.ForeColor = Color.White;

                foreach (Control c in controls)
                {
                    if (c is TextBox || c is Label || c is Button)
                    {
                        c.BackColor = Color.FromArgb(56, 56, 56);
                        c.ForeColor = Color.White;
                    }

                    if (c is DataGridView)
                    {
                        c.BackColor = Color.FromArgb(56, 56, 56);
                        c.ForeColor = Color.White;

                        ((DataGridView)c).DefaultCellStyle.BackColor = Color.FromArgb(56, 56, 56);
                        ((DataGridView)c).DefaultCellStyle.ForeColor = Color.White;
                    }

                    if (c is ListBox)
                    {
                        c.BackColor = Color.FromArgb(56, 56, 56);
                        c.ForeColor = Color.White;
                    }

                    if (c is GroupBox)
                    {
                        c.BackColor = Color.FromArgb(56, 56, 56);
                        c.ForeColor = Color.White;
                    }
                }
            }
            
            if (Properties.Settings.Default.Theme == 2)
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
                                frm.BackColor = Color.FromArgb(56, 56, 56);
                                frm.ForeColor = Color.White;

                                foreach (Control c in controls)
                                {
                                    if (c is TextBox || c is Label || c is Button)
                                    {
                                        c.BackColor = Color.FromArgb(56, 56, 56);
                                        c.ForeColor = Color.White;
                                    }

                                    if (c is DataGridView)
                                    {
                                        c.BackColor = Color.FromArgb(56, 56, 56);
                                        c.ForeColor = Color.White;

                                        ((DataGridView)c).DefaultCellStyle.BackColor = Color.FromArgb(56, 56, 56);
                                        ((DataGridView)c).DefaultCellStyle.ForeColor = Color.White;
                                    }

                                    if (c is ListBox)
                                    {
                                        c.BackColor = Color.FromArgb(56, 56, 56);
                                        c.ForeColor = Color.White;
                                    }

                                    if (c is GroupBox)
                                    {
                                        c.BackColor = Color.FromArgb(56, 56, 56);
                                        c.ForeColor = Color.White;
                                    }
                                }
                            }
                            else
                            {
                                frm.BackColor = Color.White;
                                frm.ForeColor = Color.Black;

                                foreach (Control c in controls)
                                {
                                    if (c is TextBox || c is Label || c is Button)
                                    {
                                        c.BackColor = Color.White;
                                        c.ForeColor = Color.Black;
                                    }

                                    if (c is DataGridView)
                                    {
                                        c.BackColor = Color.White;
                                        c.ForeColor = Color.Black;

                                        ((DataGridView)c).DefaultCellStyle.BackColor = Color.White;
                                        ((DataGridView)c).DefaultCellStyle.ForeColor = Color.Black;
                                    }

                                    if (c is ListBox)
                                    {
                                        c.BackColor = Color.White;
                                        c.ForeColor = Color.Black;
                                    }

                                    if (c is GroupBox)
                                    {
                                        c.BackColor = Color.White;
                                        c.ForeColor = Color.Black;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        
        public bool IsValidateIP(string Address)
        {
            //Match pattern for IP address
            string Pattern = @"(^10\.)|(^172\.1[6-9]\.)|(^172\.2[0-9]\.)|(^172\.3[0-1]\.)|(^192\.168\.)|(^127\.0\.0\.1)";
            //Regular Expression object
            Regex check = new Regex(Pattern);

            //check to make sure an ip address was provided
            if (string.IsNullOrEmpty(Address))
                //returns false if IP is not provided
                return false;
            else
                //Matching the pattern
                return check.IsMatch(Address, 0);
        }

        public void NewADBCommand(string args, bool load, bool line)
        {
            string arguments = String.Empty;

            if (load == false)
            {
                arguments = " -s " + GetSerial() + args;
            }
            else
            {
                arguments = args;
            }

            Process adbProcess = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = adb;
            startInfo.Arguments = arguments;
            adbProcess.StartInfo = startInfo;
            adbProcess.Start();

            if (line)
            {
                setOutput(adbProcess.StandardOutput.ReadLine());
            }
            else
            {
                setOutput(adbProcess.StandardOutput.ReadToEnd());
            } 
        }

        public void NewADBCommand(string args, string serial, bool load, bool line)
        {
            string arguments = String.Empty;

            if (load == false)
            {
                arguments = " -s " + serial + args;
            }
            else
            {
                arguments = args;
            }

            Process adbProcess = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = adb;
            startInfo.Arguments = arguments;
            adbProcess.StartInfo = startInfo;
            adbProcess.Start();

            if (line)
            {
                setOutput(adbProcess.StandardOutput.ReadLine());
            }
            else
            {
                setOutput(adbProcess.StandardOutput.ReadToEnd());
            }
        }

        public void NewPairCommand(string args)
        {
            Process adbProcess = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = adb;
            startInfo.Arguments = args;
            adbProcess.StartInfo = startInfo;
            adbProcess.Start();

            setOutput(adbProcess.StandardOutput.ReadLine());
        }

        public void setOutput(string value)
        {
            output = value;
        }

        public string getOutput()
        {
            return output;
        }

        public void GetDevices()
        {
            NewADBCommand(" devices -l", true, false);
            ArrayList temp = new ArrayList();
            if (!getOutput().Contains("Unauthorized"))
            {
                temp.AddRange(getOutput().Split(new char[] { '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries));

                for (int i = 0; i < temp.Count; i++)
                {
                    string AllowedChars = @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\:\d{4,5}";
                    Regex regex = new Regex(AllowedChars);
                    if (regex.IsMatch(temp[i].ToString()) || temp[i].ToString().Any(char.IsDigit) && !temp[i].ToString().Contains(":"))
                    {
#if DEBUG
                        MessageBox.Show(temp[i].ToString());
#endif

                        NewADBCommand(" -s " + temp[i].ToString() + " shell settings get global device_name", true, true);

#if DEBUG
                        MessageBox.Show(getOutput()); //Debug Only
#endif

                        frmMain form = (frmMain)Application.OpenForms["frmMain"];
                        form.deviceNames.Add(getOutput());
                        form.deviceSerial.Add(temp[i].ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("A Device is Unauthorized for ADB Use, Please Authorize and Try Again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CheckForDevice(ArrayList Serial, ArrayList Names)
        {
            FormCollection fc = Application.OpenForms;
            if (Serial.Count == 0 && Names.Count == 0)
            {
                deviceconnected.Text = "No Device Connected";

                foreach (Form frm in fc)
                {
                    if (frm.Text == "Device Info")
                    {
                        MetroFramework.Controls.MetroTile shutdown = Application.OpenForms["frmDeviceInfo"].Controls.Find("mtShutdown", true)[0] as MetroFramework.Controls.MetroTile;
                        MetroFramework.Controls.MetroTile reboot = Application.OpenForms["frmDeviceInfo"].Controls.Find("mtReboot", true)[0] as MetroFramework.Controls.MetroTile;
                        MetroFramework.Controls.MetroTile screenshot = Application.OpenForms["frmDeviceInfo"].Controls.Find("mtScreenshot", true)[0] as MetroFramework.Controls.MetroTile;
                        MetroFramework.Controls.MetroTile record = Application.OpenForms["frmDeviceInfo"].Controls.Find("mtRecord", true)[0] as MetroFramework.Controls.MetroTile;
                        MetroFramework.Controls.MetroTile remote = Application.OpenForms["frmDeviceInfo"].Controls.Find("mtRemote", true)[0] as MetroFramework.Controls.MetroTile;
                        Panel pnl = Application.OpenForms["frmDeviceInfo"].Controls.Find("pnlAPK", true)[0] as Panel;
                        Button storage = Application.OpenForms["frmDeviceInfo"].Controls.Find("btnStorageDets", true)[0] as Button;

                        shutdown.Enabled = false;
                        reboot.Enabled = false;
                        screenshot.Enabled = false;
                        record.Enabled = false;
                        remote.Enabled = false;

                        pnl.Enabled = false;

                        storage.Visible = false;
                    }
                }
            }
            else
            {
                NewADBCommand(" shell dumpsys battery | grep powered", false, false);

                if (getOutput().Contains("USB powered: true"))
                {
                    deviceconnected.Text = "Device Connected";
                }
                else
                {
                    deviceconnected.Text = "Device Connected Wirelessly";
                }

                foreach (Form frm in fc)
                {
                    if (frm.Text == "Device Info")
                    {
                        MetroFramework.Controls.MetroTile shutdown = Application.OpenForms["frmDeviceInfo"].Controls.Find("mtShutdown", true)[0] as MetroFramework.Controls.MetroTile;
                        MetroFramework.Controls.MetroTile reboot = Application.OpenForms["frmDeviceInfo"].Controls.Find("mtReboot", true)[0] as MetroFramework.Controls.MetroTile;
                        MetroFramework.Controls.MetroTile screenshot = Application.OpenForms["frmDeviceInfo"].Controls.Find("mtScreenshot", true)[0] as MetroFramework.Controls.MetroTile;
                        MetroFramework.Controls.MetroTile record = Application.OpenForms["frmDeviceInfo"].Controls.Find("mtRecord", true)[0] as MetroFramework.Controls.MetroTile;
                        MetroFramework.Controls.MetroTile remote = Application.OpenForms["frmDeviceInfo"].Controls.Find("mtRemote", true)[0] as MetroFramework.Controls.MetroTile;
                        Panel pnl = Application.OpenForms["frmDeviceInfo"].Controls.Find("pnlAPK", true)[0] as Panel;
                        Button storage = Application.OpenForms["frmDeviceInfo"].Controls.Find("btnStorageDets", true)[0] as Button;

                        shutdown.Enabled = true;
                        reboot.Enabled = true;
                        screenshot.Enabled = true;
                        record.Enabled = true;
                        remote.Enabled = true;

                        pnl.Enabled = true;

                        storage.Visible = true;
                    }
                }
            }
        }

        public void SetSerial(string serial)
        {
            selectedSerial = serial;
            Properties.Settings.Default.Serial = serial;
            Properties.Settings.Default.Save();
        }

        public string GetSerial()
        {
            return selectedSerial;
        }

        public string GetSimpleStorage()
        {
            string storage = "";

            NewADBCommand(" shell df /sdcard | grep /storage", false, false);

            string intSD = getOutput();

            if (intSD != "")
            {
                intSD = intSD.Replace("   ", " ");

                intSD = intSD.Replace(" ", "_");

                string[] intStats = intSD.Split('_');

                intSD = Int32.Parse(intStats[2]) / 1024 / 1024 + " GB";

                if (GetSDSerial() != "")
                {
                    NewADBCommand(" shell df /storage/" + GetSDSerial() + " | grep /storage", false, false);

                    string extSD = getOutput();

                    extSD = extSD.Replace("   ", " ");

                    extSD = extSD.Replace(" ", "_");

                    string[] extStats = extSD.Split('_');

                    extSD = Int32.Parse(extStats[2]) / 1024 / 1024 + " GB";

                    storage = "Phone: " + intSD + "\nSD Card: " + extSD;
                }
                else
                {
                    storage = "Phone: " + intSD + "\nSD Card: N/A";
                }
            }
            return storage;
        }

        public void GetStorage(string storageType)
        {
            if (storageType == "Internal" | storageType == "Phone")
            {
                NewADBCommand(" shell df | grep /emulated", Properties.Settings.Default.Serial, false, false);

                string intSD = getOutput();

                intSD = intSD.Replace("    ", " ");

                intSD = intSD.Replace("   ", " ");

                intSD = intSD.Replace("  ", " ");

                intSD = intSD.Replace(" ", "_");

                string[] intStats = intSD.Split('_');

                int temp = 0;

                if (int.TryParse(intStats[1], out temp))
                {
                    int a = ((temp / 1024) / 1024);
                    SetPhoneTotalStorage(Convert.ToString(a));
                }

                if (int.TryParse(intStats[2], out temp))
                {
                    int a = ((temp / 1024) / 1024);
                    SetPhoneUsedStorage(Convert.ToString(a));
                }

                if (int.TryParse(intStats[3], out temp))
                {
                    int a = ((temp / 1024) / 1024);
                    SetPhoneAvailStorage(Convert.ToString(a));
                }

                SetPhoneUsedPercentStorage(intStats[4]);
            }

            if (storageType == "External" | storageType == "SD")
            {
                if (GetSerial() != "" | Properties.Settings.Default.SdSerial != "")
                {
                    NewADBCommand(" shell df | grep /" + Properties.Settings.Default.SdSerial, Properties.Settings.Default.Serial, false, false);

                    string extSD = getOutput();

                    extSD = extSD.Replace("    ", " ");

                    extSD = extSD.Replace("   ", " ");

                    extSD = extSD.Replace("  ", " ");

                    extSD = extSD.Replace(" ", "_");

                    string[] extStats = extSD.Split('_');

                    int temp = 0;

                    if (int.TryParse(extStats[1], out temp))
                    {
                        int a = ((temp / 1024) / 1024);
                        SetSDTotalStorage(Convert.ToString(a));
                    }

                    if (int.TryParse(extStats[2], out temp))
                    {
                        int a = ((temp / 1024) / 1024);
                        SetSDUsedStorage(Convert.ToString(a));
                    }

                    if (int.TryParse(extStats[3], out temp))
                    {
                        int a = ((temp / 1024) / 1024);
                        SetSDAvailStorage(Convert.ToString(a));
                    }

                    SetSDUsedPercentStorage(extStats[4]);
                }
            }
        }

        public void SetPhoneTotalStorage(string data)
        {
            phoneTotal = data;
        }

        public string GetPhoneTotalStorage()
        {
            return phoneTotal;
        }

        public void SetPhoneUsedStorage(string data)
        {
            phoneUsed = data;
        }

        public string GetPhoneUsedStorage()
        {
            return phoneUsed;
        }

        public void SetPhoneAvailStorage(string data)
        {
            phoneAvail = data;
        }

        public string GetPhoneAvailStorage()
        {
            return phoneAvail;
        }

        public void SetPhoneUsedPercentStorage(string data)
        {
            phonePercent = data;
        }

        public string GetPhoneUsedPercentStorage()
        {
            return phonePercent;
        }


        public void SetSDTotalStorage(string data)
        {
            SdTotal = data;
        }

        public string GetSDTotalStorage()
        {
            return SdTotal;
        }

        public void SetSDUsedStorage(string data)
        {
            SdUsed = data;
        }

        public string GetSDUsedStorage()
        {
            return SdUsed;
        }

        public void SetSDAvailStorage(string data)
        {
            SdAvail = data;
        }

        public string GetSDAvailStorage()
        {
            return SdAvail;
        }

        public void SetSDUsedPercentStorage(string data)
        {
            SdPercent = data;
        }

        public string GetSDUsedPercentStorage()
        {
            return SdPercent;
        }
        public void SetSDSerial(string serial)
        {
            sdSerial = serial;
        }

        public string GetSDSerial()
        {
            return sdSerial;
        }
        public string FirstLetterCapital(string str)
        {
            return Char.ToUpper(str[0]) + str.Remove(0, 1);
        }

        public void SelectPackage(string searchString)
        {
            if (dgv.Rows.Count > 0)
            {
                if (searchString != string.Empty)
                {
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        // 0 is the column index
                        if (row.Cells[2].Value.ToString().Equals(searchString))
                        {
                            row.Selected = true;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("The search string did not find any items in the ListBox that matches " + "\"" + searchString + "\"");
                        }
                    }
                }
            }
        }

        public void SaveAPK(string package)
        {
            string item = package.ToString().Replace("\r", "");

            NewADBCommand(" shell pm path " + item, false, true);

            string path = getOutput();
            path = path.Replace("\r", "");
            string[] finalPath = path.Split(':');
            string save = "";
            if (Directory.Exists(APKSavePath))
            {
                save = APKSavePath;
            }
            else
            {
                Directory.CreateDirectory(APKSavePath);
                save = APKSavePath;
            }

            string finalResult = finalPath[1].Replace("package", "");

            NewADBCommand(" pull " + finalResult + " " + '"' + save + @"\" + package + ".apk" + '"', false, false);
        }

        public void InstallAPK(string file)
        {
            string fileName = Path.GetFileNameWithoutExtension(file);
            NewADBCommand(" install  " + (char)34 + file + (char)34, false, false);

            //NewADBCommand(" shell pm list packages com.ttop.eachelper", false, false);

            string appInstalled = getOutput();
            if (appInstalled.Contains("Success"))
            {
                MessageBox.Show("App Installed: " + fileName, "App Installed", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("App Not Installed: " + fileName, "App Not Installed", MessageBoxButtons.OK);
            }
        }

        public void ReinstallApp(string package)
        {
            NewADBCommand(" shell cmd package install-existing " + package, false, false);

            if (getOutput() != string.Empty)
            {
                MessageBox.Show("App Reinstalled: " + package, "App Installed", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("App Not Installed: " + package, "App Not Installed", MessageBoxButtons.OK);
            }
        }

        public void DisableApp(string package)
        {
            NewADBCommand(" shell pm disable-user --user 0 " + package, false, false);
        }

        public void EnableApp(string package)
        {
            NewADBCommand(" shell pm enable " + package, false, false);
        }

        public void UninstallApp(string package)
        {
            NewADBCommand(" shell pm uninstall -k --user 0 " + package, false, false);
        }

        public void GetApps(DataTable dt)
        {
            dt.Clear();

            if (File.Exists(Temp + "\\apps.txt"))
            {
                File.Delete(Temp + "\\apps.txt");
            }

            if (Directory.Exists(Temp + "\\Images\\Images"))
            {
                Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(Temp + "\\Images\\Images", Microsoft.VisualBasic.FileIO.DeleteDirectoryOption.DeleteAllContents);
            }

            disabled = new ArrayList();

            disabled.Clear();

            if (search.Text != "")
            {
                search.Clear();
            }

            dgv.DataSource = null;
            dgv.Refresh();


            // Get Disabled Apps
            NewADBCommand(" shell pm list packages -d", false, false);

            string disabledPackages = getOutput();
            string disPackages = disabledPackages.Replace("package:", "");
            string[] foundpackages = disPackages.Split('\n');

            foreach (string word in foundpackages)
            {
                if (word.Contains("."))
                {
                    if (word != String.Empty)
                    {
                        disabled.Add(word.Replace("\r", ""));
                    }
                }
            }

            //Get All Apps
            NewADBCommand(" shell pm list packages", false, false);

            tempApps.Clear();

            string fullPackages = getOutput();
            string package = fullPackages.Replace("package:", "");
            string[] words = package.Split('\n');

            foreach (string word in words)
            {
                if (word.Contains("."))
                {
                    if (word != String.Empty)
                    {
                        tempApps.Add(word.Replace("\r", ""));
                    }
                }
            }

            tempApps.Sort();

            string newItem = "";

            foreach (string line in tempApps)
            {
                newItem = line.Replace("\n\r", "");

                if (disabled.Contains(newItem))
                {                 
                    dt.Rows.Add(new object[] { newItem, "Disabled" });

                }
                else
                {               
                    dt.Rows.Add(new object[] { newItem, "Enabled" });

                }

                packagecount.Text = "Packages: " + dt.Rows.Count;
            }

            if (dgv.Rows.Count > 1)
            {
                search.Enabled = true;
            }

            dgv.DataSource = dt;

            dgv.Columns["Package Name"].Width = 575;
            dgv.Columns["Status"].Width = 79;

            dgv.Columns["Package Name"].ReadOnly = true;
            dgv.Columns["Status"].ReadOnly = true;

            dgv.Columns["Package Name"].DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Regular);
            dgv.Columns["Status"].DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Regular);

            dgv.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgv.ColumnHeadersDefaultCellStyle.BackColor;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgv.DefaultCellStyle.ForeColor;

            if (File.Exists(Temp + "\\temp.txt"))
            {
                File.Delete(Temp + "\\temp.txt");
            }
        }

        public void CheckTemp()
        {
            if (!Directory.Exists(Temp))
            {
                Directory.CreateDirectory(Temp);
            }
        }

        public void CreateAppList()
        {
            NewADBCommand(" shell am start -a android.intent.action.MAIN -n com.ttop.eachelper/.MainActivity", false, false);
        }

        public void RefreshDevices()
        {
            refresh.PerformClick();
        }

        public void closeProcess(string process)
        {
            foreach (var processes in Process.GetProcessesByName(process))
            {
                processes.Kill();
            }
        }

        public void CloseAllForms()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "frmMain")
                {
                    Application.OpenForms[i].Close();
                }

                if (Application.OpenForms[i].Name == "frmMain")
                {
                    Application.OpenForms[i].Invalidate();
                    Application.OpenForms[i].Refresh();
                }
            }
        }
    }
}
