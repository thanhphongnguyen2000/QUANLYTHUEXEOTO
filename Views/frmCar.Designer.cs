
namespace QUANLYTHUEXEOTO.Views
{
    partial class frmCar
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
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdbXeTrong = new System.Windows.Forms.RadioButton();
            this.rdbTatCaXe = new System.Windows.Forms.RadioButton();
            this.rdbXeDaDat = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbXe4Cho = new System.Windows.Forms.RadioButton();
            this.rdbAllXe = new System.Windows.Forms.RadioButton();
            this.rdbXe7Cho = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.MaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoChoNgoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblChuDe = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.cbbSoChoNgoi = new System.Windows.Forms.ComboBox();
            this.cbbMaLoaiXe = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTenXe = new System.Windows.Forms.Label();
            this.lblSoChoNgoi = new System.Windows.Forms.Label();
            this.lblGiaThue = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.btnThem = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.btnThoat = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.btnSua = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.btnXoa = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.btnHuy = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.txtMaXe = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.txtGiaThue = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.txtTenXe = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.txtTimKiem = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.customDatePicker1 = new QUANLYTHUEXEOTO.CustomControls.CustomDatePicker();
            this.panelNavbar.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavbar
            // 
            this.panelNavbar.Controls.Add(this.btnSend);
            this.panelNavbar.Controls.Add(this.txtTimKiem);
            this.panelNavbar.Controls.Add(this.customDatePicker1);
            this.panelNavbar.Controls.Add(this.label1);
            this.panelNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavbar.Location = new System.Drawing.Point(0, 0);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(1064, 50);
            this.panelNavbar.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Image = global::QUANLYTHUEXEOTO.Properties.Resources.send;
            this.btnSend.Location = new System.Drawing.Point(590, 8);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(35, 30);
            this.btnSend.TabIndex = 1;
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Ngày:";
            // 
            // panelControl
            // 
            this.panelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControl.Controls.Add(this.panel4);
            this.panelControl.Controls.Add(this.panel2);
            this.panelControl.Controls.Add(this.label3);
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 50);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(200, 517);
            this.panelControl.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.rdbXeTrong);
            this.panel4.Controls.Add(this.rdbTatCaXe);
            this.panel4.Controls.Add(this.rdbXeDaDat);
            this.panel4.Location = new System.Drawing.Point(15, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 117);
            this.panel4.TabIndex = 106;
            // 
            // rdbXeTrong
            // 
            this.rdbXeTrong.AutoSize = true;
            this.rdbXeTrong.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbXeTrong.Location = new System.Drawing.Point(3, 27);
            this.rdbXeTrong.Name = "rdbXeTrong";
            this.rdbXeTrong.Size = new System.Drawing.Size(97, 17);
            this.rdbXeTrong.TabIndex = 4;
            this.rdbXeTrong.Text = "Xe Còn Trống";
            this.rdbXeTrong.UseVisualStyleBackColor = true;
            this.rdbXeTrong.CheckedChanged += new System.EventHandler(this.rdbXeTrong_CheckedChanged);
            // 
            // rdbTatCaXe
            // 
            this.rdbTatCaXe.AutoSize = true;
            this.rdbTatCaXe.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTatCaXe.Location = new System.Drawing.Point(3, 73);
            this.rdbTatCaXe.Name = "rdbTatCaXe";
            this.rdbTatCaXe.Size = new System.Drawing.Size(79, 17);
            this.rdbTatCaXe.TabIndex = 6;
            this.rdbTatCaXe.Text = "Tất Cả Xe";
            this.rdbTatCaXe.UseVisualStyleBackColor = true;
            this.rdbTatCaXe.CheckedChanged += new System.EventHandler(this.rdbTatCaXe_CheckedChanged);
            // 
            // rdbXeDaDat
            // 
            this.rdbXeDaDat.AutoSize = true;
            this.rdbXeDaDat.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbXeDaDat.Location = new System.Drawing.Point(3, 50);
            this.rdbXeDaDat.Name = "rdbXeDaDat";
            this.rdbXeDaDat.Size = new System.Drawing.Size(79, 17);
            this.rdbXeDaDat.TabIndex = 5;
            this.rdbXeDaDat.Text = "Xe Đã Đặt";
            this.rdbXeDaDat.UseVisualStyleBackColor = true;
            this.rdbXeDaDat.CheckedChanged += new System.EventHandler(this.rdbXeDaDat_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rdbXe4Cho);
            this.panel2.Controls.Add(this.rdbAllXe);
            this.panel2.Controls.Add(this.rdbXe7Cho);
            this.panel2.Location = new System.Drawing.Point(15, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 117);
            this.panel2.TabIndex = 105;
            // 
            // rdbXe4Cho
            // 
            this.rdbXe4Cho.AutoSize = true;
            this.rdbXe4Cho.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbXe4Cho.Location = new System.Drawing.Point(3, 27);
            this.rdbXe4Cho.Name = "rdbXe4Cho";
            this.rdbXe4Cho.Size = new System.Drawing.Size(73, 17);
            this.rdbXe4Cho.TabIndex = 4;
            this.rdbXe4Cho.Text = "Xe 4 Chỗ";
            this.rdbXe4Cho.UseVisualStyleBackColor = true;
            this.rdbXe4Cho.CheckedChanged += new System.EventHandler(this.rdbXe4Cho_CheckedChanged);
            // 
            // rdbAllXe
            // 
            this.rdbAllXe.AutoSize = true;
            this.rdbAllXe.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAllXe.Location = new System.Drawing.Point(3, 73);
            this.rdbAllXe.Name = "rdbAllXe";
            this.rdbAllXe.Size = new System.Drawing.Size(79, 17);
            this.rdbAllXe.TabIndex = 6;
            this.rdbAllXe.Text = "Tất Cả Xe";
            this.rdbAllXe.UseVisualStyleBackColor = true;
            this.rdbAllXe.CheckedChanged += new System.EventHandler(this.rdbAllXe_CheckedChanged);
            // 
            // rdbXe7Cho
            // 
            this.rdbXe7Cho.AutoSize = true;
            this.rdbXe7Cho.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbXe7Cho.Location = new System.Drawing.Point(3, 50);
            this.rdbXe7Cho.Name = "rdbXe7Cho";
            this.rdbXe7Cho.Size = new System.Drawing.Size(73, 17);
            this.rdbXe7Cho.TabIndex = 5;
            this.rdbXe7Cho.Text = "Xe 7 Chỗ";
            this.rdbXe7Cho.UseVisualStyleBackColor = true;
            this.rdbXe7Cho.CheckedChanged += new System.EventHandler(this.rdbXe7Cho_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 103;
            this.label3.Text = "Loại Xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 102;
            this.label2.Text = "Trạng Thái";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnThem);
            this.panelMain.Controls.Add(this.dgvProduct);
            this.panelMain.Controls.Add(this.btnThoat);
            this.panelMain.Controls.Add(this.btnSua);
            this.panelMain.Controls.Add(this.btnXoa);
            this.panelMain.Controls.Add(this.btnHuy);
            this.panelMain.Controls.Add(this.lblChuDe);
            this.panelMain.Controls.Add(this.groupBox1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 50);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(864, 517);
            this.panelMain.TabIndex = 2;
            // 
            // dgvProduct
            // 
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaXe,
            this.TenXe,
            this.SoChoNgoi,
            this.GiaThue,
            this.TinhTrang,
            this.MaLoaiXe});
            this.dgvProduct.Location = new System.Drawing.Point(254, 59);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(598, 378);
            this.dgvProduct.TabIndex = 122;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            this.dgvProduct.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellMouseLeave);
            this.dgvProduct.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProduct_CellMouseMove);
            this.dgvProduct.DoubleClick += new System.EventHandler(this.dgvProduct_DoubleClick);
            // 
            // MaXe
            // 
            this.MaXe.DataPropertyName = "MaXe";
            this.MaXe.FillWeight = 45.68528F;
            this.MaXe.HeaderText = "Mã Xe";
            this.MaXe.Name = "MaXe";
            // 
            // TenXe
            // 
            this.TenXe.DataPropertyName = "TenXe";
            this.TenXe.HeaderText = "Tên Xe";
            this.TenXe.Name = "TenXe";
            // 
            // SoChoNgoi
            // 
            this.SoChoNgoi.DataPropertyName = "SoChoNgoi";
            this.SoChoNgoi.HeaderText = "Số Chỗ Ngồi";
            this.SoChoNgoi.Name = "SoChoNgoi";
            // 
            // GiaThue
            // 
            this.GiaThue.DataPropertyName = "GiaThue";
            this.GiaThue.HeaderText = "Giá Thuê";
            this.GiaThue.Name = "GiaThue";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình Trạng Xe";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // MaLoaiXe
            // 
            this.MaLoaiXe.DataPropertyName = "MaLoaiXe";
            this.MaLoaiXe.HeaderText = "Mã Loại Xe";
            this.MaLoaiXe.Name = "MaLoaiXe";
            // 
            // lblChuDe
            // 
            this.lblChuDe.AutoSize = true;
            this.lblChuDe.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuDe.Location = new System.Drawing.Point(330, 20);
            this.lblChuDe.Name = "lblChuDe";
            this.lblChuDe.Size = new System.Drawing.Size(157, 25);
            this.lblChuDe.TabIndex = 117;
            this.lblChuDe.Text = "Danh Sách Xe";
            this.lblChuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbTinhTrang);
            this.groupBox1.Controls.Add(this.cbbSoChoNgoi);
            this.groupBox1.Controls.Add(this.cbbMaLoaiXe);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaXe);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.lblTenXe);
            this.groupBox1.Controls.Add(this.lblSoChoNgoi);
            this.groupBox1.Controls.Add(this.txtGiaThue);
            this.groupBox1.Controls.Add(this.lblGiaThue);
            this.groupBox1.Controls.Add(this.lblTinhTrang);
            this.groupBox1.Controls.Add(this.txtTenXe);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 378);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Xe";
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbbTinhTrang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Items.AddRange(new object[] {
            "Xe Trống",
            "Xe Đã Đặt"});
            this.cbbTinhTrang.Location = new System.Drawing.Point(19, 282);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(197, 26);
            this.cbbTinhTrang.TabIndex = 126;
            // 
            // cbbSoChoNgoi
            // 
            this.cbbSoChoNgoi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbSoChoNgoi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSoChoNgoi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbbSoChoNgoi.FormattingEnabled = true;
            this.cbbSoChoNgoi.Items.AddRange(new object[] {
            "4",
            "7"});
            this.cbbSoChoNgoi.Location = new System.Drawing.Point(19, 168);
            this.cbbSoChoNgoi.Name = "cbbSoChoNgoi";
            this.cbbSoChoNgoi.Size = new System.Drawing.Size(197, 28);
            this.cbbSoChoNgoi.TabIndex = 125;
            // 
            // cbbMaLoaiXe
            // 
            this.cbbMaLoaiXe.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbMaLoaiXe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaLoaiXe.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbbMaLoaiXe.FormattingEnabled = true;
            this.cbbMaLoaiXe.Location = new System.Drawing.Point(16, 339);
            this.cbbMaLoaiXe.Name = "cbbMaLoaiXe";
            this.cbbMaLoaiXe.Size = new System.Drawing.Size(200, 28);
            this.cbbMaLoaiXe.TabIndex = 124;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 123;
            this.label5.Text = "Mã Loại Xe:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(33, 40);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(52, 17);
            this.lblId.TabIndex = 121;
            this.lblId.Text = "Mã Xe:";
            // 
            // lblTenXe
            // 
            this.lblTenXe.AutoSize = true;
            this.lblTenXe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenXe.Location = new System.Drawing.Point(33, 94);
            this.lblTenXe.Name = "lblTenXe";
            this.lblTenXe.Size = new System.Drawing.Size(53, 17);
            this.lblTenXe.TabIndex = 113;
            this.lblTenXe.Text = "Tên Xe:";
            // 
            // lblSoChoNgoi
            // 
            this.lblSoChoNgoi.AutoSize = true;
            this.lblSoChoNgoi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoChoNgoi.Location = new System.Drawing.Point(33, 147);
            this.lblSoChoNgoi.Name = "lblSoChoNgoi";
            this.lblSoChoNgoi.Size = new System.Drawing.Size(91, 17);
            this.lblSoChoNgoi.TabIndex = 114;
            this.lblSoChoNgoi.Text = "Số Chỗ Ngồi:";
            // 
            // lblGiaThue
            // 
            this.lblGiaThue.AutoSize = true;
            this.lblGiaThue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaThue.Location = new System.Drawing.Point(33, 206);
            this.lblGiaThue.Name = "lblGiaThue";
            this.lblGiaThue.Size = new System.Drawing.Size(68, 17);
            this.lblGiaThue.TabIndex = 115;
            this.lblGiaThue.Text = "Giá Thuê:";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrang.Location = new System.Drawing.Point(33, 262);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(74, 17);
            this.lblTinhTrang.TabIndex = 116;
            this.lblTinhTrang.Text = "Tình Trạng:";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnThem.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThem.BorderRadius = 20;
            this.btnThem.BorderSize = 2;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(328, 465);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 123;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.Color.Black;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(755, 465);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.TabIndex = 121;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextColor = System.Drawing.Color.Black;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnSua.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSua.BorderRadius = 20;
            this.btnSua.BorderSize = 2;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(433, 465);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.TabIndex = 120;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextColor = System.Drawing.Color.Black;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnXoa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.BorderSize = 2;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(539, 465);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 119;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.Black;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnHuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnHuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Location = new System.Drawing.Point(647, 465);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 40);
            this.btnHuy.TabIndex = 118;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextColor = System.Drawing.Color.Black;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtMaXe
            // 
            this.txtMaXe.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaXe.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMaXe.BorderFocusColor = System.Drawing.Color.Black;
            this.txtMaXe.BorderRadius = 15;
            this.txtMaXe.BorderSize = 2;
            this.txtMaXe.Enabled = false;
            this.txtMaXe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaXe.ForeColor = System.Drawing.Color.Black;
            this.txtMaXe.Location = new System.Drawing.Point(16, 57);
            this.txtMaXe.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaXe.Multiline = true;
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaXe.PasswordChar = false;
            this.txtMaXe.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaXe.PlaceholderText = "";
            this.txtMaXe.Size = new System.Drawing.Size(200, 30);
            this.txtMaXe.TabIndex = 122;
            this.txtMaXe.Texts = "";
            this.txtMaXe.UnderlinedStyle = false;
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.BackColor = System.Drawing.SystemColors.Window;
            this.txtGiaThue.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtGiaThue.BorderFocusColor = System.Drawing.Color.Black;
            this.txtGiaThue.BorderRadius = 15;
            this.txtGiaThue.BorderSize = 2;
            this.txtGiaThue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaThue.ForeColor = System.Drawing.Color.Black;
            this.txtGiaThue.Location = new System.Drawing.Point(16, 223);
            this.txtGiaThue.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaThue.Multiline = true;
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGiaThue.PasswordChar = false;
            this.txtGiaThue.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGiaThue.PlaceholderText = "";
            this.txtGiaThue.Size = new System.Drawing.Size(200, 30);
            this.txtGiaThue.TabIndex = 119;
            this.txtGiaThue.Texts = "";
            this.txtGiaThue.UnderlinedStyle = false;
            // 
            // txtTenXe
            // 
            this.txtTenXe.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenXe.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTenXe.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTenXe.BorderRadius = 15;
            this.txtTenXe.BorderSize = 2;
            this.txtTenXe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenXe.ForeColor = System.Drawing.Color.Black;
            this.txtTenXe.Location = new System.Drawing.Point(16, 111);
            this.txtTenXe.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenXe.Multiline = true;
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTenXe.PasswordChar = false;
            this.txtTenXe.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenXe.PlaceholderText = "";
            this.txtTenXe.Size = new System.Drawing.Size(200, 30);
            this.txtTenXe.TabIndex = 117;
            this.txtTenXe.Texts = "";
            this.txtTenXe.UnderlinedStyle = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimKiem.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTimKiem.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTimKiem.BorderRadius = 15;
            this.txtTimKiem.BorderSize = 2;
            this.txtTimKiem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.Location = new System.Drawing.Point(358, 10);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.PlaceholderText = "     Tìm Kiếm Xe...";
            this.txtTimKiem.Size = new System.Drawing.Size(225, 30);
            this.txtTimKiem.TabIndex = 101;
            this.txtTimKiem.Texts = "";
            this.txtTimKiem.UnderlinedStyle = false;
            // 
            // customDatePicker1
            // 
            this.customDatePicker1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customDatePicker1.BorderSize = 2;
            this.customDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.customDatePicker1.Location = new System.Drawing.Point(103, 15);
            this.customDatePicker1.MinimumSize = new System.Drawing.Size(4, 25);
            this.customDatePicker1.Name = "customDatePicker1";
            this.customDatePicker1.Size = new System.Drawing.Size(225, 25);
            this.customDatePicker1.SkinColor = System.Drawing.Color.White;
            this.customDatePicker1.TabIndex = 100;
            this.customDatePicker1.TextColor = System.Drawing.Color.Black;
            // 
            // frmCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 567);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelNavbar);
            this.Name = "frmCar";
            this.Text = "Quản Lý Thuê Xe";
            this.Load += new System.EventHandler(this.frmCar_Load);
            this.panelNavbar.ResumeLayout(false);
            this.panelNavbar.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Label label1;
        private CustomControls.CustomDatePicker customDatePicker1;
        private CustomControls.Textbox txtTimKiem;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbXe4Cho;
        private System.Windows.Forms.RadioButton rdbAllXe;
        private System.Windows.Forms.RadioButton rdbXe7Cho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMain;
        private CustomControls.CustomButton btnThem;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoChoNgoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiXe;
        private CustomControls.CustomButton btnThoat;
        private CustomControls.CustomButton btnSua;
        private CustomControls.CustomButton btnXoa;
        private CustomControls.CustomButton btnHuy;
        private System.Windows.Forms.Label lblChuDe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
        private System.Windows.Forms.ComboBox cbbSoChoNgoi;
        private System.Windows.Forms.ComboBox cbbMaLoaiXe;
        private System.Windows.Forms.Label label5;
        private CustomControls.Textbox txtMaXe;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTenXe;
        private System.Windows.Forms.Label lblSoChoNgoi;
        private CustomControls.Textbox txtGiaThue;
        private System.Windows.Forms.Label lblGiaThue;
        private System.Windows.Forms.Label lblTinhTrang;
        private CustomControls.Textbox txtTenXe;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdbXeTrong;
        private System.Windows.Forms.RadioButton rdbTatCaXe;
        private System.Windows.Forms.RadioButton rdbXeDaDat;
    }
}