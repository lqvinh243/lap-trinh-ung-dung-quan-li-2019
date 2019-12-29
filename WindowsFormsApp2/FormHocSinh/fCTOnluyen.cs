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
    public partial class fCTOnluyen : Form
    {
        int Bode, Khoi;
        public int i = 0, SlCauhoi;
        int IDCHHientai;
        List<CT_MaDe> CTDe;
        List<string> currenIDDapan = new List<string>();
        Dictionary<(string, int), int> curr = new Dictionary<(string, int), int>();
        Dictionary<(int, int), bool> TLDung = new Dictionary<(int, int), bool>();
        OnLuyen Ol;
        bool Loi = false;
        public fCTOnluyen(OnLuyen ol)
        {
            InitializeComponent();

            
            Ol = ol;
            Khoi = ol.Khoi;
            Bode = ol.Made;
            Load += LoadData;
            Load += LoadControl;

            this.ControlBox = false;
            this.ShowInTaskbar = false;
            this.lbMotacauhoi.Height = 100;
            this.clbDapan.HorizontalScrollbar = true;
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.btnPre.Click += BtnPre_Click;
            this.btnNext.Click += BtnNext_Click;
            this.btnHoanthanh.Click += BtnHoanthanh_Click;
            this.btnGoiy.Click += BtnGoiy_Click;

            this.FormClosing += FCTOnluyen_FormClosing;
        }

        private void BtnGoiy_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn nhận gợi ý đáp án cho câu hỏi này?","Gợi ý đáp án",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var DB = new QTDataContext())
                {
                    var p = DB.CT_CauHois.Where(idx => idx.IDCauhoi == IDCHHientai && idx.Khoi == Khoi && idx.Dung == true);
                    foreach(var vl in p)
                    {
                        this.lbGoiydapan.Text += vl.IDdapan;
                    }
                }
                this.btnGoiy.Enabled = false;
            }
        }

        private void FCTOnluyen_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChangeTraLoi();
            TinhDiem();
        }

        private void BtnHoanthanh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn hoàn thiện bài ôn luyện?", "Xác nhận hoàn thành", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.lbGoiydapan.Text = "";
            this.btnGoiy.Enabled = true;
            ChangeTraLoi();
            this.clbDapan.Items.Clear();
            i++;
            this.curr.Clear();
            LoadCauhoi(i);
            if (i == SlCauhoi)
            {
                this.btnNext.Enabled = false;
            }
            this.btnPre.Enabled = true;
        }

        private void BtnPre_Click(object sender, EventArgs e)
        {
            this.lbGoiydapan.Text = "";
            this.btnGoiy.Enabled = true;
            ChangeTraLoi();
            this.clbDapan.Items.Clear();
            i--;
            this.curr.Clear();
            LoadCauhoi(i);

            if (i == 0)
            {
                this.btnPre.Enabled = false;
            }
            this.btnNext.Enabled = true;
        }
        public void ChangeTraLoi()
        {
            using (var DB = new QTDataContext())
            {
                var LoadCT = DB.CT_OnLuyens.Where(idx => idx.Solan == Ol.Solan && idx.IDHocsinh == Ol.IDHocsinh && idx.Lop == Ol.Lop && idx.Khoi == Ol.Khoi && idx.Made == Ol.Made && idx.Khoimade == Ol.Khoimade && idx.IDCauhoi == IDCHHientai && idx.IDKhoicauhoi == Khoi);
                foreach (Object item in this.clbDapan.CheckedItems)
                {
                    int indx = this.clbDapan.Items.IndexOf(item);
                    (string index, int b) = curr.Keys.ElementAt(indx);
                    curr[(index, b)] = 0;
                    var Tl = LoadCT.Where(idx => idx.IDDapan == index).FirstOrDefault();
                    Tl.Traloi = true;
                    DB.SubmitChanges();
                }
                
                for (int i = 0; i < curr.Count(); i++)
                {
                    if (curr[curr.Keys.ElementAt(i)] == 1)
                    {
                        var Tl = LoadCT.Where(idx => idx.IDDapan == curr.Keys.ElementAt(i).Item1 && idx.Khoi == curr.Keys.ElementAt(i).Item2).FirstOrDefault();
                        Tl.Traloi = false;
                        DB.SubmitChanges();
                    }
                }
                var Dung = DB.CT_CauHois.Where(idx => idx.IDCauhoi == IDCHHientai && idx.Khoi == Khoi && idx.Dung == true).Select(idx => idx.IDdapan).ToList();
                var Luachon = LoadCT.Where(idx => idx.Traloi == true).Select(idx => idx.IDDapan).ToList();
                int slCaudung = Dung.Count();
                int slLuachondung = Luachon.Count();
                if (slCaudung == slLuachondung)
                {
                    int check = 0;
                    for (int i = 0; i < Luachon.Count(); i++)
                    {
                        if (Dung.Contains(Luachon[i]))
                        {
                            check++;
                        }
                    }
                    if (check == slCaudung)
                    {
                        TLDung[(IDCHHientai, Khoi)] = true;
                    }
                    else TLDung[(IDCHHientai, Khoi)] = false;
                }
            }
        }
        private void LoadData(object sender, EventArgs e)
        {
            InsertCH();
            this.lbGoiydapan.Text = "";
            if (Loi == true)
            {
                this.Close();
                return;
            }
            LoadCauhoi(i);

            this.txtNgaylam.Text = DateTime.Now.ToShortDateString();
            this.txtMade.Text = Bode.ToString();
        }

        public void InsertCH()
        {
            using (var DB = new QTDataContext())
            {
                var lqCTDe = DB.CT_MaDes.Where(id => id.IDMade == Bode && id.Khoicauhoi == Khoi);
                if (lqCTDe.Count() <= 0)
                {
                    MessageBox.Show("Có lỗi khi lấy đề vui lòng báo cho người có thẩm quyền!");
                    Loi = true;
                }
                CTDe = lqCTDe.ToList();
                foreach (var vl in CTDe)
                {
                    CT_OnLuyen ctol = new CT_OnLuyen();
                    ctol.Solan = Ol.Solan;
                    ctol.IDHocsinh = Ol.IDHocsinh;
                    ctol.Lop = Ol.Lop;
                    ctol.Khoi = Ol.Khoi;
                    ctol.Made = Ol.Made;
                    ctol.Khoimade = Ol.Khoimade;
                    ctol.IDCauhoi = vl.IDCauhoi;
                    ctol.IDKhoicauhoi = vl.Khoicauhoi;
                    ctol.IDDapan = vl.IDDapan;
                    ctol.Traloi = false;
                    DB.CT_OnLuyens.InsertOnSubmit(ctol);
                    DB.SubmitChanges();
                    if (!TLDung.ContainsKey((vl.IDCauhoi, vl.Khoicauhoi)))
                    {
                        TLDung.Add((vl.IDCauhoi, vl.Khoicauhoi), false);
                    }
                }
            }
        }

        public void TinhDiem()
        {
            int Sodapan = 0;
            using (var DB = new QTDataContext())
            {
                var UpdateDiem = DB.OnLuyens.Where(idx => idx.Solan == Ol.Solan && idx.IDHocsinh == Ol.IDHocsinh && idx.Khoi == Ol.Khoi && idx.Made == Ol.Made && idx.Khoimade == Ol.Khoimade).SingleOrDefault();
                foreach (var vl in TLDung)
                {
                    if (vl.Value == true)
                    {
                        Sodapan++;
                    }
                }
                UpdateDiem.Diem = 10 / ((float)SlCauhoi) * (float)Sodapan;
                UpdateDiem.Xong = DateTime.Now;
                DB.SubmitChanges();
            }
        }

        public void LoadCauhoi(int i)
        {
            using (var DB = new QTDataContext())
            {
                var ListCh = DB.CT_MaDes.Where(a => a.IDMade == Bode && a.Khoimade == Khoi).Select(gaa => gaa.CT_CauHoi).Select(gb => gb.IDCauhoi);
                var LoadCT = DB.CT_OnLuyens.Where(idx => idx.Solan == Ol.Solan && idx.IDHocsinh == Ol.IDHocsinh && idx.Lop == Ol.Lop && idx.Khoi == Ol.Khoi && idx.Made == Ol.Made && idx.Khoimade == Ol.Khoimade);

                ListCh = ListCh.Distinct();
                SlCauhoi = ListCh.Count();
                if (SlCauhoi - 1 == i)
                {
                    this.btnNext.Enabled = false;
                }
                var ListIDCH = LoadCT.Select(idx => idx.IDCauhoi).Distinct();

                var LayCH = ListIDCH.Skip(i).Take(1).FirstOrDefault();
                this.label2.Text = String.Format("{0}/{1}", i + 1, SlCauhoi);
                IDCHHientai = LayCH;
                var ctCH = DB.CT_CauHois.Where(idx => idx.IDCauhoi == IDCHHientai && idx.Khoi == Khoi);
                this.lbMotacauhoi.Text = IDCHHientai.ToString()+ " "+  ctCH.Select(idx => idx.CauHoi.Mota).FirstOrDefault().ToString();
                foreach (var tt in ctCH)
                {
                    currenIDDapan.Add(tt.IDdapan);
                    curr.Add((tt.IDdapan, tt.Khoi), 1);

                    var check = LoadCT.Where(idx => idx.IDCauhoi == LayCH && idx.Khoi == Khoi && idx.IDDapan == tt.IDdapan).FirstOrDefault();
                    check.Motacauhoi = DB.CauHois.Where(idx => idx.ID == tt.IDCauhoi && idx.Khoi == tt.Khoi).Select(idx => idx.Mota).SingleOrDefault();
                    check.Motadapan = tt.Mota;
                    DB.SubmitChanges();
                    this.clbDapan.Items.Add(tt.IDdapan.ToString()+". "+tt.Mota, (bool)check.Traloi);
                }
            }
        }
        
    }
}
