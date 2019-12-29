using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.FormGiaoVien.Report;

namespace WindowsFormsApp2.FormGiaoVien
{
    public partial class fInDanhsach : Form
    {
        public int Loaichucnang;
        public fInDanhsach(int v)
        {
            InitializeComponent();

            Load += LoadControl;
            Load += LoadData;
            Loaichucnang = v;
        }

        private void LoadData(object sender, EventArgs e)
        {
            LoadKhoiXong();
            LoadIDXong();
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.btnThoat.Click += BtnThoat_Click;

            this.btnThucthi.Click += BtnThucthi_Click;

            this.cbbKhoikythi.SelectedIndexChanged += CbbKhoikythi_SelectedIndexChanged;
        }

        private void CbbKhoikythi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIDXong();
        }

        public void LoadIDXong()
        {
            this.cbbIDMade.Items.Clear();
            int Khoi = int.Parse(this.cbbKhoikythi.SelectedItem.ToString());
            IQueryable<int> ListMade;
            using (var DB = new QTDataContext())
            {
                if (Loaichucnang == 1)
                {
                    ListMade = DB.KyThis.Where(idx => idx.Ngaythi.Value < DateTime.Now && idx.Khoi == Khoi).OrderBy(idx => idx.ID).Select(idx => idx.ID);
                }
                else
                {
                    ListMade = DB.KyThis.Where(idx => idx.Khoi == Khoi).OrderBy(idx => idx.ID).Select(idx => idx.ID);
                }
                foreach (var vl in ListMade)
                {
                    this.cbbIDMade.Items.Add(vl);
                }
                this.cbbIDMade.SelectedIndex = 0;
            }
        }

        public void LoadKhoiXong()
        {
            using (var DB = new QTDataContext())
            {
                IQueryable<int> ListKhoi;
                if (Loaichucnang == 1)
                {
                    ListKhoi = DB.KyThis.Where(idx => idx.Ngaythi.Value < DateTime.Now).OrderBy(idx => idx.Khoi).Select(idx => idx.Khoi);
                    MessageBox.Show(ListKhoi.Count().ToString());
                }
                else
                {
                    ListKhoi = DB.KyThis.OrderBy(idx => idx.Khoi).Select(idx => idx.Khoi);
                }
                ListKhoi = ListKhoi.Distinct();
                foreach (var vl in ListKhoi)
                {
                    this.cbbKhoikythi.Items.Add(vl);
                }
            }
            this.cbbKhoikythi.SelectedIndex = 0;
        }
        private void BtnThucthi_Click(object sender, EventArgs e)
        {
            int Khoichon = int.Parse(this.cbbKhoikythi.SelectedItem.ToString());
            int Madechon = int.Parse(this.cbbIDMade.SelectedItem.ToString());

            if (MessageBox.Show("In thông tin kỳ thi này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Loaichucnang == 0)
                {
                    RpThongtin rp = new RpThongtin();
                    rp.SetParameterValue("ID", Madechon);
                    rp.SetParameterValue("Khoi", Khoichon);
                    rp.SetParameterValue("Ngaytao", DateTime.Now.ToShortDateString());
                    this.rpView.ReportSource = rp;
                    
                }
                else
                {
                    RPKetqua rp = new RPKetqua();
                    rp.SetParameterValue("ID", Madechon);
                    rp.SetParameterValue("Khoi", Khoichon);
                    rp.SetParameterValue("Ngaytao", DateTime.Now.ToShortDateString());
                    this.rpView.ReportSource = rp;
                }
            }

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
