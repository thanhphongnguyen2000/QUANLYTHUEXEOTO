using QUANLYTHUEXEOTO.BUS;
using QUANLYTHUEXEOTO.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYTHUEXEOTO.Views
{
    public partial class frmCar : Form
    {
        XeBUS busXE;

        public string tenXe;

        public frmCar()
        {
            InitializeComponent();
            busXE = new XeBUS();
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
            //lblInfo.ForeColor = ThemeColor.PrimaryColor;
        }

        //Kiểm tra thông tin nhập vào
        private bool kiemTraDayDuThongTin()
        {
            // Tên xe
            if (string.IsNullOrWhiteSpace(txtTenXe.Texts))
            {
                txtTenXe.Focus();
                MessageBox.Show("Bạn cần nhập tên xe!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Số chỗ ngồi
            if (string.IsNullOrWhiteSpace(cbbSoChoNgoi.Text))
            {
                cbbSoChoNgoi.Focus();
                MessageBox.Show("Bạn cần chọn số chỗ ngồi!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Giá Thuê
            if (string.IsNullOrWhiteSpace(txtGiaThue.Texts))
            {
                txtGiaThue.Focus();
                MessageBox.Show("Bạn cần nhập đầy đủ giá thuê!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (!decimal.TryParse(txtGiaThue.Texts, out decimal giathue))
                {
                    txtGiaThue.Focus();
                    MessageBox.Show("Bạn cần nhập lương đúng định dạng số!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            // Tình Trạng
            if (string.IsNullOrWhiteSpace(cbbTinhTrang.Text))
            {
                cbbTinhTrang.Focus();
                MessageBox.Show("Bạn cần chọn tình trạng xe!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Tên Loại Xe
            if (string.IsNullOrWhiteSpace(cbbMaLoaiXe.Text))
            {
                cbbMaLoaiXe.Focus();
                MessageBox.Show("Bạn cần chọn mã loại xe!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //nếu đúng hết thì trả về false
            return true;
        }

        // Hiển Thị Danh Sách Sản Phẩm
        private void HienThiDSSanPham()
        {
            busXE.LayDSSanPham(dgvProduct);
            dgvProduct.Columns[0].Width = (int)(dgvProduct.Width * 0.1);
            dgvProduct.Columns[1].Width = (int)(dgvProduct.Width * 0.25);
            dgvProduct.Columns[2].Width = (int)(dgvProduct.Width * 0.15);
            dgvProduct.Columns[3].Width = (int)(dgvProduct.Width * 0.15);
            dgvProduct.Columns[4].Width = (int)(dgvProduct.Width * 0.2);
            dgvProduct.Columns[5].Width = (int)(dgvProduct.Width * 0.15);

        }

        // Hiển Thị Danh Sách Sản Phẩm Xe 4 Chỗ
        private void HienThiDSSanPhamXe4Cho()
        {
            busXE.LayDSSanPhamXe4Cho(dgvProduct);
            dgvProduct.Columns[0].Width = (int)(dgvProduct.Width * 0.1);
            dgvProduct.Columns[1].Width = (int)(dgvProduct.Width * 0.25);
            dgvProduct.Columns[2].Width = (int)(dgvProduct.Width * 0.15);
            dgvProduct.Columns[3].Width = (int)(dgvProduct.Width * 0.15);
            dgvProduct.Columns[4].Width = (int)(dgvProduct.Width * 0.2);
            dgvProduct.Columns[5].Width = (int)(dgvProduct.Width * 0.15);

        }

        // Hiển Thị Danh Sách Sản Phẩm Xe 7 Chỗ
        private void HienThiDSSanPhamXe7Cho()
        {
            busXE.LayDSSanPhamXe7Cho(dgvProduct);
            dgvProduct.Columns[0].Width = (int)(dgvProduct.Width * 0.1);
            dgvProduct.Columns[1].Width = (int)(dgvProduct.Width * 0.25);
            dgvProduct.Columns[2].Width = (int)(dgvProduct.Width * 0.15);
            dgvProduct.Columns[3].Width = (int)(dgvProduct.Width * 0.15);
            dgvProduct.Columns[4].Width = (int)(dgvProduct.Width * 0.2);
            dgvProduct.Columns[5].Width = (int)(dgvProduct.Width * 0.15);

        }

        // Hiển Thị Danh Sách Sản Phẩm Xe Còn Trống
        private void HienThiDSSanPhamXeTrong()
        {
            busXE.LayDSSanPhamXeTrong(dgvProduct);
            dgvProduct.Columns[0].Width = (int)(dgvProduct.Width * 0.1);
            dgvProduct.Columns[1].Width = (int)(dgvProduct.Width * 0.25);
            dgvProduct.Columns[2].Width = (int)(dgvProduct.Width * 0.15);
            dgvProduct.Columns[3].Width = (int)(dgvProduct.Width * 0.15);
            dgvProduct.Columns[4].Width = (int)(dgvProduct.Width * 0.2);
            dgvProduct.Columns[5].Width = (int)(dgvProduct.Width * 0.15);

        }

        // Hiển Thị Danh Sách Sản Phẩm Xe Đã Đặt
        private void HienThiDSSanPhamXeDaDat()
        {
            busXE.LayDSSanPhamXeDaDat(dgvProduct);
            dgvProduct.Columns[0].Width = (int)(dgvProduct.Width * 0.1);
            dgvProduct.Columns[1].Width = (int)(dgvProduct.Width * 0.25);
            dgvProduct.Columns[2].Width = (int)(dgvProduct.Width * 0.15);
            dgvProduct.Columns[3].Width = (int)(dgvProduct.Width * 0.15);
            dgvProduct.Columns[4].Width = (int)(dgvProduct.Width * 0.2);
            dgvProduct.Columns[5].Width = (int)(dgvProduct.Width * 0.15);

        }

        //Tìm kiếm danh sách xe theo tên xe truyền vào
        /*private void TimKiemXe(string tenXe)
        {
            busXE.TimKiemXe(dgvProduct, tenXe);
            dgvProduct.Columns[0].Width = (int)(dgvProduct.Width * 0.1);
            dgvProduct.Columns[1].Width = (int)(dgvProduct.Width * 0.25);
            dgvProduct.Columns[2].Width = (int)(dgvProduct.Width * 0.15);
            dgvProduct.Columns[3].Width = (int)(dgvProduct.Width * 0.15);
            dgvProduct.Columns[4].Width = (int)(dgvProduct.Width * 0.2);
            dgvProduct.Columns[5].Width = (int)(dgvProduct.Width * 0.15);
        }*/

        private void frmCar_Load(object sender, EventArgs e)
        {
            LoadTheme();
            HienThiDSSanPham();
            busXE.LayDSLoaiSanPham(cbbMaLoaiXe);
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvProduct.Rows.Count)
            {
                txtMaXe.Texts = dgvProduct.Rows[e.RowIndex].Cells["MaXe"].Value.ToString();
                txtTenXe.Texts = dgvProduct.Rows[e.RowIndex].Cells["TenXe"].Value.ToString();
                cbbSoChoNgoi.Text = dgvProduct.Rows[e.RowIndex].Cells["SoChoNgoi"].Value.ToString();
                txtGiaThue.Texts = dgvProduct.Rows[e.RowIndex].Cells["GiaThue"].Value.ToString();
                cbbTinhTrang.Text = dgvProduct.Rows[e.RowIndex].Cells["TinhTrang"].Value.ToString();
                cbbMaLoaiXe.Text = dgvProduct.Rows[e.RowIndex].Cells["MaLoaiXe"].Value.ToString();
            }
        }

        private void dgvProduct_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvProduct.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                dgvProduct.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void dgvProduct_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvProduct.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 255);
                dgvProduct.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tb_Xe sp = new tb_Xe();
            if (kiemTraDayDuThongTin())
            {
                sp.TenXe = txtTenXe.Texts;
                sp.SoChoNgoi = int.Parse(cbbSoChoNgoi.SelectedItem.ToString());
                sp.GiaThue = (decimal.Parse(txtGiaThue.Texts));
                sp.TinhTrang = cbbTinhTrang.SelectedItem.ToString();
                sp.MaLoaiXe = int.Parse(cbbMaLoaiXe.SelectedValue.ToString());

                //Gọi sự kiện thêm xe BUS

                MessageBox.Show("Thêm Xe Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                busXE.themSanPham(sp);
                busXE.LayDSSanPham(dgvProduct);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tb_Xe xe = new tb_Xe();
            if (kiemTraDayDuThongTin())
            {
                xe.MaXe = int.Parse(txtMaXe.Texts);
                xe.TenXe = txtTenXe.Texts;
                xe.SoChoNgoi = int.Parse(cbbSoChoNgoi.SelectedItem.ToString());
                xe.GiaThue = decimal.Parse(txtGiaThue.Texts);
                xe.TinhTrang = cbbTinhTrang.SelectedItem.ToString();
                xe.MaLoaiXe = int.Parse(cbbMaLoaiXe.SelectedValue.ToString());

                //Gọi sự kiện sửa xe BUS
                busXE.suaSanPham(xe);
                MessageBox.Show("Sửa Xe Có Mã " + xe.MaXe + " Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                busXE.LayDSSanPham(dgvProduct);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tb_Xe xe = new tb_Xe();
            if (kiemTraDayDuThongTin())
            {
                xe.MaXe = int.Parse(txtMaXe.Texts);
                xe.TenXe = txtTenXe.Texts;
                xe.SoChoNgoi = int.Parse(cbbSoChoNgoi.SelectedItem.ToString());
                xe.GiaThue = decimal.Parse(txtGiaThue.Texts);
                xe.TinhTrang = cbbTinhTrang.SelectedItem.ToString();
                xe.MaLoaiXe = int.Parse(cbbMaLoaiXe.SelectedValue.ToString());

                //Gọi sự kiện xóa xe BUS
                busXE.xoaSanPham(xe);
                MessageBox.Show("Xóa Xe Có Mã " + xe.MaXe + " Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                busXE.LayDSSanPham(dgvProduct);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaXe.Texts = txtTenXe.Texts = txtGiaThue.Texts = "";
            rdbXe4Cho.Checked = rdbXe7Cho.Checked = rdbAllXe.Checked = rdbXeTrong.Checked = rdbXeDaDat.Checked = rdbTatCaXe.Checked = false;
            frmCar_Load(sender, e);
            txtTenXe.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frm = new frmMain();
            frm.Show();
        }

        private void rdbXe4Cho_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbXe4Cho.Checked == true)
            {
                rdbXeTrong.Checked = rdbXeDaDat.Checked = rdbTatCaXe.Checked = false;
                HienThiDSSanPhamXe4Cho();
            }
            else
            {
                HienThiDSSanPham();
            }
        }

        private void rdbXe7Cho_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbXe7Cho.Checked == true)
            {
                rdbXeTrong.Checked = rdbXeDaDat.Checked = rdbTatCaXe.Checked = false;
                HienThiDSSanPhamXe7Cho();
            }
            else
            {
                HienThiDSSanPham();
            }
        }

        private void rdbAllXe_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAllXe.Checked == true)
            {
                rdbXeTrong.Checked = rdbXeDaDat.Checked = rdbTatCaXe.Checked = false;
                HienThiDSSanPham();
            }
            else
            {
                HienThiDSSanPham();
            }
        }

        private void rdbTatCaXe_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAllXe.Checked == true)
            {
                rdbXe4Cho.Checked = rdbXe7Cho.Checked = rdbAllXe.Checked = false;
                HienThiDSSanPham();
            }
            else
            {
                HienThiDSSanPham();
            }
        }

        private void rdbXeTrong_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbXeTrong.Checked == true)
            {
                rdbXe4Cho.Checked = rdbXe7Cho.Checked = rdbAllXe.Checked = false;
                HienThiDSSanPhamXeTrong();
            }
            else
            {
                HienThiDSSanPham();
            }
        }

        private void rdbXeDaDat_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbXeDaDat.Checked == true)
            {
                rdbXe4Cho.Checked = rdbXe7Cho.Checked = rdbAllXe.Checked = false;
                HienThiDSSanPhamXeDaDat();
            }
            else
            {
                HienThiDSSanPham();
            }
        }

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            int ma;
            //Lấy mã xe đang được chọn
            ma = int.Parse(dgvProduct.CurrentRow.Cells[0].Value.ToString());
            //Truyền cho form frmBookCar
            frmBookCar frm = new frmBookCar();
            frm.maXe = ma;
            frm.Show();
        }
    }
}
