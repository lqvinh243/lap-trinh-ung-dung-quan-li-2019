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
    public partial class fDanhsachdethi : Form
    {
        QTDataContext DB = new QTDataContext();
        public bool Chonmade = false, Choncauhoi = false;
        public int Khoi, IDMade;
        public fDanhsachdethi()
        {
            InitializeComponent();

            Load += LoadControl;
            Load += LoadData;

        }

        private void LoadData(object sender, EventArgs e)
        {
            this.Text = "Xem danh sách đề thi";
            LoadcbbKhoi();
        }

        public void LoadcbbKhoi()
        {
            this.cbbKhoi.Items.Add(10);
            this.cbbKhoi.Items.Add(11);
            this.cbbKhoi.Items.Add(12);
        }

        public void LoadDe()
        {
            if (this.cbbKhoi.SelectedIndex >= 0)
            {
                Khoi = int.Parse(this.cbbKhoi.SelectedItem.ToString());

                var dsDe = DB.MaDes.Where(idx => idx.Khoi == Khoi).Select(idx => new { IDMade = idx.ID, IDNguoitao = idx.IDNguoitao, Dokho = idx.Dokho });
                if (dsDe.Count() <= 0)
                {
                    MessageBox.Show("Không tồn tại mã đề nào của khối này", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                dgvDanhsachdethi.DataSource = dsDe;

            }

        }
        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();

            this.FormClosing += FDanhsachdethi_FormClosing;
            this.cbbKhoi.SelectedIndexChanged += CbbKhoi_SelectedIndexChanged;
            this.dgvDanhsachdethi.CellClick += DgvDanhsachdethi_CellClick;
            this.dgvDanhsachcauhoi.CellClick += DgvDanhsachcauhoi_CellClick;
            this.btnThoat.Click += BtnThoat_Click;

            //Mã đề
            this.btnXoamade.Click += BtnXoamade_Click;
            this.btnThemmade.Click += BtnThemmade_Click;

            //Câu hỏi
            this.btnThemcauhoi.Click += BtnThemcauhoi_Click;
            this.btnXoacauhoi.Click += BtnXoacauhoi_Click;
        }

        private void DgvDanhsachcauhoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
            {
                Choncauhoi = false;
                return;
            }
            Choncauhoi = true;
        }

        private void BtnXoacauhoi_Click(object sender, EventArgs e)
        {
            var checkMade = DB.CT_KetQuas.Where(idx => idx.IDMade == IDMade && idx.Khoi == Khoi).FirstOrDefault();
            if (checkMade != null)
            {
                MessageBox.Show("Câu hỏi này đã được sử dụng trong kỳ thi nên không thể xóa câu hỏi!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (Choncauhoi == false)
            {
                MessageBox.Show("Vui lòng chọn câu hỏi!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            int idy = dgvDanhsachcauhoi.SelectedCells[0].RowIndex;
            DataGridViewRow slr = dgvDanhsachcauhoi.Rows[idy];

            if(MessageBox.Show("Bạn có chắc chắn xóa câu hỏi này khỏi đề thi?","Xác nhận",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int Khoi = int.Parse(slr.Cells[1].Value.ToString());
                int IDCh = int.Parse(slr.Cells[0].Value.ToString());
                var CT_Made = DB.CT_MaDes.Where(idx => idx.Khoicauhoi == Khoi && idx.IDCauhoi == IDCh);
                DB.CT_MaDes.DeleteAllOnSubmit(CT_Made);
                try
                {
                    DB.SubmitChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa câu hỏi khỏi mã đề!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                MessageBox.Show("Xóa câu hỏi khỏi mã đề thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadCTMade();
                Choncauhoi = false;
                
            }
        }

        private void BtnThemcauhoi_Click(object sender, EventArgs e)
        {
            if (Chonmade == false)
            {
                MessageBox.Show("Vui lòng chọn mã đề cần thêm câu hỏi!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            var checkMade = DB.CT_KetQuas.Where(idx => idx.IDMade == IDMade && idx.Khoi == Khoi).FirstOrDefault();
            if (checkMade != null)
            {
                MessageBox.Show("Câu hỏi này đã được sử dụng trong kỳ thi nên không thể thao tác câu hỏi trên mã đề này!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            fThemcauhoimoi f = new fThemcauhoimoi(IDMade,Khoi);
            f.ShowDialog();
        }

        private void BtnThemmade_Click(object sender, EventArgs e)
        {
            fThemmademoi f = new fThemmademoi();
            f.ShowDialog();
            Reset();
            LoadDe();
        }

        private void BtnXoamade_Click(object sender, EventArgs e)
        {
            if (Chonmade == false)
            {
                MessageBox.Show("Vui lòng chọn mã đề cần xóa trước!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            var checkMade = DB.CT_ThamGias.Where(idx => idx.IDMade == IDMade && idx.Khoi == Khoi).FirstOrDefault();
            if (checkMade != null)
            {
                MessageBox.Show("Mã đề này đã được sử dụng trong kỳ thi nên không thể xóa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có chắn chắn xóa mã đề này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                var CT_Made = DB.CT_MaDes.Where(idx => idx.IDMade == IDMade && idx.Khoimade == Khoi);
                DB.CT_MaDes.DeleteAllOnSubmit(CT_Made);
                try
                {
                    DB.SubmitChanges();
                }
                catch (Exception) { MessageBox.Show("Không thể xóa chi tiết mã đề"); return; }

                var Made = DB.MaDes.Where(idx => idx.Khoi == Khoi && idx.ID == IDMade);
                DB.MaDes.DeleteAllOnSubmit(Made);
                try
                {
                    DB.SubmitChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa mã đề!");
                    return;
                }
                Reset();
                LoadDe();
            }
        }

        public void Reset()
        {
            Chonmade = false;
            Choncauhoi = false;
            this.dgvDanhsachcauhoi.DataSource = "";
            this.dgvDanhsachdethi.DataSource = "";
        }
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvDanhsachdethi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
            {
                Chonmade = false;
                return;
            }
            Chonmade = true;
            int idy = dgvDanhsachdethi.SelectedCells[0].RowIndex;
            DataGridViewRow slr = dgvDanhsachdethi.Rows[idy];

            IDMade = int.Parse(slr.Cells[0].Value.ToString());
            LoadCTMade();
            
        }

        public void LoadCTMade()
        {
            var listmd = DB.CT_MaDes.Where(idx => idx.IDMade == IDMade && idx.Khoimade == Khoi).Select(idx => new { IDCauhoi = idx.IDCauhoi, Khoi = idx.Khoicauhoi, Mota = idx.CT_CauHoi.CauHoi.Mota }).Distinct();
            //var listmd = DB.CT_MaDes.Join(DB.CT_CauHois, k1 => new { Khoi = k1.Khoicauhoi, ID = k1.IDCauhoi, IDDA = k1.IDDapan }, k2 => new { Khoi = k2.Khoi, ID =  k2.IDCauhoi, IDDA = k2.IDdapan }, (k1, k2) => new { CTMade = k1, CTCauhoi = k2 });
            dgvDanhsachcauhoi.DataSource = listmd;
            dgvDanhsachcauhoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDanhsachcauhoi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDanhsachcauhoi.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None).AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
            dgvDanhsachcauhoi.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void CbbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chonmade = false;

            this.dgvDanhsachdethi.DataSource = "";
            this.dgvDanhsachcauhoi.DataSource = "";
            LoadDe();
        }

        private void FDanhsachdethi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Dispose();
        }
    }
}
