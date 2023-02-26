using ADB_Debloater;
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
    public partial class frmStorage : Form
    {
        public frmStorage()
        {
            InitializeComponent();
        }
        private clsFunctions functions;
        private void frmStorage_Load(object sender, EventArgs e)
        {
            functions = new clsFunctions();
            functions.GetStorage("Phone");
            functions.GetStorage("SD");

            for (int i =0; i < 2; i++)
            {
                dgvStorage.Rows.Add();
            }

           dgvStorage.DefaultCellStyle.Font = new Font("Segoe UI", 12);

            dgvStorage.Rows[0].HeaderCell.Value = "Phone";
            
            if (Properties.Settings.Default.SdSerial != "")
            {
                dgvStorage.Rows[1].HeaderCell.Value = "SD Card (" + Properties.Settings.Default.SdSerial + ")";
            }
            else
            {
                dgvStorage.Rows[1].HeaderCell.Value = "SD Card (N/A)";
            }
           

            dgvStorage.Rows[0].Cells[0].Value = functions.GetPhoneTotalStorage() + " GB";
            dgvStorage.Rows[0].Cells[1].Value = functions.GetPhoneUsedStorage() + " GB";
            dgvStorage.Rows[0].Cells[2].Value = functions.GetPhoneAvailStorage() + " GB";
            dgvStorage.Rows[0].Cells[3].Value = functions.GetPhoneUsedPercentStorage();

            if (functions.GetSDTotalStorage() != "")
            {
                dgvStorage.Rows[1].Cells[0].Value = functions.GetSDTotalStorage() + " GB";
                
            }
            else
            {
                dgvStorage.Rows[1].Cells[0].Value = "N/A";
            }

            if (functions.GetSDUsedStorage() != "")
            {
                dgvStorage.Rows[1].Cells[1].Value = functions.GetSDUsedStorage() + " GB";
               
            }
            else
            {
                dgvStorage.Rows[1].Cells[1].Value = "N/A";
            }

            if (functions.GetSDAvailStorage() != "")
            {
                dgvStorage.Rows[1].Cells[2].Value = functions.GetSDAvailStorage() + " GB";
               
            }
            else
            {
                dgvStorage.Rows[1].Cells[2].Value = "N/A";
            }

            if (functions.GetSDUsedPercentStorage() != "")
            {
                dgvStorage.Rows[1].Cells[3].Value = functions.GetSDUsedPercentStorage();
            }
            else
            {
                dgvStorage.Rows[1].Cells[3].Value = "N/A";
            }


            ArrayList controls = new ArrayList();
            controls.Add(dgvStorage);
            functions.SetTheme(this, controls);
        }

        private void dgvStorage_SelectionChanged(object sender, EventArgs e)
        {
            dgvStorage.ClearSelection();
        }

        private void dgvStorage_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintCells(e.ClipBounds, DataGridViewPaintParts.All);



            e.PaintHeader(DataGridViewPaintParts.Background

                | DataGridViewPaintParts.Border

                | DataGridViewPaintParts.Focus

                | DataGridViewPaintParts.SelectionBackground

                | DataGridViewPaintParts.ContentForeground);



            e.Handled = true;
        }
    }
}
