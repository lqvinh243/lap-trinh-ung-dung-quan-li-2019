using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Validatior;

namespace WindowsFormsApp2
{
    public partial class fDangnhap : Form
    {
        int Hashlen = 20;
        static List<char> lHash = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        public int CM { get; set; }
        public bool isLogin { get; set; }
        public fDangnhap()
        {
            InitializeComponent();

            isLogin = false;
            Load += LoadControl;
            Load += LoadValidator;
        }

        private void LoadValidator(object sender, EventArgs e)
        {
            this.CenterToParent();
            var rqinputten = new RequiredInputValidator();
            rqinputten.Controltovalidate = txtUsername;

            var rqinputmk = new RequiredInputValidator();
            rqinputmk.Controltovalidate = txtPassword;

            var checkuser = new DBValidator();
            checkuser.ValidatorCheck = 1;
            checkuser.Controltovalidate = txtUsername;
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToScreen();

            this.btnThoat.Click += BtnThoat_Click;
            this.btnDangky.Click += BtnDangky_Click;
            this.btnDangnhap.Click += BtnDangnhap_Click;
            this.FormClosing += FDangnhap_FormClosing;
        }

        private void FDangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLogin == false)
            {
                CurrentUser.PhanQuyen = -1;
            }
        }


        private void BtnDangnhap_Click(object sender, EventArgs e)
        {
            using (var DB = new QTDataContext())
            {
                var username = DB.NguoiDungs.Where(a => a.TaiKhoan == txtUsername.Text).SingleOrDefault();
                if (username == null)
                {
                    lbLoi.Text = "User Name Không Tồn Tại!";
                }
                else
                {
                    try
                    {
                        var strPw = this.txtPassword.Text;
                        var sha = new SHA1CryptoServiceProvider();
                        var Arrbytepw = ASCIIEncoding.ASCII.GetBytes(strPw);

                        var arrChar = username.Matkhau.ToCharArray();
                        var arrByte = new byte[username.Matkhau.Length / 2 - Hashlen];
                        for (int i = Hashlen * 2, j = 0; i < arrChar.Length; i = i + 2)
                        {
                            arrByte[j++] = (byte)(lHash.IndexOf(arrChar[i]) * 16 + lHash.IndexOf(arrChar[i + 1]));
                        }

                        var arrstrSalt = new Byte[arrByte.Length + Arrbytepw.Length];

                        Array.Copy(Arrbytepw, arrstrSalt, Arrbytepw.Length);
                        Array.Copy(arrByte, 0, arrstrSalt, Arrbytepw.Length, arrByte.Length);

                        var arrHash = sha.ComputeHash(arrstrSalt);
                        var arrstrSaltHased = new byte[arrHash.Length + arrByte.Length];
                        Array.Copy(arrHash, arrstrSaltHased, arrHash.Length);
                        Array.Copy(arrByte, 0, arrstrSaltHased, arrHash.Length, arrByte.Length);

                        var strPwHashed = BitConverter.ToString(arrstrSaltHased).Replace("-", "");
                        if (strPwHashed != username.Matkhau)
                        {
                            lbLoi.Text = "Mật khẩu không đúng kiểm tra lại!";
                        }
                        else
                        {
                            isLogin = true;
                            CM = username.ID;
                            CurrentUser.UserID = CM;
                            CurrentUser.CMND = username.CMND;
                            CurrentUser.TaiKhoan = txtUsername.Text;
                            CurrentUser.PhanQuyen = username.Loainguoidung;
                            this.Close();
                        }
                    }
                    catch (Exception)
                    {
                        lbLoi.Text = "Đăng nhập thất bại vui lòng liên hệ quản trị viên!";
                    }
                lbLoi.Left = (this.ClientSize.Width - lbLoi.Size.Width) / 2;
                }
                    
            }
        }

        private void BtnDangky_Click(object sender, EventArgs e)
        {
            fDangky frmDangKy = new fDangky();
            frmDangKy.ShowDialog();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
