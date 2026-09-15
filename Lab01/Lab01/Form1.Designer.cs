namespace Lab01
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
            this.lblTitle = new Label();
            this.lblHoTen = new Label();
            this.txtHoTen = new TextBox();
            this.lblNamSinh = new Label();
            this.txtNamSinh = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.grpGioiTinh = new GroupBox();
            this.radNam = new RadioButton();
            this.radNu = new RadioButton();
            this.lblKhoa = new Label();
            this.cboKhoa = new ComboBox();
            this.btnHienThi = new Button();
            this.btnXoa = new Button();
            this.btnThoat = new Button();
            this.lblKetQua = new Label();
            this.grpGioiTinh.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(420, 30);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Text = "ỨNG DỤNG THÔNG TIN CÁ NHÂN";

            // lblHoTen
            this.lblHoTen.Location = new System.Drawing.Point(20, 60);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(90, 23);
            this.lblHoTen.Text = "Họ tên:";

            // txtHoTen
            this.txtHoTen.Location = new System.Drawing.Point(120, 57);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(300, 23);

            // lblNamSinh
            this.lblNamSinh.Location = new System.Drawing.Point(20, 95);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(90, 23);
            this.lblNamSinh.Text = "Năm sinh:";

            // txtNamSinh
            this.txtNamSinh.Location = new System.Drawing.Point(120, 92);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(150, 23);

            // lblEmail
            this.lblEmail.Location = new System.Drawing.Point(20, 130);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(90, 23);
            this.lblEmail.Text = "Email:";

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(120, 127);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 23);

            // grpGioiTinh
            this.grpGioiTinh.Controls.Add(this.radNam);
            this.grpGioiTinh.Controls.Add(this.radNu);
            this.grpGioiTinh.Location = new System.Drawing.Point(20, 165);
            this.grpGioiTinh.Name = "grpGioiTinh";
            this.grpGioiTinh.Size = new System.Drawing.Size(400, 45);
            this.grpGioiTinh.TabStop = false;
            this.grpGioiTinh.Text = "Giới tính";

            // radNam
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(20, 18);
            this.radNam.Name = "radNam";
            this.radNam.Text = "Nam";

            // radNu
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(160, 18);
            this.radNu.Name = "radNu";
            this.radNu.Text = "Nữ";

            // lblKhoa
            this.lblKhoa.Location = new System.Drawing.Point(20, 222);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(90, 23);
            this.lblKhoa.Text = "Khoa/Lớp:";

            // cboKhoa
            this.cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboKhoa.Location = new System.Drawing.Point(120, 219);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(300, 23);
            this.cboKhoa.Items.AddRange(new object[] {
                "Công nghệ thông tin",
                "Toán - Tin học",
                "Sư phạm Tin học",
                "Khác"});

            // btnHienThi
            this.btnHienThi.Location = new System.Drawing.Point(20, 260);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(120, 32);
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);

            // btnXoa
            this.btnXoa.Location = new System.Drawing.Point(160, 260);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 32);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnThoat
            this.btnThoat.Location = new System.Drawing.Point(300, 260);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 32);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // lblKetQua
            this.lblKetQua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKetQua.Location = new System.Drawing.Point(20, 305);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(400, 120);
            this.lblKetQua.Text = "";

            // Form1
            this.ClientSize = new System.Drawing.Size(450, 445);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblNamSinh);
            this.Controls.Add(this.txtNamSinh);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.grpGioiTinh);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblKetQua);
            this.Name = "Form1";
            this.Text = "Lab01 - Ứng dụng thông tin cá nhân";
            this.grpGioiTinh.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblNamSinh;
        private TextBox txtNamSinh;
        private Label lblEmail;
        private TextBox txtEmail;
        private GroupBox grpGioiTinh;
        private RadioButton radNam;
        private RadioButton radNu;
        private Label lblKhoa;
        private ComboBox cboKhoa;
        private Button btnHienThi;
        private Button btnXoa;
        private Button btnThoat;
        private Label lblKetQua;
    }
}
