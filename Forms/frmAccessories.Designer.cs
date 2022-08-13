
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccessories));
            this.dgvPhuKien = new System.Windows.Forms.DataGridView();
            this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblChuDe = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblTenPhuKien = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPhuKien = new QUANLYTHUEXEOTO.CustomControls.Textbox();
            this.txtDonGia = new QUANLYTHUEXEOTO.CustomControls.Textbox();
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
            this.dgvPhuKien.Size = new System.Drawing.Size(383, 290);
            this.dgvPhuKien.TabIndex = 59;
            // 
            // Stt
            // 
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
            this.TenPhuKien.HeaderText = "Tên Phụ Kiện";
            this.TenPhuKien.Name = "TenPhuKien";
            this.TenPhuKien.ReadOnly = true;
            // 
            // DonGia
            // 
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
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(525, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 36);
            this.button3.TabIndex = 50;
            this.button3.Text = "Lưu";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(410, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 36);
            this.button2.TabIndex = 49;
            this.button2.Text = "Xóa";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(292, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 36);
            this.button1.TabIndex = 48;
            this.button1.Text = "Thêm";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtPhuKien
            // 
            this.txtPhuKien.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhuKien.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPhuKien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPhuKien.BorderRadius = 15;
            this.txtPhuKien.BorderSize = 2;
            this.txtPhuKien.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhuKien.ForeColor = System.Drawing.Color.HotPink;
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
            this.txtDonGia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDonGia.BorderRadius = 15;
            this.txtDonGia.BorderSize = 2;
            this.txtDonGia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.ForeColor = System.Drawing.Color.HotPink;
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
            // frmAccessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 416);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtPhuKien);
            this.Controls.Add(this.dgvPhuKien);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblChuDe);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblTenPhuKien);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private CustomControls.Textbox txtPhuKien;
        private CustomControls.Textbox txtDonGia;
    }
}