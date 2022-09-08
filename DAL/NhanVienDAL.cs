using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHUEXEOTO.DAL
{
    class NhanVienDAL
    {
        QuanLyThueXeEntities db;

        public NhanVienDAL()
        {
            db = new QuanLyThueXeEntities();
        }

        //Lấy Danh Sách Nhân Viên
        public dynamic LayDSNhanVien()
        {
            var dsNV = db.tb_NhanVien.Select(s => new
            {
                s.MaNV,
                s.HoTen,
                s.NgaySinh,
                s.CCCD,
                s.SDT,
                s.DiaChi,
                s.GioiTinh,
                s.Luong,
                s.ChucVu
            }).ToList();
            return dsNV;
        }

        //Lấy Danh Sách Nhân Viên Theo Tên
        /*public dynamic LayDSNhanVienTheoTen()
        {
            var dsNV = db.tb_NhanVien.Select(s => new
            {
                s.MaNV,
                s.HoTen,
                s.NgaySinh,
                s.CCCD,
                s.SDT,
                s.DiaChi,
                s.GioiTinh,
                s.Luong,
                s.ChucVu
            }).ToList();
            return dsNV;
        }*/

        //Thêm Nhân Viên Mới
        public void themNhanVien(tb_NhanVien nv)
        {
            db.tb_NhanVien.Add(nv);
            db.SaveChanges();
        }

        //Kiểm Tra Nhân Viên Có Tồn Tại Không
        public bool kiemTraNhanVien(tb_NhanVien nv)
        {
            tb_NhanVien nhanvien = db.tb_NhanVien.Find(nv.MaNV);
            if (nv != null)
            {
                return true;
            }
            else
                return false;
        }

        //Sửa Nhân Viên
        public void suaNhanVien(tb_NhanVien nv)
        {
            tb_NhanVien nhanvien = db.tb_NhanVien.Find(nv.MaNV);
            nhanvien.HoTen = nv.HoTen;
            nhanvien.NgaySinh = nv.NgaySinh;
            nhanvien.CCCD = nv.CCCD;
            nhanvien.SDT = nv.SDT;
            nhanvien.DiaChi = nv.DiaChi;
            nhanvien.GioiTinh = nv.GioiTinh;
            nhanvien.Luong = nv.Luong;
            nhanvien.ChucVu = nv.ChucVu;
            db.SaveChanges();
        }

        //Xóa Nhân Viên
        public void xoaNhanVien(tb_NhanVien nv)
        {
            tb_NhanVien nhanvien = db.tb_NhanVien.Find(nv.MaNV);
            db.tb_NhanVien.Remove(nhanvien);
            db.SaveChanges();
        }
    }
}
