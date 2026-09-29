using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var service = new ProductService();
            service.ProductAdded += p => Console.WriteLine($"[EVENT] Da them san pham: {p.MaSP} - {p.TenSP}");
            service.ProductRemoved += p => Console.WriteLine($"[EVENT] Da xoa san pham: {p.MaSP} - {p.TenSP}");

            while (true)
            {
                ShowMenu();
                string choice = ReadLine("Chon: ");

                try
                {
                    switch (choice)
                    {
                        case "1": HandleAdd(service); break;
                        case "2": HandleShowAll(service); break;
                        case "3": HandleFindById(service); break;
                        case "4": HandleFindByName(service); break;
                        case "5": HandleFilterByPrice(service); break;
                        case "6": HandleRemove(service); break;
                        case "7": Console.WriteLine($"Tong gia tri kho: {service.GetTotalValue():N0}"); break;
                        case "0": Console.WriteLine("Tam biet!"); return;
                        default: Console.WriteLine("Lua chon khong hop le."); break;
                    }
                }
                catch (DuplicateProductException ex)
                {
                    Console.WriteLine($"Loi trung ma: {ex.Message}");
                }
                catch (ProductNotFoundException ex)
                {
                    Console.WriteLine($"Loi khong ton tai: {ex.Message}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Du lieu khong hop le: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Loi khong xac dinh: {ex.Message}");
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("===== PRODUCT MANAGER =====");
            Console.WriteLine("1. Them san pham");
            Console.WriteLine("2. Xuat danh sach");
            Console.WriteLine("3. Tim theo ma");
            Console.WriteLine("4. Tim theo ten");
            Console.WriteLine("5. Loc theo khoang gia");
            Console.WriteLine("6. Xoa san pham");
            Console.WriteLine("7. Tinh tong gia tri kho");
            Console.WriteLine("0. Thoat");
        }

        static void HandleAdd(ProductService service)
        {
            // Kiem tra ma ngay sau khi nhap: rong/trung thi bao loi luon, khong bat nhap tiep.
            string ma = ReadLine("Ma san pham: ");
            service.EnsureIdAvailable(ma);

            string ten = ReadNonEmpty("Ten san pham: ");
            decimal price = ReadNonNegativeDecimal("Don gia: ");
            int quantity = ReadNonNegativeInt("So luong: ");

            service.AddProduct(new Product(ma, ten, price, quantity));
        }

        static void HandleShowAll(ProductService service)
        {
            PrintList(service.GetAll(), "Danh sach san pham rong.");
        }

        static void HandleFindById(ProductService service)
        {
            string ma = ReadNonEmpty("Nhap ma can tim: ");
            Product? product = service.FindById(ma);
            Console.WriteLine(product != null ? product.ToString() : "Khong tim thay san pham.");
        }

        static void HandleFindByName(ProductService service)
        {
            string keyword = ReadNonEmpty("Nhap tu khoa: ");
            PrintList(service.SearchByName(keyword), "Khong co san pham nao phu hop.");
        }

        static void HandleFilterByPrice(ProductService service)
        {
            decimal min = ReadNonNegativeDecimal("Gia nho nhat: ");
            decimal max;
            while (true)
            {
                max = ReadNonNegativeDecimal("Gia lon nhat: ");
                if (max >= min)
                    break;
                Console.WriteLine("Gia lon nhat phai >= gia nho nhat.");
            }

            PrintList(service.FilterByPrice(min, max), "Khong co san pham trong khoang gia nay.");
        }

        static void HandleRemove(ProductService service)
        {
            string ma = ReadNonEmpty("Nhap ma can xoa: ");
            service.RemoveProduct(ma);
        }

        static void PrintList(List<Product> list, string emptyMessage)
        {
            if (list.Count == 0)
            {
                Console.WriteLine(emptyMessage);
                return;
            }
            foreach (Product p in list)
                Console.WriteLine(p);
        }

        static string ReadLine(string prompt)
        {
            Console.Write(prompt);
            string? line = Console.ReadLine();
            if (line == null) // het input (Ctrl+Z / Ctrl+D): thoat de khong bi lap vo han
            {
                Console.WriteLine();
                Environment.Exit(0);
            }
            return line.Trim();
        }

        static string ReadNonEmpty(string prompt)
        {
            while (true)
            {
                string value = ReadLine(prompt);
                if (value.Length > 0)
                    return value;
                Console.WriteLine("Khong duoc de trong.");
            }
        }

        static int ReadNonNegativeInt(string prompt)
        {
            while (true)
            {
                if (!int.TryParse(ReadLine(prompt), out int value))
                    Console.WriteLine("Vui long nhap so nguyen hop le.");
                else if (value < 0)
                    Console.WriteLine("Khong duoc nhap so am.");
                else
                    return value;
            }
        }

        static decimal ReadNonNegativeDecimal(string prompt)
        {
            while (true)
            {
                if (!decimal.TryParse(ReadLine(prompt), out decimal value))
                    Console.WriteLine("Vui long nhap so hop le.");
                else if (value < 0)
                    Console.WriteLine("Khong duoc nhap so am.");
                else
                    return value;
            }
        }
    }
}
