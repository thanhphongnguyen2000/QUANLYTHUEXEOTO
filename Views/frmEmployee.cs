using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL;
using BUS;
using System.Text.RegularExpressions;
using QUANLYTHUEXEOTO.Views;

namespace QUANLYTHUEXEOTO.Forms
{
    public partial class frmEmployee : Form
    {
        ObservableCollection<tb_NhanVien> listData;
        public frmEmployee()
        {
            InitializeComponent();
            listData = new ObservableCollection<tb_NhanVien>(NhanVienBUS.GetInstance().getDataNhanVien());
            //dgvNhanVien.DataSource = listData;
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            lblChuDe.ForeColor = ThemeColor.SecondaryColor;
            lblTimKiem.ForeColor = ThemeColor.PrimaryColor;
            lblThongTin.ForeColor = ThemeColor.PrimaryColor;
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void dgvNhanVien_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvNhanVien.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                dgvNhanVien.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void dgvNhanVien_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvNhanVien.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 255);
                dgvNhanVien.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        #region method
        //Thêm nhân viên
        void addNhanVien(tb_NhanVien nv)
        {
            listData.Add(nv);
            if (NhanVienBUS.GetInstance().addNhanVien(nv))
                MessageBox.Show("Thêm Nhân Viên Thành Công!", "Susscess!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //Sửa nhân viên để update lên list view
        void updateNhanVien(tb_NhanVien nv)
        {
            tb_NhanVien nhanVien_Sua = listData.Where(s => s.MaNV.Equals(nv.MaNV)).FirstOrDefault();
            nhanVien_Sua.HoTen = nv.HoTen;
            nhanVien_Sua.GioiTinh = nv.GioiTinh;
            nhanVien_Sua.NgaySinh = nv.NgaySinh;
            nhanVien_Sua.Luong = nv.Luong;
            nhanVien_Sua.SDT = nv.SDT;
            nhanVien_Sua.CCCD = nv.CCCD;
            nhanVien_Sua.ChucVu = nv.ChucVu;
            nhanVien_Sua.DiaChi = nv.DiaChi;

            if (NhanVienBUS.GetInstance().updateNhanVien(nv))
            {
                MessageBox.Show("Sửa Nhân Viên Thành Công!", "Susscess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public string RemoveVietnameseTone(string text)
        {
            string result = text.ToLower();
            result = Regex.Replace(result, "à|á|ạ|ả|ã|â|ầ|ấ|ậ|ẩ|ẫ|ă|ằ|ắ|ặ|ẳ|ẵ|/g", "a");
            result = Regex.Replace(result, "è|é|ẹ|ẻ|ẽ|ê|ề|ế|ệ|ể|ễ|/g", "e");
            result = Regex.Replace(result, "ì|í|ị|ỉ|ĩ|/g", "i");
            result = Regex.Replace(result, "ò|ó|ọ|ỏ|õ|ô|ồ|ố|ộ|ổ|ỗ|ơ|ờ|ớ|ợ|ở|ỡ|/g", "o");
            result = Regex.Replace(result, "ù|ú|ụ|ủ|ũ|ư|ừ|ứ|ự|ử|ữ|/g", "u");
            result = Regex.Replace(result, "ỳ|ý|ỵ|ỷ|ỹ|/g", "y");
            result = Regex.Replace(result, "đ", "d");
            return result;
        }
        private bool filterTimKiem(object obj)
        {
            if (String.IsNullOrEmpty(txtTimKiem.Texts))
                return true;
            else
            {
                string objTenNV = RemoveVietnameseTone((obj as tb_NhanVien).HoTen);
                string timkiem = RemoveVietnameseTone(txtTimKiem.Texts);
                return objTenNV.Contains(timkiem);
            }
        }
        #endregion

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmAdd_Up_Employee frm = new frmAdd_Up_Employee();
            frm.themNhanVien = new frmAdd_Up_Employee.CRUD(addNhanVien);
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //tb_NhanVien nv = (sender as Button).DataContext as tb_NhanVien;
            frmAdd_Up_Employee themNhanVien = new frmAdd_Up_Employee();
            //themNhanVien.truyenNhanVien(nv);
            themNhanVien.suaNhanVien = new frmAdd_Up_Employee.CRUD(updateNhanVien);
            themNhanVien.ShowDialog();
        }

        private void txtTimKiem__TextChanged(object sender, EventArgs e)
        {
            //CollectionView viewNV = (CollectionView)CollectionViewSource.GetDefaultView(lvNhanVien.ItemsSource);
            //viewNV.Filter = filterTimKiem;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //tb_NhanVien nv = (sender as Button).DataContext as tb_NhanVien;
            //DialogResult dr;
            //dr = MessageBox.Show("Bạn Có Muốn Xóa Nhân Viên " + nv.HoTen, "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dr == DialogResult.Yes)
            //{
            //if (NhanVienBUS.GetInstance().deleteNhanVien(nv))
            //{
            //listData.Remove(nv);
            //MessageBox.Show("Xóa Nhân Viên " + nv.HoTen + " Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            // }
        }
    }
}
