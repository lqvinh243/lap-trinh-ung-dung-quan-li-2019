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
    public partial class fDangky : Form
    {
        public fDangky()
        {
            InitializeComponent();

            Load += LoadControl;
            Load += LoadData;
       }

        private void LoadData(object sender, EventArgs e)
        {
            this.CenterToParent();
            
            
            var rq1 = new RequiredInputValidator();
            rq1.Controltovalidate = txtCMND;
            var rq2 = new RequiredInputValidator();
            rq2.Controltovalidate = txtTaiKhoan;
            var rq3 = new RequiredInputValidator();
            rq3.Controltovalidate = txtMatKhau;
            var rq4 = new RequiredInputValidator();
            rq4.Controltovalidate = txtNhaplaiMk;

            var rqcm = new DBValidator();
            rqcm.ValidatorCheck = 2;
            rqcm.Controltovalidate = txtCMND;

            var rqtk = new DBValidator();
            rqtk.ValidatorCheck = 3;
            rqtk.Controltovalidate = txtTaiKhoan;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chăc chắn muốn thoát","Xác nhận thoát",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnDangky_Click(object sender, EventArgs e)
        {
            lbErr.Width = 100;
            lbErr.AutoSize = true;
            if(string.IsNullOrWhiteSpace(this.txtCMND.Text) ||string.IsNullOrWhiteSpace(this.txtMatKhau.Text) || string.IsNullOrWhiteSpace(this.txtNhaplaiMk.Text) || string.IsNullOrWhiteSpace(this.txtTaiKhoan.Text))
            {
                lbErr.Text = "Các ô phải được nhập đầy đủ!";
                lbErr.Left = (this.panel1.Width - lbErr.Size.Width) / 2;
                return;
            }
            using (var DB = new QTDataContext())
            {
                var cmnd = DB.NguoiDungs.Where(a => a.CMND == txtCMND.Text).SingleOrDefault();
                if (cmnd == null)
                {
                    lbErr.Text = "Không tồn tại cmnd!";
                }
                else
                {
                    if ((cmnd.TaiKhoan ?? "").Length > 0)
                    {
                        lbErr.Text = "CMND này đã được đăng ký tài khoản!";
                    }
                    else
                    {
                        var nd = DB.NguoiDungs.Where(idx => idx.TaiKhoan == this.txtTaiKhoan.Text).FirstOrDefault();
                        if (nd != null)
                        {
                            lbErr.Text = "Đã tồn tại tài khoản này,vui lòng chọn tên khác";
                            lbErr.Left = (this.panel1.Width - lbErr.Size.Width) / 2;
                            return;
                        }
                        if (txtMatKhau.Text.Length <= 0)
                        {
                            lbErr.Text = "Mật khẩu không được để trống!";
                        }
                        else
                        {
                            if (txtMatKhau.Text != txtNhaplaiMk.Text)
                            {
                                lbErr.Text = "Mật khẩu nhập lại không đúng!";
                            }
                            else
                            {
                                cmnd.TaiKhoan = txtTaiKhoan.Text;
                                var Pw = this.txtMatKhau.Text;
                                var sha = new SHA1CryptoServiceProvider();

                                //get time Now with Millisecond
                                var strTimeNow = DateTime.Now.Millisecond.ToString();

                                //Convert to ASCII
                                var arrByte = ASCIIEncoding.ASCII.GetBytes(Pw);
                                var arrByteTimeN = ASCIIEncoding.ASCII.GetBytes(strTimeNow);

                                //create array byte with size arrByte and size arrByteTime
                                var arrStrSalt = new byte[arrByte.Length + arrByteTimeN.Length];

                                Array.Copy(arrByte, arrStrSalt, arrByte.Length);
                                Array.Copy(arrByteTimeN, 0, arrStrSalt, arrByte.Length, arrByteTimeN.Length);


                                var arrPwHash = sha.ComputeHash(arrStrSalt);
                                var arrPwSaltHashed = new byte[arrPwHash.Length + arrByteTimeN.Length];
                                Array.Copy(arrPwHash, arrPwSaltHashed, arrPwHash.Length);
                                Array.Copy(arrByteTimeN, 0, arrPwSaltHashed, arrPwHash.Length, arrByteTimeN.Length);
                                var strPwHash = BitConverter.ToString(arrPwSaltHashed).Replace("-", "");
                                cmnd.Matkhau = strPwHash;
                                try
                                {
                                    DB.SubmitChanges();
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Không thể đăng ký,vui lòng thử lại!!", "Thông báo", MessageBoxButtons.OK);
                                    return;
                                }
                                MessageBox.Show("Đăng ký tài khoản thành công!", "Thành công", MessageBoxButtons.OK);
                                this.Close();
                            }
                        }

                    }
                }
                lbErr.Left = (this.panel1.Width - lbErr.Size.Width) / 2;

            }
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.btnDangky.Click += BtnDangky_Click;
            this.btnThoat.Click += BtnThoat_Click;
        }
    }
}
