using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL;
using QUANLYTHUEXEOTO.Forms;

namespace QUANLYTHUEXEOTO.Views
{
    public partial class frmAdd_Up_Employee : Form
    {
        public delegate void CRUD(tb_NhanVien nv);

        public CRUD themNhanVien;
        public CRUD suaNhanVien;
        public CRUD truyenNhanVien;
        private string maNV;

        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(128, 128, 255);

        //Constructor
        public frmAdd_Up_Employee()
        {
            InitializeComponent();
            truyenNhanVien = new CRUD(nhanDataNhanVien);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.panelTitleBar.BackColor = borderColor;
            this.BackColor = borderColor;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
                return cp;
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }

        private void DrawPath(Rectangle rect, Graphics graph, Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }

        private struct FormBoundsColors
        {
            public Color TopLeftColor;
            public Color TopRightColor;
            public Color BottomLeftColor;
            public Color BottomRightColor;
        }
        private FormBoundsColors GetFormBoundsColors()
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new Rectangle(0, 0, 1, 1);
                //Top Left
                rectBmp.X = this.Bounds.X - 1;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);
                //Top Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);
                //Bottom Left
                rectBmp.X = this.Bounds.X;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);
                //Bottom Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }

        private void frmAdd_Up_Employee_Paint(object sender, PaintEventArgs e)
        {
            //-> SMOOTH OUTER BORDER
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = this.ClientRectangle;
            int mWidht = rectForm.Width / 2;
            int mHeight = rectForm.Height / 2;
            var fbColors = GetFormBoundsColors();
            //Top Left
            DrawPath(rectForm, e.Graphics, fbColors.TopLeftColor);
            //Top Right
            Rectangle rectTopRight = new Rectangle(mWidht, rectForm.Y, mWidht, mHeight);
            DrawPath(rectTopRight, e.Graphics, fbColors.TopRightColor);
            //Bottom Left
            Rectangle rectBottomLeft = new Rectangle(rectForm.X, rectForm.X + mHeight, mWidht, mHeight);
            DrawPath(rectBottomLeft, e.Graphics, fbColors.BottomLeftColor);
            //Bottom Right
            Rectangle rectBottomRight = new Rectangle(mWidht, rectForm.Y + mHeight, mWidht, mHeight);
            DrawPath(rectBottomRight, e.Graphics, fbColors.BottomRightColor);
            //-> SET ROUNDED REGION AND BORDER
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        private void frmAdd_Up_Employee_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void frmAdd_Up_Employee_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void frmAdd_Up_Employee_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmAdd_Up_Employee_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            ControlRegionAndBorder(panelContainer, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Nhận nhân viên theo mã nhân viên
        public void nhanDataNhanVien(tb_NhanVien nv)
        {
            lblTitle.Text = "Sửa Nhân Viên";
            txtHoTen.Texts = nv.HoTen;
            txtCCCD.Texts = nv.CCCD;
            txtChucVu.Texts = nv.ChucVu;
            txtDiaChi.Texts = nv.DiaChi;
            txtLuong.Texts = nv.Luong.ToString();
            txtDienThoai.Texts = nv.SDT;
            cbbGioiTinh.Texts = nv.GioiTinh;
            dtpNgaySinh.Text = nv.NgaySinh.ToString();
            maNV = nv.MaNV.ToString();
        }

        //Check thông tin nhập vào đã đúng hay chưa
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
            if (string.IsNullOrWhiteSpace(cbbGioiTinh.Texts))
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

        #region event
        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            frm.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemTraDayDuThongTin())
            {
                tb_NhanVien nhanVien = new tb_NhanVien()
                {
                    HoTen = txtHoTen.Texts,
                    CCCD = txtCCCD.Texts,
                    ChucVu = txtChucVu.Texts,
                    DiaChi = txtDiaChi.Texts,
                    GioiTinh = cbbGioiTinh.Texts,
                    Luong = (decimal.Parse(txtLuong.Texts)),
                    NgaySinh = DateTime.Parse(dtpNgaySinh.ToString()),
                    SDT = txtDienThoai.Texts
                };
                if (themNhanVien != null)
                {
                    themNhanVien(nhanVien);
                }
                this.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (kiemTraDayDuThongTin())
            {
                tb_NhanVien nhanVien = new tb_NhanVien()
                {
                    MaNV = int.Parse(maNV),
                    HoTen = txtHoTen.Texts,
                    CCCD = txtCCCD.Texts,
                    ChucVu = txtChucVu.Texts,
                    DiaChi = txtDiaChi.Texts,
                    GioiTinh = cbbGioiTinh.Texts,
                    Luong = (decimal.Parse(txtLuong.Texts)),
                    NgaySinh = DateTime.Parse(dtpNgaySinh.ToString()),
                    SDT = txtDienThoai.Texts
                };

                if (suaNhanVien != null)
                {
                    suaNhanVien(nhanVien);
                }
                this.Close();
            }
        }
        #endregion
    }
}
