using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Validatior;

namespace WindowsFormsApp2.FormGiaoVien
{
    public partial class fXoaSuakythi : Form
    {

        QTDataContext DB = new QTDataContext();
        public bool Chon = false, Dienra = false;
        public bool ChonMade = false;
        public int IDKythi, Khoikythi;
        public fXoaSuakythi()
        {
            InitializeComponent();

            Load += LoadControl;
            Load += LoadData;

        }

        private void LoadData(object sender, EventArgs e)
        {
            LoadKhoi();
            Loadkythi();
        }

        public void LoadKhoi()
        {
            this.cbbKhoi.Items.Add(10);
            this.cbbKhoi.Items.Add(11);
            this.cbbKhoi.Items.Add(12);
            this.cbbKhoi.SelectedIndex = 0;
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.txtNgaytao.Enabled = false;
            this.txtID.Enabled = false;
            this.cbDienra.Enabled = false;
            this.txtKhoi.Enabled = false;
            this.cbThithu.Enabled = false;
            FormClosing += FXoaSuakythi_FormClosing;


            this.btnThoat.Click += BtnThoat_Click;

            this.dgvKythi.CellClick += DgvKythi_CellClick;

            this.btnSuakythi.Click += BtnSuakythi_Click;

            this.btnXoa.Click += BtnXoa_Click;

            //Mã đề
            this.btnThemmade.Click += BtnThemmade_Click;
            this.dgvMade.CellClick += DgvMade_CellClick;
            this.btnXoamade.Click += BtnXoamade_Click;

            //Dánh sách học sinh
            this.btnDanhsachHs.Click += BtnDanhsachHs_Click;


            //Lọc
            this.cbbKhoi.SelectedIndexChanged += CbbKhoi_SelectedIndexChanged;
        }

        private void CbbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loadkythi();
        }

        private void BtnDanhsachHs_Click(object sender, EventArgs e)
        {
            if (Chon == false)
            {
                MessageBox.Show("Vui lòng chọn kỳ thi trước!", "Thông báo chọn", MessageBoxButtons.OK);
                return;
            }
            using (var DB = new QTDataContext())
            {
                var rq = DB.CT_KyThis.Where(idx => idx.IDKythi == IDKythi && idx.Khoikythi == Khoikythi).FirstOrDefault();
                if (rq == null)
                {
                    MessageBox.Show("Kỳ thi hiện tại chưa có mã đề nào, vui lòng thêm mã đề thi trước!!");
                    return;
                }
            }
            fDanhsachHsthi f = new fDanhsachHsthi(IDKythi, Khoikythi, Dienra);
            f.ShowDialog();
        }

        private void BtnXoamade_Click(object sender, EventArgs e)
        {
            if (Chon == false)
            {
                MessageBox.Show("Bạn phải chọn kỳ thi trước!!", "Thông báo chọn", MessageBoxButtons.OK);
                return;
            }
            if (Dienra == true)
            {
                MessageBox.Show("Kỳ thi này đã diễn ra không thể thao tác!!!", "Thông báo!", MessageBoxButtons.OK);
                return;
            }
            if (ChonMade == false)
            {
                MessageBox.Show("Bạn phải chọn mã đề cần xóa!", "Thông báo chọn", MessageBoxButtons.OK);
                return;
            }


            int idx = dgvMade.SelectedCells[0].RowIndex;
            DataGridViewRow slr = dgvMade.Rows[idx];

            int Madechon = int.Parse(slr.Cells[0].Value.ToString());
            int Khoidechon = int.Parse(slr.Cells[1].Value.ToString());

            var checkSudung = DB.CT_ThamGias.Where(idy => idy.IDMade == Madechon && idy.Khoidethi == Khoidechon && idy.IDKythi == IDKythi && idy.Khoikythi == Khoikythi).FirstOrDefault();
            if (checkSudung != null)
            {
                MessageBox.Show("Không thể xóa đề thi này vì đang sử dụng cho học sinh thi,vui lòng cập nhật mã đề thi mới cho học sinh rồi xóa!", "Thông báo!!!", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn xóa mã đề này?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var CTkt = DB.CT_KyThis.Where(idy => idy.IDMade == Madechon && idy.Khoidethi == Khoidechon);
                DB.CT_KyThis.DeleteAllOnSubmit(CTkt);
                try
                {
                    DB.SubmitChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa mã đề trong kỳ thi!");
                    return;
                }
            }
            Loadmade();
        }


        private void DgvMade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                ChonMade = true;
            }
            else ChonMade = false;
        }

        private void BtnThemmade_Click(object sender, EventArgs e)
        {
            if (Chon == false)
            {
                MessageBox.Show("Bạn phải chọn kỳ thi trước!!", "Thông báo chọn", MessageBoxButtons.OK);
                return;
            }
            if (Dienra == true)
            {
                MessageBox.Show("Kỳ thi này đã diễn ra không thể thao tác!!!", "Thông báo!", MessageBoxButtons.OK);
                return;
            }
            fThemmade f = new fThemmade(IDKythi, Khoikythi);
            f.ShowDialog();
            Loadmade();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (Chon == false)
            {
                MessageBox.Show("Vui lòng chọn kỳ thi cần xóa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (Dienra == true)
            {
                MessageBox.Show("Kỳ thi này đã diễn ra, không cho phép xóa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa kỳ thi này?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var Listhstg = DB.CT_ThamGias.Where(idx => idx.IDKythi == IDKythi && idx.Khoikythi == Khoikythi);
                int flag = 1;
                try
                {
                    DB.CT_ThamGias.DeleteAllOnSubmit(Listhstg);
                    DB.SubmitChanges();
                }
                catch (Exception)
                {
                    flag = 0;
                    MessageBox.Show("Không thể xóa người tham gia kỳ thi");
                    return;
                }

                if (flag == 1)
                {
                    var CT_Kythi = DB.CT_KyThis.Where(idx => idx.IDKythi == IDKythi && idx.Khoikythi == Khoikythi);
                    try
                    {
                        DB.CT_KyThis.DeleteAllOnSubmit(CT_Kythi);
                        DB.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        flag = 0;
                        MessageBox.Show("Không thể xóa chi tiết kì thi");
                        return;
                    }
                }

                if (flag == 1)
                {
                    var Kythi = DB.KyThis.Where(idx => idx.ID == IDKythi && idx.Khoi == Khoikythi);
                    try
                    {
                        DB.KyThis.DeleteAllOnSubmit(Kythi);
                        DB.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa kỳ thi!");
                        return;
                    }
                }
                Chon = false;
                Dienra = false;
                MessageBox.Show("Xóa kỳ thi thành công!");
                Loadkythi();
            }

        }

        private void BtnSuakythi_Click(object sender, EventArgs e)
        {
            if (Chon == false)
            {
                MessageBox.Show("Vui lòng chọn kỳ thi cần sửa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (Dienra == true)
            {
                MessageBox.Show("Kỳ thi này đã diễn ra, không cho phép sửa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (DateTime.Now > dtpNgaythi.Value)
            {
                this.lbLoi.Text = "Ngày thi phải lớn hơn ngày hiện tại!";
                lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                return;
            }

            var rgID = new Regex(RegexString.Number);
            if (!rgID.IsMatch(this.txtIDNguoitao.Text))
            {
                this.lbLoi.Text = "ID người tạo không đúng định dạng";
                lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                return;
            }

            var rqThoigian = new Regex(RegexString.Number);
            if (!rqThoigian.IsMatch(this.txtThoigian.Text))
            {
                this.lbLoi.Text = "Thời gian định dạng không đúng!";
                lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                return;
            }

            var CheckNT = DB.GiaoViens.Where(idx => idx.ID == int.Parse(this.txtIDNguoitao.Text)).SingleOrDefault();
            if (CheckNT == null)
            {
                this.lbLoi.Text = "Không tồn tại giáo viên có ID này!";
                lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin kỳ thi này?", "Xác nhận sửa!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var Kythi = DB.KyThis.Where(idx => idx.ID == IDKythi && idx.Khoi == Khoikythi).SingleOrDefault();
                Kythi.Ngaythi = dtpNgaythi.Value;
                Kythi.IDNguoitao = int.Parse(this.txtIDNguoitao.Text);
                Kythi.Gioihanthoigian = int.Parse(this.txtThoigian.Text);
                Kythi.Thithu = this.cbThithu.Checked == true ? 1 : 0;
                try
                {
                    DB.SubmitChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể thay đổi thông tin kỳ thi!");
                    return;
                }
                MessageBox.Show("Sửa thông tin kỳ thi thành công!");
                this.lbLoi.Text = "";
                Loadkythi();
            }


        }

        private void DgvKythi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
            {
                Reset();
                return;
            }
            Chon = true;
            int idx = dgvKythi.SelectedCells[0].RowIndex;
            DataGridViewRow slr = dgvKythi.Rows[idx];

            Khoikythi = int.Parse(slr.Cells[1].Value.ToString());
            IDKythi = int.Parse(slr.Cells[0].Value.ToString());
            int IDNgtao = int.Parse(slr.Cells[3].Value.ToString());

            var CT_Kythi = DB.KyThis.GroupJoin(DB.CT_KyThis, kt => new { ID = kt.ID, Khoi = kt.Khoi }, ctkt => new { ID = ctkt.IDKythi, Khoi = ctkt.Khoikythi }, (kt, ctkt) => new { CT = ctkt, KT = kt }).Where(idy => idy.KT.ID == IDKythi && idy.KT.Khoi == Khoikythi);
            this.txtID.Text = CT_Kythi.Select(idy => idy.KT.ID).FirstOrDefault().ToString();
            this.txtKhoi.Text = CT_Kythi.Select(idy => idy.KT.Khoi).FirstOrDefault().ToString();
            this.dtpNgaythi.Value = CT_Kythi.Select(idy => idy.KT.Ngaythi.Value).FirstOrDefault();
            this.txtIDNguoitao.Text = CT_Kythi.Select(idy => idy.KT.IDNguoitao).FirstOrDefault().ToString();
            this.txtThoigian.Text = CT_Kythi.Select(idy => idy.KT.Gioihanthoigian).FirstOrDefault().ToString();
            this.cbThithu.Checked = CT_Kythi.Select(idy => idy.KT.Thithu).FirstOrDefault() == 1 ? true : false;

            try
            {
                this.txtNgaytao.Text = CT_Kythi.Select(idy => idy.KT.Ngaytao.Value.ToShortDateString()).FirstOrDefault();
            }
            catch (Exception)
            {
                //
            }


            Loadmade();
            var Kythidienra = DB.CT_ThamGias.Where(idy => idy.IDKythi == IDKythi && idy.Khoikythi == Khoikythi).Any(idy => idy.Diem != null);
            var Thoigiandienra = DB.KyThis.Where(idy => idy.ID == IDKythi && idy.Khoi == Khoikythi).Any(idy => idy.Ngaythi.Value < DateTime.Now);
            if (Kythidienra == true || Thoigiandienra == true)
            {
                Dienra = true;
                this.dtpNgaythi.Enabled = false;
                this.txtIDNguoitao.Enabled = false;
                this.cbDienra.Checked = true;
                this.txtThoigian.Enabled = false;
                this.cbThithu.Enabled = false;
            }
            else
            {
                Dienra = false;
                this.dtpNgaythi.Enabled = true;
                this.txtIDNguoitao.Enabled = true;
                this.cbDienra.Checked = false;
                this.txtThoigian.Enabled = true;
                this.cbThithu.Enabled = true;
            }

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FXoaSuakythi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Dispose();
        }

        public void Reset()
        {
            Chon = false;
            Dienra = false;
            ChonMade = false;
            cbDienra.Enabled = false;
            Khoikythi = -1;
            IDKythi = -1;
            this.txtID.Clear();
            this.txtIDNguoitao.Clear();
            this.txtKhoi.Clear();
            this.txtNgaytao.Clear();
            this.txtIDNguoitao.Enabled = false;
            this.dtpNgaythi.Enabled = false;
            this.txtThoigian.Clear();
            this.txtThoigian.Enabled = false;
            dgvMade.DataSource = "";
        }
        public void Loadkythi()
        {
            Reset();
            int KhoiLoc = int.Parse(this.cbbKhoi.SelectedItem.ToString());
            var ListKythi = DB.KyThis.Select(idx => new { IDkythi = idx.ID, Khoikythi = idx.Khoi, Ngaytao = idx.Ngaytao, IDNguoitao = idx.IDNguoitao }).Where(idx => idx.Khoikythi == KhoiLoc);
            dgvKythi.DataSource = ListKythi;
        }

        public void Loadmade()
        {
            var Made = DB.CT_KyThis.Where(idy => idy.IDKythi == IDKythi && idy.Khoikythi == Khoikythi).Select(idx => new { IDMade = idx.IDMade, Khoimade = idx.Khoidethi });
            dgvMade.DataSource = Made;
        }
    }
}
