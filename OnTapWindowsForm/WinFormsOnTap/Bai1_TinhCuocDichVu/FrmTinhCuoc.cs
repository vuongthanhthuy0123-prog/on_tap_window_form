using System;
using System.Globalization;
using System.Windows.Forms;

namespace Bai1_TinhCuocDichVu
{
    public partial class FrmTinhCuoc : Form
    {
        // Dùng định dạng Việt Nam để hiển thị tiền: 1.250.000 đ
        private static readonly CultureInfo VietNam = new CultureInfo("vi-VN");

        public FrmTinhCuoc()
        {
            InitializeComponent();
        }

        #region Sự kiện

        // Nút "Tính tiền": kiểm tra dữ liệu, báo lỗi bằng MessageBox nếu sai, ngược lại hiển thị tổng tiền
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            decimal donGia;
            int soLuong;
            decimal phanTramGiam;

            if (!KiemTraDuLieu(true, out donGia, out soLuong, out phanTramGiam))
            {
                lblTongTien.Text = DinhDangTien(0);
                return;
            }

            decimal tongTien = TinhTongTien(donGia, soLuong, phanTramGiam);
            lblTongTien.Text = DinhDangTien(tongTien);
        }

        // Nút "Làm mới": xóa toàn bộ dữ liệu, đưa con trỏ về ô đầu tiên
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtGiamGia.Clear();
            lblTongTien.Text = DinhDangTien(0);
            txtDonGia.Focus();
        }

        // Tự động tính lại tổng tiền mỗi khi người dùng gõ (không bật MessageBox khi đang gõ)
        private void txtNhapLieu_TextChanged(object sender, EventArgs e)
        {
            decimal donGia;
            int soLuong;
            decimal phanTramGiam;

            if (KiemTraDuLieu(false, out donGia, out soLuong, out phanTramGiam))
                lblTongTien.Text = DinhDangTien(TinhTongTien(donGia, soLuong, phanTramGiam));
            else
                lblTongTien.Text = DinhDangTien(0);
        }

        #endregion

        #region Xử lý nghiệp vụ

        /// <summary>
        /// Tổng tiền = (Đơn giá × Số lượng) × (100 − % Giảm) / 100
        /// </summary>
        private static decimal TinhTongTien(decimal donGia, int soLuong, decimal phanTramGiam)
        {
            decimal tong = donGia * soLuong * (100 - phanTramGiam) / 100;
            return Math.Round(tong, 0, MidpointRounding.AwayFromZero);
        }

        private static string DinhDangTien(decimal soTien)
        {
            return soTien.ToString("N0", VietNam) + " đ";
        }

        /// <summary>
        /// Kiểm tra toàn bộ dữ liệu nhập.
        /// hienThongBao = true  : hiển thị MessageBox cảnh báo và đưa con trỏ về ô bị lỗi.
        /// hienThongBao = false : chỉ kiểm tra im lặng (dùng cho tự động tính khi gõ).
        /// </summary>
        private bool KiemTraDuLieu(bool hienThongBao, out decimal donGia, out int soLuong, out decimal phanTramGiam)
        {
            donGia = 0;
            soLuong = 0;
            phanTramGiam = 0;

            // 1. Đơn giá dịch vụ: bắt buộc, là số, > 0
            if (!DocSoThuc(txtDonGia, "Đơn giá dịch vụ", hienThongBao, out donGia))
                return false;
            if (donGia <= 0)
                return BaoLoi(txtDonGia, "Đơn giá dịch vụ phải lớn hơn 0!", hienThongBao);

            // 2. Số lượng khách: bắt buộc, là số nguyên, > 0
            string chuoiSoLuong = txtSoLuong.Text.Trim();
            if (chuoiSoLuong.Length == 0)
                return BaoLoi(txtSoLuong, "Vui lòng nhập Số lượng khách!", hienThongBao);
            if (!int.TryParse(chuoiSoLuong, NumberStyles.Integer, CultureInfo.CurrentCulture, out soLuong))
                return BaoLoi(txtSoLuong, "Số lượng khách phải là số nguyên (không được nhập chữ hoặc số lẻ)!", hienThongBao);
            if (soLuong <= 0)
                return BaoLoi(txtSoLuong, "Số lượng khách phải lớn hơn 0!", hienThongBao);

            // 3. % giảm giá: bắt buộc, là số, trong khoảng 0 - 100
            if (!DocSoThuc(txtGiamGia, "Mã giảm giá (% giảm)", hienThongBao, out phanTramGiam))
                return false;
            if (phanTramGiam < 0 || phanTramGiam > 100)
                return BaoLoi(txtGiamGia, "Phần trăm giảm giá phải nằm trong khoảng từ 0 đến 100!", hienThongBao);

            return true;
        }

        private bool DocSoThuc(TextBox txt, string tenTruong, bool hienThongBao, out decimal giaTri)
        {
            giaTri = 0;
            string chuoi = txt.Text.Trim();

            if (chuoi.Length == 0)
                return BaoLoi(txt, "Vui lòng nhập " + tenTruong + "!", hienThongBao);

            if (!decimal.TryParse(chuoi, NumberStyles.Number, CultureInfo.CurrentCulture, out giaTri))
                return BaoLoi(txt, tenTruong + " phải là số hợp lệ (không được nhập chữ)!", hienThongBao);

            return true;
        }

        // Luôn trả về false để có thể viết gọn: return BaoLoi(...)
        private static bool BaoLoi(TextBox txt, string thongBao, bool hienThongBao)
        {
            if (hienThongBao)
            {
                MessageBox.Show(thongBao, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
                txt.SelectAll();
            }
            return false;
        }

        #endregion
    }
}
