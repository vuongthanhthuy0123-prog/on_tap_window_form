using System;
using System.Windows.Forms;

namespace Bai5_QuanLyDonGiaoHang
{
    internal static class Program
    {
        /// <summary>
        /// Điểm khởi chạy chính của ứng dụng.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmDonGiaoHang());
        }
    }
}
