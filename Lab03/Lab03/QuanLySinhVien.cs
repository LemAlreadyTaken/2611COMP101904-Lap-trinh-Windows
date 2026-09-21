using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Lab03_QuanLySinhVienOOP
{
    /// <summary>
    /// Quản lý danh sách sinh viên. Main không được đụng trực tiếp vào List.
    /// </summary>
    public class QuanLySinhVien
    {
        private readonly List<SinhVien> _danhSach = new List<SinhVien>();

        // Trả về false nếu mã đã tồn tại
        public bool Them(SinhVien sv)
        {
            if (sv == null) return false;
            if (TimTheoMa(sv.MaSinhVien) != null) return false;

            _danhSach.Add(sv);
            return true;
        }

        // Trả về false nếu không tìm thấy mã
        public bool Sua(string maSinhVien, double diemMoi)
        {
            SinhVien? sv = TimTheoMa(maSinhVien);
            if (sv == null) return false;

            sv.DiemTrungBinh = diemMoi;
            return true;
        }

        // Trả về false nếu không tìm thấy mã
        public bool Xoa(string maSinhVien)
        {
            SinhVien? sv = TimTheoMa(maSinhVien);
            if (sv == null) return false;

            return _danhSach.Remove(sv);
        }

        // LINQ: FirstOrDefault
        public SinhVien? TimTheoMa(string maSinhVien)
        {
            string ma = (maSinhVien ?? string.Empty).Trim();
            return _danhSach.FirstOrDefault(sv =>
                string.Equals(sv.MaSinhVien, ma, StringComparison.OrdinalIgnoreCase));
        }

        // LINQ: Where - tìm theo từ khóa, không phân biệt hoa/thường và dấu
        public List<SinhVien> TimTheoTen(string tuKhoa)
        {
            string key = BoDau(tuKhoa ?? string.Empty).Trim();
            return _danhSach
                .Where(sv => BoDau(sv.HoTen).Contains(key, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // LINQ: OrderByDescending
        public List<SinhVien> SapXepTheoDiem()
        {
            return _danhSach
                .OrderByDescending(sv => sv.DiemTrungBinh)
                .ThenBy(sv => sv.HoTen)
                .ToList();
        }

        // LINQ: Where - sinh viên đạt (ĐTB >= 5)
        public List<SinhVien> LocSinhVienDat()
        {
            return _danhSach
                .Where(sv => sv.DiemTrungBinh >= 5)
                .ToList();
        }

        // Trả về bản chỉ đọc để bên ngoài không sửa được List gốc
        public IReadOnlyList<SinhVien> LayDanhSach()
        {
            return _danhSach.AsReadOnly();
        }

        // Bỏ dấu tiếng Việt: "Nguyễn" -> "Nguyen"
        private static string BoDau(string s)
        {
            string normalized = s.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();
            foreach (char c in normalized)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }
            return sb.ToString()
                     .Replace('đ', 'd')
                     .Replace('Đ', 'D')
                     .Normalize(NormalizationForm.FormC);
        }
    }
}
