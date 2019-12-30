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
    public partial class fThongkekythi : Form
    {
        QTDataContext DB = new QTDataContext();
        public fThongkekythi()
        {
            InitializeComponent();
            Load += LoadData;
            Load += LoadControl;
        }

        public void LoadKhoi()
        {
            this.cbbKhoi.Items.Add(10);
            this.cbbKhoi.Items.Add(11);
            this.cbbKhoi.Items.Add(12);
            this.cbbKhoi.SelectedItem = 0;
        }
        private void LoadData(object sender, EventArgs e)
        {
            LoadKhoi();
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.btnThoat.Click += BtnThoat_Click;

            this.btnXem.Click += BtnXem_Click;
        }

        private void BtnXem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn thông tin nhập vào là đúng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.dgvHocsinh.DataSource = "";
                string ID = this.txtIDkythi.Text;
                if (string.IsNullOrWhiteSpace(ID))
                {
                    lbLoi.Text = "Nhập ID kỳ thi!";
                    lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                    return;
                }
                var rgNum = new Regex(RegexString.Number);
                if (!rgNum.IsMatch(ID))
                {
                    lbLoi.Text = "ID sai định dạng!";
                    lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                    return;
                }

                int Khoi = int.Parse(this.cbbKhoi.SelectedItem.ToString());
                var CheckKythi = DB.KyThis.Where(idx => idx.ID == int.Parse(ID) && idx.Khoi == Khoi).SingleOrDefault();
                if (CheckKythi == null)
                {
                    lbLoi.Text = "Không tồn tại kỳ thi này!";
                    lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                    return;
                }
                var Check = DB.CT_ThamGias.Where(idx => idx.IDKythi == int.Parse(ID) && idx.Khoi == Khoi);
                if (Check.Count() <= 0)
                {
                    MessageBox.Show("Chưa có thí sinh nào tồn tại trong kỳ thi này!!");
                    return;
                }
                var P = Check.Select(idx => new { IDKythi = idx.IDKythi, Khoikythi = idx.Khoikythi, IDMade = idx.IDMade, Khoimade = idx.Khoidethi, IDHocsinh = idx.IDHocsinh, Lop = idx.Lop, Khoi = idx.Khoi, Diem = idx.Diem });
                this.dgvHocsinh.DataSource = P;
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
