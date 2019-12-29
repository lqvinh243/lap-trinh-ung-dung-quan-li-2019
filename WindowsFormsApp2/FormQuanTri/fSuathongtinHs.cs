using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Validatior;

namespace WindowsFormsApp2.FormQuanTri
{
    public partial class fSuathongtinHs : Form
    {
        public int ID;
        public int CheckUpdate = 0;
        public Dictionary<string, int> UD = new Dictionary<string, int>();

        public NguoiDung NguoiDung { get; private set; }
        public HocSinh HS { get; private set; }
        public fSuathongtinHs(int idhs)
        {
            InitializeComponent();

            ID = idhs;

            Load += LoadControl;
            Load += LoadData;
        }

        private void LoadData(object sender, EventArgs e)
        {
            LoadDuLieu();

            var rq1 = new RequiredInputValidator();
            rq1.Controltovalidate = this.txtCMND;
            

            var rgx = new ValidatorN();
            rgx.i = 1;
            rgx.Controltovalidate = this.txtKhoi;
            var rgy = new ValidatorN();
            rgy.i = 2;
            rgy.Controltovalidate = this.txtLop;
            var rgz = new DBValidator();
            rgz.ValidatorCheck = 4;
            rgz.Controltovalidate = this.txtCMND;

            var rgu = new RegexValidator();
            rgu.FlagRegex = 1;
            rgu.Controltovalidate = txtCMND;
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.txtID.Enabled = false;
            this.btnHuy.Click += BtnHuy_Click;
            this.btnCapnhat.Click += BtnCapnhat_Click;

            this.txtCMND.TextChanged += TxtCMND_TextChanged;
            this.txtHoten.TextChanged += TxtHoten_TextChanged;
            this.txtKhoi.TextChanged += TxtKhoi_TextChanged;
            this.txtLop.TextChanged += TxtLop_TextChanged;
            this.txtUsername.TextChanged += TxtUsername_TextChanged;
            this.txtPassword.TextChanged += TxtPassword_TextChanged;
            this.dtpNgaysinh.TextChanged += DtpNgaysinh_TextChanged;
        }

        private void DtpNgaysinh_TextChanged(object sender, EventArgs e)
        {
            if (dtpNgaysinh.Value != HS.Ngaysinh)
            {
                UD["Ngaysinh"] = 1;
            } else UD["Ngaysinh"] = 0;
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != NguoiDung.Matkhau)
            {
                UD["Matkhau"] = 1;
            }
            else UD["Matkhau"] = 0;
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != NguoiDung.TaiKhoan)
            {
                UD["Taikhoan"] = 1;
            }
            else UD["Taikhoan"] = 0;
        }

        private void TxtLop_TextChanged(object sender, EventArgs e)
        {
            var rx = new Regex(RegexString.Lop);
            if (rx.IsMatch(this.txtLop.Text))
            {
                if (int.Parse(txtLop.Text) != HS.Lop)
                {
                    UD["Lop"] = 1;
                }
                else UD["Lop"] = 0;
            }
        }

        private void TxtKhoi_TextChanged(object sender, EventArgs e)
        {
            var rx = new Regex(RegexString.Khoi);
            if (rx.IsMatch(this.txtKhoi.Text))
            {
                if (int.Parse(txtKhoi.Text) != HS.Khoi)
                {
                    UD["Khoi"] = 1;
                }
                else UD["Khoi"] = 0;
            }
        }

        private void TxtHoten_TextChanged(object sender, EventArgs e)
        {
            if (txtHoten.Text != HS.Hoten)
            {
                UD["Hoten"] = 1;
            }
            else UD["Hoten"] = 0;
        }

        private void TxtCMND_TextChanged(object sender, EventArgs e)
        {
            if (txtCMND.Text != NguoiDung.CMND)
            {
                UD["CMND"] = 1;
            }
            else UD["CMND"] = 0;
        }

        private void BtnCapnhat_Click(object sender, EventArgs e)
        {
            if (txtCMND == null && string.IsNullOrWhiteSpace(txtCMND.Text))
            {
                this.lbLoi.Text = "CMND không được để trống!";
                this.lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                return;
            }

            var rg = new Regex(RegexString.CMND);
            if (!rg.IsMatch(this.txtCMND.Text))
            {
                this.lbLoi.Text = "CMND sai định dạng, kiểm tra lại!";
                this.lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                return;
            }

            using (var DB = new QTDataContext())
            {
                var p = DB.NguoiDungs.Where(idx => idx.CMND == txtCMND.Text && idx.ID != NguoiDung.ID).SingleOrDefault();
                if (p != null)
                {
                    this.lbLoi.Text = "CMND đã tồn tại trong cơ sở dữ liệu vui lòng kiểm tra lại!";
                    this.lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                    return;
                }
            }
            if ((string.IsNullOrWhiteSpace(txtUsername.Text)
                && !string.IsNullOrWhiteSpace(txtPassword.Text))
                || (!string.IsNullOrWhiteSpace(txtUsername.Text))
                && (string.IsNullOrWhiteSpace(txtPassword.Text)))
            {
                this.lbLoi.Text = "Nếu có tài khoản thì phải có mật khẩu và ngược lại!";
                this.lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                return;
            }
            using (var DB = new QTDataContext())
            {
                var checktk = DB.NguoiDungs.Where(idx => idx.TaiKhoan == txtUsername.Text).FirstOrDefault();
                if (checktk != null)
                {
                    this.lbLoi.Text = "Tài khoản đã tồn tại,chọn tài khoản khác!";
                    this.lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(txtKhoi.Text) || string.IsNullOrWhiteSpace(txtLop.Text))
            {
                this.lbLoi.Text = "Khối và lớp không đươc để trống!";
                this.lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                return;
            }

            if (UD.ContainsValue(1))
            {
                if (MessageBox.Show("Bạn có chắc chắn về thông tin cập nhật?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var DB = new QTDataContext())
                    {
                        
                        var nd = DB.NguoiDungs.Where(idx => idx.CMND == ID.ToString()).SingleOrDefault();
                        var hs = DB.HocSinhs.Where(idx => idx.ID == nd.ID).SingleOrDefault();
                        if (UD["Hoten"] == 1)
                            hs.Hoten = this.txtHoten.Text;
                        if (UD["Lop"] == 1)
                            hs.Lop = int.Parse(this.txtLop.Text);
                        if (UD["Khoi"] == 1)
                            hs.Khoi = int.Parse(this.txtKhoi.Text);
                        if (UD["Ngaysinh"] == 1)
                            hs.Ngaysinh = this.dtpNgaysinh.Value;
                        if (UD["Matkhau"] == 1 && UD["Taikhoan"] == 1)
                        {
                            nd.TaiKhoan = this.txtUsername.Text;
                            nd.Matkhau = this.txtPassword.Text;
                        }
                        if(UD["Ngaysinh"] == 1)
                        {
                            hs.Ngaysinh = this.dtpNgaysinh.Value;
                        }
                        DB.SubmitChanges();

                        if (UD["CMND"] == 1)
                            nd.CMND = this.txtCMND.Text;
                        DB.SubmitChanges();
                        MessageBox.Show("Cập nhật thông tin thành công", "Thành công!");
                        this.Close();
                    }
                }

            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            if (UD.ContainsValue(1))
            {
                if (MessageBox.Show("Bạn có muốn hủy cập nhật thông tin", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else this.Close();

        }

        public void LoadDuLieu()
        {
            using (var DB = new QTDataContext())
            {
                UD.Add("CMND", 0);
                UD.Add("Taikhoan", 0);
                UD.Add("Matkhau", 0);
                UD.Add("Lop", 0);
                UD.Add("Khoi", 0);
                UD.Add("Hoten", 0);
                UD.Add("Ngaysinh", 0);
                NguoiDung = DB.NguoiDungs.Where(idx => idx.CMND == ID.ToString()).SingleOrDefault();
                HS = DB.HocSinhs.Where(idx => idx.ID == NguoiDung.ID).SingleOrDefault();
                this.txtID.Text = NguoiDung.ID.ToString();
                this.txtCMND.Text = NguoiDung.CMND;
                this.txtHoten.Text = HS.Hoten;
                this.txtKhoi.Text = HS.Khoi.ToString();
                this.txtLop.Text = HS.Lop.ToString();
                this.txtUsername.Text = NguoiDung.TaiKhoan;
                this.txtPassword.Text = NguoiDung.Matkhau;
                this.dtpNgaysinh.Text = HS.Ngaysinh.Value.ToShortDateString();
            }

        }
    }
}
