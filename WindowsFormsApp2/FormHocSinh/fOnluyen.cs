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
    public partial class fOnluyen : Form
    {

        public HocSinh hs;
        public int i = 0, SlDe;
        public bool Chonde = false;
        public fOnluyen()
        {
            InitializeComponent();

            Load += LoadControl;

            Load += LoadData;
        }

        private void LoadData(object sender, EventArgs e)
        {
            using (var DB = new QTDataContext())
            {
                var linqHS = DB.HocSinhs.Where(id => id.ID == CurrentUser.UserID).SingleOrDefault();
                hs = linqHS;

                var Dethi = DB.MaDes.Where(Kh => Kh.Khoi == hs.Khoi);
                var Dokho = Dethi.Select(a => a.Dokho);
                Dokho = Dokho.Distinct();
                foreach (var dt in Dokho)
                {
                    this.cbbDokho.Items.Add(dt);
                }
            }
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.txtMade.Enabled = false;
            this.btnPre.Enabled = false;
            this.btnNext.Enabled = false;

            cbbDokho.SelectedIndexChanged += CbbDokho_SelectedIndexChanged;

            this.btnThoat.Click += BtnThoat_Click;
            this.btnNext.Click += BtnNext_Click;
            this.btnPre.Click += BtnPre_Click;
            this.btnBatdau.Click += BtnBatdau_Click;

            this.txtMade.TextChanged += TxtMade_TextChanged;
        }

        private void TxtMade_TextChanged(object sender, EventArgs e)
        {
            Chonde = true;
        }

        private void BtnBatdau_Click(object sender, EventArgs e)
        {
            if (Chonde == false)
            {
                MessageBox.Show("Vui lòng chọn mã đề để ôn luyện!", "Chọn mã đề", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn ôn luyện với bộ đề này?", "Xác nhận!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                OnLuyen ol = new OnLuyen();
                using (var DB = new QTDataContext())
                {

                    var linq = DB.OnLuyens.Where(it => it.IDHocsinh == hs.ID && it.Khoi == hs.Khoi && it.Lop == hs.Lop && it.Made == int.Parse(this.txtMade.Text) && it.Khoimade == hs.Khoi).OrderByDescending(p => p.Solan).FirstOrDefault();
                    if (linq != null)
                    {
                        ol.Solan = linq.Solan + 1;
                    }
                    else ol.Solan = 1;
                    ol.IDHocsinh = hs.ID;
                    ol.Khoi = hs.Khoi;
                    ol.Lop = hs.Lop;
                    ol.Made = int.Parse(this.txtMade.Text);
                    ol.Khoimade = hs.Khoi;
                    ol.Ngaylam = DateTime.Now;

                    DB.OnLuyens.InsertOnSubmit(ol);
                    DB.SubmitChanges();
                }
                fCTOnluyen frmCtOn = new fCTOnluyen(ol);
                frmCtOn.ShowDialog();
                this.Close();
            }
        }

        private void BtnPre_Click(object sender, EventArgs e)
        {
            i--;
            if (i == 0)
            {
                btnPre.Enabled = false;
            }
            btnNext.Enabled = true;
            LoadMade(cbbDokho.SelectedItem.ToString());
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            i++;
            if (i == SlDe)
            {
                btnNext.Enabled = false;
            }
            btnPre.Enabled = true;
            LoadMade(cbbDokho.SelectedItem.ToString());
        }

        public void LoadMade(string Dokho)
        {
            using (var DB = new QTDataContext())
            {
                var Dethi = DB.MaDes.Where(dokho => dokho.Dokho == Dokho && dokho.Khoi == hs.Khoi).ToList();
                var Made = Dethi.Select(Md => Md.ID);
                SlDe = Made.Count() - 1;
                if (SlDe == i)
                {
                    this.btnNext.Enabled = false;
                }
                else this.btnNext.Enabled = true;
                var S = Made.Skip(i).Take(1);
                foreach (var it in S)
                {
                    this.txtMade.Text = it.ToString();
                }
            }
        }
        private void CbbDokho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDokho.SelectedIndex >= 0)
            {
                i = 0;
                this.btnPre.Enabled = false;
                LoadMade(cbbDokho.SelectedItem.ToString());
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
