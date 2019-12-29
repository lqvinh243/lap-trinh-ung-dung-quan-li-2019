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
    public partial class fThaotaccauhoi : Form
    {

        public int ID, Khoi;
        public string Mota;
        public bool Dachon = false;
        public fThaotaccauhoi()
        {
            InitializeComponent();

            Load += LoadData;
            Load += LoadControl;


        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.btnThoat.Click += BtnThoat_Click;
            this.dgvCauhoi.CellClick += DgvCauhoi_CellClick;
            this.btnChinhsua.Click += BtnChinhsua_Click;
            this.btnCapnhat.Click += BtnCapnhat_Click;

        }

        private void BtnCapnhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn cập nhật ?", "Cập nhật", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var DB = new QTDataContext())
                {
                    var sd = DB.CauHois.Where(idx => idx.ID == ID && idx.Khoi == Khoi).SingleOrDefault();
                    sd.Mota = this.txtCauHoi.Text;
                    var Cha = DB.CT_CauHois.Where(idx => idx.IDCauhoi == ID && idx.Khoi == Khoi);

                    foreach (var vl in Cha)
                    {
                        if (vl.IDdapan == "A ")
                            vl.Mota = txtDAA.Text;
                        else if (vl.IDdapan == "B ")
                            vl.Mota = txtDAB.Text;
                        else if (vl.IDdapan == "C ")
                            vl.Mota = txtDAC.Text;
                        else if (vl.IDdapan == "D ")
                            vl.Mota = txtDAD.Text;
                        else if (vl.IDdapan == "E ")
                            vl.Mota = txtDAE.Text;
                    }
                    DB.SubmitChanges();
                    MessageBox.Show("Cập nhật dữ liệu câu hỏi thành công!");
                    LoadControltxt();
                    LoadDulieu();
                    Dachon = false;

                }
            }
        }

        private void BtnChinhsua_Click(object sender, EventArgs e)
        {
            if (Dachon == false)
            {
                MessageBox.Show("Vui lòng chọn câu hỏi cần chỉnh sửa!!", "Thông báo chọn", MessageBoxButtons.OK);
                return;
            }
            this.txtDAB.Enabled = true;
            this.txtDAE.Enabled = true;
            this.txtDAC.Enabled = true;
            this.txtDAD.Enabled = true;
            this.txtDAA.Enabled = true;
            this.txtCauHoi.Enabled = true;
            this.btnCapnhat.Enabled = true;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        public void LoadControltxt()
        {
            this.txtDAB.Enabled = false;
            this.txtDAE.Enabled = false;
            this.txtDAC.Enabled = false;
            this.txtDAD.Enabled = false;
            this.txtDAA.Enabled = false;
            this.txtCauHoi.Enabled = false;
            this.btnCapnhat.Enabled = false;
        }

        private void DgvCauhoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadControltxt();
            if (e.RowIndex > -1)
            {
                Dachon = true;
                ID = int.Parse(dgvCauhoi.Rows[e.RowIndex].Cells[0].Value.ToString());
                Khoi = int.Parse(dgvCauhoi.Rows[e.RowIndex].Cells[1].Value.ToString());
                using (var DB = new QTDataContext())
                {
                    var linqch = DB.CauHois.Where(a => a.ID == ID && a.Khoi == Khoi).SingleOrDefault();
                    this.txtCauHoi.Text = linqch.Mota;
                    var linq = DB.CT_CauHois.Where(idx => idx.IDCauhoi == ID && idx.Khoi == Khoi);
                    foreach (var text in linq)
                    {
                        if (text.IDdapan == "A ")
                            txtDAA.Text = text.Mota;
                        else if (text.IDdapan == "B ")
                            txtDAB.Text = text.Mota;
                        else if (text.IDdapan == "C ")
                            txtDAC.Text = text.Mota;
                        else if (text.IDdapan == "D ")
                            txtDAD.Text = text.Mota;
                        else if (text.IDdapan == "E ")
                            txtDAE.Text = text.Mota;
                    }
                    this.dgvCauhoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    this.dgvCauhoi.AutoResizeColumns();
                }
            }
        }

        private void LoadData(object sender, EventArgs e)
        {
            LoadDulieu();
        }

        public void LoadDulieu()
        {
            using (var DB = new QTDataContext())
            {
                var linq = DB.CauHois.Select(a => new { ID = a.ID, Khoi = a.Khoi, Cauhoi = a.Mota }).OrderBy(idx => idx.Khoi).ThenByDescending(idx => idx.ID);
                var p = linq.ToList();
                dgvCauhoi.DataSource = p;
                this.dgvCauhoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                this.dgvCauhoi.AutoResizeColumns();
            }
        }
    }
}
