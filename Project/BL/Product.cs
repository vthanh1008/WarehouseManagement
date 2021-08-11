using Project.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Project.BL
{
    class Product
    {
        private int productId;
        private string name;
        private int quantity;
        private int storeId;
        private DateTime time;
        private int typeId;
        private int price;

        public Product(int productId, string name, int quantity, int storeId, DateTime time, int typeId,int price)
        {
            this.productId = productId;
            this.name = name;
            this.quantity = quantity;
            this.storeId = storeId;
            this.time = time;
            this.TypeId = typeId;
            this.price = price;
        }

        public int ProductId { get => productId; set => productId = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int StoreId { get => storeId; set => storeId = value; }
        public DateTime Time { get => time; set => time = value; }
        public int TypeId { get => typeId; set => typeId = value; }
        public int Price { get => price; set => price = value; }

        public static List<Product> GetAllProduct()
        {
            List<Product> products = new List<Product>();
            DataTable dataTable = ProductDAL.GetAllProduct();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                int id = Convert.ToInt32(dataRow["ProductID"].ToString());
                string name = dataRow["Name"].ToString();
                int quantity = Convert.ToInt32(dataRow["Quantity"].ToString());
                int storeId = Convert.ToInt32(dataRow["StoreId"].ToString());
                DateTime date = Convert.ToDateTime(dataRow["Time"].ToString());
                int typeId = Convert.ToInt32(dataRow["TypeID"].ToString());
                int price = Convert.ToInt32(dataRow["Price"].ToString());

                Product product = new Product(id, name, quantity, storeId, date, typeId, price);
                products.Add(product);
            }

            return products;
        }

        public static int searchProduct(string name, int id)
        {
            ArrayList list = new ArrayList();
            DataTable dataTable = HangHoaDAL.SearchProduct(name,id);
            foreach (DataRow dr in dataTable.Rows)
            {
                list.Add("value");
            }
            return list.Count;
            
        }


        internal static int AddProduct(Product product)
        {
            return ProductDAL.AddProduct(product);
        }
        public static int UpdateProduct(Product product)
        {
            return ProductDAL.UpdateProduct(product);
        }

        public static int UpdateListProduct(List<Product> product)
        {
            return ProductDAL.UpdateListProduct(product);
        }
        internal static int DeleteProduct(string categoryId)
        {
            return ProductDAL.DeleteProduct(categoryId);
        }

        internal static int GetHighestId()
        {
            DataTable dataTable = ProductDAL.GetHighestId();
            int highest = 0;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                highest = Convert.ToInt32(dataRow[0]);
                return highest;
            }
            return highest;

        }
    }
}
