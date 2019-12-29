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
    public partial class fChitietcauhoi : Form
    {
        public int ID, Khoi;
        public fChitietcauhoi(int dch, int khoichon)
        {
            InitializeComponent();

            Load += LoadControl;
            Load += LoadData;
            ID = dch;
            Khoi = khoichon;
        }

        private void LoadData(object sender, EventArgs e)
        {
            using (var DB = new QTDataContext())
            {
                var CH = DB.CauHois.Where(idx => idx.ID == ID && idx.Khoi == Khoi).SingleOrDefault();
                this.txtMotacauhoi.Text = CH.Mota;
                foreach(var vl in CH.CT_CauHois)
                {
                    if (vl.IDdapan == "A ")
                    {
                        this.txtDAA.Text = vl.Mota;
                    }
                    else if(vl.IDdapan == "B ")
                    {
                        this.txtDAB.Text = vl.Mota;
                    }
                    else if (vl.IDdapan == "C ")
                    {
                        this.txtDAC.Text = vl.Mota;
                    }
                    else if (vl.IDdapan == "D ")
                    {
                        this.txtDAD.Text = vl.Mota;
                    }
                    else if (vl.IDdapan == "E ")
                    {
                        this.txtDAE.Text = vl.Mota;
                    }

                    if(vl.Dung == true)
                    {
                        lbDapan.Text += vl.IDdapan;
                    }
                }
                
            }
        }

        private void LoadControl(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.btnThoat.Click += BtnThoat_Click;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
