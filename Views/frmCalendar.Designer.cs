
namespace QUANLYTHUEXEOTO.Forms
{
    partial class frmCalendar
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
            this.dgvLichLamViec = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CALAMVIEC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblXemLai = new System.Windows.Forms.Label();
            this.lblChuDe = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblCaLamViec = new System.Windows.Forms.Label();
            this.lblNgayLamViec = new System.Windows.Forms.Label();
            this.cbbTenNV = new QUANLYTHUEXEOTO.CustomControls.CustomCombobox();
            this.cbbCa = new QUANLYTHUEXEOTO.CustomControls.CustomCombobox();
            this.txtXemDanhSach = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.customButton5 = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.customButton4 = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.customButton3 = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.customButton2 = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.customDatePicker1 = new QUANLYTHUEXEOTO.CustomControls.CustomDatePicker();
            this.customButton1 = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichLamViec
            // 
            this.dgvLichLamViec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLichLamViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichLamViec.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLichLamViec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLichLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichLamViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.HOTENNV,
            this.CALAMVIEC,
            this.NGAYLAM,
            this.id});
            this.dgvLichLamViec.Location = new System.Drawing.Point(239, 50);
            this.dgvLichLamViec.Name = "dgvLichLamViec";
            this.dgvLichLamViec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichLamViec.Size = new System.Drawing.Size(383, 290);
            this.dgvLichLamViec.TabIndex = 71;
            this.dgvLichLamViec.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichLamViec_CellMouseLeave);
            this.dgvLichLamViec.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLichLamViec_CellMouseMove);
            // 
            // stt
            // 
            this.stt.FillWeight = 31.57232F;
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // HOTENNV
            // 
            this.HOTENNV.FillWeight = 181.5043F;
            this.HOTENNV.HeaderText = "Họ Tên Nhân Viên";
            this.HOTENNV.Name = "HOTENNV";
            // 
            // CALAMVIEC
            // 
            this.CALAMVIEC.FillWeight = 85.40057F;
            this.CALAMVIEC.HeaderText = "Ca Làm Việc";
            this.CALAMVIEC.Name = "CALAMVIEC";
            // 
            // NGAYLAM
            // 
            this.NGAYLAM.FillWeight = 101.5229F;
            this.NGAYLAM.HeaderText = "Ngày Làm Việc";
            this.NGAYLAM.Name = "NGAYLAM";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // lblXemLai
            // 
            this.lblXemLai.AutoSize = true;
            this.lblXemLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblXemLai.Location = new System.Drawing.Point(12, 50);
            this.lblXemLai.Name = "lblXemLai";
            this.lblXemLai.Size = new System.Drawing.Size(99, 16);
            this.lblXemLai.TabIndex = 70;
            this.lblXemLai.Text = "Xem Lại Lịch:";
            // 
            // lblChuDe
            // 
            this.lblChuDe.AutoSize = true;
            this.lblChuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChuDe.Location = new System.Drawing.Point(235, 15);
            this.lblChuDe.Name = "lblChuDe";
            this.lblChuDe.Size = new System.Drawing.Size(215, 20);
            this.lblChuDe.TabIndex = 69;
            this.lblChuDe.Text = "Danh Sách Lịch Làm Việc";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenNV.Location = new System.Drawing.Point(12, 170);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(96, 13);
            this.lblTenNV.TabIndex = 77;
            this.lblTenNV.Text = "Tên Nhân Viên:";
            // 
            // lblCaLamViec
            // 
            this.lblCaLamViec.AutoSize = true;
            this.lblCaLamViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCaLamViec.Location = new System.Drawing.Point(12, 232);
            this.lblCaLamViec.Name = "lblCaLamViec";
            this.lblCaLamViec.Size = new System.Drawing.Size(82, 13);
            this.lblCaLamViec.TabIndex = 78;
            this.lblCaLamViec.Text = "Ca Làm Việc:";
            // 
            // lblNgayLamViec
            // 
            this.lblNgayLamViec.AutoSize = true;
            this.lblNgayLamViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayLamViec.Location = new System.Drawing.Point(12, 295);
            this.lblNgayLamViec.Name = "lblNgayLamViec";
            this.lblNgayLamViec.Size = new System.Drawing.Size(96, 13);
            this.lblNgayLamViec.TabIndex = 79;
            this.lblNgayLamViec.Text = "Ngày Làm Việc:";
            // 
            // cbbTenNV
            // 
            this.cbbTenNV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbTenNV.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbTenNV.BorderSize = 3;
            this.cbbTenNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbbTenNV.ForeColor = System.Drawing.Color.DimGray;
            this.cbbTenNV.IconColor = System.Drawing.Color.Fuchsia;
            this.cbbTenNV.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbTenNV.ListTextColor = System.Drawing.Color.DimGray;
            this.cbbTenNV.Location = new System.Drawing.Point(8, 186);
            this.cbbTenNV.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbbTenNV.Name = "cbbTenNV";
            this.cbbTenNV.Padding = new System.Windows.Forms.Padding(3);
            this.cbbTenNV.Size = new System.Drawing.Size(225, 30);
            this.cbbTenNV.TabIndex = 83;
            this.cbbTenNV.Texts = "";
            // 
            // cbbCa
            // 
            this.cbbCa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbCa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbCa.BorderSize = 3;
            this.cbbCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbbCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbbCa.ForeColor = System.Drawing.Color.DimGray;
            this.cbbCa.IconColor = System.Drawing.Color.Fuchsia;
            this.cbbCa.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbCa.ListTextColor = System.Drawing.Color.DimGray;
            this.cbbCa.Location = new System.Drawing.Point(7, 248);
            this.cbbCa.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbbCa.Name = "cbbCa";
            this.cbbCa.Padding = new System.Windows.Forms.Padding(3);
            this.cbbCa.Size = new System.Drawing.Size(225, 30);
            this.cbbCa.TabIndex = 84;
            this.cbbCa.Texts = "";
            // 
            // txtXemDanhSach
            // 
            this.txtXemDanhSach.BackColor = System.Drawing.SystemColors.Window;
            this.txtXemDanhSach.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtXemDanhSach.BorderFocusColor = System.Drawing.Color.Black;
            this.txtXemDanhSach.BorderRadius = 15;
            this.txtXemDanhSach.BorderSize = 2;
            this.txtXemDanhSach.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXemDanhSach.ForeColor = System.Drawing.Color.Black;
            this.txtXemDanhSach.Location = new System.Drawing.Point(7, 74);
            this.txtXemDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtXemDanhSach.Multiline = true;
            this.txtXemDanhSach.Name = "txtXemDanhSach";
            this.txtXemDanhSach.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtXemDanhSach.PasswordChar = false;
            this.txtXemDanhSach.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtXemDanhSach.PlaceholderText = "";
            this.txtXemDanhSach.Size = new System.Drawing.Size(225, 30);
            this.txtXemDanhSach.TabIndex = 85;
            this.txtXemDanhSach.Texts = "";
            this.txtXemDanhSach.UnderlinedStyle = false;
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
            this.customButton5.Location = new System.Drawing.Point(202, 364);
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
            this.customButton4.Location = new System.Drawing.Point(308, 364);
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
            this.customButton3.Location = new System.Drawing.Point(414, 364);
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
            // customDatePicker1
            // 
            this.customDatePicker1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customDatePicker1.BorderSize = 2;
            this.customDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.customDatePicker1.Location = new System.Drawing.Point(7, 315);
            this.customDatePicker1.MinimumSize = new System.Drawing.Size(4, 25);
            this.customDatePicker1.Name = "customDatePicker1";
            this.customDatePicker1.Size = new System.Drawing.Size(225, 25);
            this.customDatePicker1.SkinColor = System.Drawing.Color.White;
            this.customDatePicker1.TabIndex = 99;
            this.customDatePicker1.TextColor = System.Drawing.Color.Black;
            // 
            // customButton1
            // 
            this.customButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton1.BackColor = System.Drawing.SystemColors.Control;
            this.customButton1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.customButton1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BorderRadius = 20;
            this.customButton1.BorderSize = 2;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.Black;
            this.customButton1.Location = new System.Drawing.Point(69, 111);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(100, 40);
            this.customButton1.TabIndex = 100;
            this.customButton1.Text = "Xem Lại";
            this.customButton1.TextColor = System.Drawing.Color.Black;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // frmCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 416);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.customDatePicker1);
            this.Controls.Add(this.customButton5);
            this.Controls.Add(this.customButton4);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.txtXemDanhSach);
            this.Controls.Add(this.cbbCa);
            this.Controls.Add(this.cbbTenNV);
            this.Controls.Add(this.lblNgayLamViec);
            this.Controls.Add(this.lblCaLamViec);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.dgvLichLamViec);
            this.Controls.Add(this.lblXemLai);
            this.Controls.Add(this.lblChuDe);
            this.Name = "frmCalendar";
            this.Text = "Quản Lý Lịch Làm Việc";
            this.Load += new System.EventHandler(this.frmCalendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLichLamViec;
        private System.Windows.Forms.Label lblXemLai;
        private System.Windows.Forms.Label lblChuDe;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblCaLamViec;
        private System.Windows.Forms.Label lblNgayLamViec;
        private CustomControls.CustomCombobox cbbTenNV;
        private CustomControls.CustomCombobox cbbCa;
        private CustomControls.Textbox txtXemDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CALAMVIEC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private CustomControls.CustomButton customButton5;
        private CustomControls.CustomButton customButton4;
        private CustomControls.CustomButton customButton3;
        private CustomControls.CustomButton customButton2;
        private CustomControls.CustomDatePicker customDatePicker1;
        private CustomControls.CustomButton customButton1;
    }
}