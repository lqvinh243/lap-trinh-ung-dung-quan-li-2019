using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.FormHocSinh
{
    public partial class fKetquathi : Form
    {
        public int i = 0, lanthi;
        public string tkNgay = string.Empty;
        public fKetquathi()
        {
            InitializeComponent();

            Load += LoadControl;

            Load += LoadData;
        }

        private void LoadData(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.txtDiemso.Enabled = false;
            this.txtMade.Enabled = false;
            this.txtKythi.Enabled = false;
            this.txtNgaythi.Enabled = false;


            LoadKq(i);
        }

        private void LoadControl(object sender, EventArgs e)
        {
            //Load Nav
            this.btnNext.Click += BtnNext_Click;
            this.btnPre.Click += BtnPre_Click;

            this.btnThoat.Click += BtnThoat_Click;

            //Lọc theo ngày
            this.btnHuytimkiem.Click += BtnHuytimkiem_Click;
            this.btnTimkiem.Click += BtnTimkiem_Click;

            if (lanthi == 0)
            {
                btnNext.Enabled = false;
            }
            btnPre.Enabled = false;
            btnHuytimkiem.Enabled = false;
        }

        private void BtnTimkiem_Click(object sender, EventArgs e)
        {
            i = 0;
            this.btnPre.Enabled = false;
            this.btnHuytimkiem.Enabled = true;
            tkNgay = dtpNgaythi.Value.ToShortDateString();
            LoadKq(i);
        }

        private void BtnHuytimkiem_Click(object sender, EventArgs e)
        {
            if (tkNgay != string.Empty)
            {
                i = 0;
                tkNgay = string.Empty;
                LoadKq(i);
                btnHuytimkiem.Enabled = false;
                this.btnPre.Enabled = false;
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPre_Click(object sender, EventArgs e)
        {
            i--;
            LoadKq(i);
            if (i == 0)
            {
                btnPre.Enabled = false;
                btnNext.Enabled = true;
            }
            btnNext.Enabled = true;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            i++;
            LoadKq(i);
            if (i == lanthi)
            {
                btnPre.Enabled = true;
                btnNext.Enabled = false;
            }
            btnPre.Enabled = true;
        }

        

        public void LoadKq(int i)
        {
            IQueryable<CT_ThamGia> lqLoadDiem;
            using (var DB = new QTDataContext())
            {
                if (tkNgay != string.Empty)
                {
                    lqLoadDiem = DB.CT_ThamGias.Where(id => id.IDHocsinh == CurrentUser.UserID && id.Diem != null && id.CT_KyThi.KyThi.Ngaythi == DateTime.Parse(tkNgay));
                }
                else
                {
                    lqLoadDiem = DB.CT_ThamGias.Where(id => id.IDHocsinh == CurrentUser.UserID && id.Diem != null);
                }
                lanthi = lqLoadDiem.Count() - 1;
                if (lanthi <= 0)
                {
                    btnNext.Enabled = false;
                }
                else btnNext.Enabled = true;
                if (lanthi == -1)
                {
                    this.lbKythi.Text = "Không có kết quả thi nào khả dụng";
                    this.lbDiemso.Hide();
                    this.lbMade.Hide();
                    this.txtKythi.Hide();
                    this.txtDiemso.Hide();
                    this.txtMade.Hide();
                    this.txtNgaythi.Hide();
                    this.pnThanhngang.Hide();
                    btnNext.Hide();
                    btnPre.Hide();
                }
                else
                {
                    this.lbKythi.Text = "Kỳ thi";
                    this.lbKythi.Show();
                    this.lbDiemso.Show();
                    this.lbMade.Show();
                    this.txtKythi.Show();
                    this.txtDiemso.Show();
                    this.txtMade.Show();
                    this.txtNgaythi.Show();
                    this.pnThanhngang.Show();
                    btnNext.Show();
                    btnPre.Show();
                    var lMot = lqLoadDiem.Skip(i).Take(1);
                    foreach (var et in lMot)
                    {
                        this.txtDiemso.Text = string.Format("{0:0.0}", et.Diem);
                        this.txtMade.Text = et.IDMade.ToString();
                        this.txtKythi.Text = et.IDKythi.ToString();
                        this.txtNgaythi.Text = et.CT_KyThi.KyThi.Ngaythi.Value.ToShortDateString();
                    }
                }
            }
        }
    }
}
