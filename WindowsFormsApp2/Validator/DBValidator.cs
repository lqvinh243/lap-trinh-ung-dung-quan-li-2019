using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Validatior
{
    public class DBValidator : BaseValidator
    {
        public int ValidatorCheck;
        public override bool Validate()
        {
            using (var DB = new QTDataContext())
            {

                if (ValidatorCheck == 1)
                {
                    if (!string.IsNullOrWhiteSpace(Controltovalidate.Text))
                    {
                        var linq = DB.NguoiDungs.Where(a => a.TaiKhoan == this.Controltovalidate.Text).SingleOrDefault();
                        if (linq == null)
                        {
                            this.ErrMess = "Tên đăng nhập không tồn tại trong hệ thống!";
                            return false;
                        }

                    }
                }
                else if (ValidatorCheck == 2)
                {
                    var linq = DB.NguoiDungs.Where(a => a.CMND == this.Controltovalidate.Text).SingleOrDefault();
                    if (linq == null)
                    {
                        this.ErrMess = "Không tồn tại số CMND này trong hệ thống!";
                        return false;
                    }
                    else
                    {
                        if ((linq.TaiKhoan ?? "").Length > 0)
                        {
                            this.ErrMess = "Số CMND này đã đăng ký tài khoản, vui lòng kiểm tra lại!";
                            return false;
                        }
                    }
                }
                else if (ValidatorCheck == 3)
                {
                    var linq = DB.NguoiDungs.Where(a => a.TaiKhoan == this.Controltovalidate.Text).FirstOrDefault();
                    if (linq != null)
                    {
                        this.ErrMess = "Tên đăng nhập đã tồn tại vui lòng chọn tên khác!";
                        return false;
                    }
                }
                else if (ValidatorCheck == 4)
                {
                    var linq = DB.NguoiDungs.Where(a => a.CMND == this.Controltovalidate.Text && a.ID != CurrentUser.UserID).SingleOrDefault();
                    if (linq != null)
                    {
                        this.ErrMess = "CMND đã tồn tại!";
                        return false;
                    }
                }
                else if (ValidatorCheck == 5)
                {
                    var linq = DB.NguoiDungs.Where(a => a.CMND == this.Controltovalidate.Text).SingleOrDefault();
                    if (linq != null)
                    {
                        this.ErrMess = "CMND đã tồn tại!";
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
