using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.FormHocSinh.Report;

namespace WindowsFormsApp2.FormHocSinh
{
    public partial class fBangdiem : Form
    {
        public fBangdiem()
        {
            InitializeComponent();

            Load += LoadControl;
            Load += LoadData;
        }

        private void LoadData(object sender, EventArgs e)
        {
            //
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.btnThoat.Click += BtnThoat_Click;
            this.btnLoad.Click += BtnLoad_Click;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            RPBangdiem rp = new RPBangdiem();
            rp.SetParameterValue("idhs", CurrentUser.UserID);
            rp.SetParameterValue("idhstg", CurrentUser.UserID);
            rp.SetParameterValue("ngaytao", DateTime.Now.ToShortDateString());
            rpView.ReportSource = rp;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
