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
    public partial class QuanLyTaiKhoan : Form
    {
        bool addNew = true;
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RefreshDgv()
        {
            dgvTaiKhoan.DataSource = null;
            dgvTaiKhoan.DataSource = LoginDAL.GetAllLogin();



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (addNew == false)
            {
                addNew = true;
                txtId.Text = "";
                txtPassword.Text = "";
                txtUserName.Text = "";
                txtCMND.Text = "";
                txtDiaChi.Text = "";
                txtHoTen.Text = "";
                txtUserName.Focus();

            }
            else
            {
                if (!txtUserName.Text.Equals("") && !txtPassword.Text.Equals("") && !txtCMND.Text.Equals("") && !txtDiaChi.Text.Equals("") && !txtHoTen.Text.Equals(""))
                {
                    string name = txtUserName.Text.Trim();
                    string pass = txtPassword.Text.Trim();
                    string hoten = txtHoTen.Text.Trim();
                    string diachi = txtDiaChi.Text.Trim();
                    string cmnd = txtCMND.Text.Trim();

                    LoginDAL i = new LoginDAL();
                    LoginDAL.AddLogin(name, pass,hoten,diachi,cmnd);
                    RefreshDgv();
                }
                else MessageBox.Show("Nhập toàn bộ thông tin để thêm");
                
            }
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = null;
            dgvTaiKhoan.DataSource = LoginDAL.GetAllLoginToDisplay();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addNew = false;
            if (e.RowIndex>=0)
            {
                dgvTaiKhoan.CurrentRow.Selected = true;
                txtId.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtUserName.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                txtPassword.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                txtHoTen.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
                txtDiaChi.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                txtCMND.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["CMND"].Value.ToString();



            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (addNew != true)
            {
                id = Convert.ToInt32(txtId.Text.Trim());
            }

            string name = "";
            if (txtUserName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập tên tài khoản để thêm để thêm");
                return;
            }
            else name = txtUserName.Text.Trim();

            string pass = "";
            if (txtPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập mật khẩu để thêm");
                return;
            }
            else pass = txtPassword.Text.Trim();

            string hoTen = "";
            if (txtHoTen.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập họ tên người dùng để thêm");
                return;
            }
            else hoTen = txtHoTen.Text.Trim();

            string diaChi = "";
            if (txtDiaChi.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập địa chỉ người dùng để thêm");
                return;
            }
            else diaChi = txtDiaChi.Text.Trim();

            string cmnd = "";
            if (txtCMND.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nhập CMND người dùng để thêm");
                return;
            }
            else cmnd = txtCMND.Text.Trim();


            if (addNew == true)
            {

                if (LoginDAL.AddLogin(name,pass,hoTen,diaChi,cmnd) > 0)
                    MessageBox.Show("Thêm tài khoản thành công.");
                else
                    MessageBox.Show("Thêm tài khoản thất bại.");
            }
            else
            {
                if (LoginDAL.UpdateLogin(id, name,pass,hoTen,diaChi,cmnd) > 0)
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
                LoginDAL.DeleteLogin(id);
                addNew = true;
                RefreshDgv();
            }
            else
                MessageBox.Show("Chọn tài khoản để xóa");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length != 0)
            {
                if (LoginDAL.searchAccount(txtSearch.Text.Trim()).Rows.Count > 0)
                {

                    dgvTaiKhoan.DataSource = null;
                    dgvTaiKhoan.DataSource = LoginDAL.searchAccount(txtSearch.Text.Trim());

                }
                else
                {
                    MessageBox.Show("Không tìm thấy Tài khoản");
                    RefreshDgv();
                }
            }
            else
            {
                MessageBox.Show("Nhập tên tài khoản để tìm kiếm");
                RefreshDgv();
                txtSearch.Focus();
            }
        }
    }
}
