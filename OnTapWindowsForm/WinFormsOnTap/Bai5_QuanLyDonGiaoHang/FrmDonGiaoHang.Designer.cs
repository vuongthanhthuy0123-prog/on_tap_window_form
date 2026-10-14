namespace Bai5_QuanLyDonGiaoHang
{
    partial class FrmDonGiaoHang
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
            this.components = new System.ComponentModel.Container();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.tabThongTin = new System.Windows.Forms.TabControl();
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.dtpNgayGiao = new System.Windows.Forms.DateTimePicker();
            this.lblNgayGiao = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.tabVanChuyen = new System.Windows.Forms.TabPage();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.cboThanhToan = new System.Windows.Forms.ComboBox();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.grpLoaiVanChuyen = new System.Windows.Forms.GroupBox();
            this.rdoHoaToc = new System.Windows.Forms.RadioButton();
            this.rdoNhanh = new System.Windows.Forms.RadioButton();
            this.rdoTieuChuan = new System.Windows.Forms.RadioButton();
            this.pnlNutLenh = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuuDon = new System.Windows.Forms.Button();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.colTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblThoiGian = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTongSoLuong = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTongTrongLuong = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTongTien = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDongHo = new System.Windows.Forms.Timer(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.tabThongTin.SuspendLayout();
            this.tabKhachHang.SuspendLayout();
            this.tabVanChuyen.SuspendLayout();
            this.grpLoaiVanChuyen.SuspendLayout();
            this.pnlNutLenh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1100, 45);
            this.lblTieuDe.TabIndex = 10;
            this.lblTieuDe.Text = "BẢNG ĐIỀU KHIỂN QUẢN LÝ ĐƠN GIAO HÀNG";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitMain.Location = new System.Drawing.Point(0, 45);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.tabThongTin);
            this.splitMain.Panel1.Controls.Add(this.pnlNutLenh);
            this.splitMain.Panel1.Padding = new System.Windows.Forms.Padding(6);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.dgvHangHoa);
            this.splitMain.Panel2.Controls.Add(this.lblHuongDan);
            this.splitMain.Panel2.Padding = new System.Windows.Forms.Padding(6, 6, 26, 6);
            this.splitMain.Size = new System.Drawing.Size(1100, 549);
            this.splitMain.SplitterDistance = 380;
            this.splitMain.SplitterWidth = 5;
            this.splitMain.TabIndex = 0;
            // 
            // tabThongTin
            // 
            this.tabThongTin.Controls.Add(this.tabKhachHang);
            this.tabThongTin.Controls.Add(this.tabVanChuyen);
            this.tabThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabThongTin.Location = new System.Drawing.Point(6, 6);
            this.tabThongTin.Name = "tabThongTin";
            this.tabThongTin.SelectedIndex = 0;
            this.tabThongTin.Size = new System.Drawing.Size(368, 477);
            this.tabThongTin.TabIndex = 0;
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.Controls.Add(this.dtpNgayGiao);
            this.tabKhachHang.Controls.Add(this.lblNgayGiao);
            this.tabKhachHang.Controls.Add(this.txtDiaChi);
            this.tabKhachHang.Controls.Add(this.lblDiaChi);
            this.tabKhachHang.Controls.Add(this.txtSoDienThoai);
            this.tabKhachHang.Controls.Add(this.lblSoDienThoai);
            this.tabKhachHang.Controls.Add(this.txtTenKH);
            this.tabKhachHang.Controls.Add(this.lblTenKH);
            this.tabKhachHang.Location = new System.Drawing.Point(4, 32);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhachHang.Size = new System.Drawing.Size(360, 441);
            this.tabKhachHang.TabIndex = 0;
            this.tabKhachHang.Text = "Thông tin khách hàng";
            this.tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(12, 15);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(126, 23);
            this.lblTenKH.TabIndex = 10;
            this.lblTenKH.Text = "Tên khách hàng:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(12, 40);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(310, 30);
            this.txtTenKH.TabIndex = 0;
            this.txtTenKH.Validating += new System.ComponentModel.CancelEventHandler(this.txtKhachHang_Validating);
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(12, 80);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(107, 23);
            this.lblSoDienThoai.TabIndex = 11;
            this.lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(12, 105);
            this.txtSoDienThoai.MaxLength = 11;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(310, 30);
            this.txtSoDienThoai.TabIndex = 1;
            this.txtSoDienThoai.Validating += new System.ComponentModel.CancelEventHandler(this.txtKhachHang_Validating);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(12, 145);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(124, 23);
            this.lblDiaChi.TabIndex = 12;
            this.lblDiaChi.Text = "Địa chỉ giao hàng:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(12, 170);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiaChi.Size = new System.Drawing.Size(310, 75);
            this.txtDiaChi.TabIndex = 2;
            this.txtDiaChi.Validating += new System.ComponentModel.CancelEventHandler(this.txtKhachHang_Validating);
            // 
            // lblNgayGiao
            // 
            this.lblNgayGiao.AutoSize = true;
            this.lblNgayGiao.Location = new System.Drawing.Point(12, 255);
            this.lblNgayGiao.Name = "lblNgayGiao";
            this.lblNgayGiao.Size = new System.Drawing.Size(135, 23);
            this.lblNgayGiao.TabIndex = 13;
            this.lblNgayGiao.Text = "Ngày giao dự kiến:";
            // 
            // dtpNgayGiao
            // 
            this.dtpNgayGiao.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayGiao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayGiao.Location = new System.Drawing.Point(12, 280);
            this.dtpNgayGiao.Name = "dtpNgayGiao";
            this.dtpNgayGiao.Size = new System.Drawing.Size(310, 30);
            this.dtpNgayGiao.TabIndex = 3;
            // 
            // tabVanChuyen
            // 
            this.tabVanChuyen.Controls.Add(this.txtGhiChu);
            this.tabVanChuyen.Controls.Add(this.lblGhiChu);
            this.tabVanChuyen.Controls.Add(this.cboThanhToan);
            this.tabVanChuyen.Controls.Add(this.lblThanhToan);
            this.tabVanChuyen.Controls.Add(this.grpLoaiVanChuyen);
            this.tabVanChuyen.Location = new System.Drawing.Point(4, 32);
            this.tabVanChuyen.Name = "tabVanChuyen";
            this.tabVanChuyen.Padding = new System.Windows.Forms.Padding(3);
            this.tabVanChuyen.Size = new System.Drawing.Size(360, 441);
            this.tabVanChuyen.TabIndex = 1;
            this.tabVanChuyen.Text = "Loại vận chuyển";
            this.tabVanChuyen.UseVisualStyleBackColor = true;
            // 
            // grpLoaiVanChuyen
            // 
            this.grpLoaiVanChuyen.Controls.Add(this.rdoHoaToc);
            this.grpLoaiVanChuyen.Controls.Add(this.rdoNhanh);
            this.grpLoaiVanChuyen.Controls.Add(this.rdoTieuChuan);
            this.grpLoaiVanChuyen.Location = new System.Drawing.Point(12, 12);
            this.grpLoaiVanChuyen.Name = "grpLoaiVanChuyen";
            this.grpLoaiVanChuyen.Size = new System.Drawing.Size(310, 140);
            this.grpLoaiVanChuyen.TabIndex = 0;
            this.grpLoaiVanChuyen.TabStop = false;
            this.grpLoaiVanChuyen.Text = "Hình thức vận chuyển";
            // 
            // rdoTieuChuan
            // 
            this.rdoTieuChuan.AutoSize = true;
            this.rdoTieuChuan.Checked = true;
            this.rdoTieuChuan.Location = new System.Drawing.Point(15, 30);
            this.rdoTieuChuan.Name = "rdoTieuChuan";
            this.rdoTieuChuan.Size = new System.Drawing.Size(196, 27);
            this.rdoTieuChuan.TabIndex = 0;
            this.rdoTieuChuan.TabStop = true;
            this.rdoTieuChuan.Text = "Tiêu chuẩn (3 - 5 ngày)";
            this.rdoTieuChuan.UseVisualStyleBackColor = true;
            // 
            // rdoNhanh
            // 
            this.rdoNhanh.AutoSize = true;
            this.rdoNhanh.Location = new System.Drawing.Point(15, 64);
            this.rdoNhanh.Name = "rdoNhanh";
            this.rdoNhanh.Size = new System.Drawing.Size(166, 27);
            this.rdoNhanh.TabIndex = 1;
            this.rdoNhanh.Text = "Nhanh (1 - 2 ngày)";
            this.rdoNhanh.UseVisualStyleBackColor = true;
            // 
            // rdoHoaToc
            // 
            this.rdoHoaToc.AutoSize = true;
            this.rdoHoaToc.Location = new System.Drawing.Point(15, 98);
            this.rdoHoaToc.Name = "rdoHoaToc";
            this.rdoHoaToc.Size = new System.Drawing.Size(182, 27);
            this.rdoHoaToc.TabIndex = 2;
            this.rdoHoaToc.Text = "Hỏa tốc (trong ngày)";
            this.rdoHoaToc.UseVisualStyleBackColor = true;
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.Location = new System.Drawing.Point(12, 165);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(165, 23);
            this.lblThanhToan.TabIndex = 10;
            this.lblThanhToan.Text = "Hình thức thanh toán:";
            // 
            // cboThanhToan
            // 
            this.cboThanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThanhToan.FormattingEnabled = true;
            this.cboThanhToan.Items.AddRange(new object[] {
            "Tiền mặt khi nhận hàng (COD)",
            "Chuyển khoản ngân hàng",
            "Ví điện tử"});
            this.cboThanhToan.Location = new System.Drawing.Point(12, 190);
            this.cboThanhToan.Name = "cboThanhToan";
            this.cboThanhToan.Size = new System.Drawing.Size(310, 31);
            this.cboThanhToan.TabIndex = 1;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(12, 235);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(67, 23);
            this.lblGhiChu.TabIndex = 11;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(12, 260);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGhiChu.Size = new System.Drawing.Size(310, 90);
            this.txtGhiChu.TabIndex = 2;
            // 
            // pnlNutLenh
            // 
            this.pnlNutLenh.Controls.Add(this.btnLamMoi);
            this.pnlNutLenh.Controls.Add(this.btnLuuDon);
            this.pnlNutLenh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNutLenh.Location = new System.Drawing.Point(6, 483);
            this.pnlNutLenh.Name = "pnlNutLenh";
            this.pnlNutLenh.Size = new System.Drawing.Size(368, 60);
            this.pnlNutLenh.TabIndex = 1;
            // 
            // btnLuuDon
            // 
            this.btnLuuDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuuDon.Location = new System.Drawing.Point(4, 12);
            this.btnLuuDon.Name = "btnLuuDon";
            this.btnLuuDon.Size = new System.Drawing.Size(170, 42);
            this.btnLuuDon.TabIndex = 0;
            this.btnLuuDon.Text = "Lưu đơn hàng";
            this.btnLuuDon.UseVisualStyleBackColor = true;
            this.btnLuuDon.Click += new System.EventHandler(this.btnLuuDon_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(184, 12);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(170, 42);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHangHoa.BackgroundColor = System.Drawing.Color.White;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenHang,
            this.colSoLuong,
            this.colTrongLuong,
            this.colDonGia,
            this.colThanhTien});
            this.dgvHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHangHoa.Location = new System.Drawing.Point(6, 38);
            this.dgvHangHoa.MultiSelect = false;
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.RowHeadersWidth = 40;
            this.dgvHangHoa.Size = new System.Drawing.Size(683, 505);
            this.dgvHangHoa.TabIndex = 0;
            this.dgvHangHoa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellDoubleClick);
            this.dgvHangHoa.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellEndEdit);
            this.dgvHangHoa.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvHangHoa_CellValidating);
            this.dgvHangHoa.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellValueChanged);
            this.dgvHangHoa.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvHangHoa_DataError);
            this.dgvHangHoa.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvHangHoa_EditingControlShowing);
            this.dgvHangHoa.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvHangHoa_RowsAdded);
            this.dgvHangHoa.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvHangHoa_RowsRemoved);
            // 
            // colTenHang
            // 
            this.colTenHang.FillWeight = 34F;
            this.colTenHang.HeaderText = "Tên hàng";
            this.colTenHang.Name = "colTenHang";
            // 
            // colSoLuong
            // 
            this.colSoLuong.FillWeight = 13F;
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colTrongLuong
            // 
            this.colTrongLuong.FillWeight = 17F;
            this.colTrongLuong.HeaderText = "Trọng lượng (kg)";
            this.colTrongLuong.Name = "colTrongLuong";
            // 
            // colDonGia
            // 
            this.colDonGia.FillWeight = 17F;
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.Name = "colDonGia";
            // 
            // colThanhTien
            // 
            this.colThanhTien.FillWeight = 19F;
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHuongDan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblHuongDan.ForeColor = System.Drawing.Color.DimGray;
            this.lblHuongDan.Location = new System.Drawing.Point(6, 6);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new System.Drawing.Size(683, 32);
            this.lblHuongDan.TabIndex = 10;
            this.lblHuongDan.Text = "Chi tiết hàng hóa  |  F2: Thêm nhanh dòng mới  |  Delete: Xóa dòng đang chọn  |  Esc: Hủy sửa ô";
            this.lblHuongDan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblThoiGian,
            this.lblTongSoLuong,
            this.lblTongTrongLuong,
            this.lblTongTien});
            this.statusStrip.Location = new System.Drawing.Point(0, 594);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1100, 26);
            this.statusStrip.TabIndex = 2;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(230, 20);
            this.lblThoiGian.Text = "Thời gian: --/--/---- --:--:--";
            // 
            // lblTongSoLuong
            // 
            this.lblTongSoLuong.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblTongSoLuong.Name = "lblTongSoLuong";
            this.lblTongSoLuong.Size = new System.Drawing.Size(160, 20);
            this.lblTongSoLuong.Text = "Tổng số lượng: 0";
            // 
            // lblTongTrongLuong
            // 
            this.lblTongTrongLuong.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblTongTrongLuong.Name = "lblTongTrongLuong";
            this.lblTongTrongLuong.Size = new System.Drawing.Size(190, 20);
            this.lblTongTrongLuong.Text = "Tổng trọng lượng: 0 kg";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(150, 20);
            this.lblTongTien.Text = "Tổng tiền: 0 đ";
            // 
            // timerDongHo
            // 
            this.timerDongHo.Interval = 1000;
            this.timerDongHo.Tick += new System.EventHandler(this.timerDongHo_Tick);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // FrmDonGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1100, 620);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmDonGiaoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 5 - Bảng điều khiển Quản lý Đơn giao hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDonGiaoHang_FormClosing);
            this.Load += new System.EventHandler(this.FrmDonGiaoHang_Load);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.tabThongTin.ResumeLayout(false);
            this.tabKhachHang.ResumeLayout(false);
            this.tabKhachHang.PerformLayout();
            this.tabVanChuyen.ResumeLayout(false);
            this.tabVanChuyen.PerformLayout();
            this.grpLoaiVanChuyen.ResumeLayout(false);
            this.grpLoaiVanChuyen.PerformLayout();
            this.pnlNutLenh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.TabControl tabThongTin;
        private System.Windows.Forms.TabPage tabKhachHang;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblNgayGiao;
        private System.Windows.Forms.DateTimePicker dtpNgayGiao;
        private System.Windows.Forms.TabPage tabVanChuyen;
        private System.Windows.Forms.GroupBox grpLoaiVanChuyen;
        private System.Windows.Forms.RadioButton rdoTieuChuan;
        private System.Windows.Forms.RadioButton rdoNhanh;
        private System.Windows.Forms.RadioButton rdoHoaToc;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.ComboBox cboThanhToan;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Panel pnlNutLenh;
        private System.Windows.Forms.Button btnLuuDon;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrongLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.Label lblHuongDan;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblThoiGian;
        private System.Windows.Forms.ToolStripStatusLabel lblTongSoLuong;
        private System.Windows.Forms.ToolStripStatusLabel lblTongTrongLuong;
        private System.Windows.Forms.ToolStripStatusLabel lblTongTien;
        private System.Windows.Forms.Timer timerDongHo;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
