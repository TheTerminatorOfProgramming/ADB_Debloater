using ADB_Debloater;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADB_Debloater
{
    partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            clsFunctions functions = new clsFunctions();

            lblProductName.Text = functions.GetName();
            lblVersion.Text = functions.GetVersion();
            lblCopyright.Text = functions.GetCopyright();
            lblCompanyName.Text = functions.GetCompanyName();
            txtDescription.Text = functions.GetDesc();
            pbLogo.Image = functions.GetIcon().ToBitmap();

            ArrayList controls = new ArrayList();
            controls.Add(lblProductName);
            controls.Add(lblVersion);
            controls.Add(lblCopyright);
            controls.Add(lblCompanyName);
            controls.Add(txtDescription);

            functions.SetTheme(this, controls);
        }
    }
}
