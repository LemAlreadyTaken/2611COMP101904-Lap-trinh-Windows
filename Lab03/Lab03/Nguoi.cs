using System;

namespace Lab03_QuanLySinhVienOOP
{
    /// <summary>
    /// Class cha: chứa thông tin chung của một con người.
    /// </summary>
    public class Nguoi
    {
        private string _hoTen = string.Empty;
        private DateTime _ngaySinh;

        public string HoTen
        {
            get => _hoTen;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Họ tên không được để trống.");
                _hoTen = value.Trim();
            }
        }

        public DateTime NgaySinh
        {
            get => _ngaySinh;
            set
            {
                if (value.Date > DateTime.Today || value.Year < 1900)
                    throw new ArgumentException("Ngày sinh không hợp lệ.");
                _ngaySinh = value.Date;
            }
        }

        public Nguoi(string hoTen, DateTime ngaySinh)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
        }

        // virtual để class con có thể override
        public virtual string LayThongTin()
        {
            return $"Họ tên: {HoTen} | Ngày sinh: {NgaySinh:dd/MM/yyyy}";
        }
    }
}
