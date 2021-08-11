using Microsoft.VisualBasic;
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
    public partial class SaleUI : Form
    {
        public SaleUI()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaleUI_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn chkSelectColumn = new DataGridViewCheckBoxColumn();
            chkSelectColumn.Name = "chkColumn";
            chkSelectColumn.HeaderText = "Select";
            chkSelectColumn.ValueType = typeof(bool);
            productdgv.Columns.Add(chkSelectColumn);

            

            cbbType.DataSource = HangHoaDAL.getAllDanhMuc();
            cbbType.DisplayMember = "TenDanhMuc";
            cbbType.ValueMember = "DanhMucId";



            RefreshDgvCategory();




        }

        private void productdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void RefreshDgvCategory()
        {
            productdgv.DataSource = null;
            productdgv.DataSource = HangHoaDAL.GetAllHangHoaToSale();
        }

        private void addtobillbtn_Click(object sender, EventArgs e)
        {
            
            //DateTime d = DateTime.Now;
            //List<Bill> bills = new List<Bill>();

           

            //if (billdgv.ColumnCount != 0)
            //{
            //    foreach (DataGridViewRow row in billdgv.Rows)
            //    {

            //        int billId = Bill.GetHighestId();
            //        int productId = Convert.ToInt32(row.Cells["ProductId"].Value.ToString());
            //        string name = row.Cells["Name"].Value.ToString();
            //        int Quantity = Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
            //        int price = Convert.ToInt32(row.Cells["Price"].Value.ToString());

            //        Bill b = new Bill(billId, productId, name, Quantity, d, price, "Xuất");

            //        bills.Add(b);



            //    }
            //}
            //int count = 0;
            //foreach (DataGridViewRow row in productdgv.Rows)
            //{
            //    DataGridViewCheckBoxCell chk = row.Cells[0] as DataGridViewCheckBoxCell;
            //    if (Convert.ToBoolean(chk.Value) == true)
            //    {
            //        int billId = Bill.GetHighestId();
            //        int productId = Convert.ToInt32(row.Cells["ProductId"].Value.ToString());
            //        string name = row.Cells["Name"].Value.ToString();
            //        int Quantity = Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
            //        DateTime date = Convert.ToDateTime((row.Cells["Time"].Value.ToString()));
            //        int price = Convert.ToInt32(row.Cells["Price"].Value.ToString());

            //        Bill b = new Bill(billId, productId, name, Quantity, d,price,"Xuất");

            //        bills.Add(b);
            //        count++;
            //    }

            //}

            //if (count == 0)
            //{
            //    MessageBox.Show("Select the Product to add.");
            //} else
            //{
            //    billdgv.DataSource = bills;
            //}
        }

        private void addbillbtn_Click(object sender, EventArgs e)
        {
            
            //List<Bill> bills = new List<Bill>();
            //List<Product> product = new List<Product>();
            //DateTime d = DateTime.Now;
            //foreach (DataGridViewRow row in billdgv.Rows)
            //{
                
            //        int billId = BillDAL.GetHighestId()+1;
            //        int productId = Convert.ToInt32(row.Cells["ProductId"].Value.ToString());
            //        string name = row.Cells["Name"].Value.ToString();
            //        int Quantity = Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
            //        int price = Convert.ToInt32(row.Cells["Price"].Value.ToString());
            //    int storeId=1, typeId=1, quantity2 = 1;
            //    foreach (DataGridViewRow row1 in productdgv.Rows)
            //    {

            //        if (productId == Convert.ToInt32(row1.Cells["ProductId"].Value.ToString()))
            //        {
            //            quantity2 = Convert.ToInt32(row1.Cells["Quantity"].Value.ToString());
            //            storeId = Convert.ToInt32(row1.Cells["StoreId"].Value.ToString());
            //            typeId = Convert.ToInt32(row1.Cells["TypeId"].Value.ToString());
            //        }    

            //    }

            //    Bill b = new Bill(billId, productId, name, Quantity, d,price,"Xuất");
            //    Product p = new Product(productId, name, quantity2 - Quantity, storeId, d, typeId, price);
            //        bills.Add(b);
            //    product.Add(p);
                    

            //}
            //if (Bill.AddBill(bills) == 1) {
            //    MessageBox.Show("Add successful");
            //    Product.UpdateListProduct(product);
            //    RefreshDgvCategory();
            //};

        }

        private void deleteinbillbtn_Click(object sender, EventArgs e)
        {
            //List<Bill> bills1 = new List<Bill>();

            //int count = 0;
            //foreach (DataGridViewRow row in billdgv.Rows)
            //{
            //    DataGridViewCheckBoxCell chk = row.Cells[0] as DataGridViewCheckBoxCell;
            //    if (Convert.ToBoolean(chk.Value) != true)
            //    {
            //        int billId = Bill.GetHighestId();
            //        int productId = Convert.ToInt32(row.Cells["ProductId"].Value.ToString());
            //        string name = row.Cells["Name"].Value.ToString();
            //        int Quantity = Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
            //        DateTime date = Convert.ToDateTime((row.Cells["Date"].Value.ToString()));
            //        int price = Convert.ToInt32(row.Cells["Price"].Value.ToString());

            //        Bill b = new Bill(billId, productId, name, Quantity, date,price,"Xuất");

            //        bills1.Add(b);
            //        count++;
            //    }

            //}

            //if (count == 0)
            //{
            //    MessageBox.Show("Select the Product to add.");
            //} else
            //{
            //    billdgv.DataSource = bills1;
            //}
            
        }

        private void billdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addtobillbtn_Click_1(object sender, EventArgs e)
        {
            int count = billdgv.Rows.Count;
            foreach (DataGridViewRow row in productdgv.Rows)
            {
                int temp = 0;
                
                DataGridViewCheckBoxCell chk = row.Cells[0] as DataGridViewCheckBoxCell;
                foreach (DataGridViewRow row2 in billdgv.Rows)
                {
                    if (row2.Cells["Id"].Value.ToString().Equals(row.Cells["Id"].Value.ToString()))
                    {
                        temp = 1;
                        break;
                    }
                }

                if (Convert.ToBoolean(chk.Value) == true && temp!=1)
                {
                    billdgv.Rows.Add();
                    billdgv.Rows[count].Cells["Id"].Value = row.Cells["Id"].Value.ToString();
                    billdgv.Rows[count].Cells["Ten"].Value = row.Cells["Ten"].Value.ToString();
                    billdgv.Rows[count].Cells["Gia"].Value = row.Cells["GiaBan"].Value.ToString();
                    billdgv.Rows[count].Cells["SoLuong"].Value = "1";
                    billdgv.Rows[count].Cells["KhoId"].Value = row.Cells["KhoId"].Value.ToString();
                    billdgv.Rows[count].Cells["DanhMuc"].Value = row.Cells["DanhMucId"].Value.ToString();
                    count++;
                    
                }

            }

            
        }

        
        private void productdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void deleteinbillbtn_Click_1(object sender, EventArgs e)
        {
            billdgv.Rows.RemoveAt(temp);

        }
        int temp=0;
        private void billdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            temp = e.RowIndex;
        }

        private void addbillbtn_Click_1(object sender, EventArgs e)
        {
            int tongTien = 0;
            int lai = 0;
            string tenKhachHang = "";
            tenKhachHang = Interaction.InputBox("Nhập tên khách hàng", "Khách Hàng", "", 500, 300);
            if (!tenKhachHang.Equals(""))
            {
                int billId = BillDAL.GetHighestId() + 1;
                foreach (DataGridViewRow row in billdgv.Rows)
                {


                    string productId = row.Cells["Id"].Value.ToString();
                    string name = row.Cells["Ten"].Value.ToString();
                    int Quantity = Convert.ToInt32(row.Cells["SoLuong"].Value.ToString());
                    string price = row.Cells["Gia"].Value.ToString();
                    string khoId = row.Cells["KhoId"].Value.ToString();
                    string danhMucId = row.Cells["DanhMuc"].Value.ToString();
                    int quantity2 = 0;
                    int lai2 = ((Convert.ToInt32(price) - HangHoaDAL.GetGiaNhap(productId)) * Convert.ToInt32(Quantity));
                    lai += lai2;
                    tongTien += (Convert.ToInt32(price) * Convert.ToInt32(Quantity));
                    foreach (DataGridViewRow row1 in productdgv.Rows)
                    {

                        if (productId == row1.Cells["Id"].Value.ToString())
                        {
                             
                            quantity2 = Convert.ToInt32(row1.Cells["SoLuong"].Value.ToString());
                            if (Quantity > quantity2)
                            {
                                MessageBox.Show("Số lượng không được lớn hơn số lượng trong kho");

                                return;
                            }
                        }

                    }

                    BillDAL.AddBill(billId, productId, name, Quantity, price, khoId, danhMucId, lai2);
                    HangHoaDAL.UpdateProductQuantity(productId, quantity2 - Quantity);


                }

                HoaDonDAL.AddKhachHang(billId, tenKhachHang, tongTien,lai) ;
                MessageBox.Show("Add successful");
                RefreshDgvCategory();
            }
            
            
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length != 0)
            {
                if (Product.searchProduct(txtSearch.Text.Trim(), cbbType.SelectedIndex)>0)
                {
                    productdgv.DataSource = null;
                    productdgv.DataSource = HangHoaDAL.SearchProduct(txtSearch.Text.Trim(), cbbType.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("The product not found!");
                    RefreshDgvCategory();
                }
            }
            else
            {
                MessageBox.Show("Enter the product name to search, please!");
                RefreshDgvCategory();
                txtSearch.Focus();
            }
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = cbbType.SelectedIndex;
            if (id == 0)
            {
                productdgv.DataSource = null;
                productdgv.DataSource = HangHoaDAL.GetAllHangHoaToSale();
            }
            else
            {
                productdgv.DataSource = null;
                productdgv.DataSource = HangHoaDAL.GetAllHangHoaByType(id);
            }
        }

        private void SaleUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
        }
    }
}
