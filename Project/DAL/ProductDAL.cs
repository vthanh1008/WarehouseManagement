using Project.BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Project.DAL
{
    class ProductDAL
    {

      

        public static DataTable GetAllProduct()
        {
            string sql = "SELECT * FROM Products";
            return Database.GetDataBySQL(sql);
        }

        public static DataTable SearchProduct(string productName,string id)
        {
            string sql = "SELECT * FROM HangHoa WHERE Ten LIKE '" + productName + "%' and DanhMucId="+id;
            return Database.GetDataBySQL(sql);
        }

        public static DataTable getAllType()
        {
            string sql = "SELECT * FROM TypeProduct";
            return Database.GetDataBySQL(sql);
        }
        public static DataTable getAllStore()
        {
            string sql = "SELECT * FROM Store";
            return Database.GetDataBySQL(sql);
        }

        internal static int AddProduct(Product product)
        {
            string sql = "INSERT INTO Products values( @name, @quantity, @storeId, getDate(),@typeId, @price)";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@name", product.Name),
                new SqlParameter("@quantity", product.Quantity),
                new SqlParameter("@storeId", product.StoreId),
                new SqlParameter("@typeId", product.TypeId),
                new SqlParameter("@price", product.Price),

            };


            return Database.ExecuteSQL(sql, param);
        }

        public static int UpdateProduct(Product product)
        {
            string sql = "UPDATE Products SET  Name=@name, Quantity=@quantity, StoreID=@storeId, Time=getDate() ,TypeID=@typeId, Price=@price WHERE ProductID=@id";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@name", product.Name),
                new SqlParameter("@quantity", product.Quantity),
                new SqlParameter("@storeId", product.StoreId),
                new SqlParameter("@typeId", product.TypeId),
                new SqlParameter("@price", product.Price),
                new SqlParameter("@id", product.ProductId),


            };


            return Database.ExecuteSQL(sql, param);
        }

        public static int UpdateListProduct(List<Product> product)
        {
            for (int i = 0; i < product.Count; i++)
            {
                string sql = "UPDATE Products SET  Name=@name, Quantity=@quantity, StoreID=@storeId, Time=getDate() ,TypeID=@typeId, Price=@price WHERE ProductID=@id";
                SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@name", product[i].Name),
                new SqlParameter("@quantity", product[i].Quantity),
                new SqlParameter("@storeId", product[i].StoreId),
                new SqlParameter("@typeId", product[i].TypeId),
                new SqlParameter("@price", product[i].Price),
                new SqlParameter("@id", product[i].ProductId),
                    };
                Database.ExecuteSQL(sql, param);
            }
            return 1;
        }

        internal static int DeleteProduct(string categoryId)
        {
            string sql = "DELETE FROM Products WHERE ProductID=@catId";
            SqlParameter param = new SqlParameter("@catId", SqlDbType.Char);
            // Gan gia tri cho cac tham so kieu SqlParameter
            param.Value = categoryId;

            return Database.ExecuteSQL(sql, param);
        }


        internal static DataTable GetHighestId()
        {
            string sql = "SELECT MAX(ProductID) FROM Products";
            return Database.GetDataBySQL(sql);


        }
    }
}
