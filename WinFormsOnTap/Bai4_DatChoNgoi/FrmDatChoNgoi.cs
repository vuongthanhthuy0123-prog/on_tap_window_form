using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Bai4_DatChoNgoi
{
    /// <summary>
    /// Trạng thái của 1 vị trí / bàn.
    /// </summary>
    public enum TrangThaiViTri
    {
        Trong,      // Trắng / xám nhạt
        DangChon,   // Xanh lá
        DaDat       // Đỏ (đã có người đặt / đã khóa)
    }

    public partial class FrmDatChoNgoi : Form
    {
        private const int SO_HANG = 4;
        private const int SO_COT = 5;

        private const decimal GIA_SANG = 100000m;
        private const decimal GIA_TOI = 150000m;

        private static readonly Color MAU_TRONG = Color.WhiteSmoke;
        private static readonly Color MAU_DANG_CHON = Color.LimeGreen;
        private static readonly Color MAU_DA_DAT = Color.Red;

        private static readonly CultureInfo VietNam = new CultureInfo("vi-VN");

        // Một số vị trí đã có người đặt sẵn từ trước (để minh họa trạng thái màu đỏ)
        private static readonly string[] VI_TRI_DA_DAT_SAN = { "A3", "B1", "C4", "D2" };

        // Danh sách 20 nút vị trí được sinh động
        private readonly List<Button> dsNutViTri = new List<Button>();

        public FrmDatChoNgoi()
        {
            InitializeComponent();
        }

        #region Form_Load: sinh 20 Button bằng vòng lặp for

        private void FrmDatChoNgoi_Load(object sender, EventArgs e)
        {
            tlpSoDo.SuspendLayout();
            tlpSoDo.Controls.Clear();
            dsNutViTri.Clear();

            for (int i = 0; i < SO_HANG * SO_COT; i++)
            {
                int hang = i / SO_COT;          // 0..3
                int cot = i % SO_COT;           // 0..4
                string tenViTri = ((char)('A' + hang)).ToString() + (cot + 1); // A1..D5

                Button btn = new Button();
                btn.Name = "btn" + tenViTri;
                btn.Text = tenViTri;
                btn.Dock = DockStyle.Fill;
                btn.Margin = new Padding(6);
                btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.Gray;
                btn.Cursor = Cursors.Hand;

                TrangThaiViTri trangThai = Array.IndexOf(VI_TRI_DA_DAT_SAN, tenViTri) >= 0
                    ? TrangThaiViTri.DaDat
                    : TrangThaiViTri.Trong;
                DatTrangThai(btn, trangThai);

                // Gán CHUNG 1 hàm xử lý sự kiện Click cho cả 20 nút
                btn.Click += ViTri_Click;

                tlpSoDo.Controls.Add(btn, cot, hang);
                dsNutViTri.Add(btn);
            }

            tlpSoDo.ResumeLayout();

            cboKhungGio.SelectedIndex = 0; // mặc định khung giờ Sáng
            CapNhatThongKe();
        }

        #endregion

        #region Hàm xử lý sự kiện dùng chung cho 20 nút

        private void ViTri_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null)
                return;

            TrangThaiViTri trangThai = (TrangThaiViTri)btn.Tag;

            switch (trangThai)
            {
                case TrangThaiViTri.DaDat:
                    MessageBox.Show("Vị trí " + btn.Text + " đã có người đặt / đã bị khóa!",
                        "Không thể chọn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                case TrangThaiViTri.Trong:
                    DatTrangThai(btn, TrangThaiViTri.DangChon);
                    break;

                case TrangThaiViTri.DangChon:
                    DatTrangThai(btn, TrangThaiViTri.Trong);
                    break;
            }

            // Cập nhật realtime số lượng và tạm tính tiền
            CapNhatThongKe();
        }

        #endregion

        #region Các nút chức năng

        private void cboKhungGio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatThongKe();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            List<Button> dangChon = LayDanhSachDangChon();
            if (dangChon.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn vị trí nào!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string danhSach = NoiTenViTri(dangChon);
            decimal tongTien = dangChon.Count * LayGiaKhungGio();

            DialogResult kq = MessageBox.Show(
                "Xác nhận đặt " + dangChon.Count + " vị trí: " + danhSach +
                "\nKhung giờ: " + LayTenKhungGio() +
                "\nTổng tiền: " + DinhDangTien(tongTien) + "\n\nBạn có muốn tiếp tục?",
                "Xác nhận đặt chỗ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq != DialogResult.Yes)
                return;

            foreach (Button btn in dangChon)
                DatTrangThai(btn, TrangThaiViTri.DaDat);

            CapNhatThongKe();

            MessageBox.Show("Đặt chỗ thành công các vị trí: " + danhSach,
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            List<Button> dangChon = LayDanhSachDangChon();
            if (dangChon.Count == 0)
            {
                MessageBox.Show("Không có vị trí nào đang được chọn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (Button btn in dangChon)
                DatTrangThai(btn, TrangThaiViTri.Trong);

            CapNhatThongKe();
        }

        #endregion

        #region Hàm hỗ trợ

        // Đổi trạng thái + màu sắc của 1 nút (trạng thái lưu trong thuộc tính Tag)
        private static void DatTrangThai(Button btn, TrangThaiViTri trangThai)
        {
            btn.Tag = trangThai;
            switch (trangThai)
            {
                case TrangThaiViTri.Trong:
                    btn.BackColor = MAU_TRONG;
                    btn.ForeColor = Color.Black;
                    break;
                case TrangThaiViTri.DangChon:
                    btn.BackColor = MAU_DANG_CHON;
                    btn.ForeColor = Color.White;
                    break;
                case TrangThaiViTri.DaDat:
                    btn.BackColor = MAU_DA_DAT;
                    btn.ForeColor = Color.White;
                    break;
            }
        }

        private List<Button> LayDanhSachDangChon()
        {
            List<Button> ds = new List<Button>();
            foreach (Button btn in dsNutViTri)
            {
                if ((TrangThaiViTri)btn.Tag == TrangThaiViTri.DangChon)
                    ds.Add(btn);
            }
            return ds;
        }

        private decimal LayGiaKhungGio()
        {
            switch (cboKhungGio.SelectedIndex)
            {
                case 0: return GIA_SANG;
                case 1: return GIA_TOI;
                default: return 0;
            }
        }

        private string LayTenKhungGio()
        {
            return cboKhungGio.SelectedItem == null ? "(chưa chọn)" : cboKhungGio.SelectedItem.ToString();
        }

        private static string NoiTenViTri(List<Button> ds)
        {
            List<string> ten = new List<string>();
            foreach (Button btn in ds)
                ten.Add(btn.Text);
            return string.Join(", ", ten.ToArray());
        }

        private static string DinhDangTien(decimal soTien)
        {
            return soTien.ToString("N0", VietNam) + " đ";
        }

        private void CapNhatThongKe()
        {
            List<Button> dangChon = LayDanhSachDangChon();
            decimal tamTinh = dangChon.Count * LayGiaKhungGio();

            lblSoViTri.Text = "Số vị trí đang chọn: " + dangChon.Count;
            lblTamTinh.Text = "Tạm tính tiền: " + DinhDangTien(tamTinh);
            lblDanhSachChon.Text = "Vị trí: " + (dangChon.Count == 0 ? "(chưa chọn)" : NoiTenViTri(dangChon));
        }

        #endregion
    }
}
