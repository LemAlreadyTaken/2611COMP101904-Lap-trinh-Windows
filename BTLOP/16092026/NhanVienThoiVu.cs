namespace QuanLyNhanVien
{
    /// <summary>
    /// (Bonus) Nhân viên thời vụ: lương = số giờ làm * lương theo giờ.
    /// Chỉ cần thêm class này và kế thừa từ NhanVien; các thuật toán tìm lương cao nhất
    /// và tính tổng lương trong Program.cs KHÔNG cần sửa gì nhờ đa hình.
    /// </summary>
    public class NhanVienThoiVu : NhanVien
    {
        private int soGioLam;
        public int SoGioLam
        {
            get => soGioLam;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Số giờ làm phải >= 0.");
                soGioLam = value;
            }
        }

        private double luongTheoGio;
        public double LuongTheoGio
        {
            get => luongTheoGio;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Lương theo giờ phải >= 0.");
                luongTheoGio = value;
            }
        }

        // Lớp cơ sở yêu cầu LuongCoBan > 0, nhưng nhân viên thời vụ không dùng lương cơ bản
        // trong công thức tính lương. Ta vẫn truyền một giá trị hợp lệ (>0) cho base(...)
        // để thỏa constructor cha, còn lương thực tế do TinhLuong() override quyết định.
        public NhanVienThoiVu(string maNV, string hoTen, double luongCoBan, int soGioLam, double luongTheoGio)
            : base(maNV, hoTen, luongCoBan)
        {
            SoGioLam = soGioLam;
            LuongTheoGio = luongTheoGio;
        }

        public override double TinhLuong()
        {
            return SoGioLam * LuongTheoGio;
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine(
                $"{MaNV,-8}| {HoTen,-25}| {"Thời vụ",-15}| {TinhLuong(),15:N0} VNĐ  (Số giờ: {SoGioLam}, Lương/giờ: {LuongTheoGio:N0})");
        }
    }
}
