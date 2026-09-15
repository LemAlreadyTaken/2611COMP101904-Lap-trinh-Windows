namespace Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboKhoa.SelectedIndex = -1; // chưa chọn khoa mặc định
        }

        // Xử lý sự kiện khi nhấn nút Hiển thị
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra họ tên không rỗng
            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            // 2. Kiểm tra năm sinh: không rỗng, phải là số nguyên, trong khoảng 1900 - năm hiện tại
            string namSinhText = txtNamSinh.Text.Trim();
            if (string.IsNullOrEmpty(namSinhText) || !int.TryParse(namSinhText, out int namSinh))
            {
                MessageBox.Show("Năm sinh không được rỗng và phải là số nguyên.", "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamSinh.Focus();
                return;
            }

            int namHienTai = DateTime.Now.Year;
            if (namSinh < 1900 || namSinh > namHienTai)
            {
                MessageBox.Show($"Năm sinh phải nằm trong khoảng từ 1900 đến {namHienTai}.", "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamSinh.Focus();
                return;
            }

            // 3. Kiểm tra email không rỗng
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập email.", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // 4. Kiểm tra đã chọn giới tính chưa
            if (!radNam.Checked && !radNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính.", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";

            // 5. Kiểm tra đã chọn khoa/lớp chưa
            if (cboKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn khoa hoặc lớp.", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string khoa = cboKhoa.SelectedItem!.ToString()!;

            // Tính tuổi từ năm sinh
            int tuoi = namHienTai - namSinh;

            // Hiển thị kết quả tổng hợp lên lblKetQua
            lblKetQua.Text =
                "THÔNG TIN SINH VIÊN" + Environment.NewLine +
                $"Họ tên: {hoTen}" + Environment.NewLine +
                $"Tuổi: {tuoi}" + Environment.NewLine +
                $"Email: {email}" + Environment.NewLine +
                $"Giới tính: {gioiTinh}" + Environment.NewLine +
                $"Khoa/Lớp: {khoa}";
        }

        // Xử lý sự kiện khi nhấn nút Xóa: đưa form về trạng thái nhập liệu ban đầu
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtNamSinh.Clear();
            txtEmail.Clear();
            radNam.Checked = false;
            radNu.Checked = false;
            cboKhoa.SelectedIndex = -1;
            lblKetQua.Text = "";
            txtHoTen.Focus();
        }

        // Xử lý sự kiện khi nhấn nút Thoát: xác nhận trước khi đóng chương trình
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
