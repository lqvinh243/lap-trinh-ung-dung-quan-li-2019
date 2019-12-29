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

namespace WindowsFormsApp2.FormGiaoVien
{
    public partial class fThemkythi : Form
    {
        public int Makythi;
        public fThemkythi()
        {
            InitializeComponent();

            Load += LoadControl;
            Load += LoadData;
        }

        private void LoadData(object sender, EventArgs e)
        {
            this.lbLoi.Text = "";
            LoadKhoi();
        }

        public void LoadKhoi()
        {
            this.cbbKhoi.Items.Add(10);
            this.cbbKhoi.Items.Add(11);
            this.cbbKhoi.Items.Add(12);
            this.cbbKhoi.SelectedIndex = 0;
        }
        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.txtMakythi.Enabled = false;
            this.btnThoat.Click += BtnThoat_Click;
            this.btnThem.Click += BtnThem_Click;

            this.cbbKhoi.SelectedIndexChanged += CbbKhoi_SelectedIndexChanged;
        }

        private void CbbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Khoi = int.Parse(this.cbbKhoi.SelectedItem.ToString());
            int IDkythitaora = 1;
            using (var DB = new QTDataContext())
            {
                var Kythi = DB.KyThis.Where(idx=>idx.Khoi == Khoi).FirstOrDefault();
                if (Kythi == null)
                {
                    this.txtMakythi.Text = IDkythitaora.ToString();
                }
                else
                {
                    IDkythitaora = DB.KyThis.Where(idx => idx.Khoi == Khoi).Max(idx => idx.ID) + 1;
                    this.txtMakythi.Text = IDkythitaora.ToString();
                }
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtThoigian.Text))
            {
                var rgthoigian = new Regex(@"^[0-9]+$");
                if (!rgthoigian.IsMatch(this.txtThoigian.Text))
                {
                    this.lbLoi.Text = "Thời gian nhập vào không hợp lệ!";
                    lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                    return;
                }
                using (var db = new QTDataContext())
                {
                    var insert = new KyThi();
                    insert.ID = int.Parse(this.txtMakythi.Text.ToString());
                    insert.Khoi = int.Parse(this.cbbKhoi.SelectedItem.ToString());
                    if (cbThithu.Checked == true)
                    {
                        insert.Thithu = 1;
                    }
                    else
                    {
                        insert.Thithu = 0;
                    }
                    insert.IDNguoitao = CurrentUser.UserID;
                    insert.Ngaythi = dtpNgaythi.Value;
                    insert.Gioihanthoigian = int.Parse(txtThoigian.Text);
                    insert.Ngaytao = DateTime.Now;
                    db.KyThis.InsertOnSubmit(insert);
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể thêm kỳ thi!");
                        return;
                    }

                    MessageBox.Show("Thêm kì thi thành công!");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Dữ Liệu", "Thông Báo");
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
