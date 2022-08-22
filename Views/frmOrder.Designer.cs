
namespace QUANLYTHUEXEOTO.Forms
{
    partial class frmOrder
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
            this.lblChuDe = new System.Windows.Forms.Label();
            this.dgvPhieuThue = new System.Windows.Forms.DataGridView();
            this.MaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.btnXoa = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.btnChiTiet = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.btnDatXe = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChuDe
            // 
            this.lblChuDe.AutoSize = true;
            this.lblChuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChuDe.Location = new System.Drawing.Point(235, 15);
            this.lblChuDe.Name = "lblChuDe";
            this.lblChuDe.Size = new System.Drawing.Size(126, 20);
            this.lblChuDe.TabIndex = 69;
            this.lblChuDe.Text = "Phiếu Thuê Xe";
            // 
            // dgvPhieuThue
            // 
            this.dgvPhieuThue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhieuThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuThue.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPhieuThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPT,
            this.TenKH,
            this.NgayLapPhieu,
            this.HoTen});
            this.dgvPhieuThue.Location = new System.Drawing.Point(12, 91);
            this.dgvPhieuThue.Name = "dgvPhieuThue";
            this.dgvPhieuThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuThue.Size = new System.Drawing.Size(620, 253);
            this.dgvPhieuThue.TabIndex = 88;
            // 
            // MaPT
            // 
            this.MaPT.HeaderText = "Số Phiếu Thuê";
            this.MaPT.Name = "MaPT";
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Tên Khách Hàng";
            this.TenKH.Name = "TenKH";
            // 
            // NgayLapPhieu
            // 
            this.NgayLapPhieu.HeaderText = "Ngày Lập Phiếu";
            this.NgayLapPhieu.Name = "NgayLapPhieu";
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Tên Nhân Viên";
            this.HoTen.Name = "HoTen";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimKiem.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTimKiem.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTimKiem.BorderRadius = 15;
            this.txtTimKiem.BorderSize = 2;
            this.txtTimKiem.Location = new System.Drawing.Point(12, 54);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.PlaceholderText = "Tìm Theo Tên Khách Hàng";
            this.txtTimKiem.Size = new System.Drawing.Size(225, 30);
            this.txtTimKiem.TabIndex = 89;
            this.txtTimKiem.Texts = "";
            this.txtTimKiem.UnderlinedStyle = false;
            this.txtTimKiem._TextChanged += new System.EventHandler(this.txtTimKiem__TextChanged);
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
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(532, 359);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 96;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.Black;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChiTiet.BackColor = System.Drawing.SystemColors.Control;
            this.btnChiTiet.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnChiTiet.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChiTiet.BorderRadius = 20;
            this.btnChiTiet.BorderSize = 2;
            this.btnChiTiet.FlatAppearance.BorderSize = 0;
            this.btnChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTiet.ForeColor = System.Drawing.Color.Black;
            this.btnChiTiet.Location = new System.Drawing.Point(426, 359);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(100, 40);
            this.btnChiTiet.TabIndex = 97;
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.TextColor = System.Drawing.Color.Black;
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnDatXe
            // 
            this.btnDatXe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatXe.BackColor = System.Drawing.SystemColors.Control;
            this.btnDatXe.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnDatXe.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDatXe.BorderRadius = 20;
            this.btnDatXe.BorderSize = 2;
            this.btnDatXe.FlatAppearance.BorderSize = 0;
            this.btnDatXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatXe.ForeColor = System.Drawing.Color.Black;
            this.btnDatXe.Location = new System.Drawing.Point(320, 359);
            this.btnDatXe.Name = "btnDatXe";
            this.btnDatXe.Size = new System.Drawing.Size(100, 40);
            this.btnDatXe.TabIndex = 98;
            this.btnDatXe.Text = "Đặt Xe";
            this.btnDatXe.TextColor = System.Drawing.Color.Black;
            this.btnDatXe.UseVisualStyleBackColor = false;
            this.btnDatXe.Click += new System.EventHandler(this.btnDatXe_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 416);
            this.Controls.Add(this.btnDatXe);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvPhieuThue);
            this.Controls.Add(this.lblChuDe);
            this.Name = "frmOrder";
            this.Text = "Phiếu Thuê";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblChuDe;
        private System.Windows.Forms.DataGridView dgvPhieuThue;
        private CustomControls.Textbox txtTimKiem;
        private CustomControls.CustomButton btnXoa;
        private CustomControls.CustomButton btnChiTiet;
        private CustomControls.CustomButton btnDatXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
    }
}