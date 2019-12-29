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
    public partial class fCTKythi : Form
    {
        protected CT_ThamGia curr;
        public int i = 0, slCauhoi;
        public int KhoiMade, IDMade, currIDCH, Khoich;
        public int Diemso;
        public int Sodapan;
        bool Loi = false;
        int Sophut, Giay;
        Dictionary<(string, int), bool> DicIDDA = new Dictionary<(string, int), bool>();
        Dictionary<(int, int), bool> TLDung = new Dictionary<(int, int), bool>();
        public fCTKythi(CT_ThamGia cttg, int thoigian)
        {
            InitializeComponent();

            Load += LoadControl;

            Load += LoadData;

            curr = cttg;
            KhoiMade = cttg.Khoidethi;
            IDMade = cttg.IDMade;
            Sophut = thoigian;
            Giay = Sophut * 60;
            this.lbMotacauhoi.Height = 100;
            this.clbDapan.HorizontalScrollbar = true;
            if (Sophut > 0)
            {
                Load += LoadThoigian;
                this.timingthi.Start();
            }
            else
            {
                this.lbThoigian.Hide();
            }

        }

        private void LoadThoigian(object sender, EventArgs e)
        {
            this.timingthi.Tick += Timingthi_Tick;
        }

        private void Timingthi_Tick(object sender, EventArgs e)
        {
            Giay--;
            this.timingthi.Enabled = true;
            this.lbPhut.Text = (Giay / 60).ToString() + " phút";
            if (Giay == 0)
            {
                this.lbPhut.Text = "Hết giờ";
                MessageBox.Show("Bạn đã hết thời gian làm bài", "Hết thời gian", MessageBoxButtons.OK);
                this.timingthi.Stop();
                this.Close();
            }

        }

        public void LoadCTThi()
        {
            using (var DB = new QTDataContext())
            {
                var lqCTDe = DB.CT_MaDes.Where(idx => idx.IDMade == curr.IDMade && idx.Khoimade == curr.Khoidethi);
                if (lqCTDe.Count() <= 0)
                {
                    MessageBox.Show("Có lỗi khi lấy đề vui lòng báo cho người có thẩm quyền!");
                    Loi = true;
                    return;
                }
                foreach (var vl in lqCTDe)
                {
                    CT_KetQua ct = new CT_KetQua();
                    ct.IDKythi = curr.IDKythi;
                    ct.Khoikythi = curr.Khoikythi;
                    ct.IDMade = curr.IDMade;
                    ct.Khoidethi = curr.Khoidethi;
                    ct.IDHocsinh = curr.IDHocsinh;
                    ct.Lop = curr.Lop;
                    ct.Khoi = curr.Khoi;
                    ct.IDCauhoi = vl.IDCauhoi;
                    ct.IDDapan = vl.IDDapan;
                    ct.Khoicauhoi = vl.Khoicauhoi;
                    ct.Motadapan = vl.CT_CauHoi.Mota;
                    ct.Motacauhoi = vl.CT_CauHoi.CauHoi.Mota;
                    ct.Traloi = false;

                    DB.CT_KetQuas.InsertOnSubmit(ct);
                    DB.SubmitChanges();
                    if (!TLDung.ContainsKey((vl.IDCauhoi, vl.Khoicauhoi)))
                    {
                        TLDung.Add((vl.IDCauhoi, vl.Khoicauhoi), false);
                    }
                }
            }
        }

        public void LuuDapan()
        {

            try
            {
                using (var DB = new QTDataContext())
                {
                    var chHT = DB.CT_KetQuas.Where(idx => idx.IDKythi == curr.IDKythi && idx.Khoikythi == curr.Khoikythi && idx.IDMade == curr.IDMade && idx.Khoidethi == curr.Khoidethi && idx.IDHocsinh == curr.IDHocsinh && idx.Lop == curr.Lop && idx.Khoi == curr.Khoi && idx.IDCauhoi == currIDCH && idx.Khoicauhoi == Khoich);
                    foreach (object obj in this.clbDapan.CheckedItems)
                    {
                        int indx = this.clbDapan.Items.IndexOf(obj);
                        (string ID, int Khoi) = DicIDDA.Keys.ElementAt(indx);
                        DicIDDA[DicIDDA.Keys.ElementAt(indx)] = true;
                        var Tl = chHT.Where(idx => idx.IDDapan == ID).SingleOrDefault();
                        Tl.Traloi = true;
                        DB.SubmitChanges();
                    }

                    for (int i = 0; i < DicIDDA.Count(); i++)
                    {
                        (string ID, int Khoi) = DicIDDA.Keys.ElementAt(i);
                        if (DicIDDA[(ID, Khoi)] == false)
                        {
                            var Tl = chHT.Where(idx => idx.IDDapan == ID).SingleOrDefault();
                            Tl.Traloi = false;
                            DB.SubmitChanges();
                        }
                    }
                    var Dung = DB.CT_CauHois.Where(idx => idx.IDCauhoi == currIDCH && idx.Khoi == Khoich && idx.Dung == true).Select(idx => idx.IDdapan).ToList();
                    var Luachon = chHT.Where(idx => idx.Traloi == true).Select(idx => idx.IDDapan).ToList();
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
                            TLDung[(currIDCH, Khoich)] = true;
                        }
                        else TLDung[(currIDCH, Khoich)] = false;
                    }
                }

            }
            catch (Exception)
            {

            }
        }


        public void LoadCauhoi(int i)
        {
            this.clbDapan.Items.Clear();
            DicIDDA.Clear();
            using (var DB = new QTDataContext())
            {
                var LoadTable = DB.CT_KetQuas.Where(idx => idx.IDKythi == curr.IDKythi && idx.Khoikythi == curr.Khoikythi && idx.IDMade == curr.IDMade && idx.Khoidethi == curr.Khoidethi && idx.IDHocsinh == curr.IDHocsinh && idx.Lop == curr.Lop && idx.Khoi == curr.Khoi);
                var idCH = LoadTable.Select(idx => new { ID = idx.IDCauhoi, khoi = idx.Khoicauhoi }).Distinct();

                slCauhoi = idCH.Count() - 1;

                if (slCauhoi == i)
                {
                    btnNext.Enabled = false;
                }
                else btnNext.Enabled = true;

                var LoadCH = idCH.Skip(i).Take(1).SingleOrDefault();


                currIDCH = LoadCH.ID;
                Khoich = LoadCH.khoi;
                string Mota = DB.CauHois.Where(idx => idx.ID == LoadCH.ID && idx.Khoi == LoadCH.khoi).Select(idx => idx.Mota).SingleOrDefault();
                this.lbMotacauhoi.Text = Mota;

                var IDDapan = DB.CT_CauHois.Where(idx => idx.IDCauhoi == LoadCH.ID && idx.Khoi == LoadCH.khoi);
                try
                {
                    foreach (var vl in IDDapan)
                    {
                        string MotaDapan = vl.Mota;
                        var check = LoadTable.Where(idx => idx.IDCauhoi == LoadCH.ID && idx.Khoicauhoi == LoadCH.khoi && idx.IDDapan == vl.IDdapan).Select(idx => idx.Traloi).SingleOrDefault();

                        DicIDDA.Add((vl.IDdapan, vl.Khoi), false);
                        this.clbDapan.Items.Add(MotaDapan, (bool)check);
                    }
                }
                catch (Exception)
                {

                }

            }
        }
        private void LoadControl(object sender, EventArgs e)
        {
            this.btnPre.Enabled = false;
            this.CenterToParent();
            this.btnNext.Click += BtnNext_Click;
            this.btnPre.Click += BtnPre_Click;
            this.btnHoanthanh.Click += BtnHoanthanh_Click;
            this.FormClosing += FCTKythi_FormClosing;
        }

        private void FCTKythi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Loi == true)
                return;
            LuuDapan();
            TinhDiem();
        }

        public void TinhDiem()
        {
            using (var DB = new QTDataContext())
            {
                var UpdateDiem = DB.CT_ThamGias.Where(idx => idx.IDKythi == curr.IDKythi && idx.Khoikythi == curr.Khoikythi && idx.IDMade == curr.IDMade && idx.Khoidethi == curr.Khoidethi && idx.IDHocsinh == curr.IDHocsinh && idx.Lop == curr.Lop && idx.Khoi == curr.Khoi).SingleOrDefault();
                foreach (var vl in TLDung)
                {
                    if (vl.Value == true)
                    {
                        Sodapan++;
                    }
                }
                UpdateDiem.Diem = 10 / ((float)slCauhoi + 1) * (float)Sodapan;
                DB.SubmitChanges();
            }
        }
        private void BtnHoanthanh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPre_Click(object sender, EventArgs e)
        {
            i--;
            if (i == 0)
            {
                btnPre.Enabled = false;
            }
            LuuDapan();
            LoadCauhoi(i);
            btnNext.Enabled = true;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            i++;
            if (i == slCauhoi)
            {
                btnNext.Enabled = false;
            }
            LuuDapan();
            LoadCauhoi(i);
            btnPre.Enabled = true;
        }

        private void LoadData(object sender, EventArgs e)
        {
            LoadCTThi();
            if (Loi == true)
            {
                this.Close();
                return;
            }
            LoadCauhoi(i);
        }
    }
}
