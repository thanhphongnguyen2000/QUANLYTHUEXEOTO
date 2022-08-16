
namespace QUANLYTHUEXEOTO
{
    partial class frmMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMember));
            this.txtDienThoai = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.btnDangKy = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.txtHoTen = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDiaChi = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.txtCMND = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.BackColor = System.Drawing.SystemColors.Window;
            this.txtDienThoai.BorderColor = System.Drawing.Color.Red;
            this.txtDienThoai.BorderFocusColor = System.Drawing.Color.Black;
            this.txtDienThoai.BorderRadius = 15;
            this.txtDienThoai.BorderSize = 2;
            this.txtDienThoai.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoai.ForeColor = System.Drawing.Color.Black;
            this.txtDienThoai.Location = new System.Drawing.Point(427, 170);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtDienThoai.Multiline = true;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDienThoai.PasswordChar = true;
            this.txtDienThoai.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDienThoai.PlaceholderText = "Điện Thoại";
            this.txtDienThoai.Size = new System.Drawing.Size(250, 30);
            this.txtDienThoai.TabIndex = 44;
            this.txtDienThoai.Texts = "";
            this.txtDienThoai.UnderlinedStyle = false;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.SystemColors.Control;
            this.btnDangKy.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnDangKy.BorderColor = System.Drawing.Color.Red;
            this.btnDangKy.BorderRadius = 20;
            this.btnDangKy.BorderSize = 2;
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDangKy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.Black;
            this.btnDangKy.Location = new System.Drawing.Point(471, 356);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(150, 40);
            this.btnDangKy.TabIndex = 43;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.TextColor = System.Drawing.Color.Black;
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoTen.BorderColor = System.Drawing.Color.Red;
            this.txtHoTen.BorderFocusColor = System.Drawing.Color.Black;
            this.txtHoTen.BorderRadius = 15;
            this.txtHoTen.BorderSize = 2;
            this.txtHoTen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.Location = new System.Drawing.Point(427, 99);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtHoTen.PasswordChar = false;
            this.txtHoTen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHoTen.PlaceholderText = "Họ Tên";
            this.txtHoTen.Size = new System.Drawing.Size(250, 30);
            this.txtHoTen.TabIndex = 42;
            this.txtHoTen.Texts = "";
            this.txtHoTen.UnderlinedStyle = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::QUANLYTHUEXEOTO.Properties.Resources.icon_close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(654, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 33);
            this.btnClose.TabIndex = 41;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Điện Thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Họ Tên Nhân Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(467, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "SignUp Member";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaChi.BorderColor = System.Drawing.Color.Red;
            this.txtDiaChi.BorderFocusColor = System.Drawing.Color.Black;
            this.txtDiaChi.BorderRadius = 15;
            this.txtDiaChi.BorderSize = 2;
            this.txtDiaChi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.Location = new System.Drawing.Point(427, 312);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDiaChi.PasswordChar = true;
            this.txtDiaChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiaChi.PlaceholderText = "Address";
            this.txtDiaChi.Size = new System.Drawing.Size(250, 30);
            this.txtDiaChi.TabIndex = 48;
            this.txtDiaChi.Texts = "";
            this.txtDiaChi.UnderlinedStyle = false;
            // 
            // txtCMND
            // 
            this.txtCMND.BackColor = System.Drawing.SystemColors.Window;
            this.txtCMND.BorderColor = System.Drawing.Color.Red;
            this.txtCMND.BorderFocusColor = System.Drawing.Color.Black;
            this.txtCMND.BorderRadius = 15;
            this.txtCMND.BorderSize = 2;
            this.txtCMND.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.ForeColor = System.Drawing.Color.Black;
            this.txtCMND.Location = new System.Drawing.Point(427, 241);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.Multiline = true;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCMND.PasswordChar = false;
            this.txtCMND.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCMND.PlaceholderText = "CMND";
            this.txtCMND.Size = new System.Drawing.Size(250, 30);
            this.txtCMND.TabIndex = 47;
            this.txtCMND.Texts = "";
            this.txtCMND.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "CMND:";
            // 
            // frmMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 420);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMember";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.Textbox txtDienThoai;
        private CustomControls.CustomButton btnDangKy;
        private CustomControls.Textbox txtHoTen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.Textbox txtDiaChi;
        private CustomControls.Textbox txtCMND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}