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
    public partial class fLichthi : Form
    {
        public int i = 0, tongkythi;
        List<KyThi> l;
        public int Baithi = 1;
        public string Ngaythi = string.Empty;
        public fLichthi()
        {
            InitializeComponent();

            Load += LoadData;
            Load += LoadControl;
        }

        private void LoadData(object sender, EventArgs e)
        {
            LoadKythi(i);
        }

        public void LoadKythi(int i)
        {

            using (var DB = new QTDataContext())
            {

                var lqSokythi = DB.CT_ThamGias.Where(a => a.IDHocsinh == CurrentUser.UserID);
                if (lqSokythi.Count() > 0)
                {
                    if (string.IsNullOrEmpty(Ngaythi))
                    {
                        var lqKythi = DB.KyThis.Select(a => a.CT_KyThis.Select(b => b.KyThi.CT_KyThis.Select(g => g.CT_ThamGias.Where(z => z.IDHocsinh == CurrentUser.UserID)))).ToList();
                        var q = DB.CT_ThamGias.Where(a => a.IDHocsinh == CurrentUser.UserID).Select(p => p.CT_KyThi.KyThi);
                        l = q.ToList();
                        var group = l.GroupBy(p => p.Ngaythi);
                        tongkythi = group.Count();
                        if (tongkythi - 1 == i)
                        {
                            this.btnNext.Enabled = false;
                        }
                        else this.btnNext.Enabled = true;
                        var h = group.Skip(i).Take(1);
                       
                        this.lbTongkythi.Text = "Có tất cả " + tongkythi + " kỳ thi!";
                        foreach (var t in h)
                        {
                            this.txtNgaythi.Text = t.Key.Value.ToShortDateString();
                            this.lbTongkythi.Text = "Vào ngày này bạn có " + t.Count().ToString() + " bài thi!";
                        }
                    }
                    else
                    {
                        var lqKythi = DB.CT_ThamGias.Where(idx => idx.IDHocsinh == CurrentUser.UserID && idx.CT_KyThi.KyThi.Ngaythi == DateTime.Parse(Ngaythi));
                        this.txtNgaythi.Text = dtpNgaythi.Value.ToShortDateString();
                        this.lbTongkythi.Text = "Vào ngày này bạn có " + lqKythi.Count().ToString() + " bài thi!";
                        this.btnNext.Enabled = false;
                        this.btnPre.Enabled = false;
                    }
                }
                else
                {
                    this.lbTongkythi.Text = "Hiện tại không có kỳ thi nào của bạn!";
                }
            }
        }
        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.txtNgaythi.Enabled = false;
            this.btnPre.Enabled = false;


            this.btnThoat.Click += BtnThoat_Click;
            this.btnNext.Click += BtnNext_Click;
            this.btnPre.Click += BtnPre_Click;
            this.btnTimkiem.Click += BtnTimkiem_Click;
            this.btnHuyboloc.Click += BtnHuyboloc_Click;
        }

        private void BtnHuyboloc_Click(object sender, EventArgs e)
        {
            i = 0;
            Ngaythi = string.Empty;
            dtpNgaythi.Value = DateTime.Now;
            this.btnPre.Enabled = false;
            LoadKythi(i);
        }

        private void BtnTimkiem_Click(object sender, EventArgs e)
        {
            i = 0;
            Ngaythi = this.dtpNgaythi.Value.ToShortDateString();
            this.btnPre.Enabled = false;
            this.btnNext.Enabled = true;
            LoadKythi(i);
        }

        private void BtnPre_Click(object sender, EventArgs e)
        {
            i--;
            LoadKythi(i);
            if (i == 0)
            {
                btnPre.Enabled = false;
                btnNext.Enabled = true;
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            i++;
            LoadKythi(i);
            if (i == tongkythi - 1)
            {
                btnNext.Enabled = false;
                btnPre.Enabled = true;
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
