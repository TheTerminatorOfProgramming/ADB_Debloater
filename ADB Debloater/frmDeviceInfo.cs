using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADB_Debloater
{
    public partial class frmDeviceInfo : Form
    {
        clsFunctions functions;
        string device;
        public frmDeviceInfo(string device)
        {
            InitializeComponent();
            this.device = device;
        }

        private void FrmDeviceInfo_Load(object sender, EventArgs e)
        {
            functions = new clsFunctions();
            ArrayList controls = new ArrayList();

            controls.Add(btnStorageDets);
            controls.Add(gpbDeviceCP);
            controls.Add(lblAndroidVer);
            controls.Add(lblAndroidVersionDetails);
            controls.Add(lblDevice);
            controls.Add(lblDeviceRegion);
            controls.Add(lblDeviceRgn);
            controls.Add(lblFirmwareVer);
            controls.Add(lblFirmwareVersionDetails);
            controls.Add(lblIp);
            controls.Add(lblIpAddress);
            controls.Add(lblPower);
            controls.Add(lblPowerLvl);
            controls.Add(lblSdCard);
            controls.Add(lblSdCardNo);
            controls.Add(lblSerial);
            controls.Add(lblSerialNo);
            controls.Add(lblWifi);
            controls.Add(lblWifiStatus);

            functions.SetTheme(this, controls);
            GetDeviceInfo(Properties.Settings.Default.Serial);
        }

        private void BtnStorageDets_Click(object sender, EventArgs e)
        {
            frmStorage storage = new frmStorage();
            storage.ShowDialog();
        }

        public void GetDeviceInfo(string serial)
        {
            functions.SetSerial(serial);

            lblDevice.Text += " " + device; 

            //Get Serial Number
            functions.NewADBCommand(" shell getprop ro.serialno", false, true);

            lblSerialNo.Text = functions.getOutput();

            //Get SD Card
            functions.NewADBCommand(" shell ls /storage/", false, true);

            string adbItem = functions.getOutput();

            if (adbItem != null)
            {
                if (adbItem.Contains("-"))
                {
                    functions.SetSDSerial(adbItem);
                    Properties.Settings.Default.SdSerial = adbItem;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    functions.SetSDSerial("");
                    Properties.Settings.Default.SdSerial = "";
                    Properties.Settings.Default.Save();
                }
            }

            //Get Storage Space
            if (functions.GetSimpleStorage() != "")
            {
                lblSdCardNo.Text = functions.GetSimpleStorage();
            }
            else
            {
                lblSdCardNo.Text = "N/A";
            }
            
            //Power Level
            functions.NewADBCommand(" shell dumpsys battery | grep level", false, true);

            string pwr = functions.getOutput();
            string[] finalpwr = pwr.Split(null);
            lblPower.Text = finalpwr[3] + "%";
            
            //Device Region
            functions.NewADBCommand(" shell getprop ro.csc.sales_code", false, true);

            string region = functions.getOutput();

            functions.NewADBCommand(" shell getprop ro.csc.country_code", false, true);

            region += " - " + functions.getOutput();

            lblDeviceRgn.Text = region;

            //Android Version
            functions.NewADBCommand(" shell getprop ro.build.version.release", false, true);

            string AndVer = "Android " + functions.getOutput();

            functions.NewADBCommand(" shell getprop ro.build.version.sdk", false, true);

            AndVer += " - API Level " + functions.getOutput();

            lblAndroidVersionDetails.Text = AndVer;

            //Firmware Version
            functions.NewADBCommand(" shell getprop ro.vendor.build.version.incremental", false, true);

            lblFirmwareVersionDetails.Text = functions.getOutput();
            
            //Wifi
            functions.NewADBCommand(" shell dumpsys wifi | grep 'Wi-Fi is'", false, true);

            string wifiStatus = functions.getOutput();

            if (wifiStatus != "")
            {
                wifiStatus = wifiStatus.Substring(9);

                lblWifiStatus.Text = functions.FirstLetterCapital(wifiStatus);
            }
            else
            {
                lblWifiStatus.Text = "Error";
            }

            //IP Address
            if (lblWifiStatus.Text == "Disabled")
            {
                lblIpAddress.Text = "N\\A";
            }
            else
            {
                functions.NewADBCommand(" shell ip addr show wlan0 | grep 'inet ' | cut -d' ' -f6|cut -d/ -f1", false, true);
                lblIpAddress.Text = functions.getOutput();
            }
        }

        private void MtShutdown_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Power Off The Selected Device: " + device, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                functions.NewADBCommand(" shell reboot -p", false, true);
                functions.CloseAllForms();
            }
        }

        private void MtReboot_Click(object sender, EventArgs e)
        {
                frmRestartManager restart = new frmRestartManager();
                restart.SetSerial(functions.GetSerial());
                restart.ShowDialog();
        }
    }
}
