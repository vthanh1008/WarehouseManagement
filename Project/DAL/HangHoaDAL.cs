using Project.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Project.DAL
{
    class HangHoaDAL
    {
        public static DataTable GetAllHangHoa()
        {
            string sql = "SELECT * FROM HangHoa";
            return Database.GetDataBySQL(sql);
        }
        public static DataTable GetAllHangHoaToSale()
        {
            string sql = "SELECT Id,Ten,SoLuong,KhoId,DanhMucId,GiaBan FROM HangHoa where SoLuong>0";
            return Database.GetDataBySQL(sql);
        }

        public static DataTable GetAllHangHoaByType(int typeid)
        {
            string sql = "SELECT Id,Ten,SoLuong,KhoId,DanhMucId,GiaBan FROM HangHoa where DanhMucId = "+ typeid;
            return Database.GetDataBySQL(sql);
        }

        public static DataTable SearchHangHoa(string productName, int danhmuc)
        {
            if (danhmuc == 0)
            {
                string sql = "SELECT Id,Ten,SoLuong,KhoId,DanhMucId,GiaBan FROM HangHoa WHERE Ten LIKE '%" + productName + "%'";
                return Database.GetDataBySQL(sql);
            }
            else
            {
                string sql = "SELECT Id,Ten,SoLuong,KhoId,DanhMucId,GiaBan FROM HangHoa WHERE Ten LIKE '%" + productName + "%' and DanhMucId=" + danhmuc;
                return Database.GetDataBySQL(sql);
            }
        }
        public static DataTable SearchProduct(string productName,int danhmuc)
        {
            if (danhmuc == 0)
            {
                string sql = "SELECT Id,Ten,SoLuong,KhoId,DanhMucId,GiaBan FROM HangHoa WHERE Ten LIKE '%" + productName + "%'";
                return Database.GetDataBySQL(sql);
            }
            else
            {
                string sql = "SELECT Id,Ten,SoLuong,KhoId,DanhMucId,GiaBan FROM HangHoa WHERE Ten LIKE '%" + productName + "%' and DanhMucId=" + danhmuc;
                return Database.GetDataBySQL(sql);
            }
        }

        public static DataTable getAllDanhMuc()
        {
            string sql = "SELECT * FROM DanhMuc";
            return Database.GetDataBySQL(sql);
        }
        public static DataTable getAllKho()
        {
            string sql = "SELECT KhoId as 'Mã Kho Hàng' ,TenKho as 'Tên Kho Hàng' FROM Kho";
            return Database.GetDataBySQL(sql);
        }

        public static DataTable searchKho(string name)
        {
            string sql = "SELECT * FROM Kho where TenKho like '%"+name+"%'";
            return Database.GetDataBySQL(sql);
        }
        public static DataTable searchDanhMuc(string name)
        {
            string sql = "SELECT * FROM DanhMuc where TenDanhMuc like '%" + name + "%'";
            return Database.GetDataBySQL(sql);
        }

        internal static int AddProduct(HangHoa product)
        {
            string sql = "INSERT INTO HangHoa values( @name, @quantity, @storeId,@typeId, @price, @price2)";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@name", product.TenHangHoa),
                new SqlParameter("@quantity", product.SoLuong),
                new SqlParameter("@storeId", product.KhoId),
                new SqlParameter("@typeId", product.DanhMucId),
                new SqlParameter("@price", product.GiaNhap),
                new SqlParameter("@price2", product.GiaBan),

            };


            return Database.ExecuteSQL(sql, param);
        }

        internal static int AddKho(string name)
        {
            string sql = "INSERT INTO Kho values( @name)";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@name", name),
                
            };


            return Database.ExecuteSQL(sql, param);
        }

        internal static int AddDanhMuc(string name)
        {
            string sql = "INSERT INTO DanhMuc values( @name)";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@name", name),

            };


            return Database.ExecuteSQL(sql, param);
        }

        internal static int UpdateKho(int id, string name)
        {
            string sql = "UPDATE Kho SET TenKho=@name where KhoId=@id";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@name", name),
                new SqlParameter("@id", id),


            };


            return Database.ExecuteSQL(sql, param);
        }
        internal static int UpdateDanhMuc(int id, string name)
        {
            string sql = "UPDATE DanhMuc SET TenDanhMuc=@name where DanhMucId=@id";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@name", name),
                new SqlParameter("@id", id),
            };


            return Database.ExecuteSQL(sql, param);
        }

        internal static int DeleteKho(string id)
        {
            string sql = "DELETE FROM Kho WHERE KhoId=@catId";
            SqlParameter param = new SqlParameter("@catId", SqlDbType.Char);
            // Gan gia tri cho cac tham so kieu SqlParameter
            param.Value = id;

            return Database.ExecuteSQL(sql, param);
        }
        internal static int DeleteDanhMuc(string id)
        {
            string sql = "DELETE FROM DanhMuc WHERE DanhMucId=@catId";
            SqlParameter param = new SqlParameter("@catId", SqlDbType.Char);
            // Gan gia tri cho cac tham so kieu SqlParameter
            param.Value = id;

            return Database.ExecuteSQL(sql, param);
        }

        public static int UpdateProduct(HangHoa product)
        {
            string sql = "UPDATE HangHoa SET  Ten=@name, SoLuong=@quantity, KhoId=@storeId,DanhMucId=@typeId, GiaNhap=@price,GiaBan=@price2 WHERE Id=@id";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@name", product.TenHangHoa),
                new SqlParameter("@quantity", product.SoLuong),
                new SqlParameter("@storeId", product.KhoId),
                new SqlParameter("@typeId", product.DanhMucId),
                new SqlParameter("@price", product.GiaNhap),
                new SqlParameter("@price2", product.GiaBan),
                new SqlParameter("@id", product.Id),


            };


            return Database.ExecuteSQL(sql, param);
        }
        public static int UpdateProductQuantity(string id, int quantity)
        {
            string sql = "UPDATE HangHoa SET SoLuong=@quantity WHERE Id=@id";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@quantity", quantity),
                new SqlParameter("@id", id),


            };


            return Database.ExecuteSQL(sql, param);
        }

        //public static int UpdateListProduct(List<Product> product)
        //{
        //    for (int i = 0; i < product.Count; i++)
        //    {
        //        string sql = "UPDATE Products SET  Name=@name, Quantity=@quantity, StoreID=@storeId, Time=getDate() ,TypeID=@typeId, Price=@price WHERE ProductID=@id";
        //        SqlParameter[] param = new SqlParameter[] {
        //        new SqlParameter("@name", product[i].Name),
        //        new SqlParameter("@quantity", product[i].Quantity),
        //        new SqlParameter("@storeId", product[i].StoreId),
        //        new SqlParameter("@typeId", product[i].TypeId),
        //        new SqlParameter("@price", product[i].Price),
        //        new SqlParameter("@id", product[i].ProductId),
        //            };
        //        Database.ExecuteSQL(sql, param);
        //    }
        //    return 1;
        //}

        internal static int DeleteHangHoa(string categoryId)
        {
            string sql = "DELETE FROM HangHoa WHERE Id=@catId";
            SqlParameter param = new SqlParameter("@catId", SqlDbType.Char);
            // Gan gia tri cho cac tham so kieu SqlParameter
            param.Value = categoryId;

            return Database.ExecuteSQL(sql, param);
        }



        internal static int GetGiaNhap(string id)
        {
            string sql = "SELECT GiaNhap FROM HangHoa where Id="+id;
            Database.GetDataBySQL(sql);
            DataTable dataTable = Database.GetDataBySQL(sql);

            int giaban = 0;
            if (dataTable == null)
            {
                return giaban;
            }
            else
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {

                    giaban = Convert.ToInt32(dataRow[0]);
                    return giaban;
                }
            }
            return giaban;


        }

        //internal static DataTable GetHighestId()
        //{
        //    string sql = "SELECT MAX(ProductID) FROM Products";
        //    return Database.GetDataBySQL(sql);


        //}
    }
}
