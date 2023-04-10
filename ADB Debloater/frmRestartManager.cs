using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace ADB_Debloater
{
    public partial class frmRestartManager : Form
    {
        private clsFunctions functions;
        private string serial = "";

        public frmRestartManager()
        {
            InitializeComponent();
        }

        private void mtReboot_Click(object sender, EventArgs e)
        {
            functions.NewADBCommand(" reboot", false, true);
            functions.CloseAllForms();
        }

        private void mtRebootRecovery_Click(object sender, EventArgs e)
        {
            functions.NewADBCommand(" reboot recovery", false, true);
            functions.CloseAllForms();
        }

        private void frmRestartManager_Load(object sender, EventArgs e)
        {
            functions = new clsFunctions();

            functions.SetSerial(GetSerial());

            functions.NewADBCommand(" shell getprop ro.product.manufacturer", false, false);

            if (functions.getOutput().Contains("samsung"))
            {
                mtRebootDownload.Visible = true;
                mtRebootRecovery.Location = new Point(55, 123);
                mtReboot.Location = new Point(55, 27);
            }
            else
            {
                mtRebootDownload.Visible = false;
                mtRebootRecovery.Location = new Point(74, 190);
                mtReboot.Location = new Point(74, 56);
            }

            ArrayList controls = new ArrayList();
            controls.Add(mtReboot);
            controls.Add(mtRebootDownload);
            controls.Add(mtRebootRecovery);

            functions.SetTheme(this, controls);

            ArrayList ctrls = new ArrayList
            { 
                Controls 
            };

            functions.setFont(this, Properties.Settings.Default.FontIndex, ctrls, null);
        }

        public void SetSerial(string serial)
        {
            this.serial = serial;
        }

        public string GetSerial()
        {
            return serial;
        }

        private void mtRebootDownload_Click(object sender, EventArgs e)
        {
            functions.NewADBCommand(" reboot bootloader", false, true);
            functions.CloseAllForms();
        }
    }
}