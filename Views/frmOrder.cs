﻿using System;
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
    public partial class frmOrder : Form
    {
        public frmOrder()
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
            lblNgayHienTai.ForeColor = ThemeColor.PrimaryColor;
            lblHienTrang.ForeColor = ThemeColor.PrimaryColor;
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmOrderDetails frm = new frmOrderDetails();
            frm.Show();
        }
    }
}
