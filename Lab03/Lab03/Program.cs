using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Lab03_QuanLySinhVienOOP
{
    internal class Program
    {
        private static readonly QuanLySinhVien _quanLy = new QuanLySinhVien();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            bool tiepTuc = true;
            while (tiepTuc)
            {
                HienThiMenu();
                string luaChon = (Console.ReadLine() ?? string.Empty).Trim();
                Console.WriteLine();

                switch (luaChon)
                {
                    case "1": ThemSinhVien(); break;
                    case "2": XuatDanhSach(); break;
                    case "3": TimTheoMa(); break;
                    case "4": TimTheoTen(); break;
                    case "5": SuaDiem(); break;
                    case "6": XoaSinhVien(); break;
                    case "7": SapXepTheoDiem(); break;
                    case "8": LocSinhVienDat(); break;
                    case "0":
                        Console.WriteLine("Tạm biệt!");
                        tiepTuc = false;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại.");
                        break;
                }

                if (tiepTuc)
                {
                    Console.WriteLine();
                    Console.Write("Nhấn Enter để tiếp tục...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        #region Menu

        private static void HienThiMenu()
        {
            Console.WriteLine("===== QUAN LY SINH VIEN =====");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. Xuat danh sach");
            Console.WriteLine("3. Tim sinh vien theo ma");
            Console.WriteLine("4. Tim sinh vien theo ten");
            Console.WriteLine("5. Sua diem trung binh");
            Console.WriteLine("6. Xoa sinh vien");
            Console.WriteLine("7. Sap xep theo diem giam dan");
            Console.WriteLine("8. Loc sinh vien dat");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon chuc nang: ");
        }

        #endregion

        #region Các chức năng

        private static void ThemSinhVien()
        {
            Console.WriteLine("--- Thêm sinh viên ---");
            string ma = NhapChuoi("Mã sinh viên: ");

            // Báo trùng sớm, khỏi bắt người dùng nhập thêm các trường khác
            if (_quanLy.TimTheoMa(ma) != null)
            {
                Console.WriteLine($"Mã sinh viên {ma.ToUpper()} đã tồn tại.");
                return;
            }

            string hoTen = NhapChuoi("Họ tên: ");
            DateTime ngaySinh = NhapNgaySinh("Ngày sinh (dd/MM/yyyy): ");
            string maLop = NhapChuoi("Mã lớp: ");
            double diem = NhapDiem("Điểm trung bình (0 - 10): ");

            try
            {
                var sv = new SinhVien(ma, hoTen, ngaySinh, maLop, diem);
                if (_quanLy.Them(sv))
                    Console.WriteLine($"Thêm thành công. Xếp loại: {sv.XepLoai()}.");
                else
                    Console.WriteLine($"Mã sinh viên {sv.MaSinhVien} đã tồn tại.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Dữ liệu không hợp lệ: " + ex.Message);
            }
        }

        private static void XuatDanhSach()
        {
            Console.WriteLine("--- Danh sách sinh viên ---");
            InDanhSach(_quanLy.LayDanhSach());
        }

        private static void TimTheoMa()
        {
            Console.WriteLine("--- Tìm theo mã ---");
            string ma = NhapChuoi("Nhập mã sinh viên: ");

            SinhVien? sv = _quanLy.TimTheoMa(ma);
            if (sv == null)
                Console.WriteLine("Không tìm thấy sinh viên có mã " + ma.ToUpper() + ".");
            else
                Console.WriteLine(sv.LayThongTin());
        }

        private static void TimTheoTen()
        {
            Console.WriteLine("--- Tìm theo tên ---");
            string tuKhoa = NhapChuoi("Nhập từ khóa họ tên: ");

            var ketQua = _quanLy.TimTheoTen(tuKhoa);
            if (ketQua.Count == 0)
                Console.WriteLine("Không tìm thấy sinh viên nào.");
            else
                InDanhSach(ketQua);
        }

        private static void SuaDiem()
        {
            Console.WriteLine("--- Sửa điểm trung bình ---");
            string ma = NhapChuoi("Nhập mã sinh viên: ");

            if (_quanLy.TimTheoMa(ma) == null)
            {
                Console.WriteLine("Không tìm thấy sinh viên có mã " + ma.ToUpper() + ".");
                return;
            }

            double diemMoi = NhapDiem("Nhập điểm mới (0 - 10): ");
            if (_quanLy.Sua(ma, diemMoi))
                Console.WriteLine("Cập nhật điểm thành công.");
            else
                Console.WriteLine("Cập nhật thất bại.");
        }

        private static void XoaSinhVien()
        {
            Console.WriteLine("--- Xóa sinh viên ---");
            string ma = NhapChuoi("Nhập mã sinh viên: ");

            if (_quanLy.Xoa(ma))
                Console.WriteLine("Đã xóa sinh viên " + ma.ToUpper() + ".");
            else
                Console.WriteLine("Không tìm thấy sinh viên có mã " + ma.ToUpper() + ".");
        }

        private static void SapXepTheoDiem()
        {
            Console.WriteLine("--- Danh sách sắp xếp theo điểm giảm dần ---");
            InDanhSach(_quanLy.SapXepTheoDiem());
        }

        private static void LocSinhVienDat()
        {
            Console.WriteLine("--- Sinh viên đạt (ĐTB >= 5) ---");
            InDanhSach(_quanLy.LocSinhVienDat());
        }

        #endregion

        #region In dữ liệu

        private static void InDanhSach(IReadOnlyList<SinhVien> danhSach)
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sách trống.");
                return;
            }

            string dong = new string('-', 78);
            Console.WriteLine(dong);
            Console.WriteLine("{0,-10} {1,-26} {2,-10} {3,-6} {4,-12}", "Mã SV", "Họ tên", "Lớp", "Điểm", "Xếp loại");
            Console.WriteLine(dong);
            foreach (SinhVien sv in danhSach)
            {
                Console.WriteLine("{0,-10} {1,-26} {2,-10} {3,-6:0.0} {4,-12}",
                    sv.MaSinhVien, sv.HoTen, sv.MaLop, sv.DiemTrungBinh, sv.XepLoai());
            }
            Console.WriteLine(dong);
            Console.WriteLine($"Tổng: {danhSach.Count} sinh viên.");
        }

        #endregion

        #region Hàm nhập dữ liệu (không bị crash khi nhập sai)

        private static string NhapChuoi(string thongBao)
        {
            while (true)
            {
                Console.Write(thongBao);
                string s = (Console.ReadLine() ?? string.Empty).Trim();
                if (s.Length > 0) return s;
                Console.WriteLine("Không được để trống, vui lòng nhập lại.");
            }
        }

        private static DateTime NhapNgaySinh(string thongBao)
        {
            while (true)
            {
                Console.Write(thongBao);
                string s = (Console.ReadLine() ?? string.Empty).Trim();

                if (!DateTime.TryParseExact(s, "d/M/yyyy", CultureInfo.InvariantCulture,
                        DateTimeStyles.None, out DateTime ngay))
                {
                    Console.WriteLine("Ngày sinh sai định dạng (dd/MM/yyyy), vui lòng nhập lại.");
                    continue;
                }

                if (ngay.Date > DateTime.Today || ngay.Year < 1900)
                {
                    Console.WriteLine("Ngày sinh không hợp lệ, vui lòng nhập lại.");
                    continue;
                }

                return ngay;
            }
        }

        private static double NhapDiem(string thongBao)
        {
            while (true)
            {
                Console.Write(thongBao);
                // Cho phép nhập cả "8.2" lẫn "8,2"
                string s = (Console.ReadLine() ?? string.Empty).Trim().Replace(',', '.');

                if (!double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out double diem))
                {
                    Console.WriteLine("Điểm phải là số, vui lòng nhập lại.");
                    continue;
                }

                if (diem < SinhVien.DiemToiThieu || diem > SinhVien.DiemToiDa)
                {
                    Console.WriteLine("Điểm không hợp lệ (phải từ 0 đến 10), vui lòng nhập lại.");
                    continue;
                }

                return diem;
            }
        }

        #endregion
    }
}
