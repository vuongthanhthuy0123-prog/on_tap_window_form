namespace Bai2_PhieuSuCoIT
{
    partial class FrmPhieuSuCo
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
            this.grpThongTinPhieu = new System.Windows.Forms.GroupBox();
            this.pnlMucDo = new System.Windows.Forms.Panel();
            this.rdoKhanCap = new System.Windows.Forms.RadioButton();
            this.rdoTrungBinh = new System.Windows.Forms.RadioButton();
            this.rdoThap = new System.Windows.Forms.RadioButton();
            this.lblMucDo = new System.Windows.Forms.Label();
            this.dtpNgayGhiNhan = new System.Windows.Forms.DateTimePicker();
            this.lblNgayGhiNhan = new System.Windows.Forms.Label();
            this.txtNguoiYeuCau = new System.Windows.Forms.TextBox();
            this.lblNguoiYeuCau = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.grpPhanLoai = new System.Windows.Forms.GroupBox();
            this.picAnhLoi = new System.Windows.Forms.PictureBox();
            this.btnTaiAnh = new System.Windows.Forms.Button();
            this.lblAnhLoi = new System.Windows.Forms.Label();
            this.chkDienThoai = new System.Windows.Forms.CheckBox();
            this.chkMayIn = new System.Windows.Forms.CheckBox();
            this.chkLaptop = new System.Windows.Forms.CheckBox();
            this.chkMayTinhBan = new System.Windows.Forms.CheckBox();
            this.lblThietBi = new System.Windows.Forms.Label();
            this.cboLoaiSuCo = new System.Windows.Forms.ComboBox();
            this.lblLoaiSuCo = new System.Windows.Forms.Label();
            this.btnGuiYeuCau = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.ofdAnhLoi = new System.Windows.Forms.OpenFileDialog();
            this.grpThongTinPhieu.SuspendLayout();
            this.pnlMucDo.SuspendLayout();
            this.grpPhanLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(15, 10);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(750, 38);
            this.lblTieuDe.TabIndex = 10;
            this.lblTieuDe.Text = "PHIẾU TIẾP NHẬN && PHÂN LOẠI SỰ CỐ IT";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpThongTinPhieu
            // 
            this.grpThongTinPhieu.Controls.Add(this.pnlMucDo);
            this.grpThongTinPhieu.Controls.Add(this.lblMucDo);
            this.grpThongTinPhieu.Controls.Add(this.dtpNgayGhiNhan);
            this.grpThongTinPhieu.Controls.Add(this.lblNgayGhiNhan);
            this.grpThongTinPhieu.Controls.Add(this.txtNguoiYeuCau);
            this.grpThongTinPhieu.Controls.Add(this.lblNguoiYeuCau);
            this.grpThongTinPhieu.Controls.Add(this.txtMaPhieu);
            this.grpThongTinPhieu.Controls.Add(this.lblMaPhieu);
            this.grpThongTinPhieu.Location = new System.Drawing.Point(15, 55);
            this.grpThongTinPhieu.Name = "grpThongTinPhieu";
            this.grpThongTinPhieu.Size = new System.Drawing.Size(365, 300);
            this.grpThongTinPhieu.TabIndex = 0;
            this.grpThongTinPhieu.TabStop = false;
            this.grpThongTinPhieu.Text = "Thông tin phiếu";
            // 
            // lblMaPhieu
            // 
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Location = new System.Drawing.Point(15, 38);
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.Size = new System.Drawing.Size(75, 23);
            this.lblMaPhieu.TabIndex = 10;
            this.lblMaPhieu.Text = "Mã phiếu:";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(140, 35);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(205, 30);
            this.txtMaPhieu.TabIndex = 0;
            // 
            // lblNguoiYeuCau
            // 
            this.lblNguoiYeuCau.AutoSize = true;
            this.lblNguoiYeuCau.Location = new System.Drawing.Point(15, 78);
            this.lblNguoiYeuCau.Name = "lblNguoiYeuCau";
            this.lblNguoiYeuCau.Size = new System.Drawing.Size(113, 23);
            this.lblNguoiYeuCau.TabIndex = 11;
            this.lblNguoiYeuCau.Text = "Người yêu cầu:";
            // 
            // txtNguoiYeuCau
            // 
            this.txtNguoiYeuCau.Location = new System.Drawing.Point(140, 75);
            this.txtNguoiYeuCau.Name = "txtNguoiYeuCau";
            this.txtNguoiYeuCau.Size = new System.Drawing.Size(205, 30);
            this.txtNguoiYeuCau.TabIndex = 1;
            // 
            // lblNgayGhiNhan
            // 
            this.lblNgayGhiNhan.AutoSize = true;
            this.lblNgayGhiNhan.Location = new System.Drawing.Point(15, 118);
            this.lblNgayGhiNhan.Name = "lblNgayGhiNhan";
            this.lblNgayGhiNhan.Size = new System.Drawing.Size(115, 23);
            this.lblNgayGhiNhan.TabIndex = 12;
            this.lblNgayGhiNhan.Text = "Ngày ghi nhận:";
            // 
            // dtpNgayGhiNhan
            // 
            this.dtpNgayGhiNhan.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpNgayGhiNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayGhiNhan.Location = new System.Drawing.Point(140, 115);
            this.dtpNgayGhiNhan.Name = "dtpNgayGhiNhan";
            this.dtpNgayGhiNhan.Size = new System.Drawing.Size(205, 30);
            this.dtpNgayGhiNhan.TabIndex = 2;
            // 
            // lblMucDo
            // 
            this.lblMucDo.AutoSize = true;
            this.lblMucDo.Location = new System.Drawing.Point(15, 160);
            this.lblMucDo.Name = "lblMucDo";
            this.lblMucDo.Size = new System.Drawing.Size(122, 23);
            this.lblMucDo.TabIndex = 13;
            this.lblMucDo.Text = "Mức độ ưu tiên:";
            // 
            // pnlMucDo
            // 
            this.pnlMucDo.Controls.Add(this.rdoKhanCap);
            this.pnlMucDo.Controls.Add(this.rdoTrungBinh);
            this.pnlMucDo.Controls.Add(this.rdoThap);
            this.pnlMucDo.Location = new System.Drawing.Point(140, 155);
            this.pnlMucDo.Name = "pnlMucDo";
            this.pnlMucDo.Size = new System.Drawing.Size(205, 105);
            this.pnlMucDo.TabIndex = 3;
            // 
            // rdoThap
            // 
            this.rdoThap.AutoSize = true;
            this.rdoThap.Location = new System.Drawing.Point(3, 3);
            this.rdoThap.Name = "rdoThap";
            this.rdoThap.Size = new System.Drawing.Size(65, 27);
            this.rdoThap.TabIndex = 0;
            this.rdoThap.Text = "Thấp";
            this.rdoThap.UseVisualStyleBackColor = true;
            // 
            // rdoTrungBinh
            // 
            this.rdoTrungBinh.AutoSize = true;
            this.rdoTrungBinh.Checked = true;
            this.rdoTrungBinh.Location = new System.Drawing.Point(3, 36);
            this.rdoTrungBinh.Name = "rdoTrungBinh";
            this.rdoTrungBinh.Size = new System.Drawing.Size(108, 27);
            this.rdoTrungBinh.TabIndex = 1;
            this.rdoTrungBinh.TabStop = true;
            this.rdoTrungBinh.Text = "Trung bình";
            this.rdoTrungBinh.UseVisualStyleBackColor = true;
            // 
            // rdoKhanCap
            // 
            this.rdoKhanCap.AutoSize = true;
            this.rdoKhanCap.ForeColor = System.Drawing.Color.Firebrick;
            this.rdoKhanCap.Location = new System.Drawing.Point(3, 69);
            this.rdoKhanCap.Name = "rdoKhanCap";
            this.rdoKhanCap.Size = new System.Drawing.Size(98, 27);
            this.rdoKhanCap.TabIndex = 2;
            this.rdoKhanCap.Text = "Khẩn cấp";
            this.rdoKhanCap.UseVisualStyleBackColor = true;
            // 
            // grpPhanLoai
            // 
            this.grpPhanLoai.Controls.Add(this.picAnhLoi);
            this.grpPhanLoai.Controls.Add(this.btnTaiAnh);
            this.grpPhanLoai.Controls.Add(this.lblAnhLoi);
            this.grpPhanLoai.Controls.Add(this.chkDienThoai);
            this.grpPhanLoai.Controls.Add(this.chkMayIn);
            this.grpPhanLoai.Controls.Add(this.chkLaptop);
            this.grpPhanLoai.Controls.Add(this.chkMayTinhBan);
            this.grpPhanLoai.Controls.Add(this.lblThietBi);
            this.grpPhanLoai.Controls.Add(this.cboLoaiSuCo);
            this.grpPhanLoai.Controls.Add(this.lblLoaiSuCo);
            this.grpPhanLoai.Location = new System.Drawing.Point(395, 55);
            this.grpPhanLoai.Name = "grpPhanLoai";
            this.grpPhanLoai.Size = new System.Drawing.Size(370, 300);
            this.grpPhanLoai.TabIndex = 1;
            this.grpPhanLoai.TabStop = false;
            this.grpPhanLoai.Text = "Phân loại && Chi tiết";
            // 
            // lblLoaiSuCo
            // 
            this.lblLoaiSuCo.AutoSize = true;
            this.lblLoaiSuCo.Location = new System.Drawing.Point(15, 38);
            this.lblLoaiSuCo.Name = "lblLoaiSuCo";
            this.lblLoaiSuCo.Size = new System.Drawing.Size(83, 23);
            this.lblLoaiSuCo.TabIndex = 10;
            this.lblLoaiSuCo.Text = "Loại sự cố:";
            // 
            // cboLoaiSuCo
            // 
            this.cboLoaiSuCo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSuCo.FormattingEnabled = true;
            this.cboLoaiSuCo.Items.AddRange(new object[] {
            "Phần cứng",
            "Phần mềm",
            "Mạng",
            "Tài khoản"});
            this.cboLoaiSuCo.Location = new System.Drawing.Point(140, 35);
            this.cboLoaiSuCo.Name = "cboLoaiSuCo";
            this.cboLoaiSuCo.Size = new System.Drawing.Size(215, 31);
            this.cboLoaiSuCo.TabIndex = 0;
            // 
            // lblThietBi
            // 
            this.lblThietBi.Location = new System.Drawing.Point(15, 80);
            this.lblThietBi.Name = "lblThietBi";
            this.lblThietBi.Size = new System.Drawing.Size(115, 50);
            this.lblThietBi.TabIndex = 11;
            this.lblThietBi.Text = "Thiết bị ảnh hưởng:";
            // 
            // chkMayTinhBan
            // 
            this.chkMayTinhBan.AutoSize = true;
            this.chkMayTinhBan.Location = new System.Drawing.Point(140, 78);
            this.chkMayTinhBan.Name = "chkMayTinhBan";
            this.chkMayTinhBan.Size = new System.Drawing.Size(129, 27);
            this.chkMayTinhBan.TabIndex = 1;
            this.chkMayTinhBan.Text = "Máy tính bàn";
            this.chkMayTinhBan.UseVisualStyleBackColor = true;
            // 
            // chkLaptop
            // 
            this.chkLaptop.AutoSize = true;
            this.chkLaptop.Location = new System.Drawing.Point(265, 78);
            this.chkLaptop.Name = "chkLaptop";
            this.chkLaptop.Size = new System.Drawing.Size(80, 27);
            this.chkLaptop.TabIndex = 2;
            this.chkLaptop.Text = "Laptop";
            this.chkLaptop.UseVisualStyleBackColor = true;
            // 
            // chkMayIn
            // 
            this.chkMayIn.AutoSize = true;
            this.chkMayIn.Location = new System.Drawing.Point(140, 108);
            this.chkMayIn.Name = "chkMayIn";
            this.chkMayIn.Size = new System.Drawing.Size(80, 27);
            this.chkMayIn.TabIndex = 3;
            this.chkMayIn.Text = "Máy in";
            this.chkMayIn.UseVisualStyleBackColor = true;
            // 
            // chkDienThoai
            // 
            this.chkDienThoai.AutoSize = true;
            this.chkDienThoai.Location = new System.Drawing.Point(265, 108);
            this.chkDienThoai.Name = "chkDienThoai";
            this.chkDienThoai.Size = new System.Drawing.Size(85, 27);
            this.chkDienThoai.TabIndex = 4;
            this.chkDienThoai.Text = "Điện thoại";
            this.chkDienThoai.UseVisualStyleBackColor = true;
            // 
            // lblAnhLoi
            // 
            this.lblAnhLoi.AutoSize = true;
            this.lblAnhLoi.Location = new System.Drawing.Point(15, 150);
            this.lblAnhLoi.Name = "lblAnhLoi";
            this.lblAnhLoi.Size = new System.Drawing.Size(103, 23);
            this.lblAnhLoi.TabIndex = 12;
            this.lblAnhLoi.Text = "Ảnh chụp lỗi:";
            // 
            // btnTaiAnh
            // 
            this.btnTaiAnh.Location = new System.Drawing.Point(15, 180);
            this.btnTaiAnh.Name = "btnTaiAnh";
            this.btnTaiAnh.Size = new System.Drawing.Size(115, 36);
            this.btnTaiAnh.TabIndex = 5;
            this.btnTaiAnh.Text = "Tải ảnh lỗi";
            this.btnTaiAnh.UseVisualStyleBackColor = true;
            this.btnTaiAnh.Click += new System.EventHandler(this.btnTaiAnh_Click);
            // 
            // picAnhLoi
            // 
            this.picAnhLoi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picAnhLoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhLoi.Location = new System.Drawing.Point(140, 145);
            this.picAnhLoi.Name = "picAnhLoi";
            this.picAnhLoi.Size = new System.Drawing.Size(215, 140);
            this.picAnhLoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhLoi.TabIndex = 13;
            this.picAnhLoi.TabStop = false;
            // 
            // btnGuiYeuCau
            // 
            this.btnGuiYeuCau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuiYeuCau.Location = new System.Drawing.Point(485, 370);
            this.btnGuiYeuCau.Name = "btnGuiYeuCau";
            this.btnGuiYeuCau.Size = new System.Drawing.Size(135, 40);
            this.btnGuiYeuCau.TabIndex = 2;
            this.btnGuiYeuCau.Text = "Gửi yêu cầu";
            this.btnGuiYeuCau.UseVisualStyleBackColor = true;
            this.btnGuiYeuCau.Click += new System.EventHandler(this.btnGuiYeuCau_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(630, 370);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(135, 40);
            this.btnNhapLai.TabIndex = 3;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // ofdAnhLoi
            // 
            this.ofdAnhLoi.Filter = "Ảnh lỗi (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            this.ofdAnhLoi.Title = "Chọn ảnh chụp lỗi";
            // 
            // FrmPhieuSuCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(780, 425);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnGuiYeuCau);
            this.Controls.Add(this.grpPhanLoai);
            this.Controls.Add(this.grpThongTinPhieu);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPhieuSuCo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 2 - Form tiếp nhận & phân loại sự cố IT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPhieuSuCo_FormClosed);
            this.grpThongTinPhieu.ResumeLayout(false);
            this.grpThongTinPhieu.PerformLayout();
            this.pnlMucDo.ResumeLayout(false);
            this.pnlMucDo.PerformLayout();
            this.grpPhanLoai.ResumeLayout(false);
            this.grpPhanLoai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhLoi)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpThongTinPhieu;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label lblNguoiYeuCau;
        private System.Windows.Forms.TextBox txtNguoiYeuCau;
        private System.Windows.Forms.Label lblNgayGhiNhan;
        private System.Windows.Forms.DateTimePicker dtpNgayGhiNhan;
        private System.Windows.Forms.Label lblMucDo;
        private System.Windows.Forms.Panel pnlMucDo;
        private System.Windows.Forms.RadioButton rdoThap;
        private System.Windows.Forms.RadioButton rdoTrungBinh;
        private System.Windows.Forms.RadioButton rdoKhanCap;
        private System.Windows.Forms.GroupBox grpPhanLoai;
        private System.Windows.Forms.Label lblLoaiSuCo;
        private System.Windows.Forms.ComboBox cboLoaiSuCo;
        private System.Windows.Forms.Label lblThietBi;
        private System.Windows.Forms.CheckBox chkMayTinhBan;
        private System.Windows.Forms.CheckBox chkLaptop;
        private System.Windows.Forms.CheckBox chkMayIn;
        private System.Windows.Forms.CheckBox chkDienThoai;
        private System.Windows.Forms.Label lblAnhLoi;
        private System.Windows.Forms.Button btnTaiAnh;
        private System.Windows.Forms.PictureBox picAnhLoi;
        private System.Windows.Forms.Button btnGuiYeuCau;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.OpenFileDialog ofdAnhLoi;
    }
}
