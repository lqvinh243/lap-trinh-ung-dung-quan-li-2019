using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.FormQuanTri
{
    public partial class fDanhsachnguoidung : Form
    {
        public int Loai, Fill;
        public int Khoi, Lop;
        public int i = 1, sltoida, page = 7;
        public fDanhsachnguoidung(int g)
        {
            InitializeComponent();
            Loai = g;
            Fill = 0;

            Load += LoadControl;
            Load += LoadData;
        }

        private void LoadData(object sender, EventArgs e)
        {
            this.CenterToParent();
            LoadDanhSach(Khoi, Lop);
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.btnChinhsua.Enabled = false;

            this.btnThoat.Click += BtnThoat_Click;

            this.cbbKhoi.TextChanged += CbbKhoi_TextChanged;
            this.cbbLop.TextChanged += CbbLop_TextChanged;

            this.btnNext.Click += BtnNext_Click;
            this.btnPre.Click += BtnPre_Click;
            this.btnStart.Click += BtnStart_Click;
            this.btnLast.Click += BtnLast_Click;
            this.btnChinhsua.Click += BtnChinhsua_Click;

            dgvDanhsach.CellClick += DgvDanhsach_CellClick;
        }

        private void BtnChinhsua_Click(object sender, EventArgs e)
        {
            if (Loai == 1)
            {
                int idx = dgvDanhsach.SelectedCells[0].RowIndex;
                DataGridViewRow slr = dgvDanhsach.Rows[idx];
                fSuathongtinHs f = new fSuathongtinHs(int.Parse(slr.Cells[0].Value.ToString()));
                f.ShowDialog();
                LoadDanhSach(Khoi, Lop);
            }

            else
            {
                int idx = dgvDanhsach.SelectedCells[0].RowIndex;
                DataGridViewRow slr = dgvDanhsach.Rows[idx];
                fSuathongtinGvQt f = new fSuathongtinGvQt(int.Parse(slr.Cells[0].Value.ToString()),Loai);
                f.ShowDialog();
                LoadDanhSach(Khoi, Lop);
            }
            
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            i = sltoida;
            LoadDanhSach(Khoi, Lop);
            this.btnNext.Enabled = false;
            this.btnLast.Enabled = false;
            this.btnPre.Enabled = true;
            this.btnStart.Enabled = true;
            

            
        }

        private void DgvDanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this.btnChinhsua.Enabled = true;
            }
            else this.btnChinhsua.Enabled = false;
            
        }


        private void BtnStart_Click(object sender, EventArgs e)
        {
            i = 1;
            LoadDanhSach(Khoi, Lop);
            this.btnPre.Enabled = false;
            this.btnStart.Enabled = false;
            this.btnNext.Enabled = true;
            this.btnLast.Enabled = true;
        }

        private void BtnPre_Click(object sender, EventArgs e)
        {
            i--;
            LoadDanhSach(Khoi, Lop);
            if (i == 1)
            {
                this.btnPre.Enabled = false;
                this.btnStart.Enabled = false;
            }
            this.btnNext.Enabled = true;
            this.btnLast.Enabled = true;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            i++;
            LoadDanhSach(Khoi, Lop);
            if (i * page == sltoida)
            {
                this.btnNext.Enabled = false;
                this.btnLast.Enabled = false;
            }
            this.btnPre.Enabled = true;
            this.btnStart.Enabled = true;
        }

        private void CbbLop_TextChanged(object sender, EventArgs e)
        {
            this.btnStart.Enabled = false;
            this.btnPre.Enabled = false;
            i = 1;
            Lop = (int)this.cbbLop.SelectedItem;
            LoadDanhSach(Khoi, Lop);
        }

        private void CbbKhoi_TextChanged(object sender, EventArgs e)
        {
            this.btnStart.Enabled = false;
            this.btnPre.Enabled = false;
            i = 1;
            this.cbbLop.Items.Clear();
            Lop = 0;
            Khoi = (int)this.cbbKhoi.SelectedItem;
            LoadDanhSach(Khoi, Lop);
            this.cbbLop.Enabled = true;
            using (var DB = new QTDataContext())
            {
                var lq = DB.HocSinhs.Where(idx => idx.Khoi == Khoi).Select(idx => idx.Lop);
                lq = lq.Distinct();
                this.cbbLop.Items.Add(0);
                foreach (var vl in lq)
                {
                    this.cbbLop.Items.Add(vl);
                }
            }
            this.cbbLop.SelectedIndex = 0;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadDanhSach(int Khoids, int Lopds)
        {
            using (var DB = new QTDataContext())
            {
                if (Loai == 1)
                {
                    this.lbHeader.Text = "Danh sách học sinh";
                    var linq = DB.NguoiDungs.Join(DB.HocSinhs, a => a.ID, b => b.ID, (a, b) => new { CMND = a.CMND, Hoten = b.Hoten, Khoi = b.Khoi, Lop = b.Lop });
                    if (Khoids != 0)
                    {
                        linq = linq.Where(idx => idx.Khoi == Khoids);
                    }
                    if (Lopds != 0)
                    {
                        linq = linq.Where(idx => idx.Lop == Lopds);
                    }
                    var Khoi = linq.Select(idx => idx.Khoi);

                    sltoida = linq.Count() / page + (linq.Count() % page > 0 ? 1 : 0);
                    if (i == sltoida)
                    {
                        this.btnNext.Enabled = false;
                        this.btnLast.Enabled = false;
                    }
                    else
                    {
                        this.btnLast.Enabled = true;
                        this.btnNext.Enabled = true;
                    }
                    var p = linq.Skip((i - 1) * page).Take(page);
                    this.lbChimuc.Text = (i).ToString() + "/" + sltoida.ToString();
                    this.dgvDanhsach.DataSource = p.ToList();
                    if (Fill == 0)
                    {
                        Khoi = Khoi.Distinct();
                        this.cbbKhoi.Items.Add(0);
                        foreach (var vl in Khoi)
                        {
                            if (!this.cbbKhoi.Items.Contains(vl))
                            {
                                cbbKhoi.Items.Add(vl);
                            }
                        }
                        Fill++;
                    }
                }

                else if (Loai == 2)
                {
                    this.cbbLop.Hide();
                    this.cbbKhoi.Hide();
                    this.lbKhoi.Hide();
                    this.lbLop.Hide();
                    this.lbHeader.Text = "Danh sách giáo viên";
                    var linq = DB.NguoiDungs.Join(DB.GiaoViens, a => a.ID, b => b.ID, (a, b) => new { CMND = a.CMND, Hoten = b.Hoten, Ngaysinh = b.Ngaysinh });
                    sltoida = linq.Count() / page + (linq.Count() % page > 0 ? 1 : 0);
                    if (i == sltoida)
                    {
                        this.btnNext.Enabled = false;
                        this.btnLast.Enabled = false;
                    }
                    else
                    {
                        this.btnLast.Enabled = true;
                        this.btnNext.Enabled = true;
                    }
                    var p = linq.Skip((i - 1) * page).Take(page);
                    this.lbChimuc.Text = (i).ToString() + "/" + sltoida.ToString();
                    this.dgvDanhsach.DataSource = p.ToList();
                }
                else if (Loai == 3)
                {
                    this.cbbLop.Hide();
                    this.cbbKhoi.Hide();
                    this.lbKhoi.Hide();
                    this.lbLop.Hide();
                    this.lbHeader.Text = "Danh sách quản trị";
                    var linq = DB.NguoiDungs.Join(DB.QuanTris, a => a.ID, b => b.ID, (a, b) => new { CMND = a.CMND, Hoten = b.Hoten, Ngaysinh = b.Ngaysinh });
                    sltoida = linq.Count() / page + (linq.Count() % page > 0 ? 1 : 0);
                    if (i == sltoida)
                    {
                        this.btnNext.Enabled = false;
                        this.btnLast.Enabled = false;
                    }
                    else
                    {
                        this.btnLast.Enabled = true;
                        this.btnNext.Enabled = true;
                    }
                    var p = linq.Skip((i - 1) * page).Take(page);
                    this.lbChimuc.Text = (i).ToString() + "/" + sltoida.ToString();
                    this.dgvDanhsach.DataSource = p.ToList();
                }


            }


            dgvDanhsach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDanhsach.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None).AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDanhsach.AllowUserToResizeColumns = false;
            this.dgvDanhsach.AllowUserToResizeRows = false;
        }
    }
}
