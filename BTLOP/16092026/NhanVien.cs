namespace QuanLyNhanVien
{
    /// <summary>
    /// Lớp cơ sở đại diện cho một nhân viên nói chung.
    /// Thể hiện tính đóng gói (Encapsulation) thông qua các Property có kiểm tra dữ liệu.
    /// </summary>
    public class NhanVien
    {
        // ----- Thuộc tính (Encapsulation: field private, truy cập qua property) -----
        public string MaNV { get; set; }
        public string HoTen { get; set; }

        private double luongCoBan;
        public double LuongCoBan
        {
            get 
            {
                luongCoBan
            };
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Lương cơ bản phải lớn hơn 0.");
                luongCoBan = value;
            }
        }

        // ----- Constructor -----
        public NhanVien(string maNV, string hoTen, double luongCoBan)
        {
            MaNV = maNV;
            HoTen = hoTen;
            LuongCoBan = luongCoBan; // đi qua property để được kiểm tra hợp lệ
        }

        /// <summary>
        /// Tính lương. Lớp con sẽ override để tính theo công thức riêng (Đa hình).
        /// </summary>
        public virtual double TinhLuong()
        {
            return LuongCoBan;
        }

        /// <summary>
        /// Hiển thị thông tin nhân viên. Lớp con sẽ override (Đa hình).
        /// </summary>
        public virtual void HienThiThongTin()
        {
            Console.WriteLine(
                $"{MaNV,-8}| {HoTen,-25}| {"Nhân viên",-15}| {TinhLuong(),15:N0} VNĐ");
        }
    }
}
