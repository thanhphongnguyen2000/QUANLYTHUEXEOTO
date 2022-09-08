using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHUEXEOTO.DAL
{
    class KhachHangDAL
    {
        QuanLyThueXeEntities db;

        public KhachHangDAL()
        {
            db = new QuanLyThueXeEntities();
        }

        //Lấy Danh Sách Khách Hàng
        public dynamic LayDSKhachHang()
        {
            var dsSP = db.tb_KhachHang.Select(s => new
            {
                s.MaKH,
                s.TenKH,
                s.CCCD,
                s.SDT,
                s.GioiTinh,
                s.DiaChi
            }).ToList();
            return dsSP;
        }

        //Thêm Khách Hàng
        public void themKhachHang(tb_KhachHang kh)
        {
            db.tb_KhachHang.Add(kh);
            db.SaveChanges();
        }

        //Kiểm Tra Khách Hàng Có Tồn Tại Không
        public bool kiemTraKhachHang(tb_KhachHang kh)
        {
            tb_KhachHang khachhang = db.tb_KhachHang.Find(kh.MaKH);
            if (kh != null)
            {
                return true;
            }
            else
                return false;
        }

        //Sửa Khách Hàng
        public void suaKhachHang(tb_KhachHang kh)
        {
            tb_KhachHang khachhang = db.tb_KhachHang.Find(kh.MaKH);
            khachhang.TenKH = kh.TenKH;
            khachhang.GioiTinh = kh.GioiTinh;
            khachhang.CCCD = kh.CCCD;
            khachhang.SDT = kh.SDT;
            khachhang.DiaChi = kh.DiaChi;
            db.SaveChanges();
        }

        //Xóa Khách Hàng
        public void xoaKhachHang(tb_KhachHang kh)
        {
            tb_KhachHang khachhang = db.tb_KhachHang.Find(kh.MaKH);
            db.tb_KhachHang.Remove(khachhang);
            db.SaveChanges();
        }
    }
}
