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
    public partial class fThemcauhoimoi : Form
    {
        QTDataContext DB = new QTDataContext();
        public int Khoichon;
        public int IDmade, Khoi;
        public bool Choncauhoi = false;
        public int IDch;
        public fThemcauhoimoi(int iDMade, int khoi)
        {
            InitializeComponent();

            Load += LoadControl;
            Load += LoadData;

            IDmade = iDMade;
            Khoi = khoi;
        }

        private void LoadData(object sender, EventArgs e)
        {
            LoadKhoi();
            this.txtIDmade.Text = IDmade.ToString();
            this.txtKhoi.Text = Khoi.ToString();
        }

        public void LoadKhoi()
        {
            this.cbbKhoi.Items.Add(10);
            this.cbbKhoi.Items.Add(11);
            this.cbbKhoi.Items.Add(12);
        }

        public void LoadCauhoi()
        {
            var lq = DB.CauHois.Where(idx => idx.Khoi == Khoichon);
            if (lq.Count() <= 0)
            {
                MessageBox.Show("Khối này hiện không có câu hỏi nào!");
                return;
            }
            var Listch = lq.Select(idx => new { IDCauhoi = idx.ID, Mota = idx.Mota, IDNguoitao = idx.IDNguoitao,DoKho = idx.Dokho });
            this.dgvCauhoi.DataSource = Listch;
            dgvCauhoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCauhoi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCauhoi.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None).AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
            dgvCauhoi.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.txtKhoi.Enabled = false;
            this.txtIDmade.Enabled = false;
            this.FormClosing += FThemcauhoimoi_FormClosing;
            this.btnThoat.Click += BtnThoat_Click;
            this.cbbKhoi.SelectedIndexChanged += CbbKhoi_SelectedIndexChanged;

            this.dgvCauhoi.CellClick += DgvCauhoi_CellClick;

            this.btnThemcauhoi.Click += BtnThemcauhoi_Click;
            this.btnChitiet.Click += BtnChitiet_Click;


        }

        private void BtnChitiet_Click(object sender, EventArgs e)
        {
            if (Choncauhoi == false)
            {
                MessageBox.Show("Vui lòng chọn câu hỏi trước!!");
                return;
            }

            fChitietcauhoi f = new fChitietcauhoi(IDch, Khoichon);
            f.ShowDialog();

        }

        private void BtnThemcauhoi_Click(object sender, EventArgs e)
        {
            if (Choncauhoi == false)
            {
                MessageBox.Show("Vui lòng chọn câu hỏi để thêm vào mã đề!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            var check = DB.CT_MaDes.Where(idx => idx.Khoimade == Khoi && idx.IDMade == IDmade && idx.Khoicauhoi == Khoichon && idx.IDCauhoi == IDch).FirstOrDefault();
            if (Khoichon != Khoi)
            {
                if (MessageBox.Show("Khối câu hỏi khác khối đề thi bạn có chắc chắn thêm?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if (check != null)
            {
                MessageBox.Show("Câu hỏi này đã tồn tại trong mã đề!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (Khoichon != Khoi)
            {
                if (MessageBox.Show("Khối câu hỏi khác khối đề thi bạn có chắc chắn thêm?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            var ctch = DB.CT_CauHois.Where(idx => idx.Khoi == Khoichon && idx.IDCauhoi == IDch);

            List<CT_MaDe> list = new List<CT_MaDe>();
            
            foreach(var vl in ctch)
            {
                CT_MaDe ctmd = new CT_MaDe();
                ctmd.IDMade = IDmade;
                ctmd.Khoimade = Khoi;
                ctmd.Khoicauhoi = Khoichon;
                ctmd.IDCauhoi = IDch;
                ctmd.IDDapan = vl.IDdapan;
                list.Add(ctmd);
            }

            DB.CT_MaDes.InsertAllOnSubmit(list);
            try
            {
                DB.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể thêm chi tiết mã đề!");
                return;
            }
            list.Clear();
            MessageBox.Show("Thêm câu hỏi vào mã đề thành công!");
            if(MessageBox.Show("Bạn có muốn tiếp tục thêm câu hỏi?","Xác nhận",MessageBoxButtons.YesNo) == DialogResult.No)
            {
                this.Close();
            }
        }

        private void DgvCauhoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
            {
                Choncauhoi = false;
                return;
            }
            Choncauhoi = true;
            int idx = dgvCauhoi.SelectedCells[0].RowIndex;
            DataGridViewRow slr = dgvCauhoi.Rows[idx];

            IDch = int.Parse(slr.Cells[0].Value.ToString());
        }

        private void CbbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Khoichon = int.Parse(this.cbbKhoi.SelectedItem.ToString());
            Reset();
            LoadCauhoi();
        }

        public void Reset()
        {
            this.dgvCauhoi.DataSource = "";
            Choncauhoi = false;
        }

        private void FThemcauhoimoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Dispose();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
