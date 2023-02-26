using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ADB_Debloater
{
    public partial class frmSelectPackages : Form
    {
        private bool standard;
        private ArrayList imported = new ArrayList();
        private string Configs = Directory.GetCurrentDirectory() + "\\Config";
        private List<string> selectedPackage;
        private ListBox std = Application.OpenForms["frmOptions"].Controls.Find("lstStandard", true)[0] as ListBox;
        private ListBox sw = Application.OpenForms["frmOptions"].Controls.Find("lstSWUpdate", true)[0] as ListBox;
        private clsFunctions functions;

        public frmSelectPackages(bool standard)
        {
            InitializeComponent();

            this.standard = standard;
        }

        private void frmSelectPackages_Load(object sender, EventArgs e)
        {
            functions = new clsFunctions();

            OpenFileDialog ofd = new OpenFileDialog()
            {
                InitialDirectory = Environment.SpecialFolder.DesktopDirectory.ToString(),
                Title = "Open .acfg",
                DefaultExt = "acfg",
                Filter = "acfg files (*.acfg)|*.acfg",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string line in File.ReadLines(ofd.FileName, Encoding.UTF8))
                {
                    if (line != "")
                    {
                        if (!imported.Contains(line))
                        {
                            imported.Add(line);
                            imported.Sort();
                        }
                    }
                }

                foreach (string item in imported)
                {
                    lstPackages.Items.Add(item);
                }
            }

            ArrayList controls = new ArrayList();
            controls.Add(btnSelect);
            controls.Add(lstPackages);

            functions.SetTheme(this, controls);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Configs))
            {
                Directory.CreateDirectory(Configs);
            }

            string sPath = "";
            selectedPackage = new List<string>();
            if (standard)
            {
                sPath = Configs + @"\" + "Standard.packageConfig";
            }
            else
            {
                sPath = Configs + @"\" + "SoftUpd.packageConfig";
            }

            for (int i = 0; i < lstPackages.SelectedItems.Count; i++)
            {
                selectedPackage.Add(lstPackages.SelectedItems[i].ToString());
            }

            using (StreamWriter SaveFile = new StreamWriter(sPath, append: true))
            {
                foreach (var item in selectedPackage)
                {
                    SaveFile.WriteLine(item.ToString());
                }
            }

            GetPackages();

            this.Close();
        }

        public void GetPackages()
        {
            std.Items.Clear();
            sw.Items.Clear();

            if (File.Exists(Configs + @"\" + "Standard.packageConfig"))
            {
                string[] lines = File.ReadAllLines(Configs + @"\" + "Standard.packageConfig");
                foreach (var line in lines)
                {
                    if (line != "")
                    {
                        std.Items.Add(line);
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
                        sw.Items.Add(line);
                    }
                }
            }
        }
    }
}