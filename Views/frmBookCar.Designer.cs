
namespace QUANLYTHUEXEOTO.Views
{
    partial class frmBookCar
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvXeDaChon = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvXeTrong = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHuy = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.btnLuu = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.btnXoaXe = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.btnThemXe = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.dtpNgayTra = new QUANLYTHUEXEOTO.CustomControls.CustomDatePicker();
            this.dtpNgayThue = new QUANLYTHUEXEOTO.CustomControls.CustomDatePicker();
            this.cbbGioiTinh = new QUANLYTHUEXEOTO.CustomControls.CustomCombobox();
            this.txtDiaChi = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.txtDienThoai = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.txtCCCD = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.txtHoTen = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.panelTitleBar.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXeDaChon)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXeTrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(884, 50);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Lavender;
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.btnHuy);
            this.panelContainer.Controls.Add(this.btnLuu);
            this.panelContainer.Controls.Add(this.groupBox2);
            this.panelContainer.Controls.Add(this.groupBox1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 50);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(884, 531);
            this.panelContainer.TabIndex = 1;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvXeDaChon);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(284, 126);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(254, 207);
            this.groupBox4.TabIndex = 102;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Xe Đã Chọn";
            // 
            // dgvXeDaChon
            // 
            this.dgvXeDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXeDaChon.Location = new System.Drawing.Point(8, 36);
            this.dgvXeDaChon.Name = "dgvXeDaChon";
            this.dgvXeDaChon.Size = new System.Drawing.Size(240, 150);
            this.dgvXeDaChon.TabIndex = 92;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvXeTrong);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(6, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 207);
            this.groupBox3.TabIndex = 101;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xe Trống";
            // 
            // dgvXeTrong
            // 
            this.dgvXeTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXeTrong.Location = new System.Drawing.Point(10, 36);
            this.dgvXeTrong.Name = "dgvXeTrong";
            this.dgvXeTrong.Size = new System.Drawing.Size(240, 150);
            this.dgvXeTrong.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 90;
            this.label2.Text = "Ngày Trả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 89;
            this.label1.Text = "Ngày Thuê";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::QUANLYTHUEXEOTO.Properties.Resources.ngaysinh;
            this.pictureBox7.Location = new System.Drawing.Point(263, 42);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 30);
            this.pictureBox7.TabIndex = 88;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::QUANLYTHUEXEOTO.Properties.Resources.ngaysinh;
            this.pictureBox6.Location = new System.Drawing.Point(6, 42);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.TabIndex = 87;
            this.pictureBox6.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnXoaXe);
            this.groupBox2.Controls.Add(this.btnThemXe);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pictureBox7);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.dtpNgayTra);
            this.groupBox2.Controls.Add(this.dtpNgayThue);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(328, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 399);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Xe";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QUANLYTHUEXEOTO.Properties.Resources.cccd;
            this.pictureBox2.Location = new System.Drawing.Point(14, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QUANLYTHUEXEOTO.Properties.Resources.hoten;
            this.pictureBox1.Location = new System.Drawing.Point(14, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::QUANLYTHUEXEOTO.Properties.Resources.gioitinh;
            this.pictureBox5.Location = new System.Drawing.Point(14, 352);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QUANLYTHUEXEOTO.Properties.Resources.diachi;
            this.pictureBox4.Location = new System.Drawing.Point(14, 278);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QUANLYTHUEXEOTO.Properties.Resources.sdt;
            this.pictureBox3.Location = new System.Drawing.Point(14, 201);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbGioiTinh);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.txtCCCD);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 402);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(784, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 50);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "_";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(834, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 24);
            this.label3.TabIndex = 104;
            this.label3.Text = "Thông Tin Đặt Xe";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.SystemColors.Control;
            this.btnHuy.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnHuy.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnHuy.BorderRadius = 20;
            this.btnHuy.BorderSize = 2;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Location = new System.Drawing.Point(772, 482);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 40);
            this.btnHuy.TabIndex = 102;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextColor = System.Drawing.Color.Black;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnLuu.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLuu.BorderRadius = 20;
            this.btnLuu.BorderSize = 2;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Location = new System.Drawing.Point(646, 482);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 40);
            this.btnLuu.TabIndex = 103;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextColor = System.Drawing.Color.Black;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoaXe
            // 
            this.btnXoaXe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaXe.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoaXe.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnXoaXe.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnXoaXe.BorderRadius = 20;
            this.btnXoaXe.BorderSize = 2;
            this.btnXoaXe.FlatAppearance.BorderSize = 0;
            this.btnXoaXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaXe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaXe.ForeColor = System.Drawing.Color.Black;
            this.btnXoaXe.Location = new System.Drawing.Point(156, 339);
            this.btnXoaXe.Name = "btnXoaXe";
            this.btnXoaXe.Size = new System.Drawing.Size(100, 40);
            this.btnXoaXe.TabIndex = 100;
            this.btnXoaXe.Text = "Xóa Xe";
            this.btnXoaXe.TextColor = System.Drawing.Color.Black;
            this.btnXoaXe.UseVisualStyleBackColor = false;
            this.btnXoaXe.Click += new System.EventHandler(this.btnXoaXe_Click);
            // 
            // btnThemXe
            // 
            this.btnThemXe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemXe.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemXe.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnThemXe.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThemXe.BorderRadius = 20;
            this.btnThemXe.BorderSize = 2;
            this.btnThemXe.FlatAppearance.BorderSize = 0;
            this.btnThemXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemXe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemXe.ForeColor = System.Drawing.Color.Black;
            this.btnThemXe.Location = new System.Drawing.Point(16, 339);
            this.btnThemXe.Name = "btnThemXe";
            this.btnThemXe.Size = new System.Drawing.Size(100, 40);
            this.btnThemXe.TabIndex = 99;
            this.btnThemXe.Text = "Thêm Xe";
            this.btnThemXe.TextColor = System.Drawing.Color.Black;
            this.btnThemXe.UseVisualStyleBackColor = false;
            this.btnThemXe.Click += new System.EventHandler(this.btnThemXe_Click);
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dtpNgayTra.BorderSize = 2;
            this.dtpNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpNgayTra.Location = new System.Drawing.Point(263, 78);
            this.dtpNgayTra.MinimumSize = new System.Drawing.Size(4, 25);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(225, 25);
            this.dtpNgayTra.SkinColor = System.Drawing.Color.White;
            this.dtpNgayTra.TabIndex = 86;
            this.dtpNgayTra.TextColor = System.Drawing.Color.Black;
            this.dtpNgayTra.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // dtpNgayThue
            // 
            this.dtpNgayThue.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dtpNgayThue.BorderSize = 2;
            this.dtpNgayThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayThue.Location = new System.Drawing.Point(6, 78);
            this.dtpNgayThue.MinimumSize = new System.Drawing.Size(4, 25);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(225, 25);
            this.dtpNgayThue.SkinColor = System.Drawing.Color.White;
            this.dtpNgayThue.TabIndex = 85;
            this.dtpNgayThue.TextColor = System.Drawing.Color.Black;
            this.dtpNgayThue.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbGioiTinh.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbGioiTinh.BorderSize = 3;
            this.cbbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbbGioiTinh.ForeColor = System.Drawing.Color.DimGray;
            this.cbbGioiTinh.IconColor = System.Drawing.Color.Fuchsia;
            this.cbbGioiTinh.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbGioiTinh.ListTextColor = System.Drawing.Color.DimGray;
            this.cbbGioiTinh.Location = new System.Drawing.Point(51, 352);
            this.cbbGioiTinh.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Padding = new System.Windows.Forms.Padding(3);
            this.cbbGioiTinh.Size = new System.Drawing.Size(225, 30);
            this.cbbGioiTinh.TabIndex = 6;
            this.cbbGioiTinh.Texts = "";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaChi.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDiaChi.BorderFocusColor = System.Drawing.Color.Black;
            this.txtDiaChi.BorderRadius = 15;
            this.txtDiaChi.BorderSize = 2;
            this.txtDiaChi.Location = new System.Drawing.Point(51, 278);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDiaChi.PasswordChar = false;
            this.txtDiaChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(225, 30);
            this.txtDiaChi.TabIndex = 5;
            this.txtDiaChi.Texts = "";
            this.txtDiaChi.UnderlinedStyle = false;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.BackColor = System.Drawing.SystemColors.Window;
            this.txtDienThoai.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDienThoai.BorderFocusColor = System.Drawing.Color.Black;
            this.txtDienThoai.BorderRadius = 15;
            this.txtDienThoai.BorderSize = 2;
            this.txtDienThoai.Location = new System.Drawing.Point(51, 201);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtDienThoai.Multiline = true;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDienThoai.PasswordChar = false;
            this.txtDienThoai.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDienThoai.PlaceholderText = "";
            this.txtDienThoai.Size = new System.Drawing.Size(225, 30);
            this.txtDienThoai.TabIndex = 4;
            this.txtDienThoai.Texts = "";
            this.txtDienThoai.UnderlinedStyle = false;
            // 
            // txtCCCD
            // 
            this.txtCCCD.BackColor = System.Drawing.SystemColors.Window;
            this.txtCCCD.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCCCD.BorderFocusColor = System.Drawing.Color.Black;
            this.txtCCCD.BorderRadius = 15;
            this.txtCCCD.BorderSize = 2;
            this.txtCCCD.Location = new System.Drawing.Point(51, 129);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(4);
            this.txtCCCD.Multiline = true;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCCCD.PasswordChar = false;
            this.txtCCCD.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCCCD.PlaceholderText = "";
            this.txtCCCD.Size = new System.Drawing.Size(225, 30);
            this.txtCCCD.TabIndex = 3;
            this.txtCCCD.Texts = "";
            this.txtCCCD.UnderlinedStyle = false;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoTen.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtHoTen.BorderFocusColor = System.Drawing.Color.Black;
            this.txtHoTen.BorderRadius = 15;
            this.txtHoTen.BorderSize = 2;
            this.txtHoTen.Location = new System.Drawing.Point(51, 53);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtHoTen.PasswordChar = false;
            this.txtHoTen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.Size = new System.Drawing.Size(225, 30);
            this.txtHoTen.TabIndex = 2;
            this.txtHoTen.Texts = "";
            this.txtHoTen.UnderlinedStyle = false;
            // 
            // frmBookCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 581);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTitleBar);
            this.Name = "frmBookCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBookCar";
            this.Activated += new System.EventHandler(this.frmBookCar_Activated);
            this.Load += new System.EventHandler(this.frmBookCar_Load);
            this.ResizeEnd += new System.EventHandler(this.frmBookCar_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.frmBookCar_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmBookCar_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmBookCar_MouseDown);
            this.panelTitleBar.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXeDaChon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXeTrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelContainer;
        private CustomControls.CustomButton btnHuy;
        private CustomControls.CustomButton btnLuu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvXeDaChon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvXeTrong;
        private CustomControls.CustomButton btnXoaXe;
        private CustomControls.CustomButton btnThemXe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private CustomControls.CustomDatePicker dtpNgayTra;
        private CustomControls.CustomDatePicker dtpNgayThue;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomControls.CustomCombobox cbbGioiTinh;
        private System.Windows.Forms.PictureBox pictureBox5;
        private CustomControls.Textbox txtDiaChi;
        private System.Windows.Forms.PictureBox pictureBox4;
        private CustomControls.Textbox txtDienThoai;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CustomControls.Textbox txtCCCD;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomControls.Textbox txtHoTen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
    }
}