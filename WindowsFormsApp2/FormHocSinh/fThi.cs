using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.FormHocSinh
{
    public partial class fThi : Form
    {
        public int i = 0, slDetoida, Khoi, Thoigian;
        public bool Chon = false;
        public fThi()
        {
            InitializeComponent();

            Load += LoadControl;

            Load += LoadData;
        }

        private void LoadData(object sender, EventArgs e)
        {
            this.txtNgaythi.Text = DateTime.Now.ToShortDateString();
            this.txtMathisinh.Text = CurrentUser.UserID.ToString();

            LoadKyThi();    
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.btnThoat.Click += BtnThoat_Click;
            this.btnNext.Click += BtnNext_Click;
            this.btnPre.Click += BtnPre_Click;
            this.btnBatdau.Click += BtnBatdau_Click;

            this.cbbKythi.SelectedIndexChanged += CbbKythi_SelectedIndexChanged; ;

            this.txtMade.Enabled = false;
            this.txtMathisinh.Enabled = false;
            this.txtNgaythi.Enabled = false;
        }

        private void CbbKythi_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = 0;
            this.btnPre.Enabled = false;
            LoadMaDe(i, (int)this.cbbKythi.SelectedItem);
            Chon = true;
        }

        private void BtnBatdau_Click(object sender, EventArgs e)
        {
            if (Chon == false)
            {
                MessageBox.Show("Vui lòng chọn kỳ thi để thi!");
                return;
            }
            if (MessageBox.Show("Bạn đã sẵn sàng để bắt đầu kỳ thi?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var DB = new QTDataContext())
                {
                    var cttg = DB.CT_ThamGias.Where(idx => idx.IDHocsinh == CurrentUser.UserID && idx.IDKythi == (int)this.cbbKythi.SelectedItem && idx.Khoikythi == Khoi && idx.IDMade == int.Parse(this.txtMade.Text) && idx.Khoidethi == Khoi).SingleOrDefault();
                    Thoigian = DB.KyThis.Where(idx => idx.ID == (int)this.cbbKythi.SelectedItem && idx.Khoi == Khoi).Select(idx => idx.Gioihanthoigian).FirstOrDefault();
                    fCTKythi f = new fCTKythi(cttg,Thoigian);
                    
                    f.ShowDialog();
                    this.Close();
                }
            }
        }

        private void BtnPre_Click(object sender, EventArgs e)
        {
            i--;
            if (i == 0)
            {
                this.btnPre.Enabled = false;
            }
            LoadMaDe(i, (int)this.cbbKythi.SelectedItem);
            this.btnNext.Enabled = true;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            i++;
            if (i == slDetoida)
            {
                this.btnNext.Enabled = false;
            }
            LoadMaDe(i, (int)this.cbbKythi.SelectedItem);
            this.btnPre.Enabled = true;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadMaDe(int i, int IDkythi)
        {
            using (var DB = new QTDataContext())
            {
                var p = DB.CT_ThamGias.Where(a => a.IDHocsinh == CurrentUser.UserID && a.Diem == null && a.CT_KyThi.KyThi.Ngaythi == DateTime.Now).Select(idx => idx.CT_KyThi).Where(idx => idx.IDKythi == IDkythi);
                slDetoida = p.Count() - 1;
                if (slDetoida == i)
                {
                    this.btnNext.Enabled = false;
                }
                else this.btnNext.Enabled = true;
                var Made = p.Skip(i).Take(1).FirstOrDefault();
                this.txtMade.Text = Made.IDMade.ToString();
                Khoi = Made.Khoidethi;
            }
        }

        public void LoadKyThi()
        {
            using (var DB = new QTDataContext())
            {
                var p = DB.CT_ThamGias.Where(a => a.IDHocsinh == CurrentUser.UserID && a.Diem == null && a.CT_KyThi.KyThi.Ngaythi == DateTime.Now).Select(idx => idx.CT_KyThi);
                var IDKythi = p.Select(idx => idx.IDKythi).Distinct();
                if (IDKythi.Count() == 0)
                {
                    MessageBox.Show("Không có kỳ thi nào trong ngày này!!");
                    this.Close();
                }
                foreach (var vl in IDKythi)
                {
                    cbbKythi.Items.Add(vl);
                }
            }
        }
    }
}
