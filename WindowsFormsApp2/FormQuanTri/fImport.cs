using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Validatior;

namespace WindowsFormsApp2.FormQuanTri
{
    public partial class fImport : Form
    {
        public int LoaiImport { get; set; }
        public int getData = 0;
        public int CheckInsert { get; set; }
        public fImport(int l)
        {
            InitializeComponent();
            LoaiImport = l;
            Load += LoadControl;
        }

        DataSet resl;
        List<string> Listloi = new List<string>();
        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.btnImport.Enabled = false;


            this.btnThoat.Click += BtnThoat_Click;
            this.btnImport.Click += BtnImport_Click;
            this.btnChonfile.Click += BtnChonfile_Click;

            this.dgvImport.DataBindingComplete += DgvImport_DataBindingComplete;

            this.dgvLoi.CellClick += DgvLoi_CellClick;

        }

        private void DgvLoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvImport.ClearSelection();
            if (e.RowIndex > -1 && e.RowIndex < dgvLoi.RowCount - 1)
            {
                int idx = int.Parse(dgvLoi.SelectedCells[0].Value.ToString());
                foreach (DataGridViewRow row in dgvImport.Rows)
                {
                    // 0 is the column index
                    if (row.Index == idx)
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
        }

        private void DgvImport_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvImport.ColumnCount == 5 && LoaiImport == 1)
            {
                this.lbLoi.Text = "";
                this.btnImport.Enabled = true;
                return;
            }

            if (dgvImport.ColumnCount == 3 && LoaiImport == 2)
            {
                this.lbLoi.Text = "";
                this.btnImport.Enabled = true;
                return;
            }

            if (dgvImport.ColumnCount > 0 && LoaiImport == 4)
            {
                this.lbLoi.Text = "";
                this.btnImport.Enabled = true;
                return;
            }

            this.lbLoi.Text = "File Import không đúng định dạng";

        }

        private void BtnChonfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel|*xls", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileStream fs;
                        try
                        {
                            fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Không thể mở file, Kiếm tra lại file");
                            return;
                        }
                        IExcelDataReader reader = ExcelReaderFactory.CreateReader(fs);

                        resl = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                        });
                        System.Data.DataTable dt = resl.Tables[0];
                        dgvImport.DataSource = dt;

                        reader.Close();
                        getData = 1;
                        dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dgvImport.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None).AutoSizeMode =
                            DataGridViewAutoSizeColumnMode.Fill;

                        ofd.Dispose();
                    }
                    catch (FieldAccessException ex)
                    {
                        MessageBox.Show("Không thể lấy dữ liệu từ file,Kiếm tra lại" + ex.ToString());

                    }
                }
            }

        }

        public void ThemHs(string CMND, string Lop, string Khoi, string Hoten, string Ngaysinh)
        {
            using (var DB = new QTDataContext())
            {
                var CheckCMND = DB.NguoiDungs.Where(idx => idx.CMND == CMND).SingleOrDefault();
                if (CheckCMND == null)
                {
                    var rqLop = new Regex(RegexString.Lop);
                    var rqKhoi = new Regex(RegexString.Khoi);
                    var rqCMND = new Regex(RegexString.CMND);
                    if (rqLop.IsMatch(Lop) && rqKhoi.IsMatch(Khoi) && rqCMND.IsMatch(CMND))
                    {
                        int CheckDate;
                        try
                        {
                            DateTime dt = new DateTime();
                            dt = Convert.ToDateTime(Ngaysinh);
                            CheckDate = 1;
                        }
                        catch (Exception)
                        {
                            //MessageBox.Show("Định dạng ngày tháng năm sinh bị sai vui lòng kiểm tra lại!");
                            CheckDate = 0;
                        }
                        if (CheckDate == 1)
                        {
                            NguoiDung nd = new NguoiDung();
                            nd.CMND = CMND;
                            nd.Loainguoidung = 1;

                            DB.NguoiDungs.InsertOnSubmit(nd);
                            DB.SubmitChanges();

                            HocSinh hs = new HocSinh();
                            hs.ID = nd.ID;
                            hs.Hoten = Hoten;
                            hs.Lop = int.Parse(Lop);
                            hs.Khoi = int.Parse(Khoi);
                            hs.Ngaysinh = Convert.ToDateTime(Ngaysinh);

                            DB.HocSinhs.InsertOnSubmit(hs);
                            DB.SubmitChanges();
                            CheckInsert = 1;
                        }
                    }

                }
            }
        }

        
        public void ThemGv(string CMND, string Hoten, string Ngaysinh)
        {
            using (var DB = new QTDataContext())
            {
                var CheckCMND = DB.NguoiDungs.Where(idx => idx.CMND == CMND).SingleOrDefault();
                var rgCMND = new Regex(RegexString.CMND);
                if (CheckCMND == null && rgCMND.IsMatch(CMND))
                {
                    int CheckDate = 0;
                    try
                    {
                        DateTime dt = new DateTime();
                        dt = Convert.ToDateTime(Ngaysinh);
                        CheckDate = 1;
                    }
                    catch (Exception)
                    {
                        //MessageBox.Show("Định dạng ngày tháng năm sinh bị sai vui lòng kiểm tra lại!");
                        CheckDate = 0;
                    }
                    if (CheckDate == 1)
                    {
                        NguoiDung nd = new NguoiDung();
                        nd.CMND = CMND;
                        nd.Loainguoidung = 2;

                        DB.NguoiDungs.InsertOnSubmit(nd);
                        DB.SubmitChanges();

                        GiaoVien gv = new GiaoVien();
                        gv.ID = nd.ID;
                        gv.Hoten = Hoten;
                        gv.Ngaysinh = Convert.ToDateTime(Ngaysinh);

                        DB.GiaoViens.InsertOnSubmit(gv);
                        DB.SubmitChanges();
                        CheckInsert = 1;
                    }
                }

            }
        }

        private void BtnImport_Click(object sender, EventArgs e)

        {
            Listloi.Clear();
            if (getData == 0) return;
            if (MessageBox.Show("Bạn chắc chắn import dữ liệu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow vl in dgvImport.Rows)
                {
                    if (vl.Index < dgvImport.RowCount - 1)
                    {

                        if (LoaiImport == 1)
                        {
                            if (vl.Cells[0].Value != null && vl.Cells[1].Value != null && vl.Cells[2].Value != null && vl.Cells[3].Value != null && vl.Cells[4].Value != null)
                            {
                                string CMND = vl.Cells[0].Value.ToString();
                                string Lop = vl.Cells[1].Value.ToString();
                                string Khoi = vl.Cells[2].Value.ToString();
                                string Hoten = vl.Cells[3].Value.ToString();
                                string Ngaysinh = vl.Cells[4].Value.ToString();
                                CheckInsert = 0;
                                ThemHs(CMND, Lop, Khoi, Hoten, Ngaysinh);
                                if (CheckInsert == 0)
                                {
                                    Listloi.Add(vl.Index.ToString());
                                }
                            }

                        }
                        else if (LoaiImport == 2)
                        {
                            if (vl.Cells[0].Value != null && vl.Cells[1].Value != null && vl.Cells[2].Value != null)
                            {
                                string CMND = vl.Cells[0].Value.ToString();
                                string Hoten = vl.Cells[1].Value.ToString();
                                string Ngaysinh = vl.Cells[2].Value.ToString();
                                CheckInsert = 0;
                                ThemGv(CMND, Hoten, Ngaysinh);
                                if (CheckInsert == 0)
                                {
                                    Listloi.Add(vl.Index.ToString());
                                }
                            }
                        }
                        else
                        {
                            int flag = 0;

                            try
                            {
                                flag = int.Parse(vl.Cells[0].Value.ToString());
                            }
                            catch (Exception)
                            {
                                //
                            }
                            if (flag == 1)
                            {
                                if (vl.DataGridView.RowCount == 5)
                                {
                                    if (vl.Cells[1].Value != null && vl.Cells[2].Value != null && vl.Cells[3].Value != null && vl.Cells[4].Value != null && vl.Cells[5].Value != null)
                                    {
                                        string CMND = vl.Cells[1].Value.ToString();
                                        string Hoten = vl.Cells[2].Value.ToString();
                                        string Ngaysinh = vl.Cells[3].Value.ToString();
                                        string Khoi = vl.Cells[4].Value.ToString();
                                        string Lop = vl.Cells[5].Value.ToString();
                                        CheckInsert = 0;
                                        ThemHs(CMND, Lop, Khoi, Hoten, Ngaysinh);
                                        if (CheckInsert == 0)
                                        {
                                            Listloi.Add(vl.Index.ToString());
                                        }
                                    }
                                    else Listloi.Add(vl.Index.ToString());
                                }
                                else Listloi.Add(vl.Index.ToString());

                            }
                            else if (flag == 2)
                            {
                                int i = vl.DataGridView.RowCount;
                                if (i > 6 || i < 4) continue;
                                for (int j = 1; j <= i; j++)
                                {
                                    if(j >= 4)
                                    {
                                        if (!string.IsNullOrWhiteSpace(vl.Cells[j].Value.ToString()))
                                        {
                                            MessageBox.Show(vl.Cells[j].Value.ToString());
                                            i = -1;
                                            break;
                                        }
                                    }
                                }
                                if (i == -1)
                                {
                                    Listloi.Add(vl.Index.ToString());
                                    continue;
                                }
                                if (vl.Cells[0].Value != null && vl.Cells[1].Value != null && vl.Cells[2].Value != null)
                                {
                                    string CMND = vl.Cells[1].Value.ToString();
                                    string Hoten = vl.Cells[2].Value.ToString();
                                    string Ngaysinh = vl.Cells[3].Value.ToString();
                                    CheckInsert = 0;
                                    ThemGv(CMND, Hoten, Ngaysinh);

                                    if (CheckInsert == 0)
                                    {
                                        Listloi.Add(vl.Index.ToString());
                                    }
                                }
                                else Listloi.Add(vl.Index.ToString());
                            }
                            else Listloi.Add(vl.Index.ToString());


                        }
                    }
                }
                System.Data.DataTable dtl = new System.Data.DataTable();
                dtl.Columns.Add("Dòng lỗi", typeof(string));
                foreach (var vl in Listloi)
                {
                    dtl.Rows.Add(vl);
                }
                dgvLoi.DataSource = dtl;
                dgvLoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvLoi.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None).AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
