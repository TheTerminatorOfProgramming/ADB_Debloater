using JR.Utils.GUI.Forms;
using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace ADB_Debloater
{
    public partial class frmConnectWirelessDebug : Form
    {
        private string ConnectBat = Directory.GetCurrentDirectory() + "\\tools\\scripts\\ADBDebug Connect.bat";
        private string PairBat = Directory.GetCurrentDirectory() + "\\tools\\scripts\\ADBDebug Pair.bat";
        private string cmd = "C:\\Windows\\System32\\cmd.exe";
        private string serial = "";
        private ArrayList devices;
        private clsFunctions functions;

        public frmConnectWirelessDebug(string ip, ArrayList serials, string serial)
        {
            InitializeComponent();
            txtIP.Text = ip;
            txtIP.Enabled = false;
            this.serial = serial;
            devices = serials;
        }

        public frmConnectWirelessDebug()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string connectString = txtIP.Text + ":" + txtPort.Text;
            string pairingcode = txtPairingCode.Text;
            
            if (functions.IsValidateIP(txtIP.Text))
            {
                if (chkPair.Checked)
                {
                    functions.NewPairCommand(" pair " + connectString + " " + pairingcode);
                    chkPair.Checked = false;

                    txtPairingCode.Clear();
                    txtPort.Clear();

                    Properties.Settings.Default.WirelessConnected = true;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    functions.NewPairCommand(" connect " + connectString);

                    if (serial != "" && devices.Contains(serial))
                    {
                        FlexibleMessageBox.FONT = functions.setMessageBoxFont(Properties.Settings.Default.FontIndex);
                        FlexibleMessageBox.Show("Remove Device from USB Cable!");
                        Properties.Settings.Default.WirelessConnected = true;
                        Properties.Settings.Default.Save();
                        this.Close();
                    }
                }
            }
        }

        private void chkPair_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPair.Checked)
            {
                txtPairingCode.Enabled = true;
                btnConnect.Text = "Pair";
            }

            if (!chkPair.Checked)
            {
                txtPairingCode.Enabled = false;
                btnConnect.Text = "Connect";
            }
        }

        private void frmConnectWirelessDebug_Load(object sender, EventArgs e)
        {
            functions = new clsFunctions();

            if (txtIP.Text == "")
            {
                chkManual.Enabled = false;
            }

            ArrayList controls = new ArrayList();
            controls.Add(lblIP);
            controls.Add(lblPair);
            controls.Add(lblPort);
            controls.Add(chkManual);
            controls.Add(chkPair);
            controls.Add(txtIP);
            controls.Add(txtPairingCode);
            controls.Add(txtPort);
            controls.Add(btnConnect);
            functions.SetTheme(this, controls);

            ArrayList ctrls = new ArrayList
            {
                Controls
            };

            functions.setFont(this, Properties.Settings.Default.FontIndex, ctrls, null);
        }

        private void frmConnectWirelessDebug_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Properties.Settings.Default.WirelessConnected == true)
            {
                Properties.Settings.Default.WirelessConnected = false;
                Properties.Settings.Default.Save();
                functions.RefreshDevices();
            }    
        }

        private void ChkManual_CheckedChanged(object sender, EventArgs e)
        {
            if (chkManual.Checked == true)
            {
                txtIP.Enabled = true;
            }
            else
            {
                txtIP.Enabled = false;
            }
        }
    }
}