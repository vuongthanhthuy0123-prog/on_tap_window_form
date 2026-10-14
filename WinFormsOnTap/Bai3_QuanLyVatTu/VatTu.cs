namespace Bai3_QuanLyVatTu
{
    /// <summary>
    /// Đối tượng Vật tư / Linh kiện (lưu tạm trên bộ nhớ RAM).
    /// </summary>
    public class VatTu
    {
        public string MaVT { get; set; }
        public string TenVT { get; set; }
        public string DonViTinh { get; set; }
        public decimal DonGia { get; set; }

        public VatTu(string maVT, string tenVT, string donViTinh, decimal donGia)
        {
            MaVT = maVT;
            TenVT = tenVT;
            DonViTinh = donViTinh;
            DonGia = donGia;
        }
    }
}
