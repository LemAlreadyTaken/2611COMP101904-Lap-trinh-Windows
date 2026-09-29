using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public class KhoaHoc
        {
            public string TenKhoaHoc { get; set; }
            public decimal HocPhi { get; set; }

            public KhoaHoc(string ten, decimal hocPhi)
            {
                TenKhoaHoc = ten;
                HocPhi = hocPhi;
            }

            public override string ToString()
            {
                return TenKhoaHoc;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "ĐĂNG KÝ KHÓA HỌC";

            dtpNgaySinh.MaxDate = DateTime.Today;
            dtpNgaySinh.Value = DateTime.Today;

            numSoThang.Minimum = 1;
            numSoThang.Maximum = 12;
            numSoThang.Value = 1;

            List<KhoaHoc> dsKhoaHoc = new List<KhoaHoc>
            {
                new KhoaHoc("C# WinForms cơ bản", 800000),
                new KhoaHoc("SQL Server cơ bản", 700000),
                new KhoaHoc("Web Frontend cơ bản", 750000),
                new KhoaHoc("Lập trình Python cơ bản", 650000)
            };

            cboKhoaHoc.DataSource = dsKhoaHoc;
            cboKhoaHoc.DisplayMember = "TenKhoaHoc";

            if (cboKhoaHoc.Items.Count > 0)
                cboKhoaHoc.SelectedIndex = 0;

            radOnline.Checked = true;

            TinhTongHocPhi();
        }

        private void TinhTongHocPhi()
        {
            if (cboKhoaHoc.SelectedItem is KhoaHoc khoaHocChon)
            {
                decimal hocPhiGoc = khoaHocChon.HocPhi;
                int soThang = (int)numSoThang.Value;

                decimal tileGiamGia = radOnline.Checked ? 0.8m : 1.0m;

                decimal hocPhiHangThang = hocPhiGoc * tileGiamGia;
                decimal tongTien = hocPhiHangThang * soThang;

                lblHocPhiThang.Text = $"{hocPhiHangThang:N0} VND";
                lblTongTien.Text = $"{tongTien:N0} VND";
            }
        }

        private void cboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhTongHocPhi();
        }

        private void numSoThang_ValueChanged(object sender, EventArgs e)
        {
            TinhTongHocPhi();
        }

        private void radOnline_CheckedChanged(object sender, EventArgs e)
        {
            TinhTongHocPhi();
        }

        private void radOffline_CheckedChanged(object sender, EventArgs e)
        {
            TinhTongHocPhi();
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            lblCounter.Text = $"{txtHoTen.Text.Length}/50";
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void chkNhanEmail_CheckedChanged(object sender, EventArgs e)
        {
            lblStatus.Text = chkNhanEmail.Checked
                ? "Nhận email thông báo"
                : "Không nhận email thông báo";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }

            if (cboKhoaHoc.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn khóa học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hoTen = txtHoTen.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string ngaySinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
            string tenKhoaHoc = ((KhoaHoc)cboKhoaHoc.SelectedItem).TenKhoaHoc;
            string hinhThuc = radOnline.Checked ? "Online (Giảm 20%)" : "Offline";
            int soThang = (int)numSoThang.Value;
            string tongTien = lblTongTien.Text;
            string nhanEmail = chkNhanEmail.Checked ? "Có" : "Không";

            string thongTinPhieu = $"--- PHIẾU ĐĂNG KÝ KHÓA HỌC ---\n\n" +
                                   $"Họ và tên: {hoTen}\n" +
                                   $"Số điện thoại: {sdt}\n" +
                                   $"Ngày sinh: {ngaySinh}\n" +
                                   $"Khóa học: {tenKhoaHoc}\n" +
                                   $"Hình thức học: {hinhThuc}\n" +
                                   $"Số tháng: {soThang}\n" +
                                   $"Tổng tiền: {tongTien}\n" +
                                   $"Nhận email thông báo: {nhanEmail}";

            MessageBox.Show(thongTinPhieu, "Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            dtpNgaySinh.Value = DateTime.Today;
            chkNhanEmail.Checked = false;

            if (cboKhoaHoc.Items.Count > 0)
                cboKhoaHoc.SelectedIndex = 0;

            radOnline.Checked = true;
            numSoThang.Value = 1;
            txtHoTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}