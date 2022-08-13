
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENXE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAUXE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOCHONGOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDLOAIXE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblChuDe = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTenXe = new System.Windows.Forms.Label();
            this.lblMauXe = new System.Windows.Forms.Label();
            this.lblSoChoNgoi = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtTenXe = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.txtMauXe = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.txtSoChoNgoi = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.txtDonGia = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.TENXE,
            this.MAUXE,
            this.SOCHONGOI,
            this.DONGIA,
            this.IDLOAIXE});
            this.dataGridView1.Location = new System.Drawing.Point(239, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(383, 290);
            this.dataGridView1.TabIndex = 71;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // TENXE
            // 
            this.TENXE.HeaderText = "Tên Xe";
            this.TENXE.Name = "TENXE";
            // 
            // MAUXE
            // 
            this.MAUXE.HeaderText = "Màu Xe";
            this.MAUXE.Name = "MAUXE";
            // 
            // SOCHONGOI
            // 
            this.SOCHONGOI.HeaderText = "Số Chỗ Ngồi";
            this.SOCHONGOI.Name = "SOCHONGOI";
            // 
            // DONGIA
            // 
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
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(525, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 36);
            this.button3.TabIndex = 62;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(410, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 36);
            this.button2.TabIndex = 61;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(292, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 36);
            this.button1.TabIndex = 60;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblTenXe
            // 
            this.lblTenXe.AutoSize = true;
            this.lblTenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenXe.Location = new System.Drawing.Point(24, 84);
            this.lblTenXe.Name = "lblTenXe";
            this.lblTenXe.Size = new System.Drawing.Size(52, 13);
            this.lblTenXe.TabIndex = 72;
            this.lblTenXe.Text = "Tên Xe:";
            // 
            // lblMauXe
            // 
            this.lblMauXe.AutoSize = true;
            this.lblMauXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMauXe.Location = new System.Drawing.Point(24, 149);
            this.lblMauXe.Name = "lblMauXe";
            this.lblMauXe.Size = new System.Drawing.Size(54, 13);
            this.lblMauXe.TabIndex = 74;
            this.lblMauXe.Text = "Màu Xe:";
            // 
            // lblSoChoNgoi
            // 
            this.lblSoChoNgoi.AutoSize = true;
            this.lblSoChoNgoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoChoNgoi.Location = new System.Drawing.Point(24, 217);
            this.lblSoChoNgoi.Name = "lblSoChoNgoi";
            this.lblSoChoNgoi.Size = new System.Drawing.Size(82, 13);
            this.lblSoChoNgoi.TabIndex = 76;
            this.lblSoChoNgoi.Text = "Số Chỗ Ngồi:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDonGia.Location = new System.Drawing.Point(24, 288);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(57, 13);
            this.lblDonGia.TabIndex = 78;
            this.lblDonGia.Text = "Đơn Giá:";
            // 
            // txtTenXe
            // 
            this.txtTenXe.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenXe.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTenXe.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenXe.BorderRadius = 15;
            this.txtTenXe.BorderSize = 2;
            this.txtTenXe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenXe.ForeColor = System.Drawing.Color.HotPink;
            this.txtTenXe.Location = new System.Drawing.Point(7, 101);
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
            this.txtMauXe.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMauXe.BorderRadius = 15;
            this.txtMauXe.BorderSize = 2;
            this.txtMauXe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMauXe.ForeColor = System.Drawing.Color.HotPink;
            this.txtMauXe.Location = new System.Drawing.Point(7, 166);
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
            this.txtSoChoNgoi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSoChoNgoi.BorderRadius = 15;
            this.txtSoChoNgoi.BorderSize = 2;
            this.txtSoChoNgoi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoChoNgoi.ForeColor = System.Drawing.Color.HotPink;
            this.txtSoChoNgoi.Location = new System.Drawing.Point(7, 234);
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
            this.txtDonGia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDonGia.BorderRadius = 15;
            this.txtDonGia.BorderSize = 2;
            this.txtDonGia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.ForeColor = System.Drawing.Color.HotPink;
            this.txtDonGia.Location = new System.Drawing.Point(7, 305);
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
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 416);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSoChoNgoi);
            this.Controls.Add(this.txtMauXe);
            this.Controls.Add(this.txtTenXe);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblSoChoNgoi);
            this.Controls.Add(this.lblMauXe);
            this.Controls.Add(this.lblTenXe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblChuDe);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmProduct";
            this.Text = "Quản Lý Sản Phẩm";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblChuDe;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTenXe;
        private System.Windows.Forms.Label lblMauXe;
        private System.Windows.Forms.Label lblSoChoNgoi;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENXE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAUXE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOCHONGOI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLOAIXE;
        private CustomControls.Textbox txtTenXe;
        private CustomControls.Textbox txtMauXe;
        private CustomControls.Textbox txtSoChoNgoi;
        private CustomControls.Textbox txtDonGia;
    }
}