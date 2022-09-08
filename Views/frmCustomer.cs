using QUANLYTHUEXEOTO.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYTHUEXEOTO.Forms
{
    public partial class frmCustomer : Form
    {
        KhachHangBUS busKH;
        public frmCustomer()
        {
            InitializeComponent();
            busKH = new KhachHangBUS();
        }

        //Kiểm tra thông tin nhập vào
        private bool kiemTraDayDuThongTin()
        {
            //Họ Tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Texts))
            {
                txtHoTen.Focus();
                MessageBox.Show("Bạn cần nhập đầy đủ họ tên!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
            // Giới tính
            if (string.IsNullOrWhiteSpace(cbbGioiTinh.Text))
            {
                cbbGioiTinh.Focus();
                MessageBox.Show("Bạn cần chọn giới tính!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //Địa chỉ
            if (string.IsNullOrWhiteSpace(txtDiaChi.Texts))
            {
                txtDiaChi.Focus();
                MessageBox.Show("Bạn cần nhập địa chỉ!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //nếu đúng hết thì trả về false
            return true;

        }

        //Hiển thị danh sách khách hàng
        private void HienThiDSKhachHang()
        {
            dgvKhachHang.DataSource = null;
            busKH.LayDSKhachHang(dgvKhachHang);
            dgvKhachHang.Columns[0].Width = (int)(dgvKhachHang.Width * 0.15);
            dgvKhachHang.Columns[1].Width = (int)(dgvKhachHang.Width * 0.2);
            dgvKhachHang.Columns[2].Width = (int)(dgvKhachHang.Width * 0.15);
            dgvKhachHang.Columns[3].Width = (int)(dgvKhachHang.Width * 0.15);
            dgvKhachHang.Columns[4].Width = (int)(dgvKhachHang.Width * 0.1);
            dgvKhachHang.Columns[5].Width = (int)(dgvKhachHang.Width * 0.25);

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
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadTheme();
            HienThiDSKhachHang();
        }

        private void dgvKhachHang_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvKhachHang.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 255);
                dgvKhachHang.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void dgvKhachHang_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvKhachHang.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                dgvKhachHang.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvKhachHang.Rows.Count)
            {
                txtMaKH.Texts = dgvKhachHang.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
                txtHoTen.Texts = dgvKhachHang.Rows[e.RowIndex].Cells["TenKH"].Value.ToString();
                txtCCCD.Texts = dgvKhachHang.Rows[e.RowIndex].Cells["CCCD"].Value.ToString();
                txtDienThoai.Texts = dgvKhachHang.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
                cbbGioiTinh.Text = dgvKhachHang.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                txtDiaChi.Texts = dgvKhachHang.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tb_KhachHang kh = new tb_KhachHang();
            if (kiemTraDayDuThongTin())
            {
                kh.TenKH = txtHoTen.Texts;
                kh.CCCD = txtCCCD.Texts;
                kh.SDT = txtDienThoai.Texts;
                kh.DiaChi = txtDiaChi.Texts;
                kh.GioiTinh = cbbGioiTinh.SelectedItem.ToString();

                //Gọi sự kiện thêm nhân viên BUS
                busKH.themKhachHang(kh);
                MessageBox.Show("Thêm Khách Hàng Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                busKH.LayDSKhachHang(dgvKhachHang);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tb_KhachHang kh = new tb_KhachHang();
            if (kiemTraDayDuThongTin())
            {
                kh.MaKH = int.Parse(txtMaKH.Texts);
                kh.TenKH = txtHoTen.Texts;
                kh.CCCD = txtCCCD.Texts;
                kh.SDT = txtDienThoai.Texts;
                kh.GioiTinh = cbbGioiTinh.SelectedItem.ToString();
                kh.DiaChi = txtDiaChi.Texts;

                //Gọi sự kiện sửa nhân viên BUS
                busKH.suaKhachHang(kh);
                MessageBox.Show("Sửa Khách Hàng Có Mã " + kh.MaKH + " Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                busKH.LayDSKhachHang(dgvKhachHang);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tb_KhachHang kh = new tb_KhachHang();
            if (kiemTraDayDuThongTin())
            {
                kh.MaKH = int.Parse(txtMaKH.Texts);
                kh.TenKH = txtHoTen.Texts;
                kh.CCCD = txtCCCD.Texts;
                kh.SDT = txtDienThoai.Texts;
                kh.GioiTinh = cbbGioiTinh.SelectedItem.ToString();
                kh.DiaChi = txtDiaChi.Texts;

                //Gọi sự kiện xóa nhân viên BUS
                busKH.xoaKhachHang(kh);
                MessageBox.Show("Xóa Khách Hàng Có Mã " + kh.MaKH + " Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                busKH.LayDSKhachHang(dgvKhachHang);
            }
        }
    }
}
