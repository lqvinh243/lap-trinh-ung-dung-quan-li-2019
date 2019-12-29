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
    public partial class fXemdanhsachthi : Form
    {

        QTDataContext DB = new QTDataContext();
        public fXemdanhsachthi()
        {
            InitializeComponent();
            Load += LoadData;
            Load += LoadControl;
        }

        private void LoadData(object sender, EventArgs e)
        {
            this.lbLoi.Text = "";
            LoadKhoi();
        }

        public void LoadKhoi()
        {

            this.cbKhoi.Items.Add(10);
            this.cbKhoi.Items.Add(11);
            this.cbKhoi.Items.Add(12);
            this.cbKhoi.SelectedIndex = 0;
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.cbKhoi.SelectedIndexChanged += CbKhoi_SelectedIndexChanged;
            this.btnThoat.Click += BtnThoat_Click;
            this.btnXem.Click += BtnXem_Click;
            this.FormClosing += FXemdanhsachthi_FormClosing;

        }

        private void FXemdanhsachthi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Dispose();
        }

        private void BtnXem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thông tin muốn xem là đúng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(this.txtIDkythi.Text))
                {
                    this.lbLoi.Text = "Mã đề không dc để trống!";
                    lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                    return;
                }

                var rqNumber = new Regex(RegexString.Number);
                if (!rqNumber.IsMatch(this.txtIDkythi.Text))
                {
                    this.lbLoi.Text = "Mã đề không hợp lệ, mã đề chỉ là số!";
                    lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                    return;
                }

                int Khoi = int.Parse(this.cbKhoi.SelectedItem.ToString());
                int IDkythi = int.Parse(this.txtIDkythi.Text);

                var lq = DB.KyThis.Where(idx => idx.Khoi == Khoi && idx.ID == IDkythi).FirstOrDefault();
                if (lq == null)
                {
                    this.lbLoi.Text = "Không tồn tại kỳ thi này với khối này!";
                    lbLoi.Left = (this.panel1.Width - lbLoi.Size.Width) / 2;
                    return;
                }
                //var ds = DB.CT_ThamGias.Where(idx => idx.Khoikythi == Khoi && idx.IDKythi == IDkythi).Select(idx => new { Khoi = idx.Khoi, Lop = idx.Lop,IDHocsinh = idx.IDHocsinh,IDmade = idx.IDMade,KhoiMade = idx.Khoidethi }).OrderBy(idx=>idx.Khoi).ThenBy(idx=>idx.Lop);
                var dshs = DB.CT_ThamGias.Join(DB.HocSinhs, k1 => new { k1.Khoi, k1.Lop,ID = k1.IDHocsinh }, k2 => new { k2.Khoi, k2.Lop,k2.ID }, (k1, k2) => new { cttg = k1, hs = k2 });
                var ds = dshs.Where(idx=>idx.cttg.Khoikythi == Khoi && idx.cttg.IDKythi == IDkythi).Select(idx=>new { Khoi = idx.cttg.Khoi, Lop = idx.cttg.Lop, IDHocsinh = idx.cttg.IDHocsinh,Hoten = idx.hs.Hoten, IDmade = idx.cttg.IDMade, KhoiMade = idx.cttg.Khoidethi }).OrderBy(idx => idx.Khoi).ThenBy(idx => idx.Lop);
                this.dgvDanhsach.DataSource = ds;
                dgvDanhsach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvDanhsach.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None).AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;

            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtIDkythi.Clear();
        }
    }
}
