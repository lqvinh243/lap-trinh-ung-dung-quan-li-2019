using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.FormGiaoVien
{
    public partial class fThemmademoi : Form
    {
        int Khoichon;
        public fThemmademoi()
        {
            InitializeComponent();

            Load += LoadControl;
            Load += LoadData;
        }

        private void LoadData(object sender, EventArgs e)
        {
            LoadKhoi();
            LoadDokho();
        }

        public void LoadKhoi()
        {
            this.cbbKhoi.Items.Add(10);
            this.cbbKhoi.Items.Add(11);
            this.cbbKhoi.Items.Add(12);
            this.cbbKhoi.SelectedIndex = 0;
        }

        public void LoadIDMoi()
        {
            int NewIDmade;
            using (var DB = new QTDataContext())
            {
                var IDMade = DB.MaDes.Where(idx => idx.Khoi == Khoichon).FirstOrDefault();
                if (IDMade == null) NewIDmade = 1;
                else
                {
                    NewIDmade = DB.MaDes.Where(idx => idx.Khoi == Khoichon).Max(idx => idx.ID) + 1;
                }
            }
            this.txtIDmademoi.Text = NewIDmade.ToString();
        }

        public void LoadDokho()
        {
            this.cbbDokho.Items.Clear();
            this.cbbDokho.Items.Add("Dễ");
            this.cbbDokho.Items.Add("Trung bình");
            this.cbbDokho.Items.Add("Khó");
            this.cbbDokho.Items.Add("Rất khó");
            this.cbbDokho.SelectedIndex = 0;
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.txtIDmademoi.Enabled = false;
            this.btnThoat.Click += BtnThoat_Click;
            this.btnThemmade.Click += BtnThemmade_Click;

            this.cbbKhoi.SelectedIndexChanged += CbbKhoi_SelectedIndexChanged;
        }

        private void BtnThemmade_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn tạo mã đề này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int IDmoi = int.Parse(this.txtIDmademoi.Text);
                using (var DB = new QTDataContext())
                {
                    MaDe md = new MaDe();
                    md.ID = IDmoi;
                    md.Khoi = Khoichon;
                    md.Dokho = this.cbbDokho.SelectedItem.ToString();
                    md.IDNguoitao = CurrentUser.UserID;
                    DB.MaDes.InsertOnSubmit(md);
                    try
                    {
                        DB.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể thêm mã đề mới!", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                }
                MessageBox.Show("Thêm mã đề mới có ID : " + IDmoi.ToString() + " và Khối : " + Khoichon.ToString() + " thành công!");
                this.Close();
            }
        }

        private void CbbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Khoichon = int.Parse(this.cbbKhoi.SelectedItem.ToString());
            LoadIDMoi();
            LoadDokho();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
