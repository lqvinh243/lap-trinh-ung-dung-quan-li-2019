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
    public partial class fSuathongtinGvQt : Form
    {
        public int ID, Loai;
        public int CheckUpdate = 0;
        public Dictionary<string, int> UD = new Dictionary<string, int>();

        public NguoiDung NguoiDung { get; private set; }

        public QuanTri QT { get; private set; }
        public GiaoVien GV { get; private set; }
        public fSuathongtinGvQt(int idgv, int loai)
        {
            InitializeComponent();

            ID = idgv;
            Loai = loai;
            Load += LoadData;
            Load += LoadControl;
            
        }

        private void LoadData(object sender, EventArgs e)
        {
            var rq1 = new RequiredInputValidator();
            rq1.Controltovalidate = this.txtCMND;

            var rgz = new DBValidator();
            rgz.ValidatorCheck = 4;
            rgz.Controltovalidate = this.txtCMND;

            var rgu = new RegexValidator();
            rgu.FlagRegex = 1;
            rgu.Controltovalidate = txtCMND;

            LoadDuLieu();
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.txtID.Enabled = false;
            this.btnHuy.Click += BtnHuy_Click;
            this.btnCapnhat.Click += BtnCapnhat_Click;


            this.txtCMND.TextChanged += TxtCMND_TextChanged;
            this.txtHoten.TextChanged += TxtHoten_TextChanged;
            this.txtPassword.TextChanged += TxtPassword_TextChanged;
            this.txtUsername.TextChanged += TxtUsername_TextChanged;
            this.dtpNgaysinh.TextChanged += DtpNgaysinh_TextChanged;
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
                var checktk = DB.NguoiDungs.Where(idx => idx.TaiKhoan == this.txtUsername.Text).FirstOrDefault();
                if (checktk != null)
                {
                    this.lbLoi.Text = "Tài khoản đã tồn tại, vui lòng chọn tài khoản khác!";
                    this.lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                    return;
                }
            }

            if (UD.ContainsValue(1))
            {
                if (MessageBox.Show("Bạn có chắc chắn về thông tin cập nhật?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var DB = new QTDataContext())
                    {
                        
                        var nd = DB.NguoiDungs.Where(idx => idx.CMND == ID.ToString()).SingleOrDefault();
                        if(Loai == 2)
                        {
                            var gv = DB.GiaoViens.Where(idx => idx.ID == nd.ID).SingleOrDefault();
                            if (UD["Hoten"] == 1)
                                gv.Hoten = this.txtHoten.Text;
                            if (UD["Ngaysinh"] == 1)
                                gv.Ngaysinh = this.dtpNgaysinh.Value;
                        }
                        else
                        {
                            var qt = DB.QuanTris.Where(idx => idx.ID == nd.ID).SingleOrDefault();
                            if (UD["Hoten"] == 1)
                                qt.Hoten = this.txtHoten.Text;
                            if (UD["Ngaysinh"] == 1)
                                qt.Ngaysinh = this.dtpNgaysinh.Value;
                        }
                        
                        if (UD["Matkhau"] == 1 && UD["Taikhoan"] == 1)
                        {
                            nd.TaiKhoan = this.txtUsername.Text;
                            nd.Matkhau = this.txtPassword.Text;
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
        private void DtpNgaysinh_TextChanged(object sender, EventArgs e)
        {
            if (Loai == 2)
            {
                if (dtpNgaysinh.Value != GV.Ngaysinh)
                {
                    UD["Ngaysinh"] = 1;
                }
                else UD["Ngaysinh"] = 0;
            }
            else
            {
                if (dtpNgaysinh.Value != QT.Ngaysinh)
                {
                    UD["Ngaysinh"] = 1;
                }
                else UD["Ngaysinh"] = 0;
            }
            
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != NguoiDung.TaiKhoan)
            {
                UD["Taikhoan"] = 1;
            }
            else UD["Taikhoan"] = 0;
            
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != NguoiDung.Matkhau)
            {
                UD["Matkhau"] = 1;
            }
            else UD["Matkhau"] = 0;
        }

        private void TxtHoten_TextChanged(object sender, EventArgs e)
        {
            if (Loai == 2)
            {
                if (txtHoten.Text != GV.Hoten)
                {
                    UD["Hoten"] = 1;
                }
                else UD["Hoten"] = 0;
            }
            else
            {
                if (txtHoten.Text != QT.Hoten)
                {
                    UD["Hoten"] = 1;
                }
                else UD["Hoten"] = 0;
            }
            
        }

        private void TxtCMND_TextChanged(object sender, EventArgs e)
        {
            if (txtCMND.Text != NguoiDung.CMND)
            {
                UD["CMND"] = 1;
            }
            else UD["CMND"] = 0;
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
                if(Loai == 2)
                {
                    GV = DB.GiaoViens.Where(idx => idx.ID == NguoiDung.ID).SingleOrDefault();
                    this.txtID.Text = NguoiDung.ID.ToString();
                    this.txtCMND.Text = NguoiDung.CMND;
                    this.txtHoten.Text = GV.Hoten;
                    this.txtUsername.Text = NguoiDung.TaiKhoan;
                    this.txtPassword.Text = NguoiDung.Matkhau;
                    this.dtpNgaysinh.Text = GV.Ngaysinh == null ? DateTime.Now.ToShortDateString() : GV.Ngaysinh.Value.ToShortDateString();
                }
                else
                {
                    QT = DB.QuanTris.Where(idx => idx.ID == NguoiDung.ID).SingleOrDefault();
                    this.txtID.Text = NguoiDung.ID.ToString();
                    this.txtCMND.Text = NguoiDung.CMND;
                    this.txtHoten.Text = QT.Hoten;
                    this.txtUsername.Text = NguoiDung.TaiKhoan;
                    this.txtPassword.Text = NguoiDung.Matkhau;
                    this.dtpNgaysinh.Text = QT.Ngaysinh == null ? DateTime.Now.ToShortDateString() : GV.Ngaysinh.Value.ToShortDateString();
                }
                
                
            }

        }
    }
}
