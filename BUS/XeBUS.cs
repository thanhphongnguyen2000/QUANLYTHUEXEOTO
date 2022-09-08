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
    class XeBUS
    {
        XeDAL dalXE;

        public XeBUS()
        {
            dalXE = new XeDAL();
        }

        //Lấy danh sách xe
        public void LayDSSanPham(DataGridView dgv)
        {
            dgv.DataSource = dalXE.LayDSSanPham();
        }

        //Lấy danh sách xe 4 chỗ
        public void LayDSSanPhamXe4Cho(DataGridView dgv)
        {
            dgv.DataSource = dalXE.LayDSSanPhamXe4Cho();
        }

        //Lấy danh sách xe 7 chỗ
        public void LayDSSanPhamXe7Cho(DataGridView dgv)
        {
            dgv.DataSource = dalXE.LayDSSanPhamXe7Cho();
        }

        //Lấy danh sách xe còn trống
        public void LayDSSanPhamXeTrong(DataGridView dgv)
        {
            dgv.DataSource = dalXE.LayDSSanPhamXeTrong();
        }

        //Lấy danh sách xe đã đặt
        public void LayDSSanPhamXeDaDat(DataGridView dgv)
        {
            dgv.DataSource = dalXE.LayDSSanPhamXeDaDat();
        }

        //Lấy danh sách chi tiết xe trống
        public void LayDSChiTietXeTrong(DataGridView dgv)
        {
            dgv.DataSource = dalXE.LayDSChiTietXeTrong();
        }

        //Lấy danh sách chi tiết xe đã chọn
        public void LayDSXeDaChon(DataGridView dgv, int maXe)
        {
            dgv.DataSource = dalXE.LayDSXeDaChon(maXe);
        }

        //Lấy danh sách xe đã tìm kiếm
        /*public void TimKiemXe(DataGridView dgv, string tenXe)
        {
            dgv.DataSource = dalXE.TimKiemXe(tenXe);
        }*/

        //Lấy danh sách loại xe
        public void LayDSLoaiSanPham(ComboBox cbb)
        {
            cbb.DataSource = dalXE.LayDSLoaiSanPham();
            cbb.DisplayMember = "MaLoaiXe";
            cbb.ValueMember = "MaLoaiXe";
        }

        //Thêm mới xe
        public bool themSanPham(tb_Xe sp)
        {
            try
            {
                dalXE.themSanPham(sp);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Sửa thông tin xe
        public bool suaSanPham(tb_Xe xe)
        {
            //Kiểm tra xe có tồn tại không
            if (dalXE.kiemTraSanPham(xe))
            {
                try
                {
                    //Sửa thông tin xe
                    dalXE.suaSanPham(xe);
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

        //Xóa xe trong danh sách
        public bool xoaSanPham(tb_Xe xe)
        {
            //Kiểm tra xe
            if (dalXE.kiemTraSanPham(xe))
            {
                try
                {
                    //Xóa xe
                    dalXE.xoaSanPham(xe);
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
