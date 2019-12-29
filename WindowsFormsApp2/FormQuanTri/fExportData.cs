using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.FormQuanTri.CrytalReport;
//using WindowsFormsApp2.FormQuanTri.CrytalReport;

namespace WindowsFormsApp2.FormQuanTri
{
    public partial class fExportData : Form
    {
        int i { get; set; }
        public fExportData(int v)
        {
            InitializeComponent();

            i = v;
            Load += LoadControl;
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.btnTatca.Click += BtnTatca_Click;
            this.btnThoat.Click += BtnThoat_Click;
            if (i == 2  && i == 4)
            {
                this.panel1.Hide();
            }
            
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnTatca_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                RPTatcahocsinh rp = new RPTatcahocsinh();
                rp.SetParameterValue("Ngaytao", DateTime.Now.ToShortDateString());
                rpView.ReportSource = rp;

            }
            else if (i == 2)
            {
                RPTatcagiaovien rp = new RPTatcagiaovien();
                rp.SetParameterValue("Ngaytao", DateTime.Now.ToShortDateString());
                rpView.ReportSource = rp;
            }
            else if (i == 4)
            {
                RPTatcanguoidung rp = new RPTatcanguoidung();
                rp.SetParameterValue("Ngaytao", DateTime.Now.ToShortDateString());
                rpView.ReportSource = rp;
            }

        }
    }
}
