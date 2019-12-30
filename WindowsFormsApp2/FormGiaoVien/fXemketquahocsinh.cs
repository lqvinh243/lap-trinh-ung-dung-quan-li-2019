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

namespace WindowsFormsApp2.FormGiaoVien
{
    public partial class fXemketquahocsinh : Form
    {
        QTDataContext DB = new QTDataContext();
        public fXemketquahocsinh()
        {
            InitializeComponent();

            Load += LoadControl;
            Load += LoadData;
        }

        private void LoadData(object sender, EventArgs e)
        {
            this.lbLoi.Text = "";
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.btnThoat.Click += BtnThoat_Click;
            FormClosing += FXemketquahocsinh_FormClosing;

            this.btnXem.Click += BtnXem_Click;
        }

        private void BtnXem_Click(object sender, EventArgs e)
        {
            this.dgvKetqua.DataSource = "";
            string IDhs = this.txtIDhs.Text;
            if (string.IsNullOrWhiteSpace(IDhs))
            {
                this.lbLoi.Text = "Vui lòng nhập";
                return;
            }
            var Rgnumber = new Regex(RegexString.Number);
            if (!Rgnumber.IsMatch(IDhs))
            {
                this.lbLoi.Text = "ID sai dịnh dạng";
                lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                return;
            }

            var TimID = DB.HocSinhs.Where(idx => idx.ID == int.Parse(IDhs)).SingleOrDefault();
            if (TimID == null)
            {
                this.lbLoi.Text = "Không tồn tại ID này";
                lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                return;
            }

            var Kq = DB.CT_ThamGias.Where(idx => idx.IDHocsinh == int.Parse(IDhs) && idx.Diem != null).Select(idx => new { IDKythi = idx.IDKythi, Khoikythi = idx.Khoikythi, IDmade = idx.IDMade, Khoidethi = idx.Khoidethi, IDHocsinh = idx.IDHocsinh, Khoi = idx.Khoi, Lop = idx.Lop, Diem = idx.Diem });
            if (Kq.Count() == 0)
            {
                MessageBox.Show("Học sinh này chưa tham gia kỳ thi có kết quả nào!!", "Thông báo", MessageBoxButtons.OK);
                lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                return;
            }
            dgvKetqua.DataSource = Kq;
        }

        private void FXemketquahocsinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Dispose();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
