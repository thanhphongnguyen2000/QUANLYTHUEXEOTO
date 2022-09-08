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
using System.Text.RegularExpressions;
using QUANLYTHUEXEOTO.Views;

namespace QUANLYTHUEXEOTO.Forms
{
    public partial class frmOrder : Form
    {
        
        public frmOrder()
        {
            InitializeComponent();
            /*lsvPhieuThueCusToms = new ObservableCollection<PhieuThue_Custom>(PhieuThueBUS.GetInstance().getDataPhieuThue());
            dgvPhieuThue.DataSource = lsvPhieuThueCusToms;*/
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

        private void frmOrder_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            //PhieuThue_Custom ptct = (sender as Button).DataContext as PhieuThue_Custom;
            //if (ptct != null)
            //{
                //frmOrderDetails frm = new frmOrderDetails(ptct);
                //frm.Show();
            //}
        }

        //Hàm custom tên khách hàng
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

        //Tìm kiếm tên khách hàng
        /*private bool filterTimKiem(object obj)
        {
            if (String.IsNullOrEmpty(txtTimKiem.Texts))
                return true;
            else
            {
                string objTenKH = RemoveVietnameseTone((obj as PhieuThue_Custom).TenKH);
                string timkiem = RemoveVietnameseTone(txtTimKiem.Texts);
                return objTenKH.Contains(timkiem);
            }
        }*/

        private void txtTimKiem__TextChanged(object sender, EventArgs e)
        {
            //CollectionView viewPT = (CollectionView)CollectionViewSource.GetDefaultView(dgvPhieuThue.DataSource);
            //viewPT.Filter = filterTimKiem;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //PhieuThue_Custom pt = (sender as Button).DataContext as PhieuThue_Custom;
            //string error = string.Empty;
            //DialogResult dr;
            //dr = MessageBox.Show("Bạn có muốn xóa phiếu thuê " + pt.MaPT, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dr == DialogResult.Yes)
            //{
                //if (PhieuThueBUS.GetInstance().xoaPhieuThueTheoMaPhieuThue(pt.MaPT, error))
                //{
                    //MessageBox.Show("Xóa phiếu thuê thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //lsvPhieuThueCusToms.Remove(pt);
                //}
                //else
                //{
                   // MessageBox.Show("Xóa phiếu thuê thất bại !\n Lỗi: " + error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            //}
        }
    }
}
