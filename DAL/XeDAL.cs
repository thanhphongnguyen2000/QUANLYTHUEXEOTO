using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHUEXEOTO.DAL
{
    class XeDAL
    {
        QuanLyThueXeEntities db;

        public XeDAL()
        {
            db = new QuanLyThueXeEntities();
        }

        //Lấy Danh Sách Xe
        public dynamic LayDSSanPham()
        {
            var dsSP = db.tb_Xe.Select(s => new
            {
                s.MaXe,
                s.TenXe,
                s.SoChoNgoi,
                s.GiaThue,
                s.TinhTrang,
                s.MaLoaiXe
            }).ToList();
            return dsSP;
        }

        //Lấy Danh Sách Xe Có Sỗ Chỗ Bằng 4
        public dynamic LayDSSanPhamXe4Cho()
        {
            var dsSP = db.tb_Xe.Where(x => x.SoChoNgoi == 4).Select(s => new
            {
                s.MaXe,
                s.TenXe,
                s.SoChoNgoi,
                s.GiaThue,
                s.TinhTrang,
                s.MaLoaiXe
            }).ToList();
            return dsSP;
        }

        //Lấy Danh Sách Xe Có Sỗ Chỗ Bằng 7
        public dynamic LayDSSanPhamXe7Cho()
        {
            var dsSP = db.tb_Xe.Where(x => x.SoChoNgoi == 7).Select(s => new
            {
                s.MaXe,
                s.TenXe,
                s.SoChoNgoi,
                s.GiaThue,
                s.TinhTrang,
                s.MaLoaiXe
            }).ToList();
            return dsSP;
        }

        //Lấy Danh Sách Xe Còn Trống
        public dynamic LayDSSanPhamXeTrong()
        {
            var dsSP = db.tb_Xe.Where(x => x.TinhTrang == "Xe Trống").Select(s => new
            {
                s.MaXe,
                s.TenXe,
                s.SoChoNgoi,
                s.GiaThue,
                s.TinhTrang,
                s.MaLoaiXe
            }).ToList();
            return dsSP;
        }

        //Lấy Danh Sách Xe Đã Đặt
        public dynamic LayDSSanPhamXeDaDat()
        {
            var dsSP = db.tb_Xe.Where(x => x.TinhTrang == "Xe Đã Đặt").Select(s => new
            {
                s.MaXe,
                s.TenXe,
                s.SoChoNgoi,
                s.GiaThue,
                s.TinhTrang,
                s.MaLoaiXe
            }).ToList();
            return dsSP;
        }

        //Lấy Ra Danh Sách Xe Còn Trống
        public dynamic LayDSChiTietXeTrong()
        {
            var dsSP = db.tb_Xe.Where(x => x.TinhTrang == "Xe Trống").Select(s => new
            {
                s.TenXe,
                s.SoChoNgoi
            }).ToList();
            return dsSP;
        }

        //Lấy Ra Xe Đã Được Chọn
        public dynamic LayDSXeDaChon(int maXe)
        {
            var dsSP = db.tb_Xe.Where(x => x.MaXe == maXe).Select(s => new
            {
                s.TenXe,
                s.SoChoNgoi
            }).ToList();
            return dsSP;
        }

        //Lấy Danh Sách Loại Sản Phẩm
        public dynamic LayDSLoaiSanPham()
        {
            var dsSP = db.tb_LoaiXe.Select(s => new
            {
                s.MaLoaiXe,
                s.TenLoaiXe
            }).ToList();
            return dsSP;
        }

        //Thêm Xe Mới
        public void themSanPham(tb_Xe sp)
        {
            db.tb_Xe.Add(sp);
            db.SaveChanges();
        }

        //Kiểm Tra Xe Có Tồn Tại Không
        public bool kiemTraSanPham(tb_Xe xe)
        {
            tb_Xe x = db.tb_Xe.Find(xe.MaXe);
            if (xe != null)
            {
                return true;
            }
            else
                return false;
        }

        //Sửa Thông Tin Xe
        public void suaSanPham(tb_Xe xe)
        {
            tb_Xe x = db.tb_Xe.Find(xe.MaXe);
            x.TenXe = xe.TenXe;
            x.SoChoNgoi = xe.SoChoNgoi;
            x.GiaThue = xe.GiaThue;
            x.TinhTrang = xe.TinhTrang;
            x.MaLoaiXe = xe.MaLoaiXe;
            db.SaveChanges();
        }

        //Xóa Xe Trong Danh Sách
        public void xoaSanPham(tb_Xe xe)
        {
            tb_Xe x = db.tb_Xe.Find(xe.MaXe);
            db.tb_Xe.Remove(x);
            db.SaveChanges();
        }

        //Tìm Kiếm Xe Khi Truy Vấn
        /*public dynamic TimKiemXe(string tenXe)
        {
            var dsSP = db.tb_Xe.Where(x => x.TenXe == tenXe).Select(s => new
            {
                s.MaXe,
                s.TenXe,
                s.SoChoNgoi,
                s.GiaThue,
                s.TinhTrang,
                s.MaLoaiXe
            }).ToList();
            return dsSP;
        }*/
    }
}

