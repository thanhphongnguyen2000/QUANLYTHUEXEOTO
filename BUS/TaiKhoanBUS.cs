using QUANLYTHUEXEOTO.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHUEXEOTO.BUS
{
    class TaiKhoanBUS
    {
        private static TaiKhoanBUS Instance;

        private TaiKhoanBUS()
        {

        }

        public static TaiKhoanBUS GetInstance()
        {
            if (Instance == null)
            {
                Instance = new TaiKhoanBUS();
            }
            return Instance;
        }

        //Kiểm tra tài khoản có tồn tại không
        /*public tb_TaiKhoan kiemTraTaiKhoan(string username, string pass)
        {
        }*/
    }
}
