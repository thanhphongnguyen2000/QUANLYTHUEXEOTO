using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS;
using DAL;

namespace QUANLYTHUEXEOTO
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtUserName.Texts))
            {
                MessageBox.Show("Vui lòng nhập tài khoản!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Texts))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            string username = txtUserName.Texts;
            string password = txtPassword.Texts;
            tb_TaiKhoan taiKhoan = TaiKhoanBUS.GetInstance().KiemTraTK(username, password);
            if (taiKhoan != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Susscess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Texts = txtPassword.Texts = "";
                txtUserName.Focus();
            }
        }
    }
}
