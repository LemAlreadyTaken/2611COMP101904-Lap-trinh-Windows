using System;

namespace Lab02
{
    class Program
    {
        static int[] mang = null;
        static bool daNhapMang = false;

        static void Main(string[] args)
        {
            int luaChon;
            do
            {
                HienThiMenu();
                luaChon = NhapLuaChonMenu();

                switch (luaChon)
                {
                    case 1:
                        mang = NhapMang();
                        daNhapMang = true;
                        Console.WriteLine("Nhap mang thanh cong!");
                        break;
                    case 2:
                        if (KiemTraDaNhapMang())
                            XuatMang(mang);
                        break;
                    case 3:
                        if (KiemTraDaNhapMang())
                            Console.WriteLine("Tong cac phan tu: " + TinhTong(mang));
                        break;
                    case 4:
                        if (KiemTraDaNhapMang())
                        {
                            Console.WriteLine("Gia tri lon nhat: " + TimMax(mang));
                            Console.WriteLine("Gia tri nho nhat: " + TimMin(mang));
                        }
                        break;
                    case 5:
                        if (KiemTraDaNhapMang())
                        {
                            Console.WriteLine("So luong so chan: " + DemChan(mang));
                            Console.WriteLine("So luong so le: " + DemLe(mang));
                        }
                        break;
                    case 6:
                        if (KiemTraDaNhapMang())
                        {
                            SapXepTangDan(mang);
                            Console.WriteLine("Mang sau khi sap xep tang dan:");
                            XuatMang(mang);
                        }
                        break;
                    case 7:
                        if (KiemTraDaNhapMang())
                        {
                            int x = NhapSoNguyen("Nhap gia tri can tim x: ");
                            int viTri = TimKiem(mang, x);
                            if (viTri != -1)
                                Console.WriteLine($"Tim thay x = {x} tai vi tri {viTri}.");
                            else
                                Console.WriteLine($"Khong tim thay x = {x} trong mang.");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Chuong trinh ket thuc.");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                        break;
                }

                if (luaChon != 0)
                {
                    Console.WriteLine("\nNhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                }

            } while (luaChon != 0);
        }

        // Hien thi menu chuc nang
        static void HienThiMenu()
        {
            Console.Clear();
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. Nhap mang");
            Console.WriteLine("2. Xuat mang");
            Console.WriteLine("3. Tinh tong");
            Console.WriteLine("4. Tim max/min");
            Console.WriteLine("5. Dem chan/le");
            Console.WriteLine("6. Sap xep tang dan");
            Console.WriteLine("7. Tim kiem");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon chuc nang: ");
        }

        // Nhap lua chon menu, kiem tra hop le (chi can la so nguyen, khong bat buoc trong khoang 0-7
        // vi truong hop nhap sai se roi vao default trong switch)
        static int NhapLuaChonMenu()
        {
            string input = Console.ReadLine();
            int luaChon;
            if (!int.TryParse(input, out luaChon))
            {
                // Tra ve gia tri khong hop le de roi vao default, khong lam crash chuong trinh
                return -999;
            }
            return luaChon;
        }

        // Kiem tra da nhap mang truoc khi cho thuc hien cac chuc nang xu ly
        static bool KiemTraDaNhapMang()
        {
            if (!daNhapMang)
            {
                Console.WriteLine("Ban chua nhap mang. Vui long chon chuc nang 1 truoc.");
                return false;
            }
            return true;
        }

        // Nhap mot so nguyen bat ky, lap lai neu nhap sai dinh dang
        static int NhapSoNguyen(string message)
        {
            int soNguyen;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                if (int.TryParse(input, out soNguyen))
                    return soNguyen;
                Console.WriteLine("Du lieu khong hop le. Vui long nhap lai (so nguyen).");
            }
        }

        // Nhap mot so nguyen duong, lap lai neu nhap sai dinh dang hoac khong duong
        static int NhapSoNguyenDuong(string message)
        {
            int soNguyen;
            while (true)
            {
                soNguyen = NhapSoNguyen(message);
                if (soNguyen > 0)
                    return soNguyen;
                Console.WriteLine("Gia tri phai la so nguyen duong. Vui long nhap lai.");
            }
        }

        // Nhap so luong phan tu va gia tri tung phan tu cua mang
        static int[] NhapMang()
        {
            int n = NhapSoNguyenDuong("Nhap so luong phan tu n: ");
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = NhapSoNguyen($"Nhap phan tu thu {i}: ");
            }
            return a;
        }

        // In toan bo phan tu cua mang
        static void XuatMang(int[] a)
        {
            Console.Write("Mang: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        // Tinh tong cac phan tu trong mang
        static int TinhTong(int[] a)
        {
            int tong = 0;
            for (int i = 0; i < a.Length; i++)
            {
                tong += a[i];
            }
            return tong;
        }

        // Tim gia tri lon nhat trong mang
        static int TimMax(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            return max;
        }

        // Tim gia tri nho nhat trong mang
        static int TimMin(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            return min;
        }

        // Dem so luong phan tu chan trong mang
        static int DemChan(int[] a)
        {
            int dem = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                    dem++;
            }
            return dem;
        }

        // Dem so luong phan tu le trong mang
        static int DemLe(int[] a)
        {
            int dem = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                    dem++;
            }
            return dem;
        }

        // Sap xep mang tang dan (thuat toan selection sort)
        static void SapXepTangDan(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int viTriMin = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[viTriMin])
                        viTriMin = j;
                }
                if (viTriMin != i)
                {
                    int temp = a[i];
                    a[i] = a[viTriMin];
                    a[viTriMin] = temp;
                }
            }
        }

        // Tim kiem gia tri x trong mang, tra ve vi tri xuat hien dau tien hoac -1 neu khong co
        static int TimKiem(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                    return i;
            }
            return -1;
        }
    }
}
