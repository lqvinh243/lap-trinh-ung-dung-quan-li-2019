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
        public string Pathfile = string.Empty;
        QTDataContext DB = new QTDataContext();
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
            this.btnLuufile.Click += BtnLuufile_Click;
            this.btnLoad.Click += BtnLoad_Click;

            this.txtLuufile.TextChanged += TxtLuufile_TextChanged;
            this.FormClosing += FExportcauhoi_FormClosing;
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

        private void TxtLuufile_TextChanged(object sender, EventArgs e)
        {
            if (txtLuufile.TextLength > 0)
            {
                this.btnThucthi.Enabled = true;
                Pathfile = this.txtLuufile.Text;
                return;
            }
            this.btnThucthi.Enabled = false;
            Pathfile = string.Empty;
        }

        private void BtnLuufile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();

            ofd.ShowNewFolderButton = true;
            DialogResult dl = ofd.ShowDialog();
            if (dl == DialogResult.OK)
            {
                this.txtLuufile.Text = ofd.SelectedPath;
                Environment.SpecialFolder root = ofd.RootFolder;
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
