namespace QuanLyNhanVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<NhanVien> danhSach = new List<NhanVien>();

            Console.WriteLine("=== NHẬP DANH SÁCH NHÂN VIÊN BAN ĐẦU (tối thiểu 5) ===");
            NhapDanhSachNhanVien(danhSach, 5);

            ChayMenu(danhSach);
        }

        // =====================================================================
        // NHẬP DỮ LIỆU
        // Ghi chú: việc "chọn loại nhân viên để tạo đối tượng nào" bắt buộc phải
        // rẽ nhánh (switch) vì đây là bước NHẬP LIỆU, không phải bước xử lý/hiển
        // thị/tính toán trên danh sách (những chỗ đó phải dùng đa hình thuần túy).
        // =====================================================================
        static void NhapDanhSachNhanVien(List<NhanVien> danhSach, int soLuongToiThieu)
        {
            int soLuong = DocSoNguyen($"Nhập số lượng nhân viên muốn nhập (>= {soLuongToiThieu}): ", soLuongToiThieu, int.MaxValue);

            for (int i = 1; i <= soLuong; i++)
            {
                Console.WriteLine($"\n--- Nhân viên thứ {i} ---");
                NhanVien nv = NhapMotNhanVien();
                danhSach.Add(nv);
            }
        }

        static NhanVien NhapMotNhanVien()
        {
            while (true)
            {
                Console.WriteLine("Chọn loại nhân viên:");
                Console.WriteLine("  1. Nhân viên văn phòng");
                Console.WriteLine("  2. Nhân viên kinh doanh");
                Console.WriteLine("  3. Nhân viên thời vụ (bonus)");
                int loai = DocSoNguyen("Lựa chọn: ", 1, 3);

                try
                {
                    string maNV = DocChuoiKhacRong("Mã nhân viên: ");
                    string hoTen = DocChuoiKhacRong("Họ tên: ");
                    double luongCoBan = DocSoThuc("Lương cơ bản (> 0): ");

                    switch (loai)
                    {
                        case 1:
                            {
                                int soNgay = DocSoNguyen("Số ngày làm việc (0-31): ", 0, 31);
                                return new NhanVienVanPhong(maNV, hoTen, luongCoBan, soNgay);
                            }
                        case 2:
                            {
                                double doanhSo = DocSoThuc("Doanh số (>= 0): ");
                                return new NhanVienKinhDoanh(maNV, hoTen, luongCoBan, doanhSo);
                            }
                        default:
                            {
                                int soGio = DocSoNguyen("Số giờ làm (>= 0): ", 0, int.MaxValue);
                                double luongGio = DocSoThuc("Lương theo giờ (>= 0): ");
                                return new NhanVienThoiVu(maNV, hoTen, luongCoBan, soGio, luongGio);
                            }
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message} Vui lòng nhập lại nhân viên này.\n");
                }
            }
        }

        // =====================================================================
        // MENU CHÍNH
        // =====================================================================
        static void ChayMenu(List<NhanVien> danhSach)
        {
            bool thoat = false;
            while (!thoat)
            {
                Console.WriteLine("\n========== MENU ==========");
                Console.WriteLine("1. Xuất danh sách nhân viên");
                Console.WriteLine("2. Tìm nhân viên theo mã");
                Console.WriteLine("3. Tìm nhân viên có lương cao nhất");
                Console.WriteLine("4. Tính tổng lương công ty phải trả");
                Console.WriteLine("0. Thoát");
                int chon = DocSoNguyen("Chọn chức năng: ", 0, 4);

                switch (chon)
                {
                    case 1:
                        XuatDanhSach(danhSach);
                        break;
                    case 2:
                        TimTheoMa(danhSach);
                        break;
                    case 3:
                        TimLuongCaoNhat(danhSach);
                        break;
                    case 4:
                        TinhTongLuong(danhSach);
                        break;
                    case 0:
                        thoat = true;
                        Console.WriteLine("Tạm biệt!");
                        break;
                }
            }
        }

        // =====================================================================
        // CÁC CHỨC NĂNG — chỉ dùng nv.HienThiThongTin() / nv.TinhLuong() (ĐA HÌNH)
        // Không có if/switch nào kiểm tra kiểu cụ thể của nhân viên ở đây.
        // =====================================================================
        static void XuatDanhSach(List<NhanVien> danhSach)
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng.");
                return;
            }

            Console.WriteLine("\n----- DANH SÁCH NHÂN VIÊN -----");
            foreach (NhanVien nv in danhSach)
            {
                nv.HienThiThongTin(); // gọi đa hình: mỗi loại tự hiển thị theo cách riêng
            }
        }

        static void TimTheoMa(List<NhanVien> danhSach)
        {
            string ma = DocChuoiKhacRong("Nhập mã nhân viên cần tìm: ");

            NhanVien? found = danhSach.Find(nv => nv.MaNV.Equals(ma, StringComparison.OrdinalIgnoreCase));

            if (found == null)
            {
                Console.WriteLine($"Không tìm thấy nhân viên có mã '{ma}'.");
            }
            else
            {
                Console.WriteLine("Tìm thấy:");
                found.HienThiThongTin();
            }
        }

        static void TimLuongCaoNhat(List<NhanVien> danhSach)
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng.");
                return;
            }

            // Chỉ dựa vào TinhLuong() (đa hình) để so sánh, không quan tâm là lớp con nào.
            NhanVien caoNhat = danhSach[0];
            foreach (NhanVien nv in danhSach)
            {
                if (nv.TinhLuong() > caoNhat.TinhLuong())
                    caoNhat = nv;
            }

            Console.WriteLine("Nhân viên có lương cao nhất:");
            caoNhat.HienThiThongTin();
        }

        static void TinhTongLuong(List<NhanVien> danhSach)
        {
            double tong = 0;
            foreach (NhanVien nv in danhSach)
            {
                tong += nv.TinhLuong(); // đa hình
            }

            Console.WriteLine($"Tổng lương công ty phải trả: {tong:N0} VNĐ");
        }

        // =====================================================================
        // CÁC HÀM ĐỌC DỮ LIỆU AN TOÀN (helper nhập liệu)
        // =====================================================================
        static int DocSoNguyen(string thongBao, int min, int max)
        {
            while (true)
            {
                Console.Write(thongBao);
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int giaTri) && giaTri >= min && giaTri <= max)
                    return giaTri;

                Console.WriteLine($"Giá trị không hợp lệ, vui lòng nhập số nguyên trong khoảng [{min}, {max}].");
            }
        }

        static double DocSoThuc(string thongBao)
        {
            while (true)
            {
                Console.Write(thongBao);
                string? input = Console.ReadLine();
                if (double.TryParse(input, out double giaTri))
                    return giaTri;

                Console.WriteLine("Giá trị không hợp lệ, vui lòng nhập lại một số.");
            }
        }

        static string DocChuoiKhacRong(string thongBao)
        {
            while (true)
            {
                Console.Write(thongBao);
                string? input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    return input.Trim();

                Console.WriteLine("Giá trị không được để trống.");
            }
        }
    }
}
