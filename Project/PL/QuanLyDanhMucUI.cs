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
    public partial class QuanLyDanhMucUI : Form
    {
        bool addNew = true;
        public QuanLyDanhMucUI()
        {
            InitializeComponent();
        }

        private void QuanLyDanhMucUI_Load(object sender, EventArgs e)
        {
            RefreshDgv();
        }

        private void RefreshDgv()
        {
            dgvDanhMuc.DataSource = null;
            dgvDanhMuc.DataSource = HangHoaDAL.getAllDanhMuc();
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addNew = false;
            if (e.RowIndex >= 0)
            {
                dgvDanhMuc.CurrentRow.Selected = true;
                txtId.Text = dgvDanhMuc.Rows[e.RowIndex].Cells["DanhMucId"].Value.ToString();
                txtTenDanhMuc.Text = dgvDanhMuc.Rows[e.RowIndex].Cells["TenDanhMuc"].Value.ToString();


            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length != 0)
            {
                if (HangHoaDAL.searchDanhMuc(txtSearch.Text.Trim()).Rows.Count > 0)
                {

                    dgvDanhMuc.DataSource = null;
                    dgvDanhMuc.DataSource = HangHoaDAL.searchDanhMuc(txtSearch.Text.Trim());

                }
                else
                {
                    MessageBox.Show("Không tìm thấy Danh Mục");
                    RefreshDgv();
                }
            }
            else
            {
                MessageBox.Show("Nhập tên danh mục để tìm kiếm");
                RefreshDgv();
                txtSearch.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (addNew == false)
            {
                addNew = true;
                txtId.Text = "";
                txtTenDanhMuc.Text = "";
                txtTenDanhMuc.Focus();

            }
            else
            {
                if (!txtTenDanhMuc.Text.Trim().Equals(""))
                {
                    string name = txtTenDanhMuc.Text.Trim();
                    HangHoaDAL.AddDanhMuc(name);
                    RefreshDgv();
                }
                else MessageBox.Show("Tên danh mục không được để trống");
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (addNew != true)
            {
                id = Convert.ToInt32(txtId.Text.Trim());
            }

            string name = txtTenDanhMuc.Text.Trim();
            if (txtTenDanhMuc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên danh mục không được để trống");
                return;
            }

            if (addNew == true)
            {

                if (HangHoaDAL.AddDanhMuc(name) > 0)
                    MessageBox.Show("Thêm danh mục thành công.");
                else
                    MessageBox.Show("Thêm danh mục bại.");
            }
            else
            {
                if (HangHoaDAL.UpdateDanhMuc(id, name) > 0)
                    MessageBox.Show("Update thành công.");
                else
                    MessageBox.Show("Update thất bại.");
            }
            // Refresh lai dgvCategory
            RefreshDgv();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (addNew != true)
            {
                string id = txtId.Text.Trim();
                HangHoaDAL.DeleteDanhMuc(id);
                addNew = true;
                RefreshDgv();
            }
            else
                MessageBox.Show("Chọn danh mục để xóa");
        }
    }
}
