using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace ADB_Debloater
{
    public partial class frmListConfirm : Form
    {
        ArrayList edited;
        ArrayList result;
        String DevName;
        public frmListConfirm(ArrayList list, String DeviceName)
        {
            InitializeComponent();
            edited = new ArrayList(list);
            DevName = DeviceName;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (dgvApps.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Confirm Removal of " + dgvApps.CurrentCell.Value, "Confirm Package Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvApps.Rows.RemoveAt(dgvApps.CurrentCell.RowIndex);
                    result.RemoveAt(dgvApps.CurrentCell.RowIndex);
                }
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            StreamReader ReadFile;
            StreamWriter SaveFile;

            SaveFileDialog sfdExport = new SaveFileDialog();

            sfdExport.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            sfdExport.Title = "Save Config File";
            sfdExport.CheckFileExists = false;
            sfdExport.CheckPathExists = true;
            sfdExport.DefaultExt = "acfg";
            sfdExport.Filter = "ADB Config Files (*.acfg)|*.acfg";
            sfdExport.FilterIndex = 2;
            sfdExport.RestoreDirectory = false;
            sfdExport.FileName = DevName;

            if (sfdExport.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfdExport.FileName))
                {
                    foreach (var line in edited)
                    {
                        ReadFile = new StreamReader(sfdExport.FileName);
                        string contents = ReadFile.ReadToEnd();
                        ReadFile.Close();

                        SaveFile = new StreamWriter(sfdExport.FileName, append: true);
                        if (!contents.Contains(line.ToString()))
                        {
                            SaveFile.WriteLine(line);
                        }
                        SaveFile.Close();
                    }
                }
                else
                {
                    SaveFile = new StreamWriter(sfdExport.FileName);
                    foreach (var line in edited)
                    {
                        SaveFile.WriteLine(line);
                    }
                    SaveFile.Close();
                }

                Hide();

                frmCreateScript createScript = new frmCreateScript(sfdExport.FileName, Path.GetDirectoryName(sfdExport.FileName));
                createScript.ShowDialog();

                Close();
            }
        }

        private void FrmListConfirm_Load(object sender, EventArgs e)
        {
            result = new ArrayList();

            foreach (string pkg in edited)
            {
                if (!result.Contains(pkg))
                {
                    result.Add(pkg);
                }
            }

            for (int i = 0; i < result.Count; i++)
            {
                dgvApps.Rows.Add(new object[] { result[i].ToString() });
                dgvApps.ClearSelection();
            }

            ArrayList controls = new ArrayList();
            controls.Add(btnConfirm);
            controls.Add(btnRemove);
            controls.Add(dgvApps);
            clsFunctions functions = new clsFunctions();
            functions.SetTheme(this, controls);
        }

        private void FrmListConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            result.Clear();
        }
    }
}
