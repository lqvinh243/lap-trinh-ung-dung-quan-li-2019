using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.FormGiaoVien
{
    public partial class fExportcauhoi : Form
    {
        QTDataContext DB = new QTDataContext();
        public bool Fill = false;
        public fExportcauhoi()
        {
            InitializeComponent();

            Load += LoadControl;
            Load += LoadData;
        }

        private void LoadData(object sender, EventArgs e)
        {
            this.Text = "Export Cau hoi";
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.btnThoat.Click += BtnThoat_Click;
            this.btnLoad.Click += BtnLoad_Click;
            this.FormClosing += FExportcauhoi_FormClosing;

            this.btnThucthi.Click += BtnThucthi_Click;

            this.dgvCauhoi.DataBindingComplete += DgvCauhoi_DataBindingComplete;
        }

        private void DgvCauhoi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Fill = true;
        }

        private void BtnThucthi_Click(object sender, EventArgs e)
        {
            if (Fill == false)
            {
                MessageBox.Show("Vui lòng chọn file cần xuất!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "ExportCauhoi";
            for (int i = 1; i < dgvCauhoi.Columns.Count + 1; i++)
            {
                worksheet.Cells[1,i] = dgvCauhoi.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgvCauhoi.Rows.Count; i++)
            {
                for (int j = 0; j < dgvCauhoi.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvCauhoi.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFiledialoge = new SaveFileDialog();
            saveFiledialoge.FileName = "output";
            saveFiledialoge.DefaultExt = ".xlsx";
            if (saveFiledialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFiledialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }

            app.Quit();
            
        }

        private void FExportcauhoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Dispose();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            var gg = DB.CauHois.Select(idx => new { idx.Khoi, idx.Mota, idx.ID,idx.Dokho }).OrderBy(idx => idx.Khoi); ;
            var p = gg.Select(idx => new { idx.Khoi, idx.Mota,idx.Dokho }).ToList();
            dgvCauhoi.DataSource = p;
            dgvCauhoi.Columns.Add("", "A");
            dgvCauhoi.Columns.Add("", "B");
            dgvCauhoi.Columns.Add("", "C");
            dgvCauhoi.Columns.Add("", "D");
            dgvCauhoi.Columns.Add("", "E");
            dgvCauhoi.Columns.Add("", "Tinh A");
            dgvCauhoi.Columns.Add("", "Tinh B");
            dgvCauhoi.Columns.Add("", "Tinh C");
            dgvCauhoi.Columns.Add("", "Tinh D");
            dgvCauhoi.Columns.Add("", "Tinh E");
            int i = 0;
            foreach (var vl in gg)
            {
                var ListDa = DB.CT_CauHois.Where(idx => idx.IDCauhoi == vl.ID && idx.Khoi == vl.Khoi);
                foreach (var da in ListDa)
                {
                    if (da.IDdapan == "A ")
                    {
                        dgvCauhoi.Rows[i].Cells[3].Value = da.Mota.ToString();
                        dgvCauhoi.Rows[i].Cells[8].Value = da.Dung == false ? 0 : 1;
                    }
                    else if (da.IDdapan == "B ")
                    {
                        dgvCauhoi.Rows[i].Cells[4].Value = da.Mota.ToString();
                        dgvCauhoi.Rows[i].Cells[9].Value = da.Dung == false ? 0 : 1;
                    }
                    else if (da.IDdapan == "C ")
                    {
                        dgvCauhoi.Rows[i].Cells[5].Value = da.Mota.ToString();
                        dgvCauhoi.Rows[i].Cells[10].Value = da.Dung == false ? 0 : 1;

                    }
                    else if (da.IDdapan == "D ")
                    {
                        dgvCauhoi.Rows[i].Cells[6].Value = da.Mota.ToString();
                        dgvCauhoi.Rows[i].Cells[11].Value = da.Dung == false ? 0 : 1;
                    }
                    else if (da.IDdapan == "E ")
                    {
                        dgvCauhoi.Rows[i].Cells[7].Value = da.Mota.ToString();
                        dgvCauhoi.Rows[i].Cells[12].Value = da.Dung == false ? 0 : 1;
                    }
                }
                i++;
            }


        }



        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
