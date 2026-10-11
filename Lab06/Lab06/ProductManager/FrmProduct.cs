using System.ComponentModel;
using System.Globalization;

namespace ProductManager
{
    public partial class FrmProduct : Form
    {
        // Danh sách gốc (toàn bộ sản phẩm). DataGridView chỉ hiển thị bản đã lọc qua bindingSource.
        private readonly List<Product> products = new List<Product>();
        private string keyword = string.Empty;          // từ khóa tìm kiếm hiện tại ("" = hiện tất cả)
        private string selectedImagePath = string.Empty; // đường dẫn ảnh đang chọn trên form
        private bool isBinding = false;                  // true khi đang gán lại dữ liệu cho lưới

        public FrmProduct()
        {
            InitializeComponent();
        }

        // =====================================================================
        // 1. LOAD FORM
        // =====================================================================
        private void FrmProduct_Load(object? sender, EventArgs e)
        {
            // Loại sản phẩm
            cboLoaiSP.Items.AddRange(new object[] { "Điện tử", "Văn phòng", "Gia dụng", "Thời trang" });
            cboLoaiSP.SelectedIndex = 0;

            // Giới hạn ô số: mặc định NumericUpDown chỉ cho tối đa 100 -> phải đặt lại
            numDonGia.Minimum = 0;
            numDonGia.Maximum = 1_000_000_000;
            numDonGia.DecimalPlaces = 0;
            numDonGia.Increment = 1000;
            numDonGia.ThousandsSeparator = true;

            numSoLuong.Minimum = 0;               // không cho số lượng âm
            numSoLuong.Maximum = 1_000_000;
            numSoLuong.DecimalPlaces = 0;         // không cho số lẻ
            numSoLuong.Increment = 1;

            tstTimKiem.TextBox.PlaceholderText = "Nhập mã hoặc tên...";

            SetupGrid();
            LoadSampleData();
            dgvProducts.DataSource = bindingSource;

            RefreshView();
            ClearInput();
            UpdateStatus("Sẵn sàng");
        }

        private void SetupGrid()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.Columns.Clear();

            DataGridViewCellStyle right = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                Format = "N0"
            };

            dgvProducts.Columns.AddRange(
                new DataGridViewTextBoxColumn { Name = "colMaSP", HeaderText = "Mã SP", DataPropertyName = nameof(Product.MaSP), Width = 90 },
                new DataGridViewTextBoxColumn { Name = "colTenSP", HeaderText = "Tên sản phẩm", DataPropertyName = nameof(Product.TenSP), AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
                new DataGridViewTextBoxColumn { Name = "colLoaiSP", HeaderText = "Loại", DataPropertyName = nameof(Product.LoaiSP), Width = 110 },
                new DataGridViewTextBoxColumn { Name = "colDonGia", HeaderText = "Đơn giá", DataPropertyName = nameof(Product.DonGia), Width = 120, DefaultCellStyle = right },
                new DataGridViewTextBoxColumn { Name = "colSoLuong", HeaderText = "Số lượng", DataPropertyName = nameof(Product.SoLuong), Width = 90, DefaultCellStyle = right },
                new DataGridViewTextBoxColumn { Name = "colNgayNhap", HeaderText = "Ngày nhập", DataPropertyName = nameof(Product.NgayNhap), Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } },
                new DataGridViewCheckBoxColumn { Name = "colConKinhDoanh", HeaderText = "Kinh doanh", DataPropertyName = nameof(Product.ConKinhDoanh), Width = 90 },
                new DataGridViewTextBoxColumn { Name = "colThanhTien", HeaderText = "Thành tiền", DataPropertyName = nameof(Product.ThanhTien), Width = 130, DefaultCellStyle = right }
            );

            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;

            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProducts.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
        }

        private void LoadSampleData()
        {
            products.Add(new Product { MaSP = "SP01", TenSP = "Chuột không dây", LoaiSP = "Điện tử", DonGia = 150000, SoLuong = 20, NgayNhap = DateTime.Today.AddDays(-10), ConKinhDoanh = true });
            products.Add(new Product { MaSP = "SP02", TenSP = "Bút bi", LoaiSP = "Văn phòng", DonGia = 5000, SoLuong = 100, NgayNhap = DateTime.Today.AddDays(-5), ConKinhDoanh = true });
            products.Add(new Product { MaSP = "SP03", TenSP = "Nồi cơm điện", LoaiSP = "Gia dụng", DonGia = 850000, SoLuong = 8, NgayNhap = DateTime.Today.AddDays(-20), ConKinhDoanh = true });
            products.Add(new Product { MaSP = "SP04", TenSP = "Áo thun nam", LoaiSP = "Thời trang", DonGia = 199000, SoLuong = 0, NgayNhap = DateTime.Today.AddDays(-30), ConKinhDoanh = false });
        }

        // =====================================================================
        // 2. THÊM
        // =====================================================================
        private void btnThem_Click(object? sender, EventArgs e)
        {
            // Đang chọn một dòng (mã bị khóa) thì không thể thêm -> tránh thêm trùng/nhầm
            if (GetSelectedProduct() != null)
            {
                MessageBox.Show("Bạn đang chọn một sản phẩm trong danh sách.\nNhấn \"Làm mới\" để nhập sản phẩm mới.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateInput(null)) return;

            Product p = new Product
            {
                MaSP = txtMaSP.Text.Trim(),
                TenSP = txtTenSP.Text.Trim(),
                LoaiSP = cboLoaiSP.Text,
                DonGia = numDonGia.Value,
                SoLuong = (int)numSoLuong.Value,
                NgayNhap = dtpNgayNhap.Value.Date,
                ConKinhDoanh = chkConKinhDoanh.Checked,
                DuongDanAnh = selectedImagePath
            };
            products.Add(p);

            // Xóa bộ lọc để sản phẩm mới chắc chắn hiện trên lưới
            keyword = string.Empty;
            tstTimKiem.Text = string.Empty;

            RefreshView();
            ClearInput();
            UpdateStatus($"Đã thêm sản phẩm {p.MaSP}");
        }

        // =====================================================================
        // 3. SỬA
        // =====================================================================
        private void btnSua_Click(object? sender, EventArgs e)
        {
            Product? p = GetSelectedProduct();
            if (p == null)
            {
                ShowSelectProductMessage();
                return;
            }

            if (!ValidateInput(p)) return;

            // Mã sản phẩm bị khóa khi sửa nên không đổi MaSP
            p.TenSP = txtTenSP.Text.Trim();
            p.LoaiSP = cboLoaiSP.Text;
            p.DonGia = numDonGia.Value;
            p.SoLuong = (int)numSoLuong.Value;
            p.NgayNhap = dtpNgayNhap.Value.Date;
            p.ConKinhDoanh = chkConKinhDoanh.Checked;
            p.DuongDanAnh = selectedImagePath;

            RefreshView();
            if (!SelectProduct(p)) ClearInput(); // sản phẩm không còn khớp bộ lọc tìm kiếm
            UpdateStatus($"Đã cập nhật sản phẩm {p.MaSP}");
        }

        // Menu chuột phải -> Sửa: đưa dữ liệu lên form để chỉnh sửa
        private void cmsSua_Click(object? sender, EventArgs e)
        {
            Product? p = GetSelectedProduct();
            if (p == null)
            {
                ShowSelectProductMessage();
                return;
            }

            LoadProductToForm(p);
            txtTenSP.Focus();
            UpdateStatus($"Đang sửa {p.MaSP}: chỉnh dữ liệu rồi nhấn \"Sửa\" để lưu");
        }

        // =====================================================================
        // 4. XÓA
        // =====================================================================
        private void btnXoa_Click(object? sender, EventArgs e)
        {
            Product? p = GetSelectedProduct();
            if (p == null)
            {
                ShowSelectProductMessage();
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa sản phẩm \"{p.TenSP}\" ({p.MaSP})?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            products.Remove(p);
            RefreshView();
            ClearInput();
            UpdateStatus($"Đã xóa sản phẩm {p.MaSP}");
        }

        // =====================================================================
        // 5. TÌM KIẾM
        // =====================================================================
        private void btnTimKiem_Click(object? sender, EventArgs e)
        {
            keyword = tstTimKiem.Text.Trim();
            RefreshView();
            ClearInput();

            if (keyword.Length == 0)
                UpdateStatus("Đã hiển thị toàn bộ danh sách");
            else
                UpdateStatus($"Tìm thấy {bindingSource.Count} sản phẩm với từ khóa \"{keyword}\"");
        }

        private void mnuTimKiem_Click(object? sender, EventArgs e)
        {
            tstTimKiem.Focus();
            UpdateStatus("Nhập mã hoặc tên sản phẩm rồi nhấn Enter để tìm");
        }

        private void tstTimKiem_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // tránh tiếng "bíp"
                btnTimKiem_Click(sender, EventArgs.Empty);
            }
        }

        // =====================================================================
        // 6. LÀM MỚI
        // =====================================================================
        private void btnLamMoi_Click(object? sender, EventArgs e)
        {
            keyword = string.Empty;
            tstTimKiem.Text = string.Empty;
            RefreshView();
            ClearInput();
            UpdateStatus("Đã làm mới dữ liệu");
        }

        // =====================================================================
        // 7. CHỌN ẢNH
        // =====================================================================
        private void btnChonAnh_Click(object? sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Chọn ảnh sản phẩm";
            dialog.Filter = "Ảnh (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            dialog.CheckFileExists = true;

            if (dialog.ShowDialog() != DialogResult.OK) return;

            Image? img = LoadImage(dialog.FileName);
            if (img == null)
            {
                MessageBox.Show("Không đọc được file này. Vui lòng chọn một file ảnh hợp lệ.",
                    "Lỗi ảnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedImagePath = dialog.FileName;
            SetPicture(img);
            UpdateStatus("Đã chọn ảnh (nhấn Thêm/Sửa để lưu cùng sản phẩm)");
        }

        // =====================================================================
        // MENU / CONTEXT MENU / SỰ KIỆN CHUỘT - BÀN PHÍM
        // =====================================================================
        private void mnuXemChiTiet_Click(object? sender, EventArgs e)
        {
            Product? p = GetSelectedProduct();
            if (p == null)
            {
                ShowSelectProductMessage();
                return;
            }

            string trangThai = p.ConKinhDoanh ? "Còn kinh doanh" : "Ngừng kinh doanh";
            string anh = string.IsNullOrEmpty(p.DuongDanAnh) ? "(không có)" : p.DuongDanAnh;

            MessageBox.Show(
                $"Mã SP: {p.MaSP}\n" +
                $"Tên SP: {p.TenSP}\n" +
                $"Loại: {p.LoaiSP}\n" +
                $"Đơn giá: {p.DonGia:N0} VND\n" +
                $"Số lượng: {p.SoLuong}\n" +
                $"Ngày nhập: {p.NgayNhap:dd/MM/yyyy}\n" +
                $"Trạng thái: {trangThai}\n" +
                $"Thành tiền: {p.ThanhTien:N0} VND\n" +
                $"Ảnh: {anh}",
                "Chi tiết sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuThoat_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void mnuGioiThieu_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("ProductManager - Quản lý sản phẩm\nCOMP1019 - Lập trình trên Windows",
                "Giới thiệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Chỉ cho nhập chữ số vào ô Đơn giá / Số lượng (chặn chữ, dấu trừ, dấu chấm khi gõ).
        // Dán chữ từ clipboard vẫn lọt qua -> ValidateInput kiểm tra lại.
        private void NumericOnly_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (e.KeyChar < '0' || e.KeyChar > '9'))
                e.Handled = true;
        }

        // Chuột phải vào dòng nào thì chọn dòng đó (mặc định chuột phải KHÔNG chọn dòng)
        private void dgvProducts_CellMouseDown(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right || e.RowIndex < 0) return;

            dgvProducts.CurrentCell = dgvProducts.Rows[e.RowIndex].Cells[0];
            dgvProducts.Rows[e.RowIndex].Selected = true;
        }

        // Không có dòng nào được chọn thì không mở menu chuột phải
        private void cmsGrid_Opening(object? sender, CancelEventArgs e)
        {
            e.Cancel = GetSelectedProduct() == null;
        }

        private void dgvProducts_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) mnuXemChiTiet_Click(sender, EventArgs.Empty);
        }

        private void dgvProducts_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
                btnXoa_Click(sender, EventArgs.Empty);
            }
        }

        // Chọn dòng nào (bằng chuột hoặc phím mũi tên) thì đưa dữ liệu lên form
        private void dgvProducts_SelectionChanged(object? sender, EventArgs e)
        {
            if (isBinding) return;

            Product? p = GetSelectedProduct();
            if (p != null)
                LoadProductToForm(p);
            else
                txtMaSP.ReadOnly = false;
        }

        // =====================================================================
        // HÀM HỖ TRỢ
        // =====================================================================

        // Lọc danh sách theo keyword rồi gán lại cho lưới. Sau khi gọi, KHÔNG có dòng nào được chọn.
        private void RefreshView()
        {
            isBinding = true;
            try
            {
                IEnumerable<Product> query = products;
                if (keyword.Length > 0)
                {
                    query = query.Where(p =>
                        p.MaSP.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                        p.TenSP.Contains(keyword, StringComparison.OrdinalIgnoreCase));
                }

                bindingSource.DataSource = new BindingList<Product>(query.ToList());
                dgvProducts.ClearSelection();
                dgvProducts.CurrentCell = null;
            }
            finally
            {
                isBinding = false;
            }

            txtMaSP.ReadOnly = GetSelectedProduct() != null;
        }

        // Lấy sản phẩm đang chọn trên lưới (null nếu chưa chọn dòng nào)
        private Product? GetSelectedProduct()
        {
            if (dgvProducts.SelectedRows.Count != 1) return null;
            return dgvProducts.SelectedRows[0].DataBoundItem as Product;
        }

        // Chọn lại một sản phẩm cụ thể trên lưới; trả về false nếu nó không có trong danh sách đang hiển thị
        private bool SelectProduct(Product p)
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (ReferenceEquals(row.DataBoundItem, p))
                {
                    dgvProducts.CurrentCell = row.Cells[0];
                    row.Selected = true;
                    return true;
                }
            }
            return false;
        }

        private void ShowSelectProductMessage()
        {
            MessageBox.Show("Vui lòng chọn một sản phẩm trong danh sách.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadProductToForm(Product p)
        {
            errorProvider1.Clear();

            txtMaSP.Text = p.MaSP;
            txtMaSP.ReadOnly = true; // không cho đổi mã khi đang sửa
            txtTenSP.Text = p.TenSP;
            cboLoaiSP.SelectedIndex = cboLoaiSP.Items.IndexOf(p.LoaiSP);
            SetNumeric(numDonGia, p.DonGia);
            SetNumeric(numSoLuong, p.SoLuong);
            dtpNgayNhap.Value = p.NgayNhap < dtpNgayNhap.MinDate ? dtpNgayNhap.MinDate : p.NgayNhap;
            chkConKinhDoanh.Checked = p.ConKinhDoanh;

            selectedImagePath = p.DuongDanAnh;
            SetPicture(LoadImage(p.DuongDanAnh));
        }

        // Xóa nội dung nhập, bỏ lỗi ErrorProvider, bỏ chọn dòng, mở khóa ô mã
        private void ClearInput()
        {
            errorProvider1.Clear();

            txtMaSP.Clear();
            txtMaSP.ReadOnly = false;
            txtTenSP.Clear();
            cboLoaiSP.SelectedIndex = 0;
            SetNumeric(numDonGia, 0);
            SetNumeric(numSoLuong, 0);
            dtpNgayNhap.Value = DateTime.Today;
            chkConKinhDoanh.Checked = true;

            selectedImagePath = string.Empty;
            SetPicture(null);

            dgvProducts.ClearSelection();
            dgvProducts.CurrentCell = null;
            txtMaSP.Focus();
        }

        private void UpdateStatus(string message)
        {
            lblStatus.Text = message;
            lblCount.Text = keyword.Length == 0
                ? $"Số sản phẩm: {products.Count}"
                : $"Hiển thị {bindingSource.Count}/{products.Count} sản phẩm";
        }

        // Ép giá trị vào NumericUpDown và làm mới cả phần chữ hiển thị
        private static void SetNumeric(NumericUpDown nud, decimal value)
        {
            nud.Value = Math.Clamp(value, nud.Minimum, nud.Maximum);
            string text = nud.Value.ToString(nud.ThousandsSeparator ? "N0" : "F0", CultureInfo.CurrentCulture);
            if (nud.Text != text) nud.Text = text;
        }

        // Đọc ảnh vào bộ nhớ rồi đóng file ngay (Image.FromFile sẽ khóa file ảnh)
        private static Image? LoadImage(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path)) return null;

            try
            {
                using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                using Image img = Image.FromStream(fs);
                return new Bitmap(img);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void SetPicture(Image? img)
        {
            Image? old = picSanPham.Image;
            picSanPham.Image = img;
            old?.Dispose();
        }

        // =====================================================================
        // VALIDATION
        // editing = null khi THÊM; = sản phẩm đang sửa khi SỬA (để bỏ qua chính nó khi kiểm tra trùng mã)
        // Đọc từ phần Text của ô số (không dùng .Value) vì .Value có thể chưa cập nhật
        // khi người dùng vừa gõ xong mà chưa rời khỏi ô.
        // =====================================================================
        private bool ValidateInput(Product? editing)
        {
            errorProvider1.Clear();
            List<string> errors = new List<string>();
            Control? firstError = null;

            void AddError(Control control, string message)
            {
                errorProvider1.SetError(control, message);
                errors.Add("- " + message);
                firstError ??= control;
            }

            // Mã SP
            string ma = txtMaSP.Text.Trim();
            if (ma.Length == 0)
            {
                AddError(txtMaSP, "Mã sản phẩm không được rỗng");
            }
            else if (products.Any(p => !ReferenceEquals(p, editing) &&
                                       string.Equals(p.MaSP, ma, StringComparison.OrdinalIgnoreCase)))
            {
                AddError(txtMaSP, "Mã sản phẩm đã tồn tại");
            }

            // Tên SP
            if (txtTenSP.Text.Trim().Length == 0)
                AddError(txtTenSP, "Tên sản phẩm không được rỗng");

            // Loại SP
            if (cboLoaiSP.SelectedIndex < 0)
                AddError(cboLoaiSP, "Vui lòng chọn loại sản phẩm");

            // Đơn giá
            if (!decimal.TryParse(numDonGia.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out decimal donGia))
                AddError(numDonGia, "Đơn giá phải là số (không được nhập chữ)");
            else if (donGia <= 0)
                AddError(numDonGia, "Đơn giá phải lớn hơn 0");
            else if (donGia != decimal.Truncate(donGia))
                AddError(numDonGia, "Đơn giá phải là số nguyên (VND)");
            else if (donGia > numDonGia.Maximum)
                AddError(numDonGia, $"Đơn giá tối đa là {numDonGia.Maximum:N0}");
            else
                SetNumeric(numDonGia, donGia); // chốt giá trị vào .Value

            // Số lượng
            if (!int.TryParse(numSoLuong.Text.Trim(), NumberStyles.Integer, CultureInfo.CurrentCulture, out int soLuong))
                AddError(numSoLuong, "Số lượng phải là số nguyên (không nhập chữ hoặc số lẻ)");
            else if (soLuong < 0)
                AddError(numSoLuong, "Số lượng phải lớn hơn hoặc bằng 0");
            else if (soLuong > numSoLuong.Maximum)
                AddError(numSoLuong, $"Số lượng tối đa là {numSoLuong.Maximum:N0}");
            else
                SetNumeric(numSoLuong, soLuong);

            // Ngày nhập
            if (dtpNgayNhap.Value.Date > DateTime.Today)
                AddError(dtpNgayNhap, "Ngày nhập không được lớn hơn ngày hiện tại");

            if (errors.Count > 0)
            {
                MessageBox.Show("Dữ liệu chưa hợp lệ:\n" + string.Join("\n", errors),
                    "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                firstError?.Focus();
                return false;
            }

            return true;
        }
    }
}
