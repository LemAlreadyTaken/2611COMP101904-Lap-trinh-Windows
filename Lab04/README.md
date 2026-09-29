### Lab04 - Exception, Delegate/Event, Func/Action và Generic trong C#

## Thông tin sinh viên
- Họ tên: Nguyễn Đan Trường
- MSSV: 51.01.104.110
- Lớp: 51.01.CNTT.A

## Mô tả
Chương trình Console C# quản lý sản phẩm, dữ liệu lưu trong bộ nhớ bằng `Repository<T>` (generic, ràng buộc `where T : IEntity`). Lỗi nhập liệu, mã trùng và sản phẩm không tồn tại được xử lý bằng exception (2 exception tự tạo: `DuplicateProductException`, `ProductNotFoundException`). `ProductService` phát event khi thêm/xóa thành công và dùng `Func<Product, bool>` để tìm kiếm/lọc.

## Chức năng
- Thêm sản phẩm (kiểm tra mã rỗng, mã trùng, giá/số lượng không âm)
- Xuất danh sách sản phẩm
- Tìm theo mã
- Tìm theo tên (theo từ khóa)
- Lọc theo khoảng giá (dùng `Func<Product, bool>`)
- Xóa sản phẩm (phát event khi xóa thành công)
- Tính tổng giá trị kho

## Hình ảnh minh họa chương trình
### 1. Menu chính
![Menu](Images/Menu.png)

### 2. Thêm sản phẩm
![ThemSanPham](Images/ThemSanPham.png)

### 3. Xuất danh sách
![XuatDanhSach](Images/XuatDanhSach.png)

### 4. Tìm theo mã / tên
![TimKiem1](Images/TimKiem1.png)
![TimKiem2](Images/TimKiem2.png)


### 5. Lọc theo khoảng giá
![LocTheoGia](Images/LocTheoGia.png)

### 6. Xóa sản phẩm
![XoaSanPham](Images/XoaSanPham.png)

### 7. Tổng giá trị kho
![TongGiaTri](Images/TongGiaTri.png)

### 8. Xử lý lỗi (mã trùng, không tồn tại, nhập sai)
![XuLyLoi1](Images/XuLyLoi1.png)
![XuLyLoi2](Images/XuLyLoi2.png)
![XuLyLoi3](Images/XuLyLoi3.png)

