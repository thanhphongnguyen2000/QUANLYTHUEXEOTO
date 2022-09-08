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

using System.Text.RegularExpressions;
using QUANLYTHUEXEOTO.BUS;

namespace QUANLYTHUEXEOTO.Forms
{
    public partial class frmEmployee : Form
    {
        NhanVienBUS busNV;
        public frmEmployee()
        {
            InitializeComponent();
            busNV = new NhanVienBUS();
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
            lblThongTin.ForeColor = ThemeColor.PrimaryColor;
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            LoadTheme();
            HienThiDSNhanVien();
        }

        // Hiển Thị Danh Sách Nhân Viên
        private void HienThiDSNhanVien()
        {
            dgvNhanVien.DataSource = null;
            busNV.LayDSNhanVien(dgvNhanVien);
            dgvNhanVien.Columns[0].Width = (int)(dgvNhanVien.Width * 0.05);
            dgvNhanVien.Columns[1].Width = (int)(dgvNhanVien.Width * 0.2);
            dgvNhanVien.Columns[2].Width = (int)(dgvNhanVien.Width * 0.1);
            dgvNhanVien.Columns[3].Width = (int)(dgvNhanVien.Width * 0.1);
            dgvNhanVien.Columns[4].Width = (int)(dgvNhanVien.Width * 0.1);
            dgvNhanVien.Columns[5].Width = (int)(dgvNhanVien.Width * 0.15);
            dgvNhanVien.Columns[6].Width = (int)(dgvNhanVien.Width * 0.1);
            dgvNhanVien.Columns[7].Width = (int)(dgvNhanVien.Width * 0.1);
            dgvNhanVien.Columns[8].Width = (int)(dgvNhanVien.Width * 0.1);

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

        //Kiểm tra thông tin nhập vào
        private bool kiemTraDayDuThongTin()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Texts))
            {
                txtHoTen.Focus();
                MessageBox.Show("Bạn cần nhập đầy đủ họ tên!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Ngày tháng năm sinh
            if (string.IsNullOrWhiteSpace(dtpNgaySinh.Text))
            {
                dtpNgaySinh.Focus();
                MessageBox.Show("Bạn cần nhập đúng định dạng ngày tháng năm sinh!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (!DateTime.TryParse(dtpNgaySinh.Text, out DateTime dt))
                {
                    dtpNgaySinh.Focus();
                    MessageBox.Show("Bạn cần nhập đúng định dạng ngày tháng năm sinh!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            //Căn cước công dân
            if (string.IsNullOrWhiteSpace(txtCCCD.Texts))
            {
                txtCCCD.Focus();
                MessageBox.Show("Bạn cần nhập đầy đủ số căn cước công dân!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (!long.TryParse(txtCCCD.Texts, out long cccd))
                {
                    txtCCCD.Focus();
                    MessageBox.Show("Căn cước công dân phải là định dạng số!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txtCCCD.Texts.Length > 12)
                {
                    txtCCCD.Focus();
                    MessageBox.Show("Số căn cước không thể quá 12 kí tự!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            // Số điện thoại
            if (string.IsNullOrWhiteSpace(txtDienThoai.Texts))
            {
                txtDienThoai.Focus();
                MessageBox.Show("Bạn cần nhập đầy đủ số điện thoại!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (!long.TryParse(txtDienThoai.Texts, out long sdt))
                {
                    txtDienThoai.Focus();
                    MessageBox.Show("Bạn cần nhập đúng định dạng số điện thoại!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txtDienThoai.Texts.Length > 10)
                {
                    txtDienThoai.Focus();
                    MessageBox.Show("Số điện thoại không thể quá 10 kí tự!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            //Địa chỉ
            if (string.IsNullOrWhiteSpace(txtDiaChi.Texts))
            {
                txtDiaChi.Focus();
                MessageBox.Show("Bạn cần nhập địa chỉ!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Giới tính
            if (string.IsNullOrWhiteSpace(cbbGioiTinh.Text))
            {
                cbbGioiTinh.Focus();
                MessageBox.Show("Bạn cần chọn giới tính!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Lương
            if (string.IsNullOrWhiteSpace(txtLuong.Texts))
            {
                txtLuong.Focus();
                MessageBox.Show("Bạn cần nhập đầy đủ lương!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (!decimal.TryParse(txtLuong.Texts, out decimal luong))
                {
                    txtLuong.Focus();
                    MessageBox.Show("Bạn cần nhập lương đúng định dạng số!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            // Chức vụ
            if (string.IsNullOrWhiteSpace(txtChucVu.Texts))
            {
                txtChucVu.Focus();
                MessageBox.Show("Bạn cần nhập chức vụ!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //nếu đúng hết thì trả về false
            return true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tb_NhanVien nv = new tb_NhanVien();
            if (kiemTraDayDuThongTin())
            {
                nv.HoTen = txtHoTen.Texts;
                nv.NgaySinh = dtpNgaySinh.Value;
                nv.CCCD = txtCCCD.Texts;
                nv.SDT = txtDienThoai.Texts;
                nv.DiaChi = txtDiaChi.Texts;
                nv.GioiTinh = cbbGioiTinh.SelectedItem.ToString();
                nv.Luong = (decimal.Parse(txtLuong.Texts));
                nv.ChucVu = txtChucVu.Texts;

                //Gọi sự kiện thêm nhân viên BUS
                busNV.themNhanVien(nv);
                MessageBox.Show("Thêm Nhân Viên Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                busNV.LayDSNhanVien(dgvNhanVien);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tb_NhanVien nv = new tb_NhanVien();
            if (kiemTraDayDuThongTin())
            {
                nv.MaNV = int.Parse(txtMaNV.Texts);
                nv.HoTen = txtHoTen.Texts;
                nv.NgaySinh = dtpNgaySinh.Value;
                nv.CCCD = txtCCCD.Texts;
                nv.SDT = txtDienThoai.Texts;
                nv.DiaChi = txtDiaChi.Texts;
                nv.GioiTinh = cbbGioiTinh.SelectedItem.ToString();
                nv.Luong = (decimal.Parse(txtLuong.Texts));
                nv.ChucVu = txtChucVu.Texts;

                //Gọi sự kiện sửa nhân viên BUS
                busNV.suaNhanVien(nv);
                MessageBox.Show("Sửa Nhân Viên Có Mã " + nv.MaNV + " Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                busNV.LayDSNhanVien(dgvNhanVien);
            }
        }

        private void txtTimKiem__TextChanged(object sender, EventArgs e)
        {
            /*QuanLyThueXeEntities db = new QuanLyThueXeEntities();
            dgvNhanVien.DataSource = db.tb_NhanVien.Where(p=>p.HoTen.Equals(txtTimKiem.Texts));
            dgvNhanVien.Columns[0].Width = (int)(dgvNhanVien.Width * 0.05);
            dgvNhanVien.Columns[1].Width = (int)(dgvNhanVien.Width * 0.2);
            dgvNhanVien.Columns[2].Width = (int)(dgvNhanVien.Width * 0.1);
            dgvNhanVien.Columns[3].Width = (int)(dgvNhanVien.Width * 0.1);
            dgvNhanVien.Columns[4].Width = (int)(dgvNhanVien.Width * 0.1);
            dgvNhanVien.Columns[5].Width = (int)(dgvNhanVien.Width * 0.15);
            dgvNhanVien.Columns[6].Width = (int)(dgvNhanVien.Width * 0.1);
            dgvNhanVien.Columns[7].Width = (int)(dgvNhanVien.Width * 0.1);
            dgvNhanVien.Columns[8].Width = (int)(dgvNhanVien.Width * 0.1);*/
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tb_NhanVien nv = new tb_NhanVien();
            if (kiemTraDayDuThongTin())
            {
                nv.MaNV = int.Parse(txtMaNV.Texts);
                nv.HoTen = txtHoTen.Texts;
                nv.NgaySinh = dtpNgaySinh.Value;
                nv.CCCD = txtCCCD.Texts;
                nv.SDT = txtDienThoai.Texts;
                nv.DiaChi = txtDiaChi.Texts;
                nv.GioiTinh = cbbGioiTinh.SelectedItem.ToString();
                nv.Luong = (decimal.Parse(txtLuong.Texts));
                nv.ChucVu = txtChucVu.Texts;

                //Gọi sự kiện xóa nhân viên BUS
                busNV.xoaNhanVien(nv);
                MessageBox.Show("Xóa Nhân Viên Có Mã " + nv.MaNV + " Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                busNV.LayDSNhanVien(dgvNhanVien);
            }

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0 && e.RowIndex < dgvNhanVien.Rows.Count)
            {
                txtMaNV.Texts = dgvNhanVien.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                txtHoTen.Texts = dgvNhanVien.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
                dtpNgaySinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
                txtCCCD.Texts = dgvNhanVien.Rows[e.RowIndex].Cells["CCCD"].Value.ToString();
                txtDienThoai.Texts = dgvNhanVien.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
                txtDiaChi.Texts = dgvNhanVien.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                cbbGioiTinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                txtLuong.Texts = dgvNhanVien.Rows[e.RowIndex].Cells["Luong"].Value.ToString();
                txtChucVu.Texts = dgvNhanVien.Rows[e.RowIndex].Cells["ChucVu"].Value.ToString();
            }
        }
    }
}
