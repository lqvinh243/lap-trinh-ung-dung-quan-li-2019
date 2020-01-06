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
    public partial class fmainHocsinh : Form
    {
        public bool isLogout { get; set; }
        public fmainHocsinh()
        {
            InitializeComponent();

            Load += LoadControl;
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();

            this.FormClosing += FmainHocsinh_FormClosing;
            this.btnDangxuat.Click += BtnDangxuat_Click;

            //Thông tin
            this.mnsXemthongtin.Click += MnsXemthongtin_Click;
            this.mnsSuathongtin.Click += MnsSuathongtin_Click;

            //Kỳ thi
            this.mnsLichthi.Click += MnsLichthi_Click;
            this.mnsKetquathi.Click += MnsKetquathi_Click;
            this.mnsLambaithi.Click += MnsLambaithi_Click;


            //Ôn luyện
            this.mnsLamonluyen.Click += MnsLamonluyen_Click;
            this.mnsKetquaonluyen.Click += MnsKetquaonluyen_Click;

            //Report view
            this.cmsInbangdiem.Click += CmsInbangdiem_Click;
          
        }

        private void CmsInbangdiem_Click(object sender, EventArgs e)
        {
            using(var DB = new QTDataContext())
            {
                var check = DB.CT_ThamGias.Where(idx => idx.IDHocsinh == CurrentUser.UserID && idx.Diem != null);
                if (check.Count() <= 0)
                {
                    MessageBox.Show("Chưa có kỳ thi nào diễn ra nên không thể sử dụng chức năng này!!");
                    return;
                }
            }
            fBangdiem f = new fBangdiem();
            f.ShowDialog();
        }

        private void MnsLambaithi_Click(object sender, EventArgs e)
        {
            fThi f = new fThi();
            f.ShowDialog();
        }

        private void MnsKetquaonluyen_Click(object sender, EventArgs e)
        {
            fKetquaOnluyen f = new fKetquaOnluyen();
            f.ShowDialog();
        }

        private void MnsLamonluyen_Click(object sender, EventArgs e)
        {
            fOnluyen f = new fOnluyen();
            f.ShowDialog();
        }


        private void MnsKetquathi_Click(object sender, EventArgs e)
        {
            fKetquathi f = new fKetquathi();
            f.ShowDialog();
        }

        private void MnsLichthi_Click(object sender, EventArgs e)
        {
            fLichthi f = new fLichthi();
            f.ShowDialog();
        }

        private void MnsSuathongtin_Click(object sender, EventArgs e)
        {
            fThongtin f = new fThongtin(0);
            f.ShowDialog();
        }

        private void MnsXemthongtin_Click(object sender, EventArgs e)
        {
            fThongtin f = new fThongtin(1);
            f.ShowDialog();
        }

        private void BtnDangxuat_Click(object sender, EventArgs e)
        {
            isLogout = true;
            CurrentUser.UserID = -1;
            CurrentUser.CMND = string.Empty;
            CurrentUser.TaiKhoan = string.Empty;
            CurrentUser.PhanQuyen = 0;
            this.Hide();
            fDangnhap dg = new fDangnhap();
            dg.Closed += (s, arg) => this.Close();
            dg.Show();
        }

        private void FmainHocsinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLogout == false)
            {
                CurrentUser.PhanQuyen = -1;
            }
        }
    }
}
