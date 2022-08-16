
namespace QUANLYTHUEXEOTO.Forms
{
    partial class frmAccessories
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
            this.dgvPhuKien = new System.Windows.Forms.DataGridView();
            this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblChuDe = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblTenPhuKien = new System.Windows.Forms.Label();
            this.txtPhuKien = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.txtDonGia = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.customButton5 = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.customButton4 = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.customButton3 = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            this.customButton2 = new QUANLYTHUEXEOTO.CustomControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuKien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhuKien
            // 
            this.dgvPhuKien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhuKien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhuKien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPhuKien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhuKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuKien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stt,
            this.id,
            this.TenPhuKien,
            this.DonGia});
            this.dgvPhuKien.Location = new System.Drawing.Point(239, 50);
            this.dgvPhuKien.Name = "dgvPhuKien";
            this.dgvPhuKien.ReadOnly = true;
            this.dgvPhuKien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhuKien.Size = new System.Drawing.Size(383, 290);
            this.dgvPhuKien.TabIndex = 59;
            this.dgvPhuKien.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuKien_CellMouseLeave);
            this.dgvPhuKien.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPhuKien_CellMouseMove);
            // 
            // Stt
            // 
            this.Stt.FillWeight = 62.40994F;
            this.Stt.HeaderText = "STT";
            this.Stt.Name = "Stt";
            this.Stt.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // TenPhuKien
            // 
            this.TenPhuKien.FillWeight = 161.4479F;
            this.TenPhuKien.HeaderText = "Tên Phụ Kiện";
            this.TenPhuKien.Name = "TenPhuKien";
            this.TenPhuKien.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.FillWeight = 76.14214F;
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblInfo.Location = new System.Drawing.Point(22, 50);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(142, 16);
            this.lblInfo.TabIndex = 58;
            this.lblInfo.Text = "Thông Tin Phụ Kiện";
            // 
            // lblChuDe
            // 
            this.lblChuDe.AutoSize = true;
            this.lblChuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChuDe.Location = new System.Drawing.Point(235, 15);
            this.lblChuDe.Name = "lblChuDe";
            this.lblChuDe.Size = new System.Drawing.Size(174, 20);
            this.lblChuDe.TabIndex = 57;
            this.lblChuDe.Text = "Danh Sách Phụ Kiện";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDonGia.Location = new System.Drawing.Point(22, 159);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(57, 13);
            this.lblDonGia.TabIndex = 53;
            this.lblDonGia.Text = "Đơn Giá:";
            // 
            // lblTenPhuKien
            // 
            this.lblTenPhuKien.AutoSize = true;
            this.lblTenPhuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenPhuKien.Location = new System.Drawing.Point(22, 90);
            this.lblTenPhuKien.Name = "lblTenPhuKien";
            this.lblTenPhuKien.Size = new System.Drawing.Size(88, 13);
            this.lblTenPhuKien.TabIndex = 51;
            this.lblTenPhuKien.Text = "Tên Phụ Kiện:";
            // 
            // txtPhuKien
            // 
            this.txtPhuKien.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhuKien.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPhuKien.BorderFocusColor = System.Drawing.Color.Black;
            this.txtPhuKien.BorderRadius = 15;
            this.txtPhuKien.BorderSize = 2;
            this.txtPhuKien.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhuKien.ForeColor = System.Drawing.Color.Black;
            this.txtPhuKien.Location = new System.Drawing.Point(7, 107);
            this.txtPhuKien.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhuKien.Multiline = true;
            this.txtPhuKien.Name = "txtPhuKien";
            this.txtPhuKien.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPhuKien.PasswordChar = false;
            this.txtPhuKien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhuKien.PlaceholderText = "";
            this.txtPhuKien.Size = new System.Drawing.Size(225, 30);
            this.txtPhuKien.TabIndex = 60;
            this.txtPhuKien.Texts = "";
            this.txtPhuKien.UnderlinedStyle = false;
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
            this.txtDonGia.Location = new System.Drawing.Point(7, 176);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDonGia.PasswordChar = false;
            this.txtDonGia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDonGia.PlaceholderText = "";
            this.txtDonGia.Size = new System.Drawing.Size(225, 30);
            this.txtDonGia.TabIndex = 61;
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
            this.customButton5.Location = new System.Drawing.Point(203, 364);
            this.customButton5.Name = "customButton5";
            this.customButton5.Size = new System.Drawing.Size(100, 40);
            this.customButton5.TabIndex = 102;
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
            this.customButton4.Location = new System.Drawing.Point(309, 364);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(100, 40);
            this.customButton4.TabIndex = 101;
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
            this.customButton3.Location = new System.Drawing.Point(415, 364);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(100, 40);
            this.customButton3.TabIndex = 100;
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
            this.customButton2.Location = new System.Drawing.Point(521, 364);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(100, 40);
            this.customButton2.TabIndex = 99;
            this.customButton2.Text = "Hủy";
            this.customButton2.TextColor = System.Drawing.Color.Black;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // frmAccessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 416);
            this.Controls.Add(this.customButton5);
            this.Controls.Add(this.customButton4);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtPhuKien);
            this.Controls.Add(this.dgvPhuKien);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblChuDe);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblTenPhuKien);
            this.Name = "frmAccessories";
            this.Text = "Quản Lý Phụ Kiện";
            this.Load += new System.EventHandler(this.frmAccessories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuKien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhuKien;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblChuDe;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblTenPhuKien;
        private CustomControls.Textbox txtPhuKien;
        private CustomControls.Textbox txtDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private CustomControls.CustomButton customButton5;
        private CustomControls.CustomButton customButton4;
        private CustomControls.CustomButton customButton3;
        private CustomControls.CustomButton customButton2;
    }
}