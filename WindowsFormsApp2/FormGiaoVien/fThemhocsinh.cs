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
    public partial class fThemhocsinh : Form
    {
        QTDataContext DB = new QTDataContext();

        public int Khoi = 0, Lop = 0;
        public int IDkythi, Khoikythi;
        public bool Chonkhoi = false, Chonhocsinh = false;
        public fThemhocsinh(int id, int khoi)
        {
            InitializeComponent();

            Load += LoadControl;
            Load += LoadData;
            IDkythi = id;
            Khoikythi = khoi;
        }

        private void LoadData(object sender, EventArgs e)
        {
            this.txtIDkythi.Text = IDkythi.ToString();
            this.txtKhoikythi.Text = Khoikythi.ToString();
            LoadKhoi();
            LoadDanhSach();
            LoadKhoiMade();
        }

        private void FThemhocsinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Dispose();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn dừng việc thêm học sinh?", "Xác nhận thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void LoadKhoi()
        {
            this.cbbKhoi.Items.Add(10);
            this.cbbKhoi.Items.Add(11);
            this.cbbKhoi.Items.Add(12);
            this.cbbKhoi.SelectedIndex = 0;
        }

        public void LoadDanhSach()
        {
            Khoi = int.Parse(this.cbbKhoi.SelectedItem.ToString());
            var Lisths = DB.HocSinhs.Join(DB.NguoiDungs, k1 => k1.ID, k2 => k2.ID, (k1, k2) => new { Khoi = k1.Khoi, Lop = k1.Lop, ID = k2.ID, CMND = k2.CMND }).Where(idx=>idx.Khoi == Khoi).OrderBy(idx => idx.Khoi).OrderBy(idx => idx.Lop);
            dgvHocsinh.DataSource = Lisths;
            dgvDaco.DataSource = "";
        }

        public void LoadKhoiMade()
        {
            var ListKhoi = DB.CT_KyThis.Where(idx => idx.IDKythi == IDkythi && idx.Khoikythi == Khoikythi).Select(idx => idx.Khoidethi);
            ListKhoi = ListKhoi.Distinct();
            foreach (var vl in ListKhoi)
            {
                this.cbbKhoimade.Items.Add(vl);
            }
        }

        public void LoadMade(int Khoimade)
        {
            var ListMade = DB.CT_KyThis.Where(idx => idx.IDKythi == IDkythi && idx.Khoikythi == Khoikythi && idx.Khoidethi == Khoimade).Select(idx => idx.IDMade);
            foreach (var vl in ListMade)
            {
                this.cbbIDMade.Items.Add(vl);
            }
            this.cbbIDMade.SelectedIndex = 0;
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.txtIDkythi.Enabled = false;
            this.txtKhoikythi.Enabled = false;
            this.btnThoat.Click += BtnThoat_Click;


            //Closing form
            this.FormClosing += FThemhocsinh_FormClosing;
            this.btnThem.Click += BtnThem_Click;

            //Chọn khối
            this.cbbKhoimade.SelectedIndexChanged += CbbKhoimade_SelectedIndexChanged;

            //Chọn học sinh
            this.dgvHocsinh.CellClick += DgvHocsinh_CellClick;

            //Load hoc sinh
            this.cbbKhoi.SelectedIndexChanged += CbbKhoi_SelectedIndexChanged;
        }

        private void CbbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void DgvHocsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
            {
                Chonhocsinh = false;
                dgvDaco.DataSource = "";
                return;
            }
            Chonhocsinh = true;
            int idx = dgvHocsinh.SelectedCells[0].RowIndex;
            DataGridViewRow slr = dgvHocsinh.Rows[idx];
            int IDhs = int.Parse(slr.Cells[2].Value.ToString());
            int Khoihs = int.Parse(slr.Cells[0].Value.ToString());
            int Lophs = int.Parse(slr.Cells[1].Value.ToString());

            var Madedaco = DB.CT_ThamGias.Where(idy => idy.IDHocsinh == IDhs && idy.Khoi == Khoihs && idy.Lop == Lophs && idy.IDKythi == IDkythi && idy.Khoikythi == Khoikythi).Select(idy => new { IDMade = idy.IDMade, Khoimade = idy.Khoidethi });
            dgvDaco.DataSource = Madedaco;

        }

        private void CbbKhoimade_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chonkhoi = true;
            int Khoi = int.Parse(this.cbbKhoimade.SelectedItem.ToString());
            LoadMade(Khoi);
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (Chonkhoi == false)
            {
                MessageBox.Show("Vui lòng chọn khối và mã đề cho học sinh trước!", "Thông báo chọn", MessageBoxButtons.OK);
                return;
            }
            if (Chonhocsinh == false)
            {
                MessageBox.Show("Vui lòng chọn học sinh để thêm!!", "Thông báo chọn", MessageBoxButtons.OK);
                return;
            }

            int idx = dgvHocsinh.SelectedCells[0].RowIndex;
            DataGridViewRow slr = dgvHocsinh.Rows[idx];

            int IDmade = int.Parse(this.cbbIDMade.SelectedItem.ToString());
            int Khoidethi = int.Parse(this.cbbKhoimade.SelectedItem.ToString());
            int IDhs = int.Parse(slr.Cells[2].Value.ToString());
            int Khoihs = int.Parse(slr.Cells[0].Value.ToString());
            int Lophs = int.Parse(slr.Cells[1].Value.ToString());


            var Checktg = DB.CT_ThamGias.Where(idy => idy.IDKythi == IDkythi && idy.Khoikythi == Khoikythi && idy.IDMade == IDmade && idy.Khoidethi == Khoidethi && idy.IDHocsinh == IDhs && idy.Khoi == Khoihs && idy.Lop == Lophs).FirstOrDefault();
            if (Checktg != null)
            {
                MessageBox.Show("Học sinh này đã được thêm vào kỳ thi với mã đề này, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (Khoikythi != Khoihs)
            {
                if (MessageBox.Show("Học sinh này có khối khác với khối kỳ thi, bạn có chắc chắn thêm?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if (MessageBox.Show("Bạn có chắn thêm học sinh này vào kỳ thi với mã đề này?", "Thông báo thêm", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            CT_ThamGia cttg = new CT_ThamGia();
            cttg.IDKythi = IDkythi;
            cttg.Khoikythi = Khoikythi;
            cttg.IDMade = IDmade;
            cttg.Khoidethi = Khoidethi;
            cttg.IDHocsinh = IDhs;
            cttg.Khoi = Khoihs;
            cttg.Lop = Lophs;
            DB.CT_ThamGias.InsertOnSubmit(cttg);
            try
            {
                DB.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể thêm học sinh!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show("Thêm học sinh có ID " + IDhs.ToString() + " vào kỳ thi với mã đề " + IDmade.ToString() + " thành công!", "Thông báo", MessageBoxButtons.OK);
            if (MessageBox.Show("Bạn có muốn tiếp tục thêm học sinh?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                this.Close();
            }
            Chonhocsinh = false;
            this.dgvDaco.DataSource = "";
            this.cbbKhoimade.SelectedIndex = 0;
            this.cbbIDMade.SelectedIndex = 0;

        }
    }
}
