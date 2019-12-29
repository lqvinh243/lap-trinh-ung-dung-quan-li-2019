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
    public partial class fKetquaOnluyen : Form
    {
        public int i = 0, toida;
        public string Ngaythi = string.Empty;
        public fKetquaOnluyen()
        {
            InitializeComponent();

            Load += LoadControl;
            Load += LoadData;
        }

        private void LoadData(object sender, EventArgs e)
        {
            LoadDL(i);
        }

        public void LoadDL(int i)
        {
            IQueryable<OnLuyen> onLuyens;
            using(var DB = new QTDataContext())
            {
                if (!string.IsNullOrWhiteSpace(Ngaythi))
                {
                    onLuyens = DB.OnLuyens.Where(idx => idx.IDHocsinh == CurrentUser.UserID && idx.Ngaylam.Date== DateTime.Parse(Ngaythi) && idx.Diem != null);
                }
                else
                {
                    onLuyens = DB.OnLuyens.Where(idx => idx.IDHocsinh == CurrentUser.UserID && idx.Diem != null);
                }

                toida = onLuyens.Count() - 1;
                if (toida < 0)
                {
                    this.lbTong.Text = "Không có kết quả ôn luyện nào khả dụng";
                    this.lbTong.Left = (this.panel1.Width - lbTong.Size.Width) / 2;
                    this.txtDiemso.Clear();
                    this.txtMade.Clear();
                    this.txtNgay.Clear();
                    this.txtThoigian.Clear();
                    this.txtSolan.Clear();
                    this.txtThoigianlam.Clear();
                    this.txtThoigianra.Clear();
                    return;
                }

                if (toida <= 0)
                {
                    btnNext.Enabled = false;
                }
                else btnNext.Enabled = true;
                
                this.lbTong.Text = "";
                var layMot = onLuyens.Skip(i).Take(1);
                foreach (var vl in layMot)
                {
                    this.txtDiemso.Text = vl.Diem.ToString();
                    this.txtMade.Text = vl.Made.ToString();
                    this.txtNgay.Text = vl.Ngaylam.ToShortDateString();
                    this.txtThoigian.Text = vl.Ngaylam.ToShortTimeString();
                    this.txtSolan.Text = vl.Solan.ToString();
                    this.txtThoigianra.Text = vl.Xong.Value.ToShortTimeString();
                    TimeSpan tp = (DateTime.Parse(vl.Xong.ToString())-vl.Ngaylam);
                    if (tp.Hours == 0)
                    {
                        this.txtThoigianlam.Text = string.Format("{0} phút", tp.Minutes);
                    }
                    else this.txtThoigianlam.Text = string.Format("{0} giờ {1} phút", tp.Hours, tp.Minutes);
                }

            }
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.btnPre.Enabled = false;
            this.txtDiemso.Enabled = false;
            this.txtMade.Enabled = false;
            this.txtNgay.Enabled = false;
            this.txtSolan.Enabled = false;
            this.txtThoigian.Enabled = false;
            this.txtThoigianra.Enabled = false;
            this.txtThoigianlam.Enabled = false;


            this.btnThoat.Click += BtnThoat_Click;
            this.btnNext.Click += BtnNext_Click;
            this.btnPre.Click += BtnPre_Click;
            this.btnTimkiem.Click += BtnTimkiem_Click;
            this.btnHuyloc.Click += BtnHuyloc_Click;

        }

        private void BtnHuyloc_Click(object sender, EventArgs e)
        {
            i = 0;
            Ngaythi = string.Empty;
            LoadDL(i);
            this.dtpThoigian.Value = DateTime.Now;
        }

        private void BtnTimkiem_Click(object sender, EventArgs e)
        {
            i = 0;
            Ngaythi = this.dtpThoigian.Value.ToShortDateString();
            this.btnPre.Enabled = false;
            this.btnNext.Enabled = true;
            LoadDL(i);
        }


        private void BtnPre_Click(object sender, EventArgs e)
        {
            i--;
            LoadDL(i);
            if (i == 0)
            {
                this.btnPre.Enabled = false;
            }
            this.btnNext.Enabled = true;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            i++;
            LoadDL(i);
            if (i == toida)
            {
                this.btnNext.Enabled = false;
            }
            this.btnPre.Enabled = true;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
