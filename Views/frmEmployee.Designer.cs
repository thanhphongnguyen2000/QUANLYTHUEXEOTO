
namespace QUANLYTHUEXEOTO.Forms
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.lblChuDe = new System.Windows.Forms.Label();
            this.txtTimKiem = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.customPictureBox1 = new QUANLYTHUEXEOTO.CustomControls.CustomPictureBox();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.customButton1 = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.customButton2 = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.customButton3 = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.customButton4 = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.customButton5 = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.HOTENNV,
            this.DIENTHOAI,
            this.CMND,
            this.DIACHI,
            this.IMAGE});
            this.dgvNhanVien.Location = new System.Drawing.Point(239, 50);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(388, 299);
            this.dgvNhanVien.TabIndex = 71;
            this.dgvNhanVien.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellMouseLeave);
            this.dgvNhanVien.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNhanVien_CellMouseMove);
            // 
            // stt
            // 
            this.stt.FillWeight = 31.68558F;
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // HOTENNV
            // 
            this.HOTENNV.FillWeight = 163.597F;
            this.HOTENNV.HeaderText = "Họ Tên Nhân Viên";
            this.HOTENNV.Name = "HOTENNV";
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.FillWeight = 90.03218F;
            this.DIENTHOAI.HeaderText = "Điện Thoại";
            this.DIENTHOAI.Name = "DIENTHOAI";
            // 
            // CMND
            // 
            this.CMND.FillWeight = 76.14213F;
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            // 
            // DIACHI
            // 
            this.DIACHI.FillWeight = 138.5431F;
            this.DIACHI.HeaderText = "Địa Chỉ";
            this.DIACHI.Name = "DIACHI";
            // 
            // IMAGE
            // 
            this.IMAGE.HeaderText = "Hình Ảnh";
            this.IMAGE.Name = "IMAGE";
            this.IMAGE.Visible = false;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTimKiem.Location = new System.Drawing.Point(12, 257);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(76, 16);
            this.lblTimKiem.TabIndex = 70;
            this.lblTimKiem.Text = "Tìm Kiếm:";
            // 
            // lblChuDe
            // 
            this.lblChuDe.AutoSize = true;
            this.lblChuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChuDe.Location = new System.Drawing.Point(235, 15);
            this.lblChuDe.Name = "lblChuDe";
            this.lblChuDe.Size = new System.Drawing.Size(186, 20);
            this.lblChuDe.TabIndex = 69;
            this.lblChuDe.Text = "Danh Sách Nhân Viên";
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
            this.txtTimKiem.Location = new System.Drawing.Point(7, 275);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(225, 30);
            this.txtTimKiem.TabIndex = 87;
            this.txtTimKiem.Texts = "";
            this.txtTimKiem.UnderlinedStyle = false;
            // 
            // customPictureBox1
            // 
            this.customPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
            this.customPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.customPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.customPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.customPictureBox1.BorderSize = 5;
            this.customPictureBox1.GradientAngle = 50F;
            this.customPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("customPictureBox1.Image")));
            this.customPictureBox1.Location = new System.Drawing.Point(15, 74);
            this.customPictureBox1.Name = "customPictureBox1";
            this.customPictureBox1.Size = new System.Drawing.Size(180, 180);
            this.customPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customPictureBox1.TabIndex = 88;
            this.customPictureBox1.TabStop = false;
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThongTin.Location = new System.Drawing.Point(12, 50);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(153, 16);
            this.lblThongTin.TabIndex = 89;
            this.lblThongTin.Text = "Thông Tin Nhân Viên";
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
            this.customButton1.Location = new System.Drawing.Point(60, 312);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(120, 40);
            this.customButton1.TabIndex = 90;
            this.customButton1.Text = "Tìm Kiếm";
            this.customButton1.TextColor = System.Drawing.Color.Black;
            this.customButton1.UseVisualStyleBackColor = false;
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
            this.customButton2.Location = new System.Drawing.Point(527, 364);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(100, 40);
            this.customButton2.TabIndex = 91;
            this.customButton2.Text = "Hủy";
            this.customButton2.TextColor = System.Drawing.Color.Black;
            this.customButton2.UseVisualStyleBackColor = false;
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
            this.customButton3.Location = new System.Drawing.Point(421, 364);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(100, 40);
            this.customButton3.TabIndex = 92;
            this.customButton3.Text = "Xóa";
            this.customButton3.TextColor = System.Drawing.Color.Black;
            this.customButton3.UseVisualStyleBackColor = false;
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
            this.customButton4.Location = new System.Drawing.Point(315, 364);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(100, 40);
            this.customButton4.TabIndex = 93;
            this.customButton4.Text = "Sửa";
            this.customButton4.TextColor = System.Drawing.Color.Black;
            this.customButton4.UseVisualStyleBackColor = false;
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
            this.customButton5.Location = new System.Drawing.Point(209, 364);
            this.customButton5.Name = "customButton5";
            this.customButton5.Size = new System.Drawing.Size(100, 40);
            this.customButton5.TabIndex = 94;
            this.customButton5.Text = "Thêm";
            this.customButton5.TextColor = System.Drawing.Color.Black;
            this.customButton5.UseVisualStyleBackColor = false;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 416);
            this.Controls.Add(this.customButton5);
            this.Controls.Add(this.customButton4);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.customPictureBox1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.lblChuDe);
            this.Name = "frmEmployee";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Label lblChuDe;
        private CustomControls.Textbox txtTimKiem;
        private CustomControls.CustomPictureBox customPictureBox1;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMAGE;
        private CustomControls.CustomButton customButton1;
        private CustomControls.CustomButton customButton2;
        private CustomControls.CustomButton customButton3;
        private CustomControls.CustomButton customButton4;
        private CustomControls.CustomButton customButton5;
    }
}