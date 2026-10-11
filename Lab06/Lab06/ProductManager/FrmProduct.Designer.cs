namespace ProductManager
{
    partial class FrmProduct
    {
        private System.ComponentModel.IContainer? components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileLamMoi = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mnuFileThoat = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuThem = new ToolStripMenuItem();
            mnuSua = new ToolStripMenuItem();
            mnuXoa = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mnuTimKiem = new ToolStripMenuItem();
            mnuXemChiTiet = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuGioiThieu = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbThem = new ToolStripButton();
            tsbSua = new ToolStripButton();
            tsbXoa = new ToolStripButton();
            tsbLamMoi = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tstTimKiem = new ToolStripTextBox();
            tsbTimKiem = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblCount = new ToolStripStatusLabel();
            lblTitle = new Label();
            grbThongTin = new GroupBox();
            chkConKinhDoanh = new CheckBox();
            dtpNgayNhap = new DateTimePicker();
            lblNgayNhap = new Label();
            numSoLuong = new NumericUpDown();
            lblSoLuong = new Label();
            numDonGia = new NumericUpDown();
            lblDonGia = new Label();
            cboLoaiSP = new ComboBox();
            lblLoaiSP = new Label();
            txtTenSP = new TextBox();
            lblTenSP = new Label();
            txtMaSP = new TextBox();
            lblMaSP = new Label();
            grbAnh = new GroupBox();
            btnChonAnh = new Button();
            picSanPham = new PictureBox();
            flpButtons = new FlowLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            dgvProducts = new DataGridView();
            cmsGrid = new ContextMenuStrip(components);
            cmsSua = new ToolStripMenuItem();
            cmsXoa = new ToolStripMenuItem();
            cmsXemChiTiet = new ToolStripMenuItem();
            errorProvider1 = new ErrorProvider(components);
            bindingSource = new BindingSource(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            grbAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSanPham).BeginInit();
            flpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            cmsGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuQuanLy, mnuTroGiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1100, 24);
            menuStrip1.TabIndex = 0;
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileLamMoi, toolStripSeparator2, mnuFileThoat });
            mnuFile.Name = "mnuFile";
            mnuFile.Text = "File";
            // 
            // mnuFileLamMoi
            // 
            mnuFileLamMoi.Name = "mnuFileLamMoi";
            mnuFileLamMoi.ShortcutKeys = Keys.F5;
            mnuFileLamMoi.Text = "Làm mới";
            mnuFileLamMoi.Click += btnLamMoi_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // mnuFileThoat
            // 
            mnuFileThoat.Name = "mnuFileThoat";
            mnuFileThoat.ShortcutKeys = Keys.Control | Keys.Q;
            mnuFileThoat.Text = "Thoát";
            mnuFileThoat.Click += mnuThoat_Click;
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuThem, mnuSua, mnuXoa, toolStripSeparator3, mnuTimKiem, mnuXemChiTiet });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Text = "Quản lý";
            // 
            // mnuThem
            // 
            mnuThem.Name = "mnuThem";
            mnuThem.ShortcutKeys = Keys.Control | Keys.N;
            mnuThem.Text = "Thêm";
            mnuThem.Click += btnThem_Click;
            // 
            // mnuSua
            // 
            mnuSua.Name = "mnuSua";
            mnuSua.ShortcutKeys = Keys.Control | Keys.E;
            mnuSua.Text = "Sửa";
            mnuSua.Click += btnSua_Click;
            // 
            // mnuXoa
            // 
            mnuXoa.Name = "mnuXoa";
            mnuXoa.ShortcutKeys = Keys.Control | Keys.D;
            mnuXoa.Text = "Xóa";
            mnuXoa.Click += btnXoa_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // mnuTimKiem
            // 
            mnuTimKiem.Name = "mnuTimKiem";
            mnuTimKiem.ShortcutKeys = Keys.Control | Keys.F;
            mnuTimKiem.Text = "Tìm kiếm";
            mnuTimKiem.Click += mnuTimKiem_Click;
            // 
            // mnuXemChiTiet
            // 
            mnuXemChiTiet.Name = "mnuXemChiTiet";
            mnuXemChiTiet.ShortcutKeys = Keys.Control | Keys.I;
            mnuXemChiTiet.Text = "Xem chi tiết";
            mnuXemChiTiet.Click += mnuXemChiTiet_Click;
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuGioiThieu });
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Text = "Trợ giúp";
            // 
            // mnuGioiThieu
            // 
            mnuGioiThieu.Name = "mnuGioiThieu";
            mnuGioiThieu.Text = "Giới thiệu";
            mnuGioiThieu.Click += mnuGioiThieu_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbThem, tsbSua, tsbXoa, tsbLamMoi, toolStripSeparator1, tstTimKiem, tsbTimKiem });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1100, 25);
            toolStrip1.TabIndex = 1;
            // 
            // tsbThem
            // 
            tsbThem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbThem.Name = "tsbThem";
            tsbThem.Text = "Thêm";
            tsbThem.Click += btnThem_Click;
            // 
            // tsbSua
            // 
            tsbSua.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbSua.Name = "tsbSua";
            tsbSua.Text = "Sửa";
            tsbSua.Click += btnSua_Click;
            // 
            // tsbXoa
            // 
            tsbXoa.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbXoa.Name = "tsbXoa";
            tsbXoa.Text = "Xóa";
            tsbXoa.Click += btnXoa_Click;
            // 
            // tsbLamMoi
            // 
            tsbLamMoi.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbLamMoi.Name = "tsbLamMoi";
            tsbLamMoi.Text = "Làm mới";
            tsbLamMoi.Click += btnLamMoi_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // tstTimKiem
            // 
            tstTimKiem.AutoSize = false;
            tstTimKiem.Name = "tstTimKiem";
            tstTimKiem.Size = new Size(220, 25);
            tstTimKiem.ToolTipText = "Nhập mã hoặc tên sản phẩm rồi nhấn Enter";
            tstTimKiem.KeyDown += tstTimKiem_KeyDown;
            // 
            // tsbTimKiem
            // 
            tsbTimKiem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbTimKiem.Name = "tsbTimKiem";
            tsbTimKiem.Text = "Tìm kiếm";
            tsbTimKiem.Click += btnTimKiem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus, lblCount });
            statusStrip1.Location = new Point(0, 713);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1100, 22);
            statusStrip1.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(950, 17);
            lblStatus.Spring = true;
            lblStatus.Text = "Sẵn sàng";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCount
            // 
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(135, 17);
            lblCount.Text = "Số sản phẩm: 0";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.Font = new Font("Segoe UI", 22F);
            lblTitle.ForeColor = Color.SteelBlue;
            lblTitle.Location = new Point(0, 55);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1100, 45);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "QUẢN LÝ SẢN PHẨM";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grbThongTin
            // 
            grbThongTin.BackColor = SystemColors.ActiveCaption;
            grbThongTin.Controls.Add(chkConKinhDoanh);
            grbThongTin.Controls.Add(dtpNgayNhap);
            grbThongTin.Controls.Add(lblNgayNhap);
            grbThongTin.Controls.Add(numSoLuong);
            grbThongTin.Controls.Add(lblSoLuong);
            grbThongTin.Controls.Add(numDonGia);
            grbThongTin.Controls.Add(lblDonGia);
            grbThongTin.Controls.Add(cboLoaiSP);
            grbThongTin.Controls.Add(lblLoaiSP);
            grbThongTin.Controls.Add(txtTenSP);
            grbThongTin.Controls.Add(lblTenSP);
            grbThongTin.Controls.Add(txtMaSP);
            grbThongTin.Controls.Add(lblMaSP);
            grbThongTin.Font = new Font("Segoe UI", 10.5F);
            grbThongTin.Location = new Point(20, 105);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(660, 245);
            grbThongTin.TabIndex = 4;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông tin sản phẩm";
            // 
            // chkConKinhDoanh
            // 
            chkConKinhDoanh.AutoSize = true;
            chkConKinhDoanh.Checked = true;
            chkConKinhDoanh.CheckState = CheckState.Checked;
            chkConKinhDoanh.Location = new Point(125, 195);
            chkConKinhDoanh.Name = "chkConKinhDoanh";
            chkConKinhDoanh.Size = new Size(140, 23);
            chkConKinhDoanh.TabIndex = 6;
            chkConKinhDoanh.Text = "Còn kinh doanh";
            chkConKinhDoanh.UseVisualStyleBackColor = true;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.Location = new Point(450, 140);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(190, 26);
            dtpNgayNhap.TabIndex = 5;
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.AutoSize = true;
            lblNgayNhap.Location = new Point(345, 144);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(80, 19);
            lblNgayNhap.TabIndex = 12;
            lblNgayNhap.Text = "Ngày nhập";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(450, 90);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(190, 26);
            numSoLuong.TabIndex = 4;
            numSoLuong.TextAlign = HorizontalAlignment.Right;
            numSoLuong.KeyPress += NumericOnly_KeyPress;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(345, 94);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(69, 19);
            lblSoLuong.TabIndex = 10;
            lblSoLuong.Text = "Số lượng";
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(450, 40);
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(190, 26);
            numDonGia.TabIndex = 3;
            numDonGia.TextAlign = HorizontalAlignment.Right;
            numDonGia.KeyPress += NumericOnly_KeyPress;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(345, 44);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(61, 19);
            lblDonGia.TabIndex = 8;
            lblDonGia.Text = "Đơn giá";
            // 
            // cboLoaiSP
            // 
            cboLoaiSP.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSP.FormattingEnabled = true;
            cboLoaiSP.Location = new Point(125, 140);
            cboLoaiSP.Name = "cboLoaiSP";
            cboLoaiSP.Size = new Size(200, 26);
            cboLoaiSP.TabIndex = 2;
            // 
            // lblLoaiSP
            // 
            lblLoaiSP.AutoSize = true;
            lblLoaiSP.Location = new Point(20, 144);
            lblLoaiSP.Name = "lblLoaiSP";
            lblLoaiSP.Size = new Size(62, 19);
            lblLoaiSP.TabIndex = 6;
            lblLoaiSP.Text = "Loại SP";
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(125, 90);
            txtTenSP.MaxLength = 100;
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(200, 26);
            txtTenSP.TabIndex = 1;
            // 
            // lblTenSP
            // 
            lblTenSP.AutoSize = true;
            lblTenSP.Location = new Point(20, 94);
            lblTenSP.Name = "lblTenSP";
            lblTenSP.Size = new Size(55, 19);
            lblTenSP.TabIndex = 4;
            lblTenSP.Text = "Tên SP";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(125, 40);
            txtMaSP.MaxLength = 20;
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(200, 26);
            txtMaSP.TabIndex = 0;
            // 
            // lblMaSP
            // 
            lblMaSP.AutoSize = true;
            lblMaSP.Location = new Point(20, 44);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(49, 19);
            lblMaSP.TabIndex = 2;
            lblMaSP.Text = "Mã SP";
            // 
            // grbAnh
            // 
            grbAnh.BackColor = SystemColors.ActiveCaption;
            grbAnh.Controls.Add(btnChonAnh);
            grbAnh.Controls.Add(picSanPham);
            grbAnh.Font = new Font("Segoe UI", 10.5F);
            grbAnh.Location = new Point(700, 105);
            grbAnh.Name = "grbAnh";
            grbAnh.Size = new Size(380, 245);
            grbAnh.TabIndex = 5;
            grbAnh.TabStop = false;
            grbAnh.Text = "Ảnh sản phẩm";
            // 
            // btnChonAnh
            // 
            btnChonAnh.BackColor = Color.LightSkyBlue;
            btnChonAnh.Location = new Point(240, 35);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(120, 40);
            btnChonAnh.TabIndex = 1;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = false;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // picSanPham
            // 
            picSanPham.BackColor = Color.White;
            picSanPham.BorderStyle = BorderStyle.FixedSingle;
            picSanPham.Location = new Point(20, 35);
            picSanPham.Name = "picSanPham";
            picSanPham.Size = new Size(200, 190);
            picSanPham.SizeMode = PictureBoxSizeMode.Zoom;
            picSanPham.TabIndex = 0;
            picSanPham.TabStop = false;
            // 
            // flpButtons
            // 
            flpButtons.Controls.Add(btnThem);
            flpButtons.Controls.Add(btnSua);
            flpButtons.Controls.Add(btnXoa);
            flpButtons.Controls.Add(btnLamMoi);
            flpButtons.Location = new Point(20, 355);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(660, 60);
            flpButtons.TabIndex = 6;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LimeGreen;
            btnThem.Location = new Point(10, 7);
            btnThem.Margin = new Padding(10, 7, 10, 7);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 45);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Gold;
            btnSua.Location = new Point(150, 7);
            btnSua.Margin = new Padding(10, 7, 10, 7);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(120, 45);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.IndianRed;
            btnXoa.Location = new Point(290, 7);
            btnXoa.Margin = new Padding(10, 7, 10, 7);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 45);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Aquamarine;
            btnLamMoi.Location = new Point(430, 7);
            btnLamMoi.Margin = new Padding(10, 7, 10, 7);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(120, 45);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.BackgroundColor = SystemColors.Window;
            dgvProducts.ContextMenuStrip = cmsGrid;
            dgvProducts.Location = new Point(20, 425);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1060, 278);
            dgvProducts.TabIndex = 7;
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
            dgvProducts.CellMouseDown += dgvProducts_CellMouseDown;
            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
            dgvProducts.KeyDown += dgvProducts_KeyDown;
            // 
            // cmsGrid
            // 
            cmsGrid.Items.AddRange(new ToolStripItem[] { cmsSua, cmsXoa, cmsXemChiTiet });
            cmsGrid.Name = "cmsGrid";
            cmsGrid.Size = new Size(140, 70);
            cmsGrid.Opening += cmsGrid_Opening;
            // 
            // cmsSua
            // 
            cmsSua.Name = "cmsSua";
            cmsSua.Size = new Size(139, 22);
            cmsSua.Text = "Sửa";
            cmsSua.Click += cmsSua_Click;
            // 
            // cmsXoa
            // 
            cmsXoa.Name = "cmsXoa";
            cmsXoa.Size = new Size(139, 22);
            cmsXoa.Text = "Xóa";
            cmsXoa.Click += btnXoa_Click;
            // 
            // cmsXemChiTiet
            // 
            cmsXemChiTiet.Name = "cmsXemChiTiet";
            cmsXemChiTiet.Size = new Size(139, 22);
            cmsXemChiTiet.Text = "Xem chi tiết";
            cmsXemChiTiet.Click += mnuXemChiTiet_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 735);
            Controls.Add(dgvProducts);
            Controls.Add(flpButtons);
            Controls.Add(grbAnh);
            Controls.Add(grbThongTin);
            Controls.Add(lblTitle);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1000, 640);
            Name = "FrmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sản phẩm";
            Load += FrmProduct_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            grbAnh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSanPham).EndInit();
            flpButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            cmsGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileLamMoi;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mnuFileThoat;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuThem;
        private ToolStripMenuItem mnuSua;
        private ToolStripMenuItem mnuXoa;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mnuTimKiem;
        private ToolStripMenuItem mnuXemChiTiet;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem mnuGioiThieu;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbThem;
        private ToolStripButton tsbSua;
        private ToolStripButton tsbXoa;
        private ToolStripButton tsbLamMoi;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox tstTimKiem;
        private ToolStripButton tsbTimKiem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblCount;
        private Label lblTitle;
        private GroupBox grbThongTin;
        private CheckBox chkConKinhDoanh;
        private DateTimePicker dtpNgayNhap;
        private Label lblNgayNhap;
        private NumericUpDown numSoLuong;
        private Label lblSoLuong;
        private NumericUpDown numDonGia;
        private Label lblDonGia;
        private ComboBox cboLoaiSP;
        private Label lblLoaiSP;
        private TextBox txtTenSP;
        private Label lblTenSP;
        private TextBox txtMaSP;
        private Label lblMaSP;
        private GroupBox grbAnh;
        private Button btnChonAnh;
        private PictureBox picSanPham;
        private FlowLayoutPanel flpButtons;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private DataGridView dgvProducts;
        private ContextMenuStrip cmsGrid;
        private ToolStripMenuItem cmsSua;
        private ToolStripMenuItem cmsXoa;
        private ToolStripMenuItem cmsXemChiTiet;
        private ErrorProvider errorProvider1;
        private BindingSource bindingSource;
    }
}
