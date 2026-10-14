namespace Bai4_DatChoNgoi
{
    partial class FrmDatChoNgoi
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
            this.grpSoDo = new System.Windows.Forms.GroupBox();
            this.tlpSoDo = new System.Windows.Forms.TableLayoutPanel();
            this.grpThongKe = new System.Windows.Forms.GroupBox();
            this.btnHuyChon = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.lblDanhSachChon = new System.Windows.Forms.Label();
            this.lblTamTinh = new System.Windows.Forms.Label();
            this.lblSoViTri = new System.Windows.Forms.Label();
            this.cboKhungGio = new System.Windows.Forms.ComboBox();
            this.lblKhungGio = new System.Windows.Forms.Label();
            this.pnlMauTrong = new System.Windows.Forms.Panel();
            this.lblChuTrong = new System.Windows.Forms.Label();
            this.pnlMauDangChon = new System.Windows.Forms.Panel();
            this.lblChuDangChon = new System.Windows.Forms.Label();
            this.pnlMauDaDat = new System.Windows.Forms.Panel();
            this.lblChuDaDat = new System.Windows.Forms.Label();
            this.grpSoDo.SuspendLayout();
            this.grpThongKe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(15, 10);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(830, 38);
            this.lblTieuDe.TabIndex = 10;
            this.lblTieuDe.Text = "SƠ ĐỒ CHỌN VỊ TRÍ / ĐẶT BÀN THEO KHUNG GIỜ";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSoDo
            // 
            this.grpSoDo.Controls.Add(this.tlpSoDo);
            this.grpSoDo.Location = new System.Drawing.Point(15, 55);
            this.grpSoDo.Name = "grpSoDo";
            this.grpSoDo.Padding = new System.Windows.Forms.Padding(8);
            this.grpSoDo.Size = new System.Drawing.Size(560, 400);
            this.grpSoDo.TabIndex = 0;
            this.grpSoDo.TabStop = false;
            this.grpSoDo.Text = "Sơ đồ vị trí (4 hàng × 5 cột)";
            // 
            // tlpSoDo
            // 
            this.tlpSoDo.ColumnCount = 5;
            this.tlpSoDo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSoDo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSoDo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSoDo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSoDo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSoDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSoDo.Location = new System.Drawing.Point(8, 31);
            this.tlpSoDo.Name = "tlpSoDo";
            this.tlpSoDo.RowCount = 4;
            this.tlpSoDo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSoDo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSoDo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSoDo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSoDo.Size = new System.Drawing.Size(544, 361);
            this.tlpSoDo.TabIndex = 0;
            // 
            // grpThongKe
            // 
            this.grpThongKe.Controls.Add(this.btnHuyChon);
            this.grpThongKe.Controls.Add(this.btnXacNhan);
            this.grpThongKe.Controls.Add(this.lblDanhSachChon);
            this.grpThongKe.Controls.Add(this.lblTamTinh);
            this.grpThongKe.Controls.Add(this.lblSoViTri);
            this.grpThongKe.Controls.Add(this.cboKhungGio);
            this.grpThongKe.Controls.Add(this.lblKhungGio);
            this.grpThongKe.Location = new System.Drawing.Point(590, 55);
            this.grpThongKe.Name = "grpThongKe";
            this.grpThongKe.Size = new System.Drawing.Size(255, 400);
            this.grpThongKe.TabIndex = 1;
            this.grpThongKe.TabStop = false;
            this.grpThongKe.Text = "Thống kê";
            // 
            // lblKhungGio
            // 
            this.lblKhungGio.AutoSize = true;
            this.lblKhungGio.Location = new System.Drawing.Point(15, 32);
            this.lblKhungGio.Name = "lblKhungGio";
            this.lblKhungGio.Size = new System.Drawing.Size(83, 23);
            this.lblKhungGio.TabIndex = 10;
            this.lblKhungGio.Text = "Khung giờ:";
            // 
            // cboKhungGio
            // 
            this.cboKhungGio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhungGio.FormattingEnabled = true;
            this.cboKhungGio.Items.AddRange(new object[] {
            "Sáng: 100.000đ",
            "Tối: 150.000đ"});
            this.cboKhungGio.Location = new System.Drawing.Point(15, 58);
            this.cboKhungGio.Name = "cboKhungGio";
            this.cboKhungGio.Size = new System.Drawing.Size(225, 31);
            this.cboKhungGio.TabIndex = 0;
            this.cboKhungGio.SelectedIndexChanged += new System.EventHandler(this.cboKhungGio_SelectedIndexChanged);
            // 
            // lblSoViTri
            // 
            this.lblSoViTri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSoViTri.Location = new System.Drawing.Point(15, 105);
            this.lblSoViTri.Name = "lblSoViTri";
            this.lblSoViTri.Size = new System.Drawing.Size(225, 28);
            this.lblSoViTri.TabIndex = 11;
            this.lblSoViTri.Text = "Số vị trí đang chọn: 0";
            // 
            // lblTamTinh
            // 
            this.lblTamTinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTamTinh.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTamTinh.Location = new System.Drawing.Point(15, 138);
            this.lblTamTinh.Name = "lblTamTinh";
            this.lblTamTinh.Size = new System.Drawing.Size(225, 28);
            this.lblTamTinh.TabIndex = 12;
            this.lblTamTinh.Text = "Tạm tính tiền: 0 đ";
            // 
            // lblDanhSachChon
            // 
            this.lblDanhSachChon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblDanhSachChon.ForeColor = System.Drawing.Color.DimGray;
            this.lblDanhSachChon.Location = new System.Drawing.Point(15, 172);
            this.lblDanhSachChon.Name = "lblDanhSachChon";
            this.lblDanhSachChon.Size = new System.Drawing.Size(225, 85);
            this.lblDanhSachChon.TabIndex = 13;
            this.lblDanhSachChon.Text = "Vị trí: (chưa chọn)";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.Location = new System.Drawing.Point(15, 280);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(225, 44);
            this.btnXacNhan.TabIndex = 1;
            this.btnXacNhan.Text = "Xác nhận đặt";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuyChon
            // 
            this.btnHuyChon.Location = new System.Drawing.Point(15, 335);
            this.btnHuyChon.Name = "btnHuyChon";
            this.btnHuyChon.Size = new System.Drawing.Size(225, 44);
            this.btnHuyChon.TabIndex = 2;
            this.btnHuyChon.Text = "Hủy chọn tất cả";
            this.btnHuyChon.UseVisualStyleBackColor = true;
            this.btnHuyChon.Click += new System.EventHandler(this.btnHuyChon_Click);
            // 
            // pnlMauTrong
            // 
            this.pnlMauTrong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMauTrong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMauTrong.Location = new System.Drawing.Point(20, 468);
            this.pnlMauTrong.Name = "pnlMauTrong";
            this.pnlMauTrong.Size = new System.Drawing.Size(22, 22);
            this.pnlMauTrong.TabIndex = 20;
            // 
            // lblChuTrong
            // 
            this.lblChuTrong.AutoSize = true;
            this.lblChuTrong.Location = new System.Drawing.Point(48, 467);
            this.lblChuTrong.Name = "lblChuTrong";
            this.lblChuTrong.Size = new System.Drawing.Size(50, 23);
            this.lblChuTrong.TabIndex = 21;
            this.lblChuTrong.Text = "Trống";
            // 
            // pnlMauDangChon
            // 
            this.pnlMauDangChon.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlMauDangChon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMauDangChon.Location = new System.Drawing.Point(140, 468);
            this.pnlMauDangChon.Name = "pnlMauDangChon";
            this.pnlMauDangChon.Size = new System.Drawing.Size(22, 22);
            this.pnlMauDangChon.TabIndex = 22;
            // 
            // lblChuDangChon
            // 
            this.lblChuDangChon.AutoSize = true;
            this.lblChuDangChon.Location = new System.Drawing.Point(168, 467);
            this.lblChuDangChon.Name = "lblChuDangChon";
            this.lblChuDangChon.Size = new System.Drawing.Size(86, 23);
            this.lblChuDangChon.TabIndex = 23;
            this.lblChuDangChon.Text = "Đang chọn";
            // 
            // pnlMauDaDat
            // 
            this.pnlMauDaDat.BackColor = System.Drawing.Color.Red;
            this.pnlMauDaDat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMauDaDat.Location = new System.Drawing.Point(290, 468);
            this.pnlMauDaDat.Name = "pnlMauDaDat";
            this.pnlMauDaDat.Size = new System.Drawing.Size(22, 22);
            this.pnlMauDaDat.TabIndex = 24;
            // 
            // lblChuDaDat
            // 
            this.lblChuDaDat.AutoSize = true;
            this.lblChuDaDat.Location = new System.Drawing.Point(318, 467);
            this.lblChuDaDat.Name = "lblChuDaDat";
            this.lblChuDaDat.Size = new System.Drawing.Size(210, 23);
            this.lblChuDaDat.TabIndex = 25;
            this.lblChuDaDat.Text = "Đã có người đặt / Đã khóa";
            // 
            // FrmDatChoNgoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(860, 505);
            this.Controls.Add(this.lblChuDaDat);
            this.Controls.Add(this.pnlMauDaDat);
            this.Controls.Add(this.lblChuDangChon);
            this.Controls.Add(this.pnlMauDangChon);
            this.Controls.Add(this.lblChuTrong);
            this.Controls.Add(this.pnlMauTrong);
            this.Controls.Add(this.grpThongKe);
            this.Controls.Add(this.grpSoDo);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDatChoNgoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 4 - Sơ đồ chọn vị trí / Đặt bàn hẹn giờ";
            this.Load += new System.EventHandler(this.FrmDatChoNgoi_Load);
            this.grpSoDo.ResumeLayout(false);
            this.grpThongKe.ResumeLayout(false);
            this.grpThongKe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpSoDo;
        private System.Windows.Forms.TableLayoutPanel tlpSoDo;
        private System.Windows.Forms.GroupBox grpThongKe;
        private System.Windows.Forms.Label lblKhungGio;
        private System.Windows.Forms.ComboBox cboKhungGio;
        private System.Windows.Forms.Label lblSoViTri;
        private System.Windows.Forms.Label lblTamTinh;
        private System.Windows.Forms.Label lblDanhSachChon;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuyChon;
        private System.Windows.Forms.Panel pnlMauTrong;
        private System.Windows.Forms.Label lblChuTrong;
        private System.Windows.Forms.Panel pnlMauDangChon;
        private System.Windows.Forms.Label lblChuDangChon;
        private System.Windows.Forms.Panel pnlMauDaDat;
        private System.Windows.Forms.Label lblChuDaDat;
    }
}
