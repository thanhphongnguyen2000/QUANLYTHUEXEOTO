using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using QUANLYTHUEXEOTO.BUS;

namespace QUANLYTHUEXEOTO.Views
{
    public partial class frmBookCar : Form
    {
        public delegate void dlg();
        public dlg luuPhieuDatXe;
        public string tenXe;

        XeBUS busXE;

        public int maXe, maNV;

        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(128, 128, 255);

        public frmBookCar()
        {
            InitializeComponent();
            busXE = new XeBUS();

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
        private void frmBookCar_Paint(object sender, PaintEventArgs e)
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

        private void frmBookCar_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void frmBookCar_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void frmBookCar_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
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

        private void frmBookCar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region method

        private bool kiemTraDayDuThongTin()
        {
            //Kiểm tra textbox họ tên có rỗng hay không
            if (string.IsNullOrWhiteSpace(txtHoTen.Texts))
            {
                txtHoTen.Focus();
                MessageBox.Show("Nhập đầy đủ họ tên !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Kiểm tra textbox CCCD rỗng hoặc nhập kí tự chữ không
            if (string.IsNullOrWhiteSpace(txtCCCD.Texts))
            {
                txtCCCD.Focus();
                MessageBox.Show("Nhập đầy đủ căn cước công dân !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (!long.TryParse(txtCCCD.Texts, out long temp))
                {
                    txtCCCD.Focus();
                    MessageBox.Show("Nhập căn cước công dân đúng định dạng số !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txtCCCD.Texts.Length > 12)
                {
                    txtCCCD.Focus();
                    MessageBox.Show("Nhập căn cước công dân không quá 12 ký tự !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            //Kiểm tra textbox SDT rỗng hoặc có nhập chữ không
            if (string.IsNullOrWhiteSpace(txtDienThoai.Texts))
            {
                txtDienThoai.Focus();
                MessageBox.Show("Nhập đầy đủ số điện thoại !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (!long.TryParse(txtDienThoai.Text, out long temp))
                {
                    txtDienThoai.Focus();
                    MessageBox.Show("Nhập số điện thoại đúng định dạng số !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txtDienThoai.Text.Length > 10)
                {
                    txtDienThoai.Focus();
                    MessageBox.Show("Nhập số điện thoại không quá 10 ký tự !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            //Kiểm tra textbox nhập địa chỉ
            if (string.IsNullOrWhiteSpace(txtDiaChi.Texts))
            {
                txtDiaChi.Focus();
                MessageBox.Show("Nhập đầy đủ địa chỉ !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Kiểm tra combobox giới tính
            if (string.IsNullOrWhiteSpace(cbbGioiTinh.Texts))
            {
                MessageBox.Show("Bạn chưa chọn giới tính !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Kiểm tra xem đã có xe được chọn chưa
            if (dgvXeChon.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn xe trước khi lưu !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion

        //Hiển thị xe trống lên Datagridview
        private void HienThiDSSanPhamXeTrong()
        {
            busXE.LayDSChiTietXeTrong(dgvXeTrong);
            dgvXeTrong.Columns[0].Width = (int)(dgvXeTrong.Width * 0.7);
            dgvXeTrong.Columns[1].Width = (int)(dgvXeTrong.Width * 0.3);
        }

        //Lấy danh sách xe theo mã xe truyền vào
        private void LayDSXeDaChon(int maXe)
        {
            busXE.LayDSXeDaChon(dgvXeChon,maXe);
            dgvXeTrong.Columns[0].Width = (int)(dgvXeTrong.Width * 0.7);
            dgvXeTrong.Columns[1].Width = (int)(dgvXeTrong.Width * 0.3);
        }

        #region event
        private void frmBookCar_Load(object sender, EventArgs e)
        {
            //Khởi tạo giá trị cho ngày, giờ Bắt đầu và Kết thúc là ngày giờ hiện tại
            dtpNgayThue.Text = new DateTime(2022, 09, 07).ToShortDateString();
            dtpNgayTra.Text = new DateTime(2022, 09, 10).ToShortDateString();

            //Khởi tạo sự kiện thay đổi ngày hoặc giờ
            dtpNgayThue.ValueChanged += dtpNgay_ValueChanged;
            dtpNgayTra.ValueChanged += dtpNgay_ValueChanged;


            //Lấy danh sách xe trống và xe đã chọn
            LayDSXeDaChon(maXe);
            HienThiDSSanPhamXeTrong();
        }

        //Kiểm tra giá trị thay đổi trong DateTimePicker
        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            string ngayThue = dtpNgayThue.Text;
            string ngayTra = dtpNgayTra.Text;
            DateTime dtpNThue;
            DateTime dtpNTra;
            if (!DateTime.TryParse(ngayThue, out dtpNThue))
            {
                MessageBox.Show("Nhập đúng định dạng ngày bắt đầu !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(ngayTra, out dtpNTra))
            {
                MessageBox.Show("Nhập đúng định dạng ngày kết thúc !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //nếu ngày bắt đầu lớn hơn ngày kết thúc thì phải báo lỗi ngay
            if (dtpNThue > dtpNTra)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgayThue.Text = ngayTra;
                dtpNgayTra.Text = ngayTra;
                return;
            }
            /*getXeTrongTheoNgay();*/
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            /*//Khai báo biến cần thiết
            int maKHThemMoi;
            string errorKhachHang;
            string errorPhieuThue;
            string errorCTPT;
            int dem = 0;
            bool checkThemKHThanhCong = false;
            bool themKhachHangMoi = false;

            if (kiemTraDayDuThongTin())
            {
                tb_KhachHang kh = new tb_KhachHang()
                {
                    CCCD = txtCCCD.Texts,
                    TenKH = txtHoTen.Texts,
                    DiaChi = txtDiaChi.Texts,
                    GioiTinh = cbbGioiTinh.Texts,
                    SDT = txtDienThoai.Texts
                };

                //B1: Thêm khách hàng kiểm tra xem khách hàng đã tồn tại trong CSDL chưa dựa vào CCCD nếu có rồi thì không thêm nữa, còn chưa có thì thêm vào CSDL
                maKHThemMoi = KhachHangBUS.GetInstance().kiemTraTonTaiKhachHang(kh.CCCD);
                if (maKHThemMoi == -1)
                {
                    checkThemKHThanhCong = KhachHangBUS.GetInstance().addKhachHang(kh, out errorKhachHang);
                    if (!checkThemKHThanhCong)
                    {
                        MessageBox.Show("Lỗi: Thêm Khách Hàng " + errorKhachHang, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    maKHThemMoi = kh.MaKH;
                    themKhachHangMoi = true;
                }
                else
                {
                    checkThemKHThanhCong = true;
                }

                //B2: Thêm phiếu thuê nếu thêm khách hàng thành công hoặc lấy ra được mã khách hàng đã tồn tại
                if (checkThemKHThanhCong)
                {
                    tb_PhieuThue pt = new tb_PhieuThue()
                    {
                        NgayLapPhieu = DateTime.Now,
                        MaKH = maKHThemMoi,
                        MaNV = this.maNV
                    };

                    if (PhieuThueBUS.GetInstance().addPhieuThue(pt, out errorPhieuThue))
                    {
                        //B3: Thêm CT phiếu thuê
                        foreach (tb_CT_PhieuThue item in dgvXeChon)
                        {

                            item.MaPT = pt.MaPT;
                            item.TinhTrangThue = "Xe Đã Đặt";
                            if (CT_PhieuThueBUS.GetInstance().addCTPhieuThue(item, out errorCTPT))
                            {
                                dem++;
                            }
                            else
                            {
                                MessageBox.Show("Lỗi: Thêm CTPT " + errorCTPT, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi: Thêm Phiếu Thuê  " + errorPhieuThue, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                if (dem == dgvXeChon.Rows.Count && dem != 0)
                {
                    if (themKhachHangMoi)
                    {
                        MessageBox.Show("Thêm khách hàng mới và đặt xe thành công !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Khách hàng đã tồn tại và đặt xe thành công !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (luuPhieuDatXe != null)
                    {
                        luuPhieuDatXe();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đặt xe thất bại  !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
        }

        private void btnThemXe_Click(object sender, EventArgs e)
        {
            //Truyền cho Datagridview khác
            /*dgvXeTrong.Rows.Remove(tenXe);*/
            /*dgvXeChon.Rows.Add(tenXe);*/
        }

        private void dgvXeTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy mã xe đang được chọn
            tenXe = dgvXeTrong.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnXoaXe_Click(object sender, EventArgs e)
        {
            /*tb_CT_PhieuThue xeDaChon = (sender as Button).DataContext as tb_CT_PhieuThue;
            foreach (XeTrong pt in dgvXeTrong)
            {
                if (pt.MaXe.Equals(xeDaChon.MaXe))
                {
                    dgvXeTrong.Rows.Add(pt);
                    dgvXeChon.Rows.Remove(pt);
                    break;
                }
            }
            dgvXeChon.Rows.Remove(xeDaChon);*/
        }
        #endregion
    }
}
