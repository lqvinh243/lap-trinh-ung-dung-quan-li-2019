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
    public partial class fmainGiaovien : Form
    {
        public bool isLogout { get; set; }
        public fmainGiaovien()
        {
            InitializeComponent();

            Load += LoadControl;
            Load += LoadData;
        }

        private void LoadData(object sender, EventArgs e)
        {
            
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();

            //Câu hỏi
            this.cmsImportCauhoi.Click += CmsImportCauhoi_Click;
            this.cmsExportcauhoi.Click += CmsExportcauhoi_Click;
            this.cmsXemsuacauhoi.Click += CmsXemsuacauhoi_Click;


            //Kỳthi
            this.cmsXoaSuakythi.Click += CmsXoaSuakythi_Click;
            this.cmsInbangdiem.Click += CmsInbangdiem_Click;
            this.cmsInthongtin.Click += CmsInthongtin_Click;

            //Đóng form
            this.FormClosing += FmainGiaovien_FormClosing;


            //Đăng xuất
            this.btnDangxuat.Click += BtnDangxuat_Click;

            // Kì thi
            this.cmsThemkithi.Click += CmsThemkithi_Click;
            this.cmsXemdanhsachthi.Click += CmsXemdanhsachthi_Click;

            //Đề thi
            this.cmsXoasuadethi.Click += CmsXoasuadethi_Click;
        }

        private void CmsXoasuadethi_Click(object sender, EventArgs e)
        {
            fDanhsachdethi f = new fDanhsachdethi();
            f.ShowDialog();
        }

        private void CmsXemdanhsachthi_Click(object sender, EventArgs e)
        {
            fXemdanhsachthi f = new fXemdanhsachthi();
            f.ShowDialog();
        }

        private void CmsThemkithi_Click(object sender, EventArgs e)
        {
            fThemkythi f = new fThemkythi();
            f.ShowDialog();
        }

        private void CmsXemsuacauhoi_Click(object sender, EventArgs e)
        {
            fThaotaccauhoi f = new fThaotaccauhoi();
            f.ShowDialog();
        }

        private void CmsInthongtin_Click(object sender, EventArgs e)
        {
            using (var DB = new QTDataContext())
            {
                var SlKythi = DB.KyThis.Count();
                if (SlKythi <= 0)
                {
                    MessageBox.Show("Hiện tại chưa có kỳ thi nào nên không thể sử dụng chức năng này!!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            fInDanhsach f = new fInDanhsach(0);
            f.ShowDialog();
        }

        private void CmsInbangdiem_Click(object sender, EventArgs e)
        {
            using (var DB = new QTDataContext())
            {
                var Dembangdiem = DB.KyThis.Where(idx => idx.Ngaythi.Value < DateTime.Now).Count();
                if (Dembangdiem == 0)
                {
                    MessageBox.Show("Hiện tại không có kỳ thi nào đã diễn ra nên không thể sử dụng chức năng này!!","Thông báo",MessageBoxButtons.OK);
                    return;
                }

            }
            fInDanhsach f = new fInDanhsach(1);
            f.ShowDialog();
        }

        private void CmsXoaSuakythi_Click(object sender, EventArgs e)
        {
            fXoaSuakythi f = new fXoaSuakythi();
            f.ShowDialog();
        }

        private void CmsExportcauhoi_Click(object sender, EventArgs e)
        {
            fExportcauhoi f = new fExportcauhoi();
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

        private void FmainGiaovien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isLogout == false)
            {
                CurrentUser.PhanQuyen = -1;
            }
        }

        private void CmsImportCauhoi_Click(object sender, EventArgs e)
        {
            fImportcauhoi f = new fImportcauhoi();
            f.ShowDialog();
        }
    }
}
