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
using WindowsFormsApp2.Validator;

namespace WindowsFormsApp2.FormQuanTri
{
    public partial class fThemGvQt : Form
    {
        public int Loai;
        public fThemGvQt(int v)
        {
            InitializeComponent();
            Loai = v;
            Load += LoadControl;
            Load += LoadData;
        }

        private void LoadData(object sender, EventArgs e)
        {
            this.lbHeader.Text = "Thêm " + (Loai == 2 ? "giáo viên" : "quản trị") + " vào cơ sở dữ liệu!";
            lbLoi.Left = (this.ClientSize.Width - lbLoi.Size.Width) / 2;
            var rq1 = new RequiredInputValidator();
            rq1.Controltovalidate = this.txtCMND;
            var rq2 = new RequiredInputValidator();
            rq2.Controltovalidate = this.txtHoten;

            var rgcmnd = new CMNDValidator();
            rgcmnd.Controltovalidate = this.txtCMND;

            this.lbLoi.Text = "";
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.btnThoat.Click += BtnThoat_Click;
            this.btnThem.Click += BtnThem_Click;

        }


        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắc thêm " + (Loai == 2 ? " giáo viên này?" : "quản trị này"), "Xác nhận thêm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(this.txtCMND.Text))
                {
                    this.lbLoi.Text = "CMND không được để trống";
                    lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                    return;
                }

                var cCMND = new Regex(RegexString.CMND);
                if (!cCMND.IsMatch(this.txtCMND.Text))
                {
                    this.lbLoi.Text = "CMND không đúng định dạng";
                    lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                    return;
                }

                if (string.IsNullOrWhiteSpace(this.txtHoten.Text))
                {
                    this.lbLoi.Text = "Họ tên không được để trống";
                    lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                }
                this.lbLoi.Text = "";
                using (var DB = new QTDataContext())
                {
                    var checkCMND = DB.NguoiDungs.Where(idx => idx.CMND == this.txtCMND.Text).SingleOrDefault();
                    if (checkCMND != null)
                    {
                        this.lbLoi.Text = "CMND đã tồn tại trong cơ sở dữ liệu";
                        lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                        return;
                    }
                    string CMND = this.txtCMND.Text;
                    string Hoten = this.txtHoten.Text;
                    DateTime Ngsinh = dtpNgaysinh.Value;

                    NguoiDung nd = new NguoiDung();
                    nd.CMND = CMND;
                    nd.Loainguoidung = Loai;
                    DB.NguoiDungs.InsertOnSubmit(nd);
                    DB.SubmitChanges();
                    if (Loai == 2)
                    {
                        GiaoVien gv = new GiaoVien();
                        gv.ID = nd.ID;
                        gv.Hoten = Hoten;
                        gv.Ngaysinh = Ngsinh;

                        DB.GiaoViens.InsertOnSubmit(gv);
                    }
                    else
                    {
                        QuanTri qt = new QuanTri();
                        qt.ID = nd.ID;
                        qt.Hoten = Hoten;
                        qt.Ngaysinh = Ngsinh;

                        DB.QuanTris.InsertOnSubmit(qt);
                    }

                    DB.SubmitChanges();
                    MessageBox.Show("Thêm " + (Loai == 2 ? "giáo viên này ? " : "quản trị này") + " thành công!", "Thành công", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy bỏ thêm " + (Loai == 2 ? "giáo viên? " : "quản trị?"), "Xác nhận thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
