using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Project.DAL
{
    class HoaDonDAL
    {
        public static DataTable GetAllHoaDon()
        {
            string sql = "SELECT * FROM HoaDon";
            return Database.GetDataBySQL(sql);
        }
        public static DataTable GetAllHoaDonById(string id)
        {
            string sql = "SELECT * FROM HoaDon where HoaDonId="+id;
            return Database.GetDataBySQL(sql);
        }
        public static DataTable GetAllKhachHang()
        {
            string sql = "SELECT * FROM KhachHang";
            return Database.GetDataBySQL(sql);
        }

        public static DataTable GetAllDate()
        {
            string sql = "SELECT DISTINCT NgayMua FROM KhachHang";
            return Database.GetDataBySQL(sql);
        }
        public static DataTable GetAllDataBetween(string date1, string date2)
        {
            string sql = "SELECT * FROM KhachHang where NgayMua between '" + date1 + "' and '" + date2 + "'";
            return Database.GetDataBySQL(sql);
        }

        public static DataTable SearchHoaDon(string name)
        {
            
                string sql = "SELECT * FROM KhachHang WHERE TenKhachHang LIKE '%" + name + "%'";
                return Database.GetDataBySQL(sql);
            
        }
        internal static int AddKhachHang(int id, string name,int tien,int lai)
        {
            string sql = "INSERT INTO KhachHang values( @id, @name, getDate(),@tien,@lai)";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@id", id),
                new SqlParameter("@name", name),

                new SqlParameter("@tien", tien),

                new SqlParameter("@lai", lai),

            };


            return Database.ExecuteSQL(sql, param);
        }
    }
}
