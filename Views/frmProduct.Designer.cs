
namespace QUANLYTHUEXEOTO.Forms
{
    partial class frmProduct
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
            this.dgvQuanLyXe = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENXE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAUXE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOCHONGOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDLOAIXE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblChuDe = new System.Windows.Forms.Label();
            this.lblTenXe = new System.Windows.Forms.Label();
            this.lblMauXe = new System.Windows.Forms.Label();
            this.lblSoChoNgoi = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtTenXe = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.txtMauXe = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.txtSoChoNgoi = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.txtDonGia = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.customButton5 = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.customButton4 = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.customButton3 = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.customButton2 = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.textbox1 = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyXe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuanLyXe
            // 
            this.dgvQuanLyXe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuanLyXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyXe.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvQuanLyXe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQuanLyXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.TENXE,
            this.MAUXE,
            this.SOCHONGOI,
            this.DONGIA,
            this.IDLOAIXE});
            this.dgvQuanLyXe.Location = new System.Drawing.Point(239, 50);
            this.dgvQuanLyXe.Name = "dgvQuanLyXe";
            this.dgvQuanLyXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuanLyXe.Size = new System.Drawing.Size(383, 290);
            this.dgvQuanLyXe.TabIndex = 71;
            this.dgvQuanLyXe.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyXe_CellMouseLeave);
            this.dgvQuanLyXe.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvQuanLyXe_CellMouseMove);
            // 
            // stt
            // 
            this.stt.FillWeight = 76.14214F;
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // TENXE
            // 
            this.TENXE.FillWeight = 177.8392F;
            this.TENXE.HeaderText = "Tên Xe";
            this.TENXE.Name = "TENXE";
            // 
            // MAUXE
            // 
            this.MAUXE.FillWeight = 66.76657F;
            this.MAUXE.HeaderText = "Màu Xe";
            this.MAUXE.Name = "MAUXE";
            // 
            // SOCHONGOI
            // 
            this.SOCHONGOI.FillWeight = 94.99701F;
            this.SOCHONGOI.HeaderText = "Số Chỗ Ngồi";
            this.SOCHONGOI.Name = "SOCHONGOI";
            // 
            // DONGIA
            // 
            this.DONGIA.FillWeight = 84.2551F;
            this.DONGIA.HeaderText = "Đơn Giá";
            this.DONGIA.Name = "DONGIA";
            // 
            // IDLOAIXE
            // 
            this.IDLOAIXE.HeaderText = "ID Loại Xe";
            this.IDLOAIXE.Name = "IDLOAIXE";
            this.IDLOAIXE.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblInfo.Location = new System.Drawing.Point(24, 50);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(100, 16);
            this.lblInfo.TabIndex = 70;
            this.lblInfo.Text = "Thông Tin Xe";
            // 
            // lblChuDe
            // 
            this.lblChuDe.AutoSize = true;
            this.lblChuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChuDe.Location = new System.Drawing.Point(235, 15);
            this.lblChuDe.Name = "lblChuDe";
            this.lblChuDe.Size = new System.Drawing.Size(102, 20);
            this.lblChuDe.TabIndex = 69;
            this.lblChuDe.Text = "Quản Lý Xe";
            // 
            // lblTenXe
            // 
            this.lblTenXe.AutoSize = true;
            this.lblTenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenXe.Location = new System.Drawing.Point(24, 131);
            this.lblTenXe.Name = "lblTenXe";
            this.lblTenXe.Size = new System.Drawing.Size(52, 13);
            this.lblTenXe.TabIndex = 72;
            this.lblTenXe.Text = "Tên Xe:";
            // 
            // lblMauXe
            // 
            this.lblMauXe.AutoSize = true;
            this.lblMauXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMauXe.Location = new System.Drawing.Point(24, 184);
            this.lblMauXe.Name = "lblMauXe";
            this.lblMauXe.Size = new System.Drawing.Size(54, 13);
            this.lblMauXe.TabIndex = 74;
            this.lblMauXe.Text = "Màu Xe:";
            // 
            // lblSoChoNgoi
            // 
            this.lblSoChoNgoi.AutoSize = true;
            this.lblSoChoNgoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoChoNgoi.Location = new System.Drawing.Point(24, 239);
            this.lblSoChoNgoi.Name = "lblSoChoNgoi";
            this.lblSoChoNgoi.Size = new System.Drawing.Size(82, 13);
            this.lblSoChoNgoi.TabIndex = 76;
            this.lblSoChoNgoi.Text = "Số Chỗ Ngồi:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDonGia.Location = new System.Drawing.Point(24, 295);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(57, 13);
            this.lblDonGia.TabIndex = 78;
            this.lblDonGia.Text = "Đơn Giá:";
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
            this.txtTenXe.Location = new System.Drawing.Point(7, 148);
            this.txtTenXe.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenXe.Multiline = true;
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTenXe.PasswordChar = false;
            this.txtTenXe.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenXe.PlaceholderText = "";
            this.txtTenXe.Size = new System.Drawing.Size(225, 30);
            this.txtTenXe.TabIndex = 83;
            this.txtTenXe.Texts = "";
            this.txtTenXe.UnderlinedStyle = false;
            // 
            // txtMauXe
            // 
            this.txtMauXe.BackColor = System.Drawing.SystemColors.Window;
            this.txtMauXe.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMauXe.BorderFocusColor = System.Drawing.Color.Black;
            this.txtMauXe.BorderRadius = 15;
            this.txtMauXe.BorderSize = 2;
            this.txtMauXe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMauXe.ForeColor = System.Drawing.Color.Black;
            this.txtMauXe.Location = new System.Drawing.Point(7, 201);
            this.txtMauXe.Margin = new System.Windows.Forms.Padding(4);
            this.txtMauXe.Multiline = true;
            this.txtMauXe.Name = "txtMauXe";
            this.txtMauXe.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMauXe.PasswordChar = false;
            this.txtMauXe.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMauXe.PlaceholderText = "";
            this.txtMauXe.Size = new System.Drawing.Size(225, 30);
            this.txtMauXe.TabIndex = 84;
            this.txtMauXe.Texts = "";
            this.txtMauXe.UnderlinedStyle = false;
            // 
            // txtSoChoNgoi
            // 
            this.txtSoChoNgoi.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoChoNgoi.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSoChoNgoi.BorderFocusColor = System.Drawing.Color.Black;
            this.txtSoChoNgoi.BorderRadius = 15;
            this.txtSoChoNgoi.BorderSize = 2;
            this.txtSoChoNgoi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoChoNgoi.ForeColor = System.Drawing.Color.Black;
            this.txtSoChoNgoi.Location = new System.Drawing.Point(7, 256);
            this.txtSoChoNgoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoChoNgoi.Multiline = true;
            this.txtSoChoNgoi.Name = "txtSoChoNgoi";
            this.txtSoChoNgoi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSoChoNgoi.PasswordChar = false;
            this.txtSoChoNgoi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoChoNgoi.PlaceholderText = "";
            this.txtSoChoNgoi.Size = new System.Drawing.Size(225, 30);
            this.txtSoChoNgoi.TabIndex = 85;
            this.txtSoChoNgoi.Texts = "";
            this.txtSoChoNgoi.UnderlinedStyle = false;
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.SystemColors.Window;
            this.txtDonGia.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDonGia.BorderFocusColor = System.Drawing.Color.Black;
            this.txtDonGia.BorderRadius = 15;
            this.txtDonGia.BorderSize = 2;
            this.txtDonGia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.ForeColor = System.Drawing.Color.Black;
            this.txtDonGia.Location = new System.Drawing.Point(7, 312);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDonGia.PasswordChar = false;
            this.txtDonGia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDonGia.PlaceholderText = "";
            this.txtDonGia.Size = new System.Drawing.Size(225, 30);
            this.txtDonGia.TabIndex = 86;
            this.txtDonGia.Texts = "";
            this.txtDonGia.UnderlinedStyle = false;
            // 
            // customButton5
            // 
            this.customButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton5.BackColor = System.Drawing.SystemColors.Control;
            this.customButton5.BackgroundColor = System.Drawing.SystemColors.Control;
            this.customButton5.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton5.BorderRadius = 20;
            this.customButton5.BorderSize = 2;
            this.customButton5.FlatAppearance.BorderSize = 0;
            this.customButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton5.ForeColor = System.Drawing.Color.Black;
            this.customButton5.Location = new System.Drawing.Point(204, 364);
            this.customButton5.Name = "customButton5";
            this.customButton5.Size = new System.Drawing.Size(100, 40);
            this.customButton5.TabIndex = 98;
            this.customButton5.Text = "Thêm";
            this.customButton5.TextColor = System.Drawing.Color.Black;
            this.customButton5.UseVisualStyleBackColor = false;
            // 
            // customButton4
            // 
            this.customButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton4.BackColor = System.Drawing.SystemColors.Control;
            this.customButton4.BackgroundColor = System.Drawing.SystemColors.Control;
            this.customButton4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton4.BorderRadius = 20;
            this.customButton4.BorderSize = 2;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.ForeColor = System.Drawing.Color.Black;
            this.customButton4.Location = new System.Drawing.Point(310, 364);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(100, 40);
            this.customButton4.TabIndex = 97;
            this.customButton4.Text = "Xóa";
            this.customButton4.TextColor = System.Drawing.Color.Black;
            this.customButton4.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            this.customButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton3.BackColor = System.Drawing.SystemColors.Control;
            this.customButton3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.customButton3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton3.BorderRadius = 20;
            this.customButton3.BorderSize = 2;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.Black;
            this.customButton3.Location = new System.Drawing.Point(416, 364);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(100, 40);
            this.customButton3.TabIndex = 96;
            this.customButton3.Text = "Sửa";
            this.customButton3.TextColor = System.Drawing.Color.Black;
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            this.customButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton2.BackColor = System.Drawing.SystemColors.Control;
            this.customButton2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.customButton2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton2.BorderRadius = 20;
            this.customButton2.BorderSize = 2;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.Black;
            this.customButton2.Location = new System.Drawing.Point(522, 364);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(100, 40);
            this.customButton2.TabIndex = 95;
            this.customButton2.Text = "Hủy";
            this.customButton2.TextColor = System.Drawing.Color.Black;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // textbox1
            // 
            this.textbox1.BackColor = System.Drawing.SystemColors.Window;
            this.textbox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textbox1.BorderFocusColor = System.Drawing.Color.Black;
            this.textbox1.BorderRadius = 15;
            this.textbox1.BorderSize = 2;
            this.textbox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox1.ForeColor = System.Drawing.Color.Black;
            this.textbox1.Location = new System.Drawing.Point(7, 94);
            this.textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.textbox1.Multiline = true;
            this.textbox1.Name = "textbox1";
            this.textbox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textbox1.PasswordChar = false;
            this.textbox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox1.PlaceholderText = "";
            this.textbox1.Size = new System.Drawing.Size(225, 30);
            this.textbox1.TabIndex = 100;
            this.textbox1.Texts = "";
            this.textbox1.UnderlinedStyle = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblId.Location = new System.Drawing.Point(24, 77);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 13);
            this.lblId.TabIndex = 99;
            this.lblId.Text = "ID:";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 416);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.customButton5);
            this.Controls.Add(this.customButton4);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSoChoNgoi);
            this.Controls.Add(this.txtMauXe);
            this.Controls.Add(this.txtTenXe);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblSoChoNgoi);
            this.Controls.Add(this.lblMauXe);
            this.Controls.Add(this.lblTenXe);
            this.Controls.Add(this.dgvQuanLyXe);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblChuDe);
            this.Name = "frmProduct";
            this.Text = "Quản Lý Sản Phẩm";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuanLyXe;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblChuDe;
        private System.Windows.Forms.Label lblTenXe;
        private System.Windows.Forms.Label lblMauXe;
        private System.Windows.Forms.Label lblSoChoNgoi;
        private System.Windows.Forms.Label lblDonGia;
        private CustomControls.Textbox txtTenXe;
        private CustomControls.Textbox txtMauXe;
        private CustomControls.Textbox txtSoChoNgoi;
        private CustomControls.Textbox txtDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENXE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAUXE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOCHONGOI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLOAIXE;
        private CustomControls.CustomButton customButton5;
        private CustomControls.CustomButton customButton4;
        private CustomControls.CustomButton customButton3;
        private CustomControls.CustomButton customButton2;
        private CustomControls.Textbox textbox1;
        private System.Windows.Forms.Label lblId;
    }
}