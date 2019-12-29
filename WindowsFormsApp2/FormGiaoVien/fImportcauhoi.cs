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

namespace WindowsFormsApp2.FormGiaoVien
{
    public partial class fImportcauhoi : Form
    {
        DataSet resl;
        List<string> Listloi = new List<string>();
        public int getData = 0;
        public fImportcauhoi()
        {
            InitializeComponent();

            Load += LoadControl;
            Load += LoadData;
            dgvImport.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvImport.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void LoadData(object sender, EventArgs e)
        {
            this.Text = "Import câu hỏi";
            this.lbLoi.Text = "";
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.btnImport.Enabled = false;

            this.btnChonfile.Click += BtnChonfile_Click;
            this.btnThoat.Click += BtnThoat_Click;
            this.btnImport.Click += BtnImport_Click;

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

        private void BtnImport_Click(object sender, EventArgs e)
        {
            Listloi.Clear();
            if (MessageBox.Show("Bạn có chắn chắn import dữ liệu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dgvImport.ColumnCount == 13)
                {
                    foreach (DataGridViewRow vl in dgvImport.Rows)
                    {
                        if (vl.Index < dgvImport.RowCount - 1)
                        {
                            if (!string.IsNullOrWhiteSpace(vl.Cells[0].Value.ToString())
                                && !string.IsNullOrWhiteSpace(vl.Cells[1].Value.ToString())
                                && !string.IsNullOrWhiteSpace(vl.Cells[2].Value.ToString())
                                && !string.IsNullOrWhiteSpace(vl.Cells[3].Value.ToString())
                                && !string.IsNullOrWhiteSpace(vl.Cells[4].Value.ToString())
                                 && !string.IsNullOrWhiteSpace(vl.Cells[5].Value.ToString())
                                 && !string.IsNullOrWhiteSpace(vl.Cells[6].Value.ToString())
                                 && !string.IsNullOrWhiteSpace(vl.Cells[7].Value.ToString())
                                 && !string.IsNullOrWhiteSpace(vl.Cells[8].Value.ToString())
                                 && !string.IsNullOrWhiteSpace(vl.Cells[9].Value.ToString())
                                 && !string.IsNullOrWhiteSpace(vl.Cells[10].Value.ToString())
                                 && !string.IsNullOrWhiteSpace(vl.Cells[11].Value.ToString())
                                 && !string.IsNullOrWhiteSpace(vl.Cells[12].Value.ToString()))
                            {
                                string Khoich = vl.Cells[0].Value.ToString();
                                string Motacauhoi = vl.Cells[1].Value.ToString();
                                string Dokho = vl.Cells[2].Value.ToString();
                                string DapanA = vl.Cells[3].Value.ToString();
                                string DapanB = vl.Cells[4].Value.ToString();
                                string DapanC = vl.Cells[5].Value.ToString();
                                string DapanD = vl.Cells[6].Value.ToString();
                                string DapanE = vl.Cells[7].Value.ToString();
                                string TinhA = vl.Cells[8].Value.ToString();
                                string TinhB = vl.Cells[9].Value.ToString();
                                string TinhC = vl.Cells[10].Value.ToString();
                                string TinhD = vl.Cells[11].Value.ToString();
                                string TinhE = vl.Cells[12].Value.ToString();

                                var rgKhoi = new Regex(RegexString.Khoi);

                                if (!rgKhoi.IsMatch(Khoich))
                                {
                                    Listloi.Add(vl.Index.ToString());
                                    continue;
                                }

                                var rgDokho = new Regex(RegexString.Dokho);
                                if (!rgDokho.IsMatch(Dokho))
                                {
                                    Listloi.Add(vl.Index.ToString());
                                    continue;
                                }

                                var rgTinh = new Regex(RegexString.Tinh);
                                if (!rgTinh.IsMatch(TinhA) || !rgTinh.IsMatch(TinhB) || !rgTinh.IsMatch(TinhC) || !rgTinh.IsMatch(TinhD) || !rgTinh.IsMatch(TinhE))
                                {
                                    Listloi.Add(vl.Index.ToString());
                                    continue;
                                }

                                using (var DB = new QTDataContext())
                                {
                                    var qr = DB.CauHois.Where(idx => idx.Mota == Motacauhoi).SingleOrDefault();
                                    if (qr != null)
                                    {
                                        Listloi.Add(vl.Index.ToString());
                                        continue;
                                    }

                                    var newCH = new CauHoi();
                                    var ch = DB.CauHois.Where(idx => idx.Khoi == int.Parse(Khoich)).FirstOrDefault();//;.Max(idx => idx.ID);
                                    int idch;
                                    if (ch != null)
                                    {
                                        idch = DB.CauHois.Where(idx => idx.Khoi == int.Parse(Khoich)).Max(idx => idx.ID);
                                        idch = idch + 1;
                                    }
                                    else
                                    {
                                        idch = 1;
                                    }
                                    
                                    
                                    newCH.ID = idch;

                                    newCH.Khoi = int.Parse(Khoich);
                                    newCH.Mota = Motacauhoi;
                                    newCH.Duyet = true;
                                    newCH.Dokho = int.Parse(Dokho);
                                    newCH.IDNguoitao = CurrentUser.UserID;

                                    DB.CauHois.InsertOnSubmit(newCH);
                                    DB.SubmitChanges();



                                    for (int i = 0; i < 5; i++)
                                    {
                                        var CTCH = new CT_CauHoi();
                                        CTCH.IDCauhoi = idch;
                                        CTCH.Khoi = int.Parse(Khoich);
                                        if (i == 0) { CTCH.IDdapan = "A"; CTCH.Mota = DapanA; CTCH.Dung = int.Parse(TinhA)==0?false:true; }
                                        else if (i == 1) { CTCH.IDdapan = "B"; CTCH.Mota = DapanB; CTCH.Dung = int.Parse(TinhB) == 0 ? false : true; ; }
                                        else if (i == 2) { CTCH.IDdapan = "C"; CTCH.Mota = DapanC; CTCH.Dung = int.Parse(TinhC) == 0 ? false : true; ; }
                                        else if (i == 3) { CTCH.IDdapan = "D"; CTCH.Mota = DapanD; CTCH.Dung = int.Parse(TinhD) == 0 ? false : true; ; }
                                        else { CTCH.IDdapan = "E"; CTCH.Mota = DapanE; CTCH.Dung = int.Parse(TinhE) == 0 ? false : true; ; }

                                        DB.CT_CauHois.InsertOnSubmit(CTCH);
                                        DB.SubmitChanges();

                                    }
                                }

                            }
                            else Listloi.Add(vl.Index.ToString());
                        }
                    }
                    this.lbLoi.Text = "Import câu hỏi thành công";
                    this.btnImport.Enabled = false;
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
        }


        private void DgvImport_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            if (dgvImport.ColumnCount == 13)
            {
                this.btnImport.Enabled = true;
                return;
            }
            this.lbLoi.Text = "File import không đúng định dạng!";
            this.btnImport.Enabled = false;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnChonfile_Click(object sender, EventArgs e)
        {
            this.lbLoi.Text = "";
            dgvLoi.DataSource = "";
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
                        dgvImport.DataSource = "";
                        dgvImport.DataSource = dt;

                        reader.Close();
                        getData = 1;
                        dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


                        ofd.Dispose();

                    }
                    catch (FieldAccessException ex)
                    {
                        MessageBox.Show("Không thể lấy dữ liệu từ file,Kiếm tra lại" + ex.ToString());

                    }
                }
            }
        }
    }
}
