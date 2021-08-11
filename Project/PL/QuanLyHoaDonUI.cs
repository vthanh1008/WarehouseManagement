using Project.DAL;
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
    public partial class QuanLyHoaDonUI : Form
    {
        public QuanLyHoaDonUI()
        {
            InitializeComponent();
        }

        private void QuanLyHoaDonUI_Load(object sender, EventArgs e)
        {
            RefreshDgv();
        }

        private void RefreshDgv()
        {
            dgvHoaDon.DataSource = null;
            dgvHoaDon.DataSource = HoaDonDAL.GetAllHoaDon();
            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = HoaDonDAL.GetAllKhachHang();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaleUI s = new SaleUI();
            s.Show();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvKhachHang.Rows[e.RowIndex].Cells["IdHoaDon"].Value.ToString();
                dgvHoaDon.DataSource = null;
                dgvHoaDon.DataSource = HoaDonDAL.GetAllHoaDonById(id);
                dgvKhachHang.CurrentRow.Selected = true;
                txtId.Text = dgvKhachHang.Rows[e.RowIndex].Cells["IdKhachHang"].Value.ToString();

                txtLai.Text = dgvKhachHang.Rows[e.RowIndex].Cells["Lai"].Value.ToString();
                txtNgayMua.Text = dgvKhachHang.Rows[e.RowIndex].Cells["NgayMua"].Value.ToString();
                txtTen.Text = dgvKhachHang.Rows[e.RowIndex].Cells["TenKhachHang"].Value.ToString();
                txtTongTien.Text = dgvKhachHang.Rows[e.RowIndex].Cells["TongTien"].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length != 0)
            {
                    dgvKhachHang.DataSource = null;
                    dgvKhachHang.DataSource = HoaDonDAL.SearchHoaDon(txtSearch.Text.Trim());

            }
            else
            {
                MessageBox.Show("Enter the product name to search, please!");
                RefreshDgv();
                txtSearch.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshDgv();
        }
    }
}
