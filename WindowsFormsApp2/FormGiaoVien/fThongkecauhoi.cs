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
    public partial class fThongkecauhoi : Form
    {
        QTDataContext DB = new QTDataContext();
        public fThongkecauhoi()
        {
            InitializeComponent();

            Load += LoadData;
            Load += LoadControl;
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.btnThoat.Click += BtnThoat_Click;
            this.btnXem.Click += BtnXem_Click;
            this.FormClosing += FThongkecauhoi_FormClosing;
        }

        private void FThongkecauhoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Dispose();
        }

        private void BtnXem_Click(object sender, EventArgs e)
        {
            int Khoi = int.Parse(this.cbbKhoi.SelectedItem.ToString());
            int Dokho = this.cbbDokho.SelectedIndex;
            this.dgvCauhoi.DataSource = "";
            this.dgvCauhoi.Columns.Clear();
            IQueryable<CauHoi> Listch;
            if (Dokho == 0)
            {
                Listch = DB.CauHois.Where(idx => idx.Khoi == Khoi);
            }
            else
            {
                Listch = DB.CauHois.Where(idx => idx.Khoi == Khoi && idx.Dokho == Dokho);
            }
            if (Listch.Count() <= 0)
            {
                MessageBox.Show("Không có câu hỏi nào trong tùy chọn!");
                return;
            }
            if (Dokho == 0)
            {
                var Listloc = Listch.Select(idx => new { ID = idx.ID, Mota = idx.Mota, IDNguoitao = idx.IDNguoitao });
                this.dgvCauhoi.DataSource = Listloc;
                this.dgvCauhoi.Columns.Add("", "Độ khó");
                int i = 0;
                dgvCauhoi.Columns.Add("", "");
                foreach (var vl in Listch)
                {
                    if (vl.Dokho == 1)
                    {
                        dgvCauhoi.Rows[i].Cells[3].Value = "Dễ";
                    }
                    else if (vl.Dokho == 2)
                    {
                        dgvCauhoi.Rows[i].Cells[3].Value = "Trung bình";
                    }
                    else if (vl.Dokho == 3)
                    {
                        dgvCauhoi.Rows[i].Cells[3].Value = "Khó";

                    }
                    else if (vl.Dokho == 4)
                    {
                        dgvCauhoi.Rows[i].Cells[3].Value = "Rất khó";
                    }
                    i++;
                }
            }
            else
            {
                var Listloc = Listch.Select(idx => new { ID = idx.ID, Mota = idx.Mota, IDNguoitao = idx.IDNguoitao });
                this.dgvCauhoi.DataSource = Listloc;
            }
            dgvCauhoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCauhoi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCauhoi.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None).AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadKhoi()
        {
            this.cbbKhoi.Items.Add(10);
            this.cbbKhoi.Items.Add(11);
            this.cbbKhoi.Items.Add(12);
            this.cbbKhoi.SelectedIndex = 0;
        }

        public void LoadDokho()
        {
            this.cbbDokho.Items.Add("Không có");
            this.cbbDokho.Items.Add("Dễ");
            this.cbbDokho.Items.Add("Trung bình");
            this.cbbDokho.Items.Add("Khó");
            this.cbbDokho.Items.Add("Rất khó");
            this.cbbDokho.SelectedIndex = 0;
        }
        private void LoadData(object sender, EventArgs e)
        {
            LoadKhoi();
            LoadDokho();
        }
    }
}
