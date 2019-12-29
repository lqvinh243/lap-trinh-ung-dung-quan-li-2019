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
    public partial class fThongtin : Form
    {
        public HocSinh hs { get; set; }
        bool checkUpdate = false;

        public int Option { get; set; }
        public string CMND { get; set; }
        public fThongtin(int Op)
        {
            InitializeComponent();

            Load += LoadControl;
            Load += LoadView;
            Option = Op;
        }

        private void LoadView(object sender, EventArgs e)
        {
            using (var DB = new QTDataContext())
            {
                hs = DB.HocSinhs.Where(idx => idx.ID == CurrentUser.UserID).SingleOrDefault();
                if (Option == 1)
                {
                    this.btnCapnhat.Enabled = false;
                    this.txtCMND.Enabled = false;
                    this.txtHoten.Enabled = false;
                    this.dtpNgaysinh.Enabled = false;

                }
                this.txtCMND.Text = CurrentUser.CMND;
                this.txtHoten.Text = hs.Hoten;
                this.txtLop.Text = hs.Lop.ToString(); 
                this.txtKhoi.Text = hs.Khoi.ToString();
                this.dtpNgaysinh.Value = hs.Ngaysinh.Value;   
                this.checkUpdate = false;
            }
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.txtKhoi.Enabled = false;
            this.txtLop.Enabled = false;

            this.btnCapnhat.Click += BtnCapnhat_Click;
            this.btnThoat.Click += BtnThoat_Click;
            this.btnCapnhat.Enabled = false;

            this.dtpNgaysinh.ValueChanged += DtpNgaysinh_ValueChanged;
            this.txtCMND.TextChanged += TxtCMND_TextChanged;
            this.txtHoten.TextChanged += TxtHoten_TextChanged;
        }

        private void TxtHoten_TextChanged(object sender, EventArgs e)
        {
            if (txtHoten.Text != hs.Hoten)
            {
                checkUpdate = true;
                this.btnCapnhat.Enabled = true;
                return;
            }
            checkUpdate = false;
            this.btnCapnhat.Enabled = false;
        }

        private void TxtCMND_TextChanged(object sender, EventArgs e)
        {
            if (txtCMND.Text != CurrentUser.CMND)
            {
                checkUpdate = true;
                this.btnCapnhat.Enabled = true;
                return;
            }
            checkUpdate = false;
            this.btnCapnhat.Enabled = false;
        }

        private void DtpNgaysinh_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpNgaysinh.Value != hs.Ngaysinh)
            {
                checkUpdate = true;
                this.btnCapnhat.Enabled = true;
                return;
            }
            checkUpdate = false;
            this.btnCapnhat.Enabled = false;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (checkUpdate == true)
            {
                if (MessageBox.Show("Bạn có muốn hủy bỏ cập nhật thông tin?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void BtnCapnhat_Click(object sender, EventArgs e)
        {
            if (checkUpdate == true)
            {
                using (var DB = new QTDataContext())
                {
                    var lqhs = DB.HocSinhs.Where(a => a.ID == CurrentUser.UserID).SingleOrDefault();
                    var nd = DB.NguoiDungs.Where(idx => idx.ID == CurrentUser.UserID).SingleOrDefault();
                    if (lqhs != null)
                    {
                        nd.CMND = this.txtCMND.Text;
                        CurrentUser.CMND = this.txtCMND.Text;
                        lqhs.Hoten = txtHoten.Text;
                        lqhs.Ngaysinh = dtpNgaysinh.Value;
                        if (MessageBox.Show("Bạn chắc chắn cập nhật ?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            DB.SubmitChanges();
                            hs = lqhs;
                            MessageBox.Show("Cập nhật thông tin thành công!");
                            checkUpdate = false;
                            this.btnCapnhat.Enabled = false;
                        }

                    }
                }
            }
        }
    }
}
