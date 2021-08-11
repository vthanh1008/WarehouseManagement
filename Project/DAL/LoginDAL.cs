using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using Project.BL;

namespace Project.DAL
{
    class LoginDAL
    {
        public static DataTable GetAllLogin()
        {
            string sql = "SELECT * FROM TaiKhoan";
            return Database.GetDataBySQL(sql);
        }
        public static DataTable GetAllLoginToDisplay()
        {
            string sql = "SELECT * FROM TaiKhoan where Id>1";
            return Database.GetDataBySQL(sql);
        }

        internal static int AddLogin(string name, string pass, string hoten, string diachi, string cmnd)
        {
            string sql = "INSERT INTO TaiKhoan values( @username, @password, @hoten, @diachi, @cmnd)";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@username", name),
                new SqlParameter("@password", pass),
                new SqlParameter("@hoten", hoten),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@cmnd", cmnd)
            };


            return Database.ExecuteSQL(sql, param);
        }


        public static DataTable searchAccount(string name)
        {
            string sql = "SELECT * FROM TaiKhoan where UserName LIKE '%" + name + "%'" ;
            return Database.GetDataBySQL(sql);
        }

        

        public static int UpdateLogin(int id, string name,string pass,string ten, string diachi, string cmnd)
        {
            string sql = "UPDATE TaiKhoan SET UserName=@name, Password=@pass, Ten=@ten, DiaChi=@diachi, CMND=@cmnd WHERE Id=@id";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@id", id),
                new SqlParameter("@name", name),
                new SqlParameter("@pass", pass),
                new SqlParameter("@ten", ten),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@cmnd", cmnd)
            };
            

            return Database.ExecuteSQL(sql, param);
        }

        internal static int DeleteLogin(string login)
        {
            string sql = "DELETE FROM TaiKhoan WHERE Id=@catId";
            SqlParameter param = new SqlParameter("@catId", SqlDbType.Char);
            // Gan gia tri cho cac tham so kieu SqlParameter
            param.Value = login;

            return Database.ExecuteSQL(sql, param);
        }
    }

   
}
