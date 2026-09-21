### Lab03 - C# và lập trình hướng đối tượng: quản lý sinh viên bằng Console

## Thông tin sinh viên

- Họ tên: Nguyễn Đan Trường
- MSSV: 51.01.104.110
- Lớp: 51.01.CNTT.A

## Mô tả

Chương trình Console C# quản lý sinh viên theo hướng đối tượng. Dữ liệu lưu trong bộ nhớ bằng `List<SinhVien>`, thao tác qua menu.

Cấu trúc project:

```
Lab03_QuanLySinhVienOOP
|-- Nguoi.cs            (class cha: HoTen, NgaySinh, LayThongTin() virtual)
|-- SinhVien.cs         (kế thừa Nguoi: MaSinhVien, MaLop, DiemTrungBinh, XepLoai(), override LayThongTin())
|-- QuanLySinhVien.cs   (service: Them, Sua, Xoa, TimTheoMa, TimTheoTen, SapXepTheoDiem, LocSinhVienDat, LayDanhSach)
|-- Program.cs          (Main, menu, các hàm nhập dữ liệu)
```

Điểm chính:

- Kế thừa: `SinhVien : Nguoi`, có constructor `base(...)` và `override LayThongTin()`.
- Validation bằng property: `DiemTrungBinh` chỉ nhận 0-10, `HoTen`/`MaSinhVien`/`MaLop` không được rỗng, `NgaySinh` không ở tương lai.
- LINQ: `FirstOrDefault` (tìm theo mã), `Where` (tìm theo tên, lọc đạt), `OrderByDescending` (sắp xếp).
- Nhập sai kiểu dữ liệu (chữ thay vì số, sai định dạng ngày) không làm chương trình dừng, chỉ yêu cầu nhập lại.
- Tìm theo tên không phân biệt hoa/thường và dấu (gõ "nguyen" vẫn tìm ra "Nguyễn").

Thang xếp loại: >= 9.0 Xuất sắc, >= 8.0 Giỏi, >= 6.5 Khá, >= 5.0 Trung bình, còn lại Yếu.

## Chức năng

- 1. Thêm sinh viên (mã không được trùng)
- 2. Xuất danh sách (mã, họ tên, lớp, điểm, xếp loại)
- 3. Tìm sinh viên theo mã
- 4. Tìm sinh viên theo tên (theo từ khóa)
- 5. Sửa điểm trung bình
- 6. Xóa sinh viên
- 7. Sắp xếp theo điểm giảm dần
- 8. Lọc sinh viên đạt (điểm >= 5)
- 0. Thoát

## Cách chạy

1. Mở `Lab03_QuanLySinhVienOOP.csproj` bằng Visual Studio (hoặc tạo Console App C# rồi thêm 4 file `.cs`).
2. Nhấn `Ctrl + F5` để chạy.
3. Hoặc chạy bằng terminal tại thư mục project: `dotnet run`.

## Hình ảnh minh họa chương trình

### 1. Menu chính
![Menu](images/Menu.png)

### 2. Thêm sinh viên và báo trùng mã
![ThemSinhVien](images/ThemSinhVien.png)
![ThemSinhVien](images/ThemSinhVienTrung.png)


### 3. Nhập điểm không hợp lệ (-1, 11)
![NhapDiemSai](images/NhapDiemSai.png)

### 4. Xuất danh sách
![XuatDanhSach](images/XuatDanhSach.png)

### 5. Tìm theo mã và tìm theo tên
![TimKiem](images/TimKiemMa.png)
![TimKiem](images/TimKiemTen.png)


### 6. Sửa điểm và xóa sinh viên
![SuaXoa](images/Sua.png)
![SuaXoa](images/Xoa.png)


### 7. Sắp xếp theo điểm giảm dần
![SapXep](images/SapXep.png)

### 8. Lọc sinh viên đạt
![LocDat](images/LocDat.png)
