
namespace QUANLYTHUEXEOTO.Forms
{
    partial class frmOrderDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnThoat = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.dgvCT_PhieuThue = new System.Windows.Forms.DataGridView();
            this.SoXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoChoNgoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.lblNgayLapHD = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_PhieuThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(235, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(145, 21);
            this.lblTitle.TabIndex = 81;
            this.lblTitle.Text = "Chi Tiết Phiếu Đặt";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.SystemColors.Control;
            this.btnThoat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnThoat.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThoat.BorderRadius = 20;
            this.btnThoat.BorderSize = 2;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(511, 364);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.TabIndex = 97;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextColor = System.Drawing.Color.Black;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvCT_PhieuThue
            // 
            this.dgvCT_PhieuThue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCT_PhieuThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT_PhieuThue.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCT_PhieuThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCT_PhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_PhieuThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoXe,
            this.NgayThue,
            this.NgayTra,
            this.SoChoNgoi});
            this.dgvCT_PhieuThue.Location = new System.Drawing.Point(37, 134);
            this.dgvCT_PhieuThue.Name = "dgvCT_PhieuThue";
            this.dgvCT_PhieuThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCT_PhieuThue.Size = new System.Drawing.Size(574, 212);
            this.dgvCT_PhieuThue.TabIndex = 104;
            // 
            // SoXe
            // 
            this.SoXe.HeaderText = "Số Xe";
            this.SoXe.Name = "SoXe";
            // 
            // NgayThue
            // 
            this.NgayThue.HeaderText = "Ngày Thuê";
            this.NgayThue.Name = "NgayThue";
            // 
            // NgayTra
            // 
            this.NgayTra.HeaderText = "Ngày Trả";
            this.NgayTra.Name = "NgayTra";
            // 
            // SoChoNgoi
            // 
            this.SoChoNgoi.HeaderText = "Số Chỗ Ngồi";
            this.SoChoNgoi.Name = "SoChoNgoi";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.Location = new System.Drawing.Point(72, 82);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(145, 17);
            this.lblKhachHang.TabIndex = 106;
            this.lblKhachHang.Text = "Nguyễn Thanh Phong";
            // 
            // lblNgayLapHD
            // 
            this.lblNgayLapHD.AutoSize = true;
            this.lblNgayLapHD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLapHD.Location = new System.Drawing.Point(265, 82);
            this.lblNgayLapHD.Name = "lblNgayLapHD";
            this.lblNgayLapHD.Size = new System.Drawing.Size(76, 17);
            this.lblNgayLapHD.TabIndex = 108;
            this.lblNgayLapHD.Text = "20/08/2022\r\n";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.Location = new System.Drawing.Point(465, 82);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(145, 17);
            this.lblTenNV.TabIndex = 110;
            this.lblTenNV.Text = "Nguyễn Thanh Phong";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QUANLYTHUEXEOTO.Properties.Resources.employee;
            this.pictureBox3.Location = new System.Drawing.Point(429, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 109;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QUANLYTHUEXEOTO.Properties.Resources.ngaysinh;
            this.pictureBox2.Location = new System.Drawing.Point(229, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QUANLYTHUEXEOTO.Properties.Resources.hoten;
            this.pictureBox1.Location = new System.Drawing.Point(36, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 416);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblNgayLapHD);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvCT_PhieuThue);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmOrderDetails";
            this.Text = "frmOrderDetails";
            this.Load += new System.EventHandler(this.frmOrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_PhieuThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private CustomControls.CustomButton btnThoat;
        private System.Windows.Forms.DataGridView dgvCT_PhieuThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoChoNgoi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label lblNgayLapHD;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}