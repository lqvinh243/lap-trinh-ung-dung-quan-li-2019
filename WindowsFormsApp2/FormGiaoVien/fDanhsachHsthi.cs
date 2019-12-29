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
    public partial class fDanhsachHsthi : Form
    {
        public int ID, Khoi;
        QTDataContext DB = new QTDataContext();
        public bool Chon = false;
        public bool Dienra = true;
        public int Khoiloc = 0, Loploc = 0;
        public fDanhsachHsthi(int iDKythi, int khoikythi, bool dienra)
        {
            InitializeComponent();
            ID = iDKythi;
            Khoi = khoikythi;
            Dienra = dienra ;
            Load += LoadControl;
            Load += LoadData;
            dgvDanhsachHs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDanhsachHs.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void LoadData(object sender, EventArgs e)
        {
            LoadKhoi();
            LoadDanhsach(); 
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.FormClosing += FDanhsachHsthi_FormClosing;
            this.btnThoat.Click += BtnThoat_Click;
            if (Dienra == true)
            {
                this.cbbKhoi.Enabled = false;
                this.cbbLop.Enabled = false;
                this.dgvDanhsachHs.Enabled = false;
            }

            //Chọn học sinh
            this.dgvDanhsachHs.CellClick += DgvDanhsachHs_CellClick;

            //Học sinh
            this.btnXoaHs.Click += BtnXoaHs_Click;
            this.btnThemHs.Click += BtnThemHs_Click;

            //Lọc theo khối
            this.cbbKhoi.SelectedIndexChanged += CbbKhoi_SelectedIndexChanged;
            this.cbbLop.SelectedIndexChanged += CbbLop_SelectedIndexChanged;
        }

        private void CbbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loploc = int.Parse(this.cbbLop.SelectedItem.ToString());
            LoadDanhsach();
        }

        private void CbbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbbLop.Items.Clear();
            Khoiloc = int.Parse(this.cbbKhoi.SelectedItem.ToString());
            Loadlop();
            LoadDanhsach();
        }

        public void Loadlop()
        {
            this.cbbLop.Items.Add(0);
            this.cbbLop.SelectedIndex = 0;
            if (Khoiloc > 0)
            {
                var Listlop = DB.CT_ThamGias.Where(idx => idx.IDKythi == ID && idx.Khoikythi == Khoi && idx.Khoi == Khoiloc).Select(idx => idx.Lop);
                Listlop = Listlop.Distinct();
                foreach (var vl in Listlop)
                {
                    this.cbbLop.Items.Add(vl);
                }
            }
        }

        private void BtnThemHs_Click(object sender, EventArgs e)
        {
            this.cbbKhoi.Items.Clear();
            if(Dienra == true)
            {
                MessageBox.Show("Kỳ thi này đã diễn ra nên bạn không thể thêm học sinh!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            fThemhocsinh f = new fThemhocsinh(ID,Khoi);
            f.ShowDialog();
            LoadDanhsach();
            LoadKhoi();
        }

        private void DgvDanhsachHs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
            {
                return;
            }
            Chon = true;
        }

        private void BtnXoaHs_Click(object sender, EventArgs e)
        {
            if (Dienra == true)
            {
                MessageBox.Show("Kỳ thi này đã diễn ra nên bạn không thể thêm học sinh!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (Chon == false)
            {
                MessageBox.Show("Bạn phải chọn học sinh để xóa trước!!","Thông báo chọn",MessageBoxButtons.OK);
                return;
            }
            int idx = dgvDanhsachHs.SelectedCells[0].RowIndex;
            DataGridViewRow slr = dgvDanhsachHs.Rows[idx];

            int IDhs = int.Parse(slr.Cells[0].Value.ToString());
            int Khoihs = int.Parse(slr.Cells[3].Value.ToString());
            int Lophs = int.Parse(slr.Cells[4].Value.ToString());
            int IDmade = int.Parse(slr.Cells[5].Value.ToString());
            int Khoimade = int.Parse(slr.Cells[6].Value.ToString());
            if(MessageBox.Show("Bạn có chắc chắn xóa học sinh với mã đè này khỏi kỳ thi?","Xác nhận xóa",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var Xoahs = DB.CT_ThamGias.Where(idy => idy.IDKythi == ID && idy.Khoikythi == Khoi && idy.IDHocsinh == IDhs && idy.Khoi == Khoihs && idy.Lop == Lophs && idy.IDMade == IDmade && idy.Khoidethi == Khoimade).SingleOrDefault();
                
                try
                {
                    DB.CT_ThamGias.DeleteOnSubmit(Xoahs);
                    DB.SubmitChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa học sinh", "Thông báo lỗi", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show("Xóa học sinh khỏi kỳ thi thành công!");
                LoadDanhsach();
            }
            
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadKhoi()
        {
            this.cbbKhoi.Items.Add(0);
            this.cbbKhoi.SelectedIndex = 0;
            var Listkhoi = DB.CT_ThamGias.Where(idx => idx.IDKythi == ID && idx.Khoikythi == Khoi).Select(idx => idx.Khoi);
            Listkhoi = Listkhoi.Distinct();
            foreach(var vl in Listkhoi)
            {
                this.cbbKhoi.Items.Add(vl);
            }
        }

        public void LoadDanhsach()
        {
            if (Khoiloc == 0)
            {
                var Kythi = DB.CT_ThamGias.Join(DB.HocSinhs.Join
                (DB.NguoiDungs, idx => idx.ID, idy => idy.ID,
                (idx, idy) => new { idx.ID, idx.Khoi, idx.Lop, idx.Ngaysinh, idx.Hoten, idy.CMND }),
                k1 => new { ID = k1.IDHocsinh, Khoi = k1.Khoi, Lop = k1.Lop }, k2 => new { ID = k2.ID, Khoi = k2.Khoi, Lop = k2.Lop },
                (k1, k2) => new { k1, k2 }).Where(idx => idx.k1.IDKythi == ID && idx.k1.Khoikythi == Khoi);
                var List = Kythi.Select(idx => new { ID = idx.k1.IDHocsinh, CMND = idx.k2.CMND, Hoten = idx.k2.Hoten, Khoi = idx.k2.Khoi, Lop = idx.k2.Lop, Made = idx.k1.IDMade, Khoimade = idx.k1.Khoidethi }).OrderBy(idx => idx.Khoi).OrderBy(idx => idx.Lop);
                dgvDanhsachHs.DataSource = List;
            }
            else if (Khoiloc != 0 && Loploc == 0)
            {
                var Kythi = DB.CT_ThamGias.Join(DB.HocSinhs.Join
                (DB.NguoiDungs, idx => idx.ID, idy => idy.ID,
                (idx, idy) => new { idx.ID, idx.Khoi, idx.Lop, idx.Ngaysinh, idx.Hoten, idy.CMND }),
                k1 => new { ID = k1.IDHocsinh, Khoi = k1.Khoi, Lop = k1.Lop }, k2 => new { ID = k2.ID, Khoi = k2.Khoi, Lop = k2.Lop },
                (k1, k2) => new { k1, k2 }).Where(idx => idx.k1.IDKythi == ID && idx.k1.Khoikythi == Khoi);
                var List = Kythi.Select(idx => new { ID = idx.k1.IDHocsinh, CMND = idx.k2.CMND, Hoten = idx.k2.Hoten, Khoi = idx.k2.Khoi, Lop = idx.k2.Lop, Made = idx.k1.IDMade, Khoimade = idx.k1.Khoidethi }).Where(idx=>idx.Khoi == Khoiloc).OrderBy(idx => idx.Khoi).OrderBy(idx => idx.Lop);
                dgvDanhsachHs.DataSource = List;
            }
            else
            {
                var Kythi = DB.CT_ThamGias.Join(DB.HocSinhs.Join
                (DB.NguoiDungs, idx => idx.ID, idy => idy.ID,
                (idx, idy) => new { idx.ID, idx.Khoi, idx.Lop, idx.Ngaysinh, idx.Hoten, idy.CMND }),
                k1 => new { ID = k1.IDHocsinh, Khoi = k1.Khoi, Lop = k1.Lop }, k2 => new { ID = k2.ID, Khoi = k2.Khoi, Lop = k2.Lop },
                (k1, k2) => new { k1, k2 }).Where(idx => idx.k1.IDKythi == ID && idx.k1.Khoikythi == Khoi);
                var List = Kythi.Select(idx => new { ID = idx.k1.IDHocsinh, CMND = idx.k2.CMND, Hoten = idx.k2.Hoten, Khoi = idx.k2.Khoi, Lop = idx.k2.Lop, Made = idx.k1.IDMade, Khoimade = idx.k1.Khoidethi }).Where(idx => idx.Khoi == Khoiloc && idx.Lop == Loploc).OrderBy(idx => idx.Khoi).OrderBy(idx => idx.Lop);
                dgvDanhsachHs.DataSource = List;
            }
            
        }

        private void FDanhsachHsthi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Dispose();
        }
    }
}
