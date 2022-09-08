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
    public partial class frmOrderDetails : Form
    {
        List<tb_CT_PhieuThue> lsvCTPT;
        public frmOrderDetails()
        {
            InitializeComponent();
        }

        /*public frmOrderDetails(PhieuThue_Custom ptct) : this()
        {
            lblKhachHang.Text = ptct.TenKH;
            lblNgayLapHD.Text = ptct.NgayLapPhieu.ToString();
            lblTenNV.Text = ptct.TenNV;
            lblTitle.Text += ptct.MaPT.ToString();
            lsvCTPT = new List<tb_CT_PhieuThue>();
            lsvCTPT = CT_PhieuThueBUS.GetInstance().getCTPhieuThueTheoMaPT(ptct.MaPT);
            dgvCT_PhieuThue.DataSource = lsvCTPT;
        }*/

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
            lblTitle.ForeColor = ThemeColor.SecondaryColor;
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
