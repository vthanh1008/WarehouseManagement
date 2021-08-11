using Project.BL;
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
    public partial class HangHoaUI : Form
    {
        bool addNew = true;
        public HangHoaUI()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void HangHoaUI_Load(object sender, EventArgs e)
        {
            RefreshDgv();
        }

        private void RefreshDgv()
        {
            dgvHangHoa.DataSource = null;
            dgvHangHoa.DataSource = HangHoaDAL.GetAllHangHoa();
            storeCbb.DataSource = HangHoaDAL.getAllKho();
            storeCbb.DisplayMember = "TenKho";
            storeCbb.ValueMember = "KhoId";

            typecbb.DataSource = HangHoaDAL.getAllDanhMuc();
            typecbb.DisplayMember = "TenDanhMuc";
            typecbb.ValueMember = "DanhMucId";
            cbbDanhMuc.DataSource = HangHoaDAL.getAllDanhMuc();
            cbbDanhMuc.DisplayMember = "TenDanhMuc";
            cbbDanhMuc.ValueMember = "DanhMucId";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addNew = false;
            if (e.RowIndex >= 0)
            {
                dgvHangHoa.CurrentRow.Selected = true;
                txtID.Text = dgvHangHoa.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtName.Text = dgvHangHoa.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
                txtQuantity.Text = dgvHangHoa.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();


                storeCbb.DataSource = HangHoaDAL.getAllKho();
                storeCbb.DisplayMember = "TenKho";
                storeCbb.ValueMember = "KhoId";
                storeCbb.SelectedIndex = Convert.ToInt32(dgvHangHoa.Rows[e.RowIndex].Cells["KhoId"].Value.ToString()) - 1;

                typecbb.DataSource = HangHoaDAL.getAllDanhMuc();
                typecbb.DisplayMember = "TenDanhMuc";
                typecbb.ValueMember = "DanhMucId";
                typecbb.SelectedIndex = Convert.ToInt32(dgvHangHoa.Rows[e.RowIndex].Cells["DanhMucId"].Value.ToString());

                txtPrice.Text = dgvHangHoa.Rows[e.RowIndex].Cells["GiaNhap"].Value.ToString();
                txtPrice2.Text = dgvHangHoa.Rows[e.RowIndex].Cells["GiaBan"].Value.ToString();


            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (addNew == false)
            {
                addNew = true;
                txtID.Text = "";
                txtName.Text = "";
                txtPrice.Text = "";
                txtPrice2.Text = "";
                txtQuantity.Text = "";
                txtName.Focus();

            }
            else
            {
                if (!txtName.Text.Equals("") || !txtPrice.Text.Equals("") || !txtPrice2.Text.Equals("") || !txtQuantity.Text.Equals(""))
                {
                    int id = 0;
                    string name = txtName.Text.Trim();
                    int quantity = 0;
                    try
                    {
                        quantity = Convert.ToInt32(txtQuantity.Text.Trim());
                        if (quantity < 0)
                        {
                            MessageBox.Show("Số lượng nhập vào phải lớn hơn 0");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Số lượng nhập vào phải là số nguyên");
                        return;
                    }
                    
                    int storeId = storeCbb.SelectedIndex + 1;
                    int typeId = typecbb.SelectedIndex;
                    int price =0;
                    try
                    {
                        price = Convert.ToInt32(txtPrice.Text.Trim());
                        if (price < 0)
                        {
                            MessageBox.Show("Giá nhập vào phải lớn hơn 0");
                            return;
                        }
                    }
                    catch (Exception exa)
                    {
                        MessageBox.Show("Giá nhập nhập vào phải là số nguyên");
                        return;
                    }

                    int price2 =0;
                    try
                    {
                        price2 = Convert.ToInt32(txtPrice2.Text.Trim());
                        if (price2 < 0)
                        {
                            MessageBox.Show("Giá nhập vào phải lớn hơn 0");
                            return;
                        }
                    }
                    catch (Exception exaa)
                    {
                        MessageBox.Show("Giá bán nhập vào phải là số nguyên");
                        return;
                    }

                    HangHoa p = new HangHoa(id, name, quantity, storeId, typeId, price, price2);
                    HangHoa.AddHangHoa(p);

                    //int billId = Bill.GetHighestId() + 1;
                    //int productId = Product.GetHighestId();
                    //int Quantity = Convert.ToInt32(txtQuantity.Text.Trim());


                    //Bill b = new Bill(billId, productId, name, Quantity, date, price, "Nhập");

                    //Bill.AddBill1(b);


                    RefreshDgv();
                }
                else MessageBox.Show("Hãy điền toàn bộ thông tin để thêm mới");
                
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            int id = 0;
            if (addNew != true)
            {
                id = Convert.ToInt32(txtID.Text.Trim());
            }

            string name = txtName.Text.Trim();
            int quantity = 0;
            try
            {
                quantity = Convert.ToInt32(txtQuantity.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số lượng nhập vào phải là số nguyên");
                return;
            }
            int storeId = storeCbb.SelectedIndex + 1;
            int typeId = typecbb.SelectedIndex ;
            int price = 0;
            try
            {
                price = Convert.ToInt32(txtPrice.Text.Trim());
            }
            catch (Exception exa)
            {
                MessageBox.Show("Giá nhập nhập vào phải là số nguyên");
                return;
            }
            int price2 = 0;
            try
            {
                price2 = Convert.ToInt32(txtPrice2.Text.Trim());
            }
            catch (Exception exaa)
            {
                MessageBox.Show("Giá bán nhập vào phải là số nguyên");
                return;
            }

            HangHoa p = new HangHoa(id, name, quantity, storeId,  typeId, price, price2);

            if (addNew == true)
            {

                if (HangHoa.AddHangHoa(p) > 0)
                    MessageBox.Show("Add success.");
                else
                    MessageBox.Show("Add false.");
            }
            else
            {
                if (HangHoa.UpdateHangHoa(p) > 0)
                    MessageBox.Show("Update success.");
                else
                    MessageBox.Show("Update false.");
            }
            // Refresh lai dgvCategory
            RefreshDgv();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (addNew != true )
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string id = txtID.Text.Trim();
                    HangHoa.DeleteHangHoa(id);
                    addNew = true;
                    RefreshDgv();
                }
            }else
                MessageBox.Show("Chọn hàng hóa để xóa");
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length != 0)
            {
                int danhmuc = cbbDanhMuc.SelectedIndex;
                if (HangHoa.searchHangHoa(txtTimKiem.Text.Trim(),danhmuc) > 0)
                {
                    
                    dgvHangHoa.DataSource = null;
                    dgvHangHoa.DataSource = HangHoaDAL.SearchHangHoa(txtTimKiem.Text.Trim(),danhmuc);
                    
                }
                else
                {
                    MessageBox.Show("The product not found!");
                    RefreshDgv();
                }
            }
            else
            {
                MessageBox.Show("Enter the product name to search, please!");
                RefreshDgv();
                txtTimKiem.Focus();
            }
        }

        private void dgvHangHoa_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
