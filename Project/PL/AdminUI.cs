using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project.PL
{
    public partial class AdminUI : Form
    {
        public AdminUI()
        {
            InitializeComponent();
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            HangHoaUI hanghoa = new HangHoaUI();
            hanghoa.Show();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            QuanLyDanhMucUI a = new QuanLyDanhMucUI();
            a.Show();
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            QuanLyKhoUI kho = new QuanLyKhoUI();
            kho.Show();
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            QuanLyHoaDonUI hd = new QuanLyHoaDonUI();
            hd.Show();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            QuanLyDoanhThuUi dt = new QuanLyDoanhThuUi();
            dt.Show();
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan tk = new QuanLyTaiKhoan();
            tk.Show();
        }
    }
}
