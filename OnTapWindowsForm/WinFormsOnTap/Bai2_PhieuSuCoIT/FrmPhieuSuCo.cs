using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Bai2_PhieuSuCoIT
{
    public partial class FrmPhieuSuCo : Form
    {
        // Đường dẫn ảnh lỗi đã chọn (rỗng nếu chưa chọn)
        private string duongDanAnh = string.Empty;

        public FrmPhieuSuCo()
        {
            InitializeComponent();
            dtpNgayGhiNhan.Value = DateTime.Now;
        }

        #region Tải ảnh lỗi

        // Mở OpenFileDialog chọn ảnh .jpg/.png và hiển thị lên PictureBox (SizeMode = StretchImage)
        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            if (ofdAnhLoi.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                // Tạo bản sao Bitmap để KHÔNG khóa file ảnh gốc trên ổ đĩa
                Image anhMoi;
                using (Image anhGoc = Image.FromFile(ofdAnhLoi.FileName))
                {
                    anhMoi = new Bitmap(anhGoc);
                }

                XoaAnhHienTai();
                picAnhLoi.SizeMode = PictureBoxSizeMode.StretchImage;
                picAnhLoi.Image = anhMoi;
                duongDanAnh = ofdAnhLoi.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở tệp hình ảnh đã chọn!\n" + ex.Message,
                    "Lỗi tải ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaAnhHienTai()
        {
            if (picAnhLoi.Image != null)
            {
                Image anhCu = picAnhLoi.Image;
                picAnhLoi.Image = null;
                anhCu.Dispose();
            }
            duongDanAnh = string.Empty;
        }

        #endregion

        #region Gửi yêu cầu

        // Gom toàn bộ thông tin trên giao diện và hiển thị bảng tóm tắt qua MessageBox
        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("===== TÓM TẮT PHIẾU YÊU CẦU HỖ TRỢ IT =====");
            sb.AppendLine();
            sb.AppendLine("• Mã phiếu: " + txtMaPhieu.Text.Trim());
            sb.AppendLine("• Người yêu cầu: " + txtNguoiYeuCau.Text.Trim());
            sb.AppendLine("• Ngày ghi nhận: " + dtpNgayGhiNhan.Value.ToString("dd/MM/yyyy HH:mm"));
            sb.AppendLine("• Mức độ ưu tiên: " + LayMucDoUuTien());
            sb.AppendLine("• Loại sự cố: " + cboLoaiSuCo.SelectedItem);
            sb.AppendLine("• Thiết bị ảnh hưởng: " + LayDanhSachThietBi());
            sb.AppendLine("• Ảnh chụp lỗi: " +
                (string.IsNullOrEmpty(duongDanAnh) ? "(Không đính kèm)" : Path.GetFileName(duongDanAnh)));

            MessageBox.Show(sb.ToString(), "Gửi yêu cầu thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
                return BaoLoi(txtMaPhieu, "Vui lòng nhập Mã phiếu!");

            if (string.IsNullOrWhiteSpace(txtNguoiYeuCau.Text))
                return BaoLoi(txtNguoiYeuCau, "Vui lòng nhập Người yêu cầu!");

            if (cboLoaiSuCo.SelectedIndex < 0)
                return BaoLoi(cboLoaiSuCo, "Vui lòng chọn Loại sự cố!");

            if (!chkMayTinhBan.Checked && !chkLaptop.Checked && !chkMayIn.Checked && !chkDienThoai.Checked)
                return BaoLoi(chkMayTinhBan, "Vui lòng chọn ít nhất 1 Thiết bị ảnh hưởng!");

            return true;
        }

        private static bool BaoLoi(Control control, string thongBao)
        {
            MessageBox.Show(thongBao, "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
            return false;
        }

        private string LayMucDoUuTien()
        {
            if (rdoThap.Checked) return rdoThap.Text;
            if (rdoKhanCap.Checked) return rdoKhanCap.Text;
            return rdoTrungBinh.Text;
        }

        private string LayDanhSachThietBi()
        {
            List<string> ds = new List<string>();
            CheckBox[] cacThietBi = { chkMayTinhBan, chkLaptop, chkMayIn, chkDienThoai };
            foreach (CheckBox chk in cacThietBi)
            {
                if (chk.Checked)
                    ds.Add(chk.Text);
            }
            return ds.Count == 0 ? "(Không có)" : string.Join(", ", ds.ToArray());
        }

        #endregion

        #region Nhập lại

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            txtNguoiYeuCau.Clear();
            dtpNgayGhiNhan.Value = DateTime.Now;
            rdoTrungBinh.Checked = true;
            cboLoaiSuCo.SelectedIndex = -1;
            chkMayTinhBan.Checked = false;
            chkLaptop.Checked = false;
            chkMayIn.Checked = false;
            chkDienThoai.Checked = false;
            XoaAnhHienTai();
            txtMaPhieu.Focus();
        }

        #endregion

        private void FrmPhieuSuCo_FormClosed(object sender, FormClosedEventArgs e)
        {
            XoaAnhHienTai();
        }
    }
}
