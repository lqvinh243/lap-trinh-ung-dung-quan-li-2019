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
    public partial class fThemmade : Form
    {
        public int ID, Khoi;
        public bool Chon = false;
        public fThemmade(int iDKythi, int khoikythi)
        {
            InitializeComponent();

            Load += LoadControl;
            Load += LoadData;
            ID = iDKythi;
            Khoi = khoikythi;
        }

        private void LoadData(object sender, EventArgs e)
        {
            this.Text = "Thêm mã đề cho kỳ thi";
            this.txtKhoi.Text = Khoi.ToString();
            this.txtKythi.Text = ID.ToString();
            LoadDulieu();
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.txtKythi.Enabled = false;
            this.txtKhoi.Enabled = false;

            //Thoát
            this.btnThoat.Click += BtnThoat_Click;
            //Chọn mã đề
            this.cbbKhoi.SelectedIndexChanged += CbbKhoi_SelectedIndexChanged;

            //Thêm
            this.btnThemmade.Click += BtnThemmade_Click;
        }

        private void BtnThemmade_Click(object sender, EventArgs e)
        {
            
            if (Chon == false)
            {
                this.lbLoi.Text = "Vui lòng chọn khối!";
                lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2; 
                return;
            }
            int Khoichon = int.Parse(this.cbbKhoi.SelectedItem.ToString());
            if (Khoichon == 0)
            {
                this.lbLoi.Text = "0 là số mặc định vui lòng chọn khối";
                lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                return;
            }
            int Madechon = int.Parse(this.cbbMade.SelectedItem.ToString());
            if (Madechon == 0)
            {
                this.lbLoi.Text = "0 là số mặc định vui lòng chọn mã đề";
                lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                return;
            }

            if (Khoi != Khoichon)
            {
                if (MessageBox.Show("Khối mã đề bạn chọn hiện đang không dành cho kỳ thi khối hiện tại,bạn có chắc thêm mã đề này?", "Xác nhận thêm", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                } 
            }
            else if (MessageBox.Show("Bạn có chắc chắn thêm mã đề này?", "Xác nhận thêm", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            using (var DB = new QTDataContext())
            {
                var Made = DB.CT_MaDes.Where(idx => idx.Khoimade == Khoichon && idx.IDMade == Madechon);
                if (Made.Count() <= 0)
                {
                    MessageBox.Show("Không thể thêm mã đề này vì mã đề chưa tồn tại câu hỏi nào!!", "Xác nhận");
                    return;
                }
                CT_KyThi ct = new CT_KyThi();
                ct.IDKythi = ID;
                ct.Khoikythi = Khoi;
                ct.Khoidethi = Khoichon;
                ct.IDMade = Madechon;
                try
                {
                    DB.CT_KyThis.InsertOnSubmit(ct);
                    DB.SubmitChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể thêm mã đề cho kỳ thi");
                    return;
                }
                MessageBox.Show("Thêm mã đề cho kỳ thi thành công!");
                this.Close();
            }
        }

        private void CbbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbbMade.Items.Clear();

            int KhoiChon = int.Parse(this.cbbKhoi.SelectedItem.ToString());
            this.cbbMade.Items.Add(0);
            this.cbbMade.SelectedIndex = 0;
            using (var DB = new QTDataContext())
            {
                var ListMade = DB.MaDes.Where(idx => idx.Khoi == KhoiChon).Select(idx => idx.ID);
                var ListMadeco = DB.CT_KyThis.Where(idx => idx.IDKythi == ID && idx.Khoikythi == Khoi).Select(idx => idx.IDMade);
                ListMade = ListMade.Distinct();
                foreach (var vl in ListMade)
                {
                    if (!ListMadeco.Contains(vl))
                    {
                        this.cbbMade.Items.Add(vl);
                    }

                }
            }
            Chon = true;
        }

        public void LoadDulieu()
        {
            this.cbbKhoi.Items.Add(0);
            using (var DB = new QTDataContext())
            {
                var listKhoi = DB.MaDes.Select(idx => idx.Khoi);
                listKhoi = listKhoi.Distinct();
                foreach (var vl in listKhoi)
                {
                    this.cbbKhoi.Items.Add(vl);
                }
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
