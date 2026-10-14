using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bai5_QuanLyDonGiaoHang
{
    public partial class FrmDonGiaoHang : Form
    {
        private static readonly CultureInfo VietNam = new CultureInfo("vi-VN");
        private const string LOI_LUOI = "Có ô Số lượng / Trọng lượng / Đơn giá không hợp lệ (xem biểu tượng đỏ trong bảng).";

        public FrmDonGiaoHang()
        {
            InitializeComponent();
        }

        #region Khởi tạo

        private void FrmDonGiaoHang_Load(object sender, EventArgs e)
        {
            // Giới hạn kích thước tối thiểu của 2 cột SplitContainer
            splitMain.Panel1MinSize = 330;
            splitMain.Panel2MinSize = 400;

            CauHinhLuoi();

            cboThanhToan.SelectedIndex = 0;
            dtpNgayGiao.Value = DateTime.Today.AddDays(1);

            // Vị trí biểu tượng ErrorProvider cho bảng hàng hóa
            errorProvider.SetIconAlignment(dgvHangHoa, ErrorIconAlignment.TopRight);
            errorProvider.SetIconPadding(dgvHangHoa, 3);

            // Dữ liệu mẫu để minh họa
            dgvHangHoa.Rows.Add("Bàn phím cơ", 2, 1.2m, 850000m);
            dgvHangHoa.Rows.Add("Chuột không dây", 3, 0.3m, 250000m);
            foreach (DataGridViewRow dong in dgvHangHoa.Rows)
                TinhThanhTien(dong);

            // Đồng hồ hệ thống trên StatusStrip
            CapNhatDongHo();
            timerDongHo.Start();

            TinhLaiTongCong();
        }

        private void CauHinhLuoi()
        {
            // Kiểu dữ liệu từng cột số
            colSoLuong.ValueType = typeof(int);
            colTrongLuong.ValueType = typeof(decimal);
            colDonGia.ValueType = typeof(decimal);
            colThanhTien.ValueType = typeof(decimal);

            // Định dạng hiển thị
            colTrongLuong.DefaultCellStyle.Format = "#,##0.##";
            colDonGia.DefaultCellStyle.Format = "N0";
            colThanhTien.DefaultCellStyle.Format = "N0";

            DataGridViewContentAlignment canPhai = DataGridViewContentAlignment.MiddleRight;
            colSoLuong.DefaultCellStyle.Alignment = canPhai;
            colTrongLuong.DefaultCellStyle.Alignment = canPhai;
            colDonGia.DefaultCellStyle.Alignment = canPhai;
            colThanhTien.DefaultCellStyle.Alignment = canPhai;

            // Cột Thành tiền: chỉ đọc, tự tính
            colTrongLuong.ToolTipText = "Trọng lượng của 1 đơn vị hàng (kg)";
            colThanhTien.ToolTipText = "Thành tiền = Số lượng × Đơn giá (tự tính)";
            colThanhTien.ReadOnly = true;
            colThanhTien.DefaultCellStyle.BackColor = Color.LightYellow;
            colThanhTien.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            dgvHangHoa.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            dgvHangHoa.AllowUserToAddRows = true;
            dgvHangHoa.AllowUserToDeleteRows = false; // phím Delete được xử lý riêng (có xác nhận)
        }

        #endregion

        #region Timer - Đồng hồ hệ thống

        private void timerDongHo_Tick(object sender, EventArgs e)
        {
            CapNhatDongHo();
        }

        private void CapNhatDongHo()
        {
            lblThoiGian.Text = "Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        #endregion

        #region Phím tắt: F2 thêm dòng, Delete xóa dòng

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F2)
            {
                ThemDongMoi();
                return true;
            }

            // Chỉ xóa dòng khi bảng đang được focus và KHÔNG ở chế độ sửa ô
            // (để phím Delete vẫn xóa ký tự bình thường trong TextBox / ô đang sửa)
            if (keyData == Keys.Delete && dgvHangHoa.Focused && !dgvHangHoa.IsCurrentCellInEditMode)
            {
                XoaDongDangChon();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ThemDongMoi()
        {
            // Nếu đang sửa 1 ô mà dữ liệu chưa hợp lệ thì không thêm
            if (dgvHangHoa.IsCurrentCellInEditMode && !dgvHangHoa.EndEdit())
                return;

            int index = dgvHangHoa.Rows.Add();
            DataGridViewRow dong = dgvHangHoa.Rows[index];
            dong.Cells[colSoLuong.Index].Value = 1;

            dgvHangHoa.Focus();
            dgvHangHoa.CurrentCell = dong.Cells[colTenHang.Index];
            dgvHangHoa.BeginEdit(true);
        }

        private void XoaDongDangChon()
        {
            DataGridViewRow dong = dgvHangHoa.CurrentRow;
            if (dong == null || dong.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn dòng hàng hóa cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string tenHang = Convert.ToString(dong.Cells[colTenHang.Index].Value);
            DialogResult kq = MessageBox.Show(
                "Xóa dòng " + (dong.Index + 1) + (tenHang.Length > 0 ? " (" + tenHang + ")" : "") + "?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
                dgvHangHoa.Rows.Remove(dong);
        }

        #endregion

        #region Sự kiện DataGridView

        private void dgvHangHoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && !dgvHangHoa.Columns[e.ColumnIndex].ReadOnly)
                dgvHangHoa.BeginEdit(true);
        }

        // Kiểm tra giá trị trước khi ghi vào ô
        private void dgvHangHoa_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || !LaCotSo(e.ColumnIndex))
                return;

            DataGridViewCell o = dgvHangHoa.Rows[e.RowIndex].Cells[e.ColumnIndex];
            string chuoi = Convert.ToString(e.FormattedValue).Trim();

            if (chuoi.Length == 0)
            {
                o.ErrorText = string.Empty; // cho phép để trống tạm thời, sẽ kiểm tra khi Lưu đơn
                CapNhatErrorProvider();
                return;
            }

            decimal giaTri;
            if (!ThuDocSo(e.ColumnIndex, chuoi, out giaTri))
            {
                string loi = ThongBaoSaiDinhDang(e.ColumnIndex);
                o.ErrorText = loi;
                errorProvider.SetError(dgvHangHoa, loi);
                e.Cancel = true; // giữ con trỏ tại ô để sửa (nhấn Esc để hủy)
                return;
            }

            o.ErrorText = KiemTraGiaTri(e.ColumnIndex, giaTri);
            CapNhatErrorProvider();
        }

        // Giá trị ô thay đổi -> kiểm tra lỗi, tính Thành tiền, cập nhật StatusStrip
        private void dgvHangHoa_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex == colThanhTien.Index)
                return;

            DataGridViewRow dong = dgvHangHoa.Rows[e.RowIndex];
            KiemTraLoiDong(dong);
            TinhThanhTien(dong);
            TinhLaiTongCong();
        }

        // Kết thúc sửa ô (kể cả khi nhấn Esc hủy) -> đồng bộ lại lỗi và tổng
        private void dgvHangHoa_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvHangHoa.Rows.Count)
                return;

            DataGridViewRow dong = dgvHangHoa.Rows[e.RowIndex];
            KiemTraLoiDong(dong);
            TinhThanhTien(dong);
            TinhLaiTongCong();
        }

        private void dgvHangHoa_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string loi = ThongBaoSaiDinhDang(e.ColumnIndex);
                dgvHangHoa.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = loi;
                errorProvider.SetError(dgvHangHoa, loi);
            }
        }

        // Gắn sự kiện TextChanged cho ô đang sửa để tính toán REALTIME khi người dùng gõ
        private void dgvHangHoa_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = e.Control as TextBox;
            if (tb != null)
            {
                tb.TextChanged -= OSuaDangGo_TextChanged;
                tb.TextChanged += OSuaDangGo_TextChanged;
            }
        }

        private void OSuaDangGo_TextChanged(object sender, EventArgs e)
        {
            if (!dgvHangHoa.IsCurrentCellInEditMode || dgvHangHoa.CurrentCell == null)
                return;

            int hang = dgvHangHoa.CurrentCell.RowIndex;
            int cot = dgvHangHoa.CurrentCell.ColumnIndex;
            if (!LaCotSo(cot))
                return;

            string chuoi = ((TextBox)sender).Text.Trim();
            decimal? giaTriTam = null;
            string loi = string.Empty;

            if (chuoi.Length > 0)
            {
                decimal giaTri;
                if (ThuDocSo(cot, chuoi, out giaTri))
                {
                    giaTriTam = giaTri;
                    loi = KiemTraGiaTri(cot, giaTri);
                }
                else
                {
                    loi = ThongBaoSaiDinhDang(cot);
                }
            }

            // ErrorProvider bật ngay khi đang gõ giá trị <= 0
            if (loi.Length > 0)
                errorProvider.SetError(dgvHangHoa, loi);
            else
                CapNhatErrorProvider(hang, cot);

            TinhLaiTongCong(hang, cot, giaTriTam);
        }

        private void dgvHangHoa_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            TinhLaiTongCong();
        }

        private void dgvHangHoa_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CapNhatErrorProvider();
            TinhLaiTongCong();
        }

        #endregion

        #region Tính toán

        private void TinhThanhTien(DataGridViewRow dong)
        {
            if (dong.IsNewRow)
                return;

            decimal? soLuong = LayGiaTri(dong.Cells[colSoLuong.Index].Value);
            decimal? donGia = LayGiaTri(dong.Cells[colDonGia.Index].Value);

            if (soLuong.HasValue && donGia.HasValue)
                dong.Cells[colThanhTien.Index].Value = soLuong.Value * donGia.Value;
            else
                dong.Cells[colThanhTien.Index].Value = null;
        }

        /// <summary>
        /// Tính lại Tổng số lượng, Tổng trọng lượng, Tổng tiền và hiển thị lên StatusStrip.
        /// hangDangSua / cotDangSua / giaTriDangSua: giá trị đang gõ dở trong ô (chưa ghi vào lưới).
        /// </summary>
        private void TinhLaiTongCong(int hangDangSua = -1, int cotDangSua = -1, decimal? giaTriDangSua = null)
        {
            decimal tongSoLuong = 0;
            decimal tongTrongLuong = 0;
            decimal tongTien = 0;

            foreach (DataGridViewRow dong in dgvHangHoa.Rows)
            {
                if (dong.IsNewRow)
                    continue;

                bool dangSua = dong.Index == hangDangSua;

                decimal? soLuong = LayGiaTriO(dong, colSoLuong.Index, dangSua, cotDangSua, giaTriDangSua);
                decimal? trongLuong = LayGiaTriO(dong, colTrongLuong.Index, dangSua, cotDangSua, giaTriDangSua);
                decimal? donGia = LayGiaTriO(dong, colDonGia.Index, dangSua, cotDangSua, giaTriDangSua);

                decimal? thanhTien = null;
                if (soLuong.HasValue && donGia.HasValue)
                    thanhTien = soLuong.Value * donGia.Value;

                // Cập nhật Thành tiền ngay trên dòng đang gõ
                if (dangSua)
                    dong.Cells[colThanhTien.Index].Value = thanhTien;

                if (soLuong.HasValue) tongSoLuong += soLuong.Value;
                // Trọng lượng nhập là trọng lượng của 1 đơn vị hàng -> nhân với số lượng
                if (soLuong.HasValue && trongLuong.HasValue) tongTrongLuong += soLuong.Value * trongLuong.Value;
                if (thanhTien.HasValue) tongTien += thanhTien.Value;
            }

            lblTongSoLuong.Text = "Tổng số lượng: " + tongSoLuong.ToString("N0", VietNam);
            lblTongTrongLuong.Text = "Tổng trọng lượng: " + tongTrongLuong.ToString("#,##0.##", VietNam) + " kg";
            lblTongTien.Text = "Tổng tiền: " + tongTien.ToString("N0", VietNam) + " đ";
        }

        private static decimal? LayGiaTriO(DataGridViewRow dong, int cot, bool dangSua, int cotDangSua, decimal? giaTriDangSua)
        {
            if (dangSua && cot == cotDangSua)
                return giaTriDangSua;
            return LayGiaTri(dong.Cells[cot].Value);
        }

        private static decimal? LayGiaTri(object giaTri)
        {
            if (giaTri == null || giaTri == DBNull.Value)
                return null;
            try
            {
                return Convert.ToDecimal(giaTri, CultureInfo.CurrentCulture);
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Kiểm tra lỗi (ErrorProvider)

        private bool LaCotSo(int cot)
        {
            return cot == colSoLuong.Index || cot == colTrongLuong.Index || cot == colDonGia.Index;
        }

        private bool ThuDocSo(int cot, string chuoi, out decimal giaTri)
        {
            giaTri = 0;
            if (cot == colSoLuong.Index)
            {
                int soNguyen;
                if (!int.TryParse(chuoi, NumberStyles.Integer, CultureInfo.CurrentCulture, out soNguyen))
                    return false;
                giaTri = soNguyen;
                return true;
            }
            return decimal.TryParse(chuoi, NumberStyles.Number, CultureInfo.CurrentCulture, out giaTri);
        }

        private string ThongBaoSaiDinhDang(int cot)
        {
            if (cot == colSoLuong.Index) return "Số lượng phải là số nguyên hợp lệ!";
            if (cot == colTrongLuong.Index) return "Trọng lượng phải là số hợp lệ!";
            if (cot == colDonGia.Index) return "Đơn giá phải là số hợp lệ!";
            return "Giá trị không hợp lệ!";
        }

        // Trả về chuỗi lỗi (rỗng nếu hợp lệ)
        private string KiemTraGiaTri(int cot, decimal giaTri)
        {
            if (cot == colSoLuong.Index && giaTri <= 0) return "Số lượng phải lớn hơn 0!";
            if (cot == colTrongLuong.Index && giaTri <= 0) return "Trọng lượng phải lớn hơn 0!";
            if (cot == colDonGia.Index && giaTri < 0) return "Đơn giá không được âm!";
            return string.Empty;
        }

        private void KiemTraLoiDong(DataGridViewRow dong)
        {
            if (dong.IsNewRow)
                return;

            int[] cacCot = { colSoLuong.Index, colTrongLuong.Index, colDonGia.Index };
            foreach (int cot in cacCot)
            {
                decimal? giaTri = LayGiaTri(dong.Cells[cot].Value);
                dong.Cells[cot].ErrorText = giaTri.HasValue ? KiemTraGiaTri(cot, giaTri.Value) : string.Empty;
            }
            CapNhatErrorProvider();
        }

        /// <summary>
        /// Bật/tắt biểu tượng đỏ của ErrorProvider cạnh bảng hàng hóa tùy theo còn ô lỗi hay không.
        /// boQuaHang / boQuaCot: ô đang gõ (lỗi của ô này được xử lý riêng theo thời gian thực).
        /// </summary>
        private void CapNhatErrorProvider(int boQuaHang = -1, int boQuaCot = -1)
        {
            string loiDauTien = string.Empty;

            foreach (DataGridViewRow dong in dgvHangHoa.Rows)
            {
                if (dong.IsNewRow)
                    continue;

                foreach (DataGridViewCell o in dong.Cells)
                {
                    if (dong.Index == boQuaHang && o.ColumnIndex == boQuaCot)
                        continue;
                    if (!string.IsNullOrEmpty(o.ErrorText))
                    {
                        loiDauTien = "Dòng " + (dong.Index + 1) + ": " + o.ErrorText;
                        break;
                    }
                }
                if (loiDauTien.Length > 0)
                    break;
            }

            errorProvider.SetError(dgvHangHoa, loiDauTien);
        }

        // Kiểm tra thông tin khách hàng khi rời khỏi ô nhập
        private void txtKhachHang_Validating(object sender, CancelEventArgs e)
        {
            KiemTraOKhachHang((TextBox)sender);
        }

        private bool KiemTraOKhachHang(TextBox txt)
        {
            string loi = string.Empty;
            string giaTri = txt.Text.Trim();

            if (txt == txtTenKH && giaTri.Length == 0)
                loi = "Vui lòng nhập tên khách hàng!";
            else if (txt == txtSoDienThoai && !Regex.IsMatch(giaTri, @"^0\d{9,10}$"))
                loi = "Số điện thoại phải bắt đầu bằng 0 và gồm 10 - 11 chữ số!";
            else if (txt == txtDiaChi && giaTri.Length == 0)
                loi = "Vui lòng nhập địa chỉ giao hàng!";

            errorProvider.SetError(txt, loi);
            return loi.Length == 0;
        }

        #endregion

        #region Nút Lưu đơn / Làm mới

        private void btnLuuDon_Click(object sender, EventArgs e)
        {
            if (dgvHangHoa.IsCurrentCellInEditMode && !dgvHangHoa.EndEdit())
                return;

            // 1. Thông tin khách hàng
            bool hopLe = KiemTraOKhachHang(txtTenKH);
            hopLe = KiemTraOKhachHang(txtSoDienThoai) && hopLe;
            hopLe = KiemTraOKhachHang(txtDiaChi) && hopLe;
            if (!hopLe)
            {
                tabThongTin.SelectedTab = tabKhachHang;
                MessageBox.Show("Thông tin khách hàng chưa hợp lệ (xem biểu tượng đỏ bên cạnh ô nhập)!",
                    "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Chi tiết hàng hóa
            int soDong = 0;
            foreach (DataGridViewRow dong in dgvHangHoa.Rows)
            {
                if (dong.IsNewRow)
                    continue;

                string loi = KiemTraDongKhiLuu(dong);
                if (loi.Length > 0)
                {
                    errorProvider.SetError(dgvHangHoa, "Dòng " + (dong.Index + 1) + ": " + loi);
                    dgvHangHoa.CurrentCell = dong.Cells[colTenHang.Index];
                    MessageBox.Show("Dòng " + (dong.Index + 1) + ": " + loi, "Lỗi chi tiết hàng hóa",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                soDong++;
            }

            if (soDong == 0)
            {
                MessageBox.Show("Đơn hàng chưa có hàng hóa nào! (Nhấn F2 để thêm dòng mới)",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            errorProvider.SetError(dgvHangHoa, string.Empty);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ĐÃ LƯU ĐƠN GIAO HÀNG");
            sb.AppendLine();
            sb.AppendLine("Khách hàng: " + txtTenKH.Text.Trim());
            sb.AppendLine("Số điện thoại: " + txtSoDienThoai.Text.Trim());
            sb.AppendLine("Địa chỉ: " + txtDiaChi.Text.Trim());
            sb.AppendLine("Ngày giao dự kiến: " + dtpNgayGiao.Value.ToString("dd/MM/yyyy"));
            sb.AppendLine("Vận chuyển: " + LayLoaiVanChuyen());
            sb.AppendLine("Thanh toán: " + cboThanhToan.Text);
            sb.AppendLine("Số mặt hàng: " + soDong);
            sb.AppendLine(lblTongSoLuong.Text);
            sb.AppendLine(lblTongTrongLuong.Text);
            sb.AppendLine(lblTongTien.Text);

            MessageBox.Show(sb.ToString(), "Lưu đơn thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string KiemTraDongKhiLuu(DataGridViewRow dong)
        {
            if (string.IsNullOrWhiteSpace(Convert.ToString(dong.Cells[colTenHang.Index].Value)))
                return "Chưa nhập Tên hàng!";

            decimal? soLuong = LayGiaTri(dong.Cells[colSoLuong.Index].Value);
            decimal? trongLuong = LayGiaTri(dong.Cells[colTrongLuong.Index].Value);
            decimal? donGia = LayGiaTri(dong.Cells[colDonGia.Index].Value);

            if (!soLuong.HasValue || soLuong.Value <= 0) return "Số lượng phải lớn hơn 0!";
            if (!trongLuong.HasValue || trongLuong.Value <= 0) return "Trọng lượng phải lớn hơn 0!";
            if (!donGia.HasValue) return "Chưa nhập Đơn giá!";
            if (donGia.Value < 0) return "Đơn giá không được âm!";
            return string.Empty;
        }

        private string LayLoaiVanChuyen()
        {
            if (rdoNhanh.Checked) return rdoNhanh.Text;
            if (rdoHoaToc.Checked) return rdoHoaToc.Text;
            return rdoTieuChuan.Text;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Xóa toàn bộ dữ liệu đơn hàng hiện tại?", "Xác nhận làm mới",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq != DialogResult.Yes)
                return;

            dgvHangHoa.CancelEdit();
            dgvHangHoa.Rows.Clear();

            txtTenKH.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            txtGhiChu.Clear();
            dtpNgayGiao.Value = DateTime.Today.AddDays(1);
            rdoTieuChuan.Checked = true;
            cboThanhToan.SelectedIndex = 0;

            errorProvider.Clear();
            tabThongTin.SelectedTab = tabKhachHang;
            TinhLaiTongCong();
            txtTenKH.Focus();
        }

        #endregion

        // Cho phép đóng form ngay cả khi 1 ô trong lưới đang bị lỗi (Validating đang Cancel)
        private void FrmDonGiaoHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            timerDongHo.Stop();
        }
    }
}
