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
    public partial class QuanLyKhoUI : Form
    {
        bool addNew = true;
        public QuanLyKhoUI()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length != 0)
            {
                if (HangHoaDAL.searchKho(txtSearch.Text.Trim()).Rows.Count > 0)
                {

                    dgvKho.DataSource = null;
                    dgvKho.DataSource = HangHoaDAL.searchKho(txtSearch.Text.Trim());

                }
                else
                {
                    MessageBox.Show("Không tìm thấy kho hàng");
                    RefreshDgv();
                }
            }
            else
            {
                MessageBox.Show("Nhập tên kho hàng để tìm kiếm");
                RefreshDgv();
                txtSearch.Focus();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QuanLyKhoUI_Load(object sender, EventArgs e)
        {
            RefreshDgv();
        }
        private void RefreshDgv()
        {
            dgvKho.DataSource = null;
            dgvKho.DataSource = HangHoaDAL.getAllKho();
            

            
        }

        private void dgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addNew = false;
            if (e.RowIndex >= 0)
            {
                dgvKho.CurrentRow.Selected = true;
                txtId.Text = dgvKho.Rows[e.RowIndex].Cells["KhoId"].Value.ToString();
                txtTenKho.Text = dgvKho.Rows[e.RowIndex].Cells["TenKho"].Value.ToString();




            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (addNew == false)
            {
                addNew = true;
                txtId.Text = "";
                txtTenKho.Text = "";
                txtTenKho.Focus();

            }
            else
            {
                if (!txtTenKho.Text.Equals(""))
                {
                    string name = txtTenKho.Text.Trim();
                    HangHoaDAL.AddKho(name);
                    RefreshDgv();
                }
                else MessageBox.Show("Nhập tên kho để thêm");
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (addNew != true)
            {
                 id = Convert.ToInt32(txtId.Text.Trim());
            }

            string name = txtTenKho.Text.Trim();
            if (txtTenKho.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên kho không được để trống");
                return;
            }


            if (addNew == true)
            {

                if (HangHoaDAL.AddKho(name) > 0)
                    MessageBox.Show("Thêm kho thành công.");
                else
                    MessageBox.Show("Thêm thất bại.");
            }
            else
            {
                if (HangHoaDAL.UpdateKho(id,name) > 0)
                    MessageBox.Show("Update success.");
                else
                    MessageBox.Show("Update false.");
            }
            // Refresh lai dgvCategory
            RefreshDgv();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (addNew != true)
            {
                string id = txtId.Text.Trim();
                HangHoaDAL.DeleteKho(id);
                addNew = true;
                RefreshDgv();
            }
            else
                MessageBox.Show("Chọn kho để xóa");
        }
    }
}
