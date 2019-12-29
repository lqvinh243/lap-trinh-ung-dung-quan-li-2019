using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.FormGiaoVien;
using WindowsFormsApp2.FormHocSinh;
using WindowsFormsApp2.FormQuanTri;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                if (CurrentUser.PhanQuyen == 0)
                {
                    Application.Run(new fDangnhap());
                }

                if (CurrentUser.PhanQuyen == 1)
                {
                    Application.Run(new fmainHocsinh());
                }
                else if (CurrentUser.PhanQuyen == 2)
                {
                    Application.Run(new fmainGiaovien());
                }
                else if (CurrentUser.PhanQuyen == 3)
                {
                    Application.Run(new fmainQuantri());
                }
                else if (CurrentUser.PhanQuyen == -1)
                {
                    break;
                }
            }
        }
    }
}
