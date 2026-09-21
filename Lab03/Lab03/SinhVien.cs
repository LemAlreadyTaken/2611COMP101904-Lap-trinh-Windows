using System;

namespace Lab03_QuanLySinhVienOOP
{
    /// <summary>
    /// Sinh viên kế thừa từ Nguoi.
    /// </summary>
    public class SinhVien : Nguoi
    {
        public const double DiemToiThieu = 0;
        public const double DiemToiDa = 10;

        private string _maSinhVien = string.Empty;
        private string _maLop = string.Empty;
        private double _diemTrungBinh;

        // Mã sinh viên chỉ set trong constructor (không cho sửa sau khi tạo)
        public string MaSinhVien
        {
            get => _maSinhVien;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Mã sinh viên không được để trống.");
                _maSinhVien = value.Trim().ToUpper();
            }
        }

        public string MaLop
        {
            get => _maLop;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Mã lớp không được để trống.");
                _maLop = value.Trim().ToUpper();
            }
        }

        // Kiểm tra điểm trong khoảng 0 - 10
        public double DiemTrungBinh
        {
            get => _diemTrungBinh;
            set
            {
                if (double.IsNaN(value) || value < DiemToiThieu || value > DiemToiDa)
                    throw new ArgumentOutOfRangeException(nameof(DiemTrungBinh),
                        $"Điểm trung bình phải nằm trong khoảng {DiemToiThieu} - {DiemToiDa}.");
                _diemTrungBinh = value;
            }
        }

        public SinhVien(string maSinhVien, string hoTen, DateTime ngaySinh, string maLop, double diemTrungBinh)
            : base(hoTen, ngaySinh)
        {
            MaSinhVien = maSinhVien;
            MaLop = maLop;
            DiemTrungBinh = diemTrungBinh;
        }

        public string XepLoai()
        {
            if (DiemTrungBinh >= 9.0) return "Xuất sắc";
            if (DiemTrungBinh >= 8.0) return "Giỏi";
            if (DiemTrungBinh >= 6.5) return "Khá";
            if (DiemTrungBinh >= 5.0) return "Trung bình";
            return "Yếu";
        }

        public override string LayThongTin()
        {
            return $"Mã SV: {MaSinhVien} | {base.LayThongTin()} | Lớp: {MaLop} | ĐTB: {DiemTrungBinh:0.0} | Xếp loại: {XepLoai()}";
        }
    }
}
