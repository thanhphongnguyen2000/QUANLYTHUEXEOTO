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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
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
            lblTimKiem.ForeColor = ThemeColor.PrimaryColor;
            lblThongTin.ForeColor = ThemeColor.PrimaryColor;
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void dgvNhanVien_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvNhanVien.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 255);
                dgvNhanVien.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void dgvNhanVien_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvNhanVien.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                dgvNhanVien.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }
    }
}
