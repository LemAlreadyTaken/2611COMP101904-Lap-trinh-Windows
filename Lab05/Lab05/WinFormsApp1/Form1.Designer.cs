namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            lblTitle = new Label();
            grbhocvien = new GroupBox();
            lblStatus = new Label();
            chkNhanEmail = new CheckBox();
            dtpNgaySinh = new DateTimePicker();
            lblNgaySinh = new Label();
            lblCounter = new Label();
            txtSoDienThoai = new TextBox();
            lblSoDienThoai = new Label();
            txtHoTen = new TextBox();
            lblHoTen = new Label();
            grbkhoahoc = new GroupBox();
            numSoThang = new NumericUpDown();
            lblSoThang = new Label();
            lblTongTien = new Label();
            lblTongTienTitle = new Label();
            lblHocPhiThang = new Label();
            lblHocPhiTitle = new Label();
            radOffline = new RadioButton();
            radOnline = new RadioButton();
            lblHinhThuc = new Label();
            cboKhoaHoc = new ComboBox();
            lblKhoaHoc = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnDangKy = new Button();
            btnLamMoi = new Button();
            btnThoat = new Button();
            grbhocvien.SuspendLayout();
            grbkhoahoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoThang).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 25F);
            lblTitle.ForeColor = Color.SteelBlue;
            lblTitle.Location = new Point(195, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(537, 57);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG KÝ KHÓA HỌC";
            // 
            // grbhocvien
            // 
            grbhocvien.BackColor = SystemColors.ActiveCaption;
            grbhocvien.Controls.Add(lblStatus);
            grbhocvien.Controls.Add(chkNhanEmail);
            grbhocvien.Controls.Add(dtpNgaySinh);
            grbhocvien.Controls.Add(lblNgaySinh);
            grbhocvien.Controls.Add(lblCounter);
            grbhocvien.Controls.Add(txtSoDienThoai);
            grbhocvien.Controls.Add(lblSoDienThoai);
            grbhocvien.Controls.Add(txtHoTen);
            grbhocvien.Controls.Add(lblHoTen);
            grbhocvien.Font = new Font("Segoe UI", 12F);
            grbhocvien.Location = new Point(20, 92);
            grbhocvien.Name = "grbhocvien";
            grbhocvien.Size = new Size(435, 324);
            grbhocvien.TabIndex = 1;
            grbhocvien.TabStop = false;
            grbhocvien.Text = "Thông tin học viên";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lblStatus.Location = new Point(85, 272);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(279, 28);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Không nhận mail thông báo";
            // 
            // chkNhanEmail
            // 
            chkNhanEmail.AutoSize = true;
            chkNhanEmail.Location = new Point(120, 224);
            chkNhanEmail.Name = "chkNhanEmail";
            chkNhanEmail.Size = new Size(258, 32);
            chkNhanEmail.TabIndex = 6;
            chkNhanEmail.Text = "Nhận thông báo qua mail";
            chkNhanEmail.UseVisualStyleBackColor = true;
            chkNhanEmail.CheckedChanged += chkNhanEmail_CheckedChanged;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(120, 170);
            dtpNgaySinh.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpNgaySinh.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 34);
            dtpNgaySinh.TabIndex = 2;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(15, 168);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(99, 28);
            lblNgaySinh.TabIndex = 5;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Location = new Point(376, 55);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(53, 28);
            lblCounter.TabIndex = 4;
            lblCounter.Text = "0/50";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(127, 110);
            txtSoDienThoai.MaxLength = 10;
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(239, 34);
            txtSoDienThoai.TabIndex = 3;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Location = new Point(42, 110);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(47, 28);
            lblSoDienThoai.TabIndex = 2;
            lblSoDienThoai.Text = "SĐT";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(127, 52);
            txtHoTen.MaxLength = 50;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(239, 34);
            txtHoTen.TabIndex = 1;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            txtHoTen.KeyPress += txtHoTen_KeyPress;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(27, 55);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(71, 28);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên";
            // 
            // grbkhoahoc
            // 
            grbkhoahoc.BackColor = SystemColors.ActiveCaption;
            grbkhoahoc.Controls.Add(numSoThang);
            grbkhoahoc.Controls.Add(lblSoThang);
            grbkhoahoc.Controls.Add(lblTongTien);
            grbkhoahoc.Controls.Add(lblTongTienTitle);
            grbkhoahoc.Controls.Add(lblHocPhiThang);
            grbkhoahoc.Controls.Add(lblHocPhiTitle);
            grbkhoahoc.Controls.Add(radOffline);
            grbkhoahoc.Controls.Add(radOnline);
            grbkhoahoc.Controls.Add(lblHinhThuc);
            grbkhoahoc.Controls.Add(cboKhoaHoc);
            grbkhoahoc.Controls.Add(lblKhoaHoc);
            grbkhoahoc.Font = new Font("Segoe UI", 12F);
            grbkhoahoc.Location = new Point(471, 92);
            grbkhoahoc.Name = "grbkhoahoc";
            grbkhoahoc.Size = new Size(445, 324);
            grbkhoahoc.TabIndex = 7;
            grbkhoahoc.TabStop = false;
            grbkhoahoc.Text = "Thông tin khóa học";
            // 
            // numSoThang
            // 
            numSoThang.Location = new Point(207, 150);
            numSoThang.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numSoThang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoThang.Name = "numSoThang";
            numSoThang.Size = new Size(120, 34);
            numSoThang.TabIndex = 5;
            numSoThang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numSoThang.ValueChanged += numSoThang_ValueChanged;
            // 
            // lblSoThang
            // 
            lblSoThang.AutoSize = true;
            lblSoThang.Location = new Point(27, 152);
            lblSoThang.Name = "lblSoThang";
            lblSoThang.Size = new Size(91, 28);
            lblSoThang.TabIndex = 9;
            lblSoThang.Text = "Số tháng";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font(".VnArial", 15F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.LawnGreen;
            lblTongTien.Location = new Point(207, 246);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(92, 29);
            lblTongTien.TabIndex = 8;
            lblTongTien.Text = "0 VND";
            // 
            // lblTongTienTitle
            // 
            lblTongTienTitle.AutoSize = true;
            lblTongTienTitle.Location = new Point(56, 246);
            lblTongTienTitle.Name = "lblTongTienTitle";
            lblTongTienTitle.Size = new Size(95, 28);
            lblTongTienTitle.TabIndex = 7;
            lblTongTienTitle.Text = "Tổng tiền";
            // 
            // lblHocPhiThang
            // 
            lblHocPhiThang.AutoSize = true;
            lblHocPhiThang.Font = new Font(".VnArial", 15F, FontStyle.Bold);
            lblHocPhiThang.Location = new Point(207, 195);
            lblHocPhiThang.Name = "lblHocPhiThang";
            lblHocPhiThang.Size = new Size(92, 29);
            lblHocPhiThang.TabIndex = 6;
            lblHocPhiThang.Text = "0 VND";
            // 
            // lblHocPhiTitle
            // 
            lblHocPhiTitle.AutoSize = true;
            lblHocPhiTitle.Location = new Point(27, 196);
            lblHocPhiTitle.Name = "lblHocPhiTitle";
            lblHocPhiTitle.Size = new Size(149, 28);
            lblHocPhiTitle.TabIndex = 5;
            lblHocPhiTitle.Text = "Học phí / tháng";
            // 
            // radOffline
            // 
            radOffline.AutoSize = true;
            radOffline.Location = new Point(253, 110);
            radOffline.Name = "radOffline";
            radOffline.Size = new Size(91, 32);
            radOffline.TabIndex = 4;
            radOffline.TabStop = true;
            radOffline.Text = "Offline";
            radOffline.UseVisualStyleBackColor = true;
            radOffline.CheckedChanged += radOffline_CheckedChanged;
            // 
            // radOnline
            // 
            radOnline.AutoSize = true;
            radOnline.Location = new Point(146, 110);
            radOnline.Name = "radOnline";
            radOnline.Size = new Size(90, 32);
            radOnline.TabIndex = 3;
            radOnline.TabStop = true;
            radOnline.Text = "Online";
            radOnline.UseVisualStyleBackColor = true;
            radOnline.CheckedChanged += radOnline_CheckedChanged;
            // 
            // lblHinhThuc
            // 
            lblHinhThuc.AutoSize = true;
            lblHinhThuc.Location = new Point(6, 110);
            lblHinhThuc.Name = "lblHinhThuc";
            lblHinhThuc.Size = new Size(134, 28);
            lblHinhThuc.TabIndex = 2;
            lblHinhThuc.Text = "Hình thức học";
            // 
            // cboKhoaHoc
            // 
            cboKhoaHoc.FormattingEnabled = true;
            cboKhoaHoc.Location = new Point(166, 55);
            cboKhoaHoc.Name = "cboKhoaHoc";
            cboKhoaHoc.Size = new Size(189, 36);
            cboKhoaHoc.TabIndex = 1;
            cboKhoaHoc.SelectedIndexChanged += cboKhoaHoc_SelectedIndexChanged;
            // 
            // lblKhoaHoc
            // 
            lblKhoaHoc.AutoSize = true;
            lblKhoaHoc.Location = new Point(27, 55);
            lblKhoaHoc.Name = "lblKhoaHoc";
            lblKhoaHoc.Size = new Size(94, 28);
            lblKhoaHoc.TabIndex = 0;
            lblKhoaHoc.Text = "Khóa học";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnDangKy);
            flowLayoutPanel1.Controls.Add(btnLamMoi);
            flowLayoutPanel1.Controls.Add(btnThoat);
            flowLayoutPanel1.Location = new Point(195, 416);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(542, 74);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.LimeGreen;
            btnDangKy.Location = new Point(15, 15);
            btnDangKy.Margin = new Padding(15);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(150, 50);
            btnDangKy.TabIndex = 0;
            btnDangKy.Text = "Đăng kí";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Aquamarine;
            btnLamMoi.Location = new Point(195, 15);
            btnLamMoi.Margin = new Padding(15);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(150, 50);
            btnLamMoi.TabIndex = 1;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.IndianRed;
            btnThoat.Location = new Point(375, 15);
            btnThoat.Margin = new Padding(15);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 50);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 493);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(grbkhoahoc);
            Controls.Add(grbhocvien);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "ĐĂNG KÝ KHÓA HỌC";
            Load += Form1_Load;
            grbhocvien.ResumeLayout(false);
            grbhocvien.PerformLayout();
            grbkhoahoc.ResumeLayout(false);
            grbkhoahoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoThang).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grbhocvien;
        private TextBox txtHoTen;
        private Label lblHoTen;
        private Label lblCounter;
        private TextBox txtSoDienThoai;
        private Label lblSoDienThoai;
        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private CheckBox chkNhanEmail;
        private GroupBox grbkhoahoc;
        private RadioButton radOnline;
        private Label lblHinhThuc;
        private ComboBox cboKhoaHoc;
        private Label lblKhoaHoc;
        private RadioButton radOffline;
        private Label lblStatus;
        private Label lblHocPhiTitle;
        private Label lblHocPhiThang;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnDangKy;
        private Button btnLamMoi;
        private Button btnThoat;
        private Label lblTongTien;
        private Label lblTongTienTitle;
        private NumericUpDown numSoThang;
        private Label lblSoThang;
    }
}