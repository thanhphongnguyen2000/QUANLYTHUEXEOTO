using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTHUEXEOTO.DAL;

namespace QUANLYTHUEXEOTO.BUS
{
    class NhanVienBUS
    {
        NhanVienDAL dalNV;

        public NhanVienBUS()
        {
            dalNV = new NhanVienDAL();
        }

        //Lấy danh sách nhân viên
        public void LayDSNhanVien(DataGridView dgv)
        {
            dgv.DataSource = dalNV.LayDSNhanVien();
        }

        //Lấy danh sách nhân viên theo tên
        /*public void LayDSNhanVienTheoTen(DataGridView dgv)
        {
            dgv.DataSource = dalNV.LayDSNhanVienTheoTen();
        }*/

        //Thêm mới nhân viên
        public bool themNhanVien(tb_NhanVien nv)
        {
            try
            {
                dalNV.themNhanVien(nv);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Sửa nhân viên
        public bool suaNhanVien(tb_NhanVien nv)
        {
            //Kiểm tra nhân viên
            if (dalNV.kiemTraNhanVien(nv))
            {
                try
                {
                    //Sửa nhân viên
                    dalNV.suaNhanVien(nv);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //Xóa nhân viên
        public bool xoaNhanVien(tb_NhanVien nv)
        {
            //Kiểm tra nhân viên
            if (dalNV.kiemTraNhanVien(nv))
            {
                try
                {
                    //Xóa nhân viên
                    dalNV.xoaNhanVien(nv);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
