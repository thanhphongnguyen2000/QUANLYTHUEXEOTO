
namespace QUANLYTHUEXEOTO.Forms
{
    partial class frmCustomer
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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblChuDe = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.lblLocKH = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.customDatePicker1 = new QUANLYTHUEXEOTO.CustomControls.CustomDatePicker();
            this.customDatePicker2 = new QUANLYTHUEXEOTO.CustomControls.CustomDatePicker();
            this.customButton1 = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.customButton2 = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.customButton3 = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.txtTimKiem = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.HOTENKH,
            this.DIENTHOAI,
            this.CMND,
            this.DIACHI});
            this.dgvKhachHang.Location = new System.Drawing.Point(239, 50);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(383, 340);
            this.dgvKhachHang.TabIndex = 71;
            this.dgvKhachHang.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellMouseLeave);
            this.dgvKhachHang.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKhachHang_CellMouseMove);
            // 
            // stt
            // 
            this.stt.FillWeight = 37.37905F;
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // HOTENKH
            // 
            this.HOTENKH.FillWeight = 134.267F;
            this.HOTENKH.HeaderText = "Họ Tên Khách Hàng";
            this.HOTENKH.Name = "HOTENKH";
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.FillWeight = 105.178F;
            this.DIENTHOAI.HeaderText = "Điện Thoại";
            this.DIENTHOAI.Name = "DIENTHOAI";
            // 
            // CMND
            // 
            this.CMND.FillWeight = 88.8325F;
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            // 
            // DIACHI
            // 
            this.DIACHI.FillWeight = 134.3435F;
            this.DIACHI.HeaderText = "Địa Chỉ";
            this.DIACHI.Name = "DIACHI";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblInfo.Location = new System.Drawing.Point(23, 50);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(165, 16);
            this.lblInfo.TabIndex = 70;
            this.lblInfo.Text = "Thông Tin Khách Hàng";
            // 
            // lblChuDe
            // 
            this.lblChuDe.AutoSize = true;
            this.lblChuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChuDe.Location = new System.Drawing.Point(235, 15);
            this.lblChuDe.Name = "lblChuDe";
            this.lblChuDe.Size = new System.Drawing.Size(178, 20);
            this.lblChuDe.TabIndex = 69;
            this.lblChuDe.Text = "Quản Lý Khách Hàng";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTimKiem.Location = new System.Drawing.Point(24, 84);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(62, 13);
            this.lblTimKiem.TabIndex = 63;
            this.lblTimKiem.Text = "Tìm Kiếm:";
            // 
            // lblLocKH
            // 
            this.lblLocKH.AutoSize = true;
            this.lblLocKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLocKH.Location = new System.Drawing.Point(23, 189);
            this.lblLocKH.Name = "lblLocKH";
            this.lblLocKH.Size = new System.Drawing.Size(106, 13);
            this.lblLocKH.TabIndex = 72;
            this.lblLocKH.Text = "Lọc Khách Hàng:";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTuNgay.Location = new System.Drawing.Point(23, 211);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(59, 13);
            this.lblTuNgay.TabIndex = 73;
            this.lblTuNgay.Text = "Từ Ngày:";
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDenNgay.Location = new System.Drawing.Point(23, 261);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(67, 13);
            this.lblDenNgay.TabIndex = 76;
            this.lblDenNgay.Text = "Đến Ngày:";
            // 
            // customDatePicker1
            // 
            this.customDatePicker1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customDatePicker1.BorderSize = 2;
            this.customDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.customDatePicker1.Location = new System.Drawing.Point(7, 227);
            this.customDatePicker1.MinimumSize = new System.Drawing.Size(4, 25);
            this.customDatePicker1.Name = "customDatePicker1";
            this.customDatePicker1.Size = new System.Drawing.Size(225, 25);
            this.customDatePicker1.SkinColor = System.Drawing.Color.White;
            this.customDatePicker1.TabIndex = 83;
            this.customDatePicker1.TextColor = System.Drawing.Color.Black;
            // 
            // customDatePicker2
            // 
            this.customDatePicker2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customDatePicker2.BorderSize = 2;
            this.customDatePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.customDatePicker2.Location = new System.Drawing.Point(7, 277);
            this.customDatePicker2.MinimumSize = new System.Drawing.Size(4, 25);
            this.customDatePicker2.Name = "customDatePicker2";
            this.customDatePicker2.Size = new System.Drawing.Size(225, 25);
            this.customDatePicker2.SkinColor = System.Drawing.Color.White;
            this.customDatePicker2.TabIndex = 84;
            this.customDatePicker2.TextColor = System.Drawing.Color.Black;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.SystemColors.Control;
            this.customButton1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.customButton1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BorderRadius = 20;
            this.customButton1.BorderSize = 2;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.Black;
            this.customButton1.Location = new System.Drawing.Point(58, 133);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(120, 40);
            this.customButton1.TabIndex = 86;
            this.customButton1.Text = "Tìm Kiếm";
            this.customButton1.TextColor = System.Drawing.Color.Black;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.SystemColors.Control;
            this.customButton2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.customButton2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton2.BorderRadius = 20;
            this.customButton2.BorderSize = 2;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.Black;
            this.customButton2.Location = new System.Drawing.Point(58, 308);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(120, 40);
            this.customButton2.TabIndex = 87;
            this.customButton2.Text = "Lọc Khách Hàng";
            this.customButton2.TextColor = System.Drawing.Color.Black;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.SystemColors.Control;
            this.customButton3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.customButton3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton3.BorderRadius = 20;
            this.customButton3.BorderSize = 2;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.Black;
            this.customButton3.Location = new System.Drawing.Point(58, 364);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(120, 40);
            this.customButton3.TabIndex = 88;
            this.customButton3.Text = "Hủy";
            this.customButton3.TextColor = System.Drawing.Color.Black;
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimKiem.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTimKiem.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTimKiem.BorderRadius = 15;
            this.txtTimKiem.BorderSize = 2;
            this.txtTimKiem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.Location = new System.Drawing.Point(7, 96);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(225, 30);
            this.txtTimKiem.TabIndex = 89;
            this.txtTimKiem.Texts = "";
            this.txtTimKiem.UnderlinedStyle = false;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 416);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.customDatePicker2);
            this.Controls.Add(this.customDatePicker1);
            this.Controls.Add(this.lblDenNgay);
            this.Controls.Add(this.lblTuNgay);
            this.Controls.Add(this.lblLocKH);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblChuDe);
            this.Controls.Add(this.lblTimKiem);
            this.Name = "frmCustomer";
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblChuDe;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Label lblLocKH;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private CustomControls.CustomDatePicker customDatePicker1;
        private CustomControls.CustomDatePicker customDatePicker2;
        private CustomControls.CustomButton customButton1;
        private CustomControls.CustomButton customButton2;
        private CustomControls.CustomButton customButton3;
        private CustomControls.Textbox txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
    }
}