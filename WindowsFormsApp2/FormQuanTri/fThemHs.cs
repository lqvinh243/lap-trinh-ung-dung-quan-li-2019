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
    public partial class fThemHs : Form
    {
        public fThemHs()
        {
            InitializeComponent();

            Load += LoadControl;
            Load += LoadData;
        }

        private void LoadData(object sender, EventArgs e)
        {
            var rq1 = new RequiredInputValidator();
            rq1.Controltovalidate = this.txtCMND;
            var rq2 = new RequiredInputValidator();
            rq2.Controltovalidate = this.txtHoten;
            var rq3 = new RequiredInputValidator();
            rq3.Controltovalidate = this.txtKhoi;
            var rq4 = new RequiredInputValidator();
            rq4.Controltovalidate = this.txtLop;

            var rn1 = new ValidatorN();
            rn1.i = 1;
            rn1.Controltovalidate = this.txtKhoi;
            var rn2 = new ValidatorN();
            rn2.i = 2;
            rn2.Controltovalidate = this.txtLop;

            var rgx = new DBValidator();
            rgx.ValidatorCheck = 5;
            rgx.Controltovalidate = txtCMND;

            var rgy = new RegexValidator();
            rgy.FlagRegex = 1;
            rgy.Controltovalidate = txtCMND;
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.btnThoat.Click += BtnThoat_Click;
            this.btnThemhocsinh.Click += BtnThemhocsinh_Click;
        }

        private void BtnThemhocsinh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtCMND.Text))
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
            if (string.IsNullOrWhiteSpace(this.txtHoten.Text))
            {
                this.lbLoi.Text = "Họ tên không được trống!";
                this.lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                return;
            }
            if (string.IsNullOrWhiteSpace(this.txtKhoi.Text) && string.IsNullOrWhiteSpace(this.txtLop.Text))
            {
                this.lbLoi.Text = "Khối và lớp không được để trống!";
                this.lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                return;
            }

            var rx = new Regex(RegexString.Khoi);
            if (!rx.IsMatch(this.txtKhoi.Text))
            {
                this.lbLoi.Text = "Khối chỉ được định dạng là số và nằm trong khoảng 1-12!";
                this.lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                return;
            }
            rx = new Regex(RegexString.Lop);
            if (!rx.IsMatch(this.txtLop.Text))
            {
                this.lbLoi.Text = "Khối chỉ được định dạng là số và nằm trong khoảng 1-9!";
                this.lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                return;
            }

            using (var DB = new QTDataContext())
            {
                var Check = DB.NguoiDungs.Where(idx => idx.CMND == this.txtCMND.Text).SingleOrDefault();
                if (Check != null)
                {
                    this.lbLoi.Text = "CMND đã tồn tại trong DB vui lòng kiểm tra lại!";
                    this.lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                    return;
                }
                if (MessageBox.Show("Bạn chắc chắn thông tin học sinh này là đúng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    NguoiDung nd = new NguoiDung();
                    nd.CMND = this.txtCMND.Text;
                    nd.Loainguoidung = 1;

                    DB.NguoiDungs.InsertOnSubmit(nd);
                    DB.SubmitChanges();
                    HocSinh hs = new HocSinh();
                    hs.ID = nd.ID;
                    hs.Hoten = this.txtHoten.Text;
                    hs.Lop = int.Parse(this.txtLop.Text);
                    hs.Khoi = int.Parse(this.txtKhoi.Text);
                    hs.Ngaysinh = this.dtpNgaysinh.Value;

                    DB.HocSinhs.InsertOnSubmit(hs);
                    DB.SubmitChanges();
                    MessageBox.Show("Thêm học sinh thành công!");
                    this.Close();
                }
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy bỏ việc thêm học sinh?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
         }
    }
}
