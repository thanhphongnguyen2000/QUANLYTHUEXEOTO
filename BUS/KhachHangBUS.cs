using QUANLYTHUEXEOTO.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYTHUEXEOTO.BUS
{
    class KhachHangBUS
    {
        KhachHangDAL dalKH;

        public KhachHangBUS()
        {
            dalKH = new KhachHangDAL();
        }

        //Lấy danh sách khách hàng
        public void LayDSKhachHang(DataGridView dgv)
        {
            dgv.DataSource = dalKH.LayDSKhachHang();
        }

        //Thêm mới khách hàng
        public bool themKhachHang(tb_KhachHang kh)
        {
            try
            {
                dalKH.themKhachHang(kh);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Sửa khách hàng
        public bool suaKhachHang(tb_KhachHang kh)
        {
            //Kiểm tra khách hàng
            if (dalKH.kiemTraKhachHang(kh))
            {
                try
                {
                    //Sửa khách hàng
                    dalKH.suaKhachHang(kh);
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

        //Xóa khách hàng
        public bool xoaKhachHang(tb_KhachHang kh)
        {
            //Kiểm tra khách hàng
            if (dalKH.kiemTraKhachHang(kh))
            {
                try
                {
                    //Xóa khách hàng
                    dalKH.xoaKhachHang(kh);
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
