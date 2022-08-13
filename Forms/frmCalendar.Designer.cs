
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblCaLamViec = new System.Windows.Forms.Label();
            this.lblNgayLamViec = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.customDatePicker1 = new QUANLYTHUEXEOTO.CustomControls.CustomDatePicker();
            this.cbbTenNV = new QUANLYTHUEXEOTO.CustomControls.CustomCombobox();
            this.cbbCa = new QUANLYTHUEXEOTO.CustomControls.CustomCombobox();
            this.txtXemDanhSach = new QUANLYTHUEXEOTO.CustomControls.Textbox();
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
            this.dgvLichLamViec.Size = new System.Drawing.Size(383, 290);
            this.dgvLichLamViec.TabIndex = 71;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // HOTENNV
            // 
            this.HOTENNV.HeaderText = "Họ Tên Nhân Viên";
            this.HOTENNV.Name = "HOTENNV";
            // 
            // CALAMVIEC
            // 
            this.CALAMVIEC.HeaderText = "Ca Làm Việc";
            this.CALAMVIEC.Name = "CALAMVIEC";
            // 
            // NGAYLAM
            // 
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
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(525, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 36);
            this.button3.TabIndex = 62;
            this.button3.Text = "Sửa";
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
            this.button2.Text = "Xóa";
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
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
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
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(63, 111);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 36);
            this.button5.TabIndex = 80;
            this.button5.Text = "Xem Lại";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // customDatePicker1
            // 
            this.customDatePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customDatePicker1.BorderSize = 0;
            this.customDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.customDatePicker1.Location = new System.Drawing.Point(7, 314);
            this.customDatePicker1.MinimumSize = new System.Drawing.Size(4, 25);
            this.customDatePicker1.Name = "customDatePicker1";
            this.customDatePicker1.Size = new System.Drawing.Size(225, 25);
            this.customDatePicker1.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.customDatePicker1.TabIndex = 82;
            this.customDatePicker1.TextColor = System.Drawing.Color.White;
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
            this.txtXemDanhSach.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtXemDanhSach.BorderRadius = 15;
            this.txtXemDanhSach.BorderSize = 2;
            this.txtXemDanhSach.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXemDanhSach.ForeColor = System.Drawing.Color.HotPink;
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
            // frmCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 416);
            this.Controls.Add(this.txtXemDanhSach);
            this.Controls.Add(this.cbbCa);
            this.Controls.Add(this.cbbTenNV);
            this.Controls.Add(this.customDatePicker1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lblNgayLamViec);
            this.Controls.Add(this.lblCaLamViec);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.dgvLichLamViec);
            this.Controls.Add(this.lblXemLai);
            this.Controls.Add(this.lblChuDe);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblCaLamViec;
        private System.Windows.Forms.Label lblNgayLamViec;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CALAMVIEC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private CustomControls.CustomDatePicker customDatePicker1;
        private CustomControls.CustomCombobox cbbTenNV;
        private CustomControls.CustomCombobox cbbCa;
        private CustomControls.Textbox txtXemDanhSach;
    }
}