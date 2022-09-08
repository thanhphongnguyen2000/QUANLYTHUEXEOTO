using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHUEXEOTO.DAL
{
    class TaiKhoanDAL
    {
        private static TaiKhoanDAL Instance;
        QuanLyThueXeEntities db;

        private TaiKhoanDAL()
        {
            db = new QuanLyThueXeEntities();
        }

        public static TaiKhoanDAL GetInstance()
        {
            if (Instance == null)
            {
                Instance = new TaiKhoanDAL();
            }
            return Instance;
        }

        //Lấy tài khoản từ database


        //Kiểm Tra Nhân Viên Có Tồn Tại Không
        public bool kiemTraTaiKhoan(tb_TaiKhoan tk)
        {
            tb_TaiKhoan taikhoan = db.tb_TaiKhoan.Find(tk.username);
            if (tk != null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
