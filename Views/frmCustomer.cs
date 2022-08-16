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
        public frmCustomer()
        {
            InitializeComponent();
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
            lblInfo.ForeColor = ThemeColor.PrimaryColor;
            lblTimKiem.ForeColor = ThemeColor.PrimaryColor;
            lblLocKH.ForeColor = ThemeColor.PrimaryColor;
            lblTuNgay.ForeColor = ThemeColor.PrimaryColor;
            lblDenNgay.ForeColor = ThemeColor.PrimaryColor;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadTheme();
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
    }
}
