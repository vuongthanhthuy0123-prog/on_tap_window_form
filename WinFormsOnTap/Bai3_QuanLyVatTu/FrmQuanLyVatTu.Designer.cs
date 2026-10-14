namespace Bai3_QuanLyVatTu
{
    partial class FrmQuanLyVatTu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grpNhapLieu = new System.Windows.Forms.GroupBox();
            this.btnXoaToanBo = new System.Windows.Forms.Button();
            this.btnXoaDong = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.cboDonViTinh = new System.Windows.Forms.ComboBox();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.lblTenVT = new System.Windows.Forms.Label();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.lblMaVT = new System.Windows.Forms.Label();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.lvVatTu = new System.Windows.Forms.ListView();
            this.colMaVT = new System.Windows.Forms.ColumnHeader();
            this.colTenVT = new System.Windows.Forms.ColumnHeader();
            this.colDonViTinh = new System.Windows.Forms.ColumnHeader();
            this.colDonGia = new System.Windows.Forms.ColumnHeader();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.grpNhapLieu.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(15, 10);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(870, 38);
            this.lblTieuDe.TabIndex = 10;
            this.lblTieuDe.Text = "QUẢN LÝ DANH MỤC VẬT TƯ / LINH KIỆN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpNhapLieu
            // 
            this.grpNhapLieu.Controls.Add(this.btnXoaToanBo);
            this.grpNhapLieu.Controls.Add(this.btnXoaDong);
            this.grpNhapLieu.Controls.Add(this.btnCapNhat);
            this.grpNhapLieu.Controls.Add(this.btnThemMoi);
            this.grpNhapLieu.Controls.Add(this.txtDonGia);
            this.grpNhapLieu.Controls.Add(this.lblDonGia);
            this.grpNhapLieu.Controls.Add(this.cboDonViTinh);
            this.grpNhapLieu.Controls.Add(this.lblDonViTinh);
            this.grpNhapLieu.Controls.Add(this.txtTenVT);
            this.grpNhapLieu.Controls.Add(this.lblTenVT);
            this.grpNhapLieu.Controls.Add(this.txtMaVT);
            this.grpNhapLieu.Controls.Add(this.lblMaVT);
            this.grpNhapLieu.Location = new System.Drawing.Point(15, 55);
            this.grpNhapLieu.Name = "grpNhapLieu";
            this.grpNhapLieu.Size = new System.Drawing.Size(330, 360);
            this.grpNhapLieu.TabIndex = 0;
            this.grpNhapLieu.TabStop = false;
            this.grpNhapLieu.Text = "Thông tin vật tư";
            // 
            // lblMaVT
            // 
            this.lblMaVT.AutoSize = true;
            this.lblMaVT.Location = new System.Drawing.Point(15, 38);
            this.lblMaVT.Name = "lblMaVT";
            this.lblMaVT.Size = new System.Drawing.Size(83, 23);
            this.lblMaVT.TabIndex = 10;
            this.lblMaVT.Text = "Mã vật tư:";
            // 
            // txtMaVT
            // 
            this.txtMaVT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaVT.Location = new System.Drawing.Point(125, 35);
            this.txtMaVT.MaxLength = 20;
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(190, 30);
            this.txtMaVT.TabIndex = 0;
            // 
            // lblTenVT
            // 
            this.lblTenVT.AutoSize = true;
            this.lblTenVT.Location = new System.Drawing.Point(15, 78);
            this.lblTenVT.Name = "lblTenVT";
            this.lblTenVT.Size = new System.Drawing.Size(86, 23);
            this.lblTenVT.TabIndex = 11;
            this.lblTenVT.Text = "Tên vật tư:";
            // 
            // txtTenVT
            // 
            this.txtTenVT.Location = new System.Drawing.Point(125, 75);
            this.txtTenVT.MaxLength = 100;
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Size = new System.Drawing.Size(190, 30);
            this.txtTenVT.TabIndex = 1;
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Location = new System.Drawing.Point(15, 118);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(91, 23);
            this.lblDonViTinh.TabIndex = 12;
            this.lblDonViTinh.Text = "Đơn vị tính:";
            // 
            // cboDonViTinh
            // 
            this.cboDonViTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDonViTinh.FormattingEnabled = true;
            this.cboDonViTinh.Items.AddRange(new object[] {
            "Cái",
            "Bộ",
            "Kg",
            "Mét"});
            this.cboDonViTinh.Location = new System.Drawing.Point(125, 115);
            this.cboDonViTinh.Name = "cboDonViTinh";
            this.cboDonViTinh.Size = new System.Drawing.Size(190, 31);
            this.cboDonViTinh.TabIndex = 2;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(15, 158);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(104, 23);
            this.lblDonGia.TabIndex = 13;
            this.lblDonGia.Text = "Đơn giá nhập:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(125, 155);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(190, 30);
            this.txtDonGia.TabIndex = 3;
            this.txtDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(15, 215);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(145, 40);
            this.btnThemMoi.TabIndex = 4;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(170, 215);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(145, 40);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoaDong
            // 
            this.btnXoaDong.Location = new System.Drawing.Point(15, 265);
            this.btnXoaDong.Name = "btnXoaDong";
            this.btnXoaDong.Size = new System.Drawing.Size(145, 40);
            this.btnXoaDong.TabIndex = 6;
            this.btnXoaDong.Text = "Xóa dòng";
            this.btnXoaDong.UseVisualStyleBackColor = true;
            this.btnXoaDong.Click += new System.EventHandler(this.btnXoaDong_Click);
            // 
            // btnXoaToanBo
            // 
            this.btnXoaToanBo.ForeColor = System.Drawing.Color.Firebrick;
            this.btnXoaToanBo.Location = new System.Drawing.Point(170, 265);
            this.btnXoaToanBo.Name = "btnXoaToanBo";
            this.btnXoaToanBo.Size = new System.Drawing.Size(145, 40);
            this.btnXoaToanBo.TabIndex = 7;
            this.btnXoaToanBo.Text = "Xóa toàn bộ";
            this.btnXoaToanBo.UseVisualStyleBackColor = true;
            this.btnXoaToanBo.Click += new System.EventHandler(this.btnXoaToanBo_Click);
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.lvVatTu);
            this.grpDanhSach.Location = new System.Drawing.Point(360, 55);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Padding = new System.Windows.Forms.Padding(8);
            this.grpDanhSach.Size = new System.Drawing.Size(525, 360);
            this.grpDanhSach.TabIndex = 1;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách vật tư";
            // 
            // lvVatTu
            // 
            this.lvVatTu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaVT,
            this.colTenVT,
            this.colDonViTinh,
            this.colDonGia});
            this.lvVatTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvVatTu.FullRowSelect = true;
            this.lvVatTu.GridLines = true;
            this.lvVatTu.HideSelection = false;
            this.lvVatTu.Location = new System.Drawing.Point(8, 31);
            this.lvVatTu.MultiSelect = false;
            this.lvVatTu.Name = "lvVatTu";
            this.lvVatTu.Size = new System.Drawing.Size(509, 321);
            this.lvVatTu.TabIndex = 0;
            this.lvVatTu.UseCompatibleStateImageBehavior = false;
            this.lvVatTu.View = System.Windows.Forms.View.Details;
            this.lvVatTu.SelectedIndexChanged += new System.EventHandler(this.lvVatTu_SelectedIndexChanged);
            // 
            // colMaVT
            // 
            this.colMaVT.Text = "Mã VT";
            this.colMaVT.Width = 90;
            // 
            // colTenVT
            // 
            this.colTenVT.Text = "Tên VT";
            this.colTenVT.Width = 190;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.Text = "Đơn vị tính";
            this.colDonViTinh.Width = 95;
            // 
            // colDonGia
            // 
            this.colDonGia.Text = "Đơn giá";
            this.colDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colDonGia.Width = 120;
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblTongSo.Location = new System.Drawing.Point(360, 425);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(140, 23);
            this.lblTongSo.TabIndex = 11;
            this.lblTongSo.Text = "Tổng số vật tư: 0";
            // 
            // FrmQuanLyVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(900, 460);
            this.Controls.Add(this.lblTongSo);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpNhapLieu);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmQuanLyVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 3 - Quản lý danh mục Vật tư / Linh kiện";
            this.grpNhapLieu.ResumeLayout(false);
            this.grpNhapLieu.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpNhapLieu;
        private System.Windows.Forms.Label lblMaVT;
        private System.Windows.Forms.TextBox txtMaVT;
        private System.Windows.Forms.Label lblTenVT;
        private System.Windows.Forms.TextBox txtTenVT;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.ComboBox cboDonViTinh;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoaDong;
        private System.Windows.Forms.Button btnXoaToanBo;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.ListView lvVatTu;
        private System.Windows.Forms.ColumnHeader colMaVT;
        private System.Windows.Forms.ColumnHeader colTenVT;
        private System.Windows.Forms.ColumnHeader colDonViTinh;
        private System.Windows.Forms.ColumnHeader colDonGia;
        private System.Windows.Forms.Label lblTongSo;
    }
}
