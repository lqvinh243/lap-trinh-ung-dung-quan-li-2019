using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.FormQuanTri.DB;

namespace WindowsFormsApp2.FormQuanTri
{
    public partial class fmainQuantri : Form
    {
        public bool isLogout { get; set; }
        public fmainQuantri()
        {
            InitializeComponent();

            Load += LoadControl;
            Load += LoadData;
        }

        private void LoadData(object sender, EventArgs e)
        {
            this.Text = "Chào mừng quản trị viên!";
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.FormClosing += FmainQuantri_FormClosing;
            this.btnDangxuat.Click += BtnDangxuat_Click;


            //Học sinh
            this.cmsImportHs.Click += CmsImportHs_Click;
            this.cmsXemdanhsachHs.Click += CmsXemdanhsachHs_Click;
            this.cmsThemHs.Click += CmsThemHs_Click;
            this.cmsExportHs.Click += CmsExport_Click;

            //Giáo viên
            this.cmsExportGiaovien.Click += CmsExportGiaovien_Click;
            this.cmsXemdanhsachgv.Click += CmsXemdanhsachgv_Click;
            this.cmsImportGv.Click += CmsImportGv_Click;
            this.cmsThemgiaovien.Click += CmsThemgiaovien_Click;


            //Tất cả
            this.cmsExportAll.Click += CmsExportAll_Click;
            this.cmsImportAll.Click += CmsImportAll_Click;

            //DB
            this.cmsBackupDB.Click += CmsBackupDB_Click;
            this.cmsRestoreDB.Click += CmsRestoreDB_Click;

            //Quản trik
            this.cmsXemdanhsachQt.Click += CmsXemdanhsachQt_Click;
            this.cmsThemquantri.Click += CmsThemquantri_Click;
        }

        private void CmsThemquantri_Click(object sender, EventArgs e)
        {
            fThemGvQt f = new fThemGvQt(3);
            f.ShowDialog();
        }

        private void CmsXemdanhsachQt_Click(object sender, EventArgs e)
        {
            using (var DB = new QTDataContext())
            {
                var check = DB.QuanTris;
                if (check.Count() <= 0)
                {
                    MessageBox.Show("Chưa tồn tại quản trị nào nên ko có danh sách!!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            fDanhsachnguoidung f = new fDanhsachnguoidung(3);
            f.ShowDialog();
        }

        private void CmsThemgiaovien_Click(object sender, EventArgs e)
        {
            fThemGvQt f = new fThemGvQt(2);
            f.ShowDialog();
        }

        private void FmainQuantri_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLogout == false)
            {
                CurrentUser.PhanQuyen = -1;
            }
        }

        private void CmsRestoreDB_Click(object sender, EventArgs e)
        {
            fRestoreDatabase f = new fRestoreDatabase();
            f.ShowDialog();
        }

        private void CmsBackupDB_Click(object sender, EventArgs e)
        {
            fBackupDatabase f = new fBackupDatabase();
            f.ShowDialog();
        }

        private void CmsImportAll_Click(object sender, EventArgs e)
        {
            fImport f = new fImport(4);
            f.ShowDialog();
        }

        private void CmsImportGv_Click(object sender, EventArgs e)
        {
            fImport f = new fImport(2);
            f.ShowDialog();
        }

        private void CmsXemdanhsachgv_Click(object sender, EventArgs e)
        {
            using (var DB = new QTDataContext())
            {
                var check = DB.GiaoViens;
                if (check.Count() <= 0)
                {
                    MessageBox.Show("Chưa tồn tại giáo viên nào nên ko có danh sách!!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            fDanhsachnguoidung f = new fDanhsachnguoidung(2);
            f.ShowDialog();
        }

        private void CmsExportAll_Click(object sender, EventArgs e)
        {
            fExportData f = new fExportData(4);
            f.ShowDialog();
        }

        private void CmsExportGiaovien_Click(object sender, EventArgs e)
        {
            using (var DB = new QTDataContext())
            {
                var check = DB.GiaoViens;
                if (check.Count() <= 0)
                {
                    MessageBox.Show("Chưa tồn tại giáo viên nào nên ko thể sử dụng chức năng này!!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            fExportData f = new fExportData(2);
            f.ShowDialog();
        }

        private void CmsExport_Click(object sender, EventArgs e)
        {
            using (var DB = new QTDataContext())
            {
                var check = DB.HocSinhs;
                if (check.Count() <= 0)
                {
                    MessageBox.Show("Chưa tồn tại học sinh nào nên ko thể sử dụng chức năng này!!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            fExportData f = new fExportData(1);
            f.ShowDialog();
        }

        private void CmsThemHs_Click(object sender, EventArgs e)
        {
            fThemHs f = new fThemHs();
            f.ShowDialog();
        }

        private void CmsImportHs_Click(object sender, EventArgs e)
        {
            
            fImport f = new fImport(1);
            f.ShowDialog();
        }

        private void CmsXemdanhsachHs_Click(object sender, EventArgs e)
        {
            using(var DB = new QTDataContext())
            {
                var check = DB.HocSinhs;
                if (check.Count() <= 0)
                {
                    MessageBox.Show("Chưa tồn tại học sinh nào nên ko có danh sách!!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            fDanhsachnguoidung f = new fDanhsachnguoidung(1);
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
    }
}
