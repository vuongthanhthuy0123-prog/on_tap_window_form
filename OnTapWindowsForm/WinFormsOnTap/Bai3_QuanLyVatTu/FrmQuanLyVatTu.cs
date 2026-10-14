using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Bai3_QuanLyVatTu
{
    public partial class FrmQuanLyVatTu : Form
    {
        private static readonly CultureInfo VietNam = new CultureInfo("vi-VN");

        // Danh sách đối tượng vật tư lưu tạm trên RAM
        private readonly List<VatTu> dsVatTu = new List<VatTu>();

        public FrmQuanLyVatTu()
        {
            InitializeComponent();
        }

        #region Các nút chức năng

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            VatTu vt;
            if (!DocDuLieuNhap(out vt))
                return;

            // Validate: không cho thêm nếu Mã VT đã tồn tại trong ListView
            if (TimDongTheoMa(vt.MaVT, null) != null)
            {
                MessageBox.Show("Mã vật tư \"" + vt.MaVT + "\" đã tồn tại trong danh sách!",
                    "Trùng mã vật tư", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaVT.Focus();
                txtMaVT.SelectAll();
                return;
            }

            dsVatTu.Add(vt);
            ListViewItem item = new ListViewItem(new string[] { "", "", "", "" });
            GanDuLieuChoDong(item, vt);
            lvVatTu.Items.Add(item);

            lvVatTu.SelectedItems.Clear();
            XoaONhap();
            CapNhatTongSo();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng trong danh sách để cập nhật!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            VatTu duLieuMoi;
            if (!DocDuLieuNhap(out duLieuMoi))
                return;

            ListViewItem dongDangChon = lvVatTu.SelectedItems[0];

            // Nếu đổi mã thì mã mới không được trùng với dòng khác
            if (TimDongTheoMa(duLieuMoi.MaVT, dongDangChon) != null)
            {
                MessageBox.Show("Mã vật tư \"" + duLieuMoi.MaVT + "\" đã tồn tại ở dòng khác!",
                    "Trùng mã vật tư", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaVT.Focus();
                txtMaVT.SelectAll();
                return;
            }

            VatTu vt = (VatTu)dongDangChon.Tag;
            vt.MaVT = duLieuMoi.MaVT;
            vt.TenVT = duLieuMoi.TenVT;
            vt.DonViTinh = duLieuMoi.DonViTinh;
            vt.DonGia = duLieuMoi.DonGia;
            GanDuLieuChoDong(dongDangChon, vt);

            MessageBox.Show("Cập nhật vật tư thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng trong danh sách để xóa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ListViewItem dong = lvVatTu.SelectedItems[0];
            VatTu vt = (VatTu)dong.Tag;

            // Hộp thoại xác nhận Yes/No trước khi xóa
            DialogResult kq = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa vật tư \"" + vt.MaVT + " - " + vt.TenVT + "\" không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (kq != DialogResult.Yes)
                return;

            dsVatTu.Remove(vt);
            lvVatTu.Items.Remove(dong);
            XoaONhap();
            CapNhatTongSo();
        }

        private void btnXoaToanBo_Click(object sender, EventArgs e)
        {
            if (lvVatTu.Items.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa TOÀN BỘ " + lvVatTu.Items.Count + " vật tư không?",
                "Xác nhận xóa toàn bộ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (kq != DialogResult.Yes)
                return;

            dsVatTu.Clear();
            lvVatTu.Items.Clear();
            XoaONhap();
            CapNhatTongSo();
        }

        #endregion

        #region Chọn dòng trên ListView -> đẩy dữ liệu ngược lại ô nhập

        private void lvVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sự kiện này chạy 2 lần khi đổi dòng (bỏ chọn rồi chọn) -> chỉ xử lý khi có dòng được chọn
            if (lvVatTu.SelectedItems.Count == 0)
                return;

            VatTu vt = (VatTu)lvVatTu.SelectedItems[0].Tag;
            txtMaVT.Text = vt.MaVT;
            txtTenVT.Text = vt.TenVT;
            cboDonViTinh.SelectedItem = vt.DonViTinh;
            txtDonGia.Text = vt.DonGia.ToString(CultureInfo.CurrentCulture);
        }

        #endregion

        #region Hàm hỗ trợ

        private bool DocDuLieuNhap(out VatTu vt)
        {
            vt = null;

            string ma = txtMaVT.Text.Trim().ToUpper();
            string ten = txtTenVT.Text.Trim();
            string chuoiGia = txtDonGia.Text.Trim();
            decimal donGia;

            if (ma.Length == 0)
                return BaoLoi(txtMaVT, "Vui lòng nhập Mã vật tư!");
            if (ten.Length == 0)
                return BaoLoi(txtTenVT, "Vui lòng nhập Tên vật tư!");
            if (cboDonViTinh.SelectedIndex < 0)
                return BaoLoi(cboDonViTinh, "Vui lòng chọn Đơn vị tính!");
            if (chuoiGia.Length == 0)
                return BaoLoi(txtDonGia, "Vui lòng nhập Đơn giá nhập!");
            if (!decimal.TryParse(chuoiGia, NumberStyles.Number, CultureInfo.CurrentCulture, out donGia))
                return BaoLoi(txtDonGia, "Đơn giá nhập phải là số hợp lệ!");
            if (donGia <= 0)
                return BaoLoi(txtDonGia, "Đơn giá nhập phải lớn hơn 0!");

            vt = new VatTu(ma, ten, cboDonViTinh.SelectedItem.ToString(), donGia);
            return true;
        }

        /// <summary>
        /// Tìm dòng trong ListView có Mã VT trùng (không phân biệt hoa/thường).
        /// boQua: dòng được bỏ qua khi so sánh (dùng khi cập nhật chính dòng đó).
        /// </summary>
        private ListViewItem TimDongTheoMa(string ma, ListViewItem boQua)
        {
            foreach (ListViewItem item in lvVatTu.Items)
            {
                if (item == boQua)
                    continue;
                if (string.Equals(item.Text, ma, StringComparison.OrdinalIgnoreCase))
                    return item;
            }
            return null;
        }

        private static void GanDuLieuChoDong(ListViewItem item, VatTu vt)
        {
            item.Text = vt.MaVT;
            item.SubItems[1].Text = vt.TenVT;
            item.SubItems[2].Text = vt.DonViTinh;
            item.SubItems[3].Text = vt.DonGia.ToString("#,##0.##", VietNam);
            item.Tag = vt;
        }

        private void XoaONhap()
        {
            txtMaVT.Clear();
            txtTenVT.Clear();
            cboDonViTinh.SelectedIndex = -1;
            txtDonGia.Clear();
            txtMaVT.Focus();
        }

        private void CapNhatTongSo()
        {
            lblTongSo.Text = "Tổng số vật tư: " + dsVatTu.Count;
        }

        private static bool BaoLoi(Control control, string thongBao)
        {
            MessageBox.Show(thongBao, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
            return false;
        }

        #endregion
    }
}
