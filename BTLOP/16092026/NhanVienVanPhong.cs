namespace QuanLyNhanVien
{
    /// <summary>
    /// Nhân viên văn phòng: lương = lương cơ bản + số ngày làm việc * đơn giá/ngày.
    /// Kế thừa từ NhanVien, minh họa Inheritance + Polymorphism.
    /// </summary>
    public class NhanVienVanPhong : NhanVien
    {
        public const double DON_GIA_NGAY = 200000; // 200.000 VNĐ / ngày

        private int soNgayLamViec;
        public int SoNgayLamViec
        {
            get => soNgayLamViec;
            set
            {
                if (value < 0 || value > 31)
                    throw new ArgumentException("Số ngày làm việc phải trong khoảng 0-31.");
                soNgayLamViec = value;
            }
        }

        public NhanVienVanPhong(string maNV, string hoTen, double luongCoBan, int soNgayLamViec)
            : base(maNV, hoTen, luongCoBan)
        {
            SoNgayLamViec = soNgayLamViec;
        }

        public override double TinhLuong()
        {
            return LuongCoBan + SoNgayLamViec * DON_GIA_NGAY;
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine(
                $"{MaNV,-8}| {HoTen,-25}| {"Văn phòng",-15}| {TinhLuong(),15:N0} VNĐ  (Số ngày làm: {SoNgayLamViec})");
        }
    }
}
