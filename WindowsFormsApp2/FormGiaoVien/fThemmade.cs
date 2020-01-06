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
        QTDataContext DB = new QTDataContext();
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
            LoadDanhsachde();
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.txtKythi.Enabled = false;
            this.txtKhoi.Enabled = false;

            //Thoát
            this.btnThoat.Click += BtnThoat_Click;
            //Chọn mã đề
            this.dgvMade.CellClick += DgvMade_CellClick;

            //Thêm
            this.btnThemmade.Click += BtnThemmade_Click;


            this.FormClosing += FThemmade_FormClosing;
        }

        private void FThemmade_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Dispose();
        }

        private void DgvMade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Chon = true;
            }
            else Chon = false;
        }

        private void BtnThemmade_Click(object sender, EventArgs e)
        {

            if (Chon == false)
            {
                this.lbLoi.Text = "Vui lòng chọn mã đề!";
                lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                return;
            }

            else if (MessageBox.Show("Bạn có chắc chắn thêm mã đề này?", "Xác nhận thêm", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            using (var DB = new QTDataContext())
            {
                int idy = dgvMade.SelectedCells[0].RowIndex;
                DataGridViewRow slr = dgvMade.Rows[idy];
                int IDmade = int.Parse(slr.Cells[0].Value.ToString());
                var Made = DB.CT_MaDes.Where(idx => idx.Khoimade == Khoi && idx.IDMade == IDmade);
                if (Made.Count() <= 0)
                {
                    MessageBox.Show("Không thể thêm mã đề này vì mã đề chưa tồn tại câu hỏi nào!!", "Xác nhận");
                    return;
                }
                var Madetontai = DB.CT_KyThis.Where(idx => idx.IDMade == IDmade && idx.Khoidethi == Khoi && idx.IDKythi == ID && idx.Khoikythi == Khoi).SingleOrDefault();
                if (Madetontai != null)
                {
                    MessageBox.Show("Kỳ thi đã tồn tại mà đề này!!");
                    return;
                }
                CT_KyThi ct = new CT_KyThi();
                ct.IDKythi = ID;
                ct.Khoikythi = Khoi;
                ct.Khoidethi = Khoi;
                ct.IDMade = IDmade;
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

        public void LoadDanhsachde()
        {
            var ListMade = DB.MaDes.Where(idx => idx.Khoi == Khoi).Select(idx=>new { IDMade = idx.ID }).ToList();
            var ListMadeco = DB.CT_KyThis.Where(idx => idx.IDKythi == ID && idx.Khoikythi == Khoi).Select(idx => new { IDMade = idx.IDMade });
            dgvMade.DataSource = ListMade;
            this.dgvMade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
