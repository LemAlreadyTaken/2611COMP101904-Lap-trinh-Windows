namespace QuanLyNhanVien
{
    /// <summary>
    /// Nhân viên kinh doanh: lương = lương cơ bản + 5% * doanh số.
    /// </summary>
    public class NhanVienKinhDoanh : NhanVien
    {
        public const double TY_LE_HOA_HONG = 0.05; // 5%

        private double doanhSo;
        public double DoanhSo
        {
            get => doanhSo;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Doanh số phải >= 0.");
                doanhSo = value;
            }
        }

        public NhanVienKinhDoanh(string maNV, string hoTen, double luongCoBan, double doanhSo)
            : base(maNV, hoTen, luongCoBan)
        {
            DoanhSo = doanhSo;
        }

        public override double TinhLuong()
        {
            return LuongCoBan + TY_LE_HOA_HONG * DoanhSo;
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine(
                $"{MaNV,-8}| {HoTen,-25}| {"Kinh doanh",-15}| {TinhLuong(),15:N0} VNĐ  (Doanh số: {DoanhSo:N0})");
        }
    }
}
