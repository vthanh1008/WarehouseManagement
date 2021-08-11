using Project.BL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Project.DAL
{
    class BillDAL
    {
        internal static int AddBill(int id,string pId, string name, int quantity, string price, string store, string type,int lai)
        {
            
                string sql = "Insert into HoaDon VALUES(@BillId, @ProductId, @Name, @Quantity, @Store, @Type, @Price, getDate(),@lai)";
                SqlParameter[] param = new SqlParameter[] {

                new SqlParameter("@BillId", id),
                new SqlParameter("@ProductId", pId),
                new SqlParameter("@Name", name),
                new SqlParameter("@Quantity", quantity),
                new SqlParameter("@Store", store),
                new SqlParameter("@Type", type),

                new SqlParameter("@Price", price),

                new SqlParameter("@lai", lai),

                };
                
                Database.ExecuteSQL(sql, param);

            return 1;
            }
            


          

        


        internal static int AddBill1(Bill bill)
        {


            
                string sql = "Insert into Bill VALUES(@BillId, @ProductId, @Name, @Quantity, getdate(),@Price,'Nhập')";
                SqlParameter[] param = new SqlParameter[] {

                new SqlParameter("@BillId", SqlDbType.Int),
                new SqlParameter("@ProductId", SqlDbType.Int),
                new SqlParameter("@Name", SqlDbType.NVarChar),
                new SqlParameter("@Quantity", SqlDbType.Int),
                new SqlParameter("@Price", SqlDbType.Int),

                };
                ArrayList temp = new ArrayList();
                temp.Add(bill.BillId);
                temp.Add(bill.ProductId);
                temp.Add(bill.Name);
                temp.Add(bill.Quantity);
                temp.Add(bill.Price);
                for (int i = 0; i < temp.Count; i++)
                {
                    param[i].Value = temp[i];

                }
                return  Database.ExecuteSQL(sql, param);


            

        }



            public static DataTable GetAllBill()
        {
            string sql = "SELECT * FROM Bill";
            return Database.GetDataBySQL(sql);
        }

        internal static int GetHighestId()
        {
            string sql = "SELECT MAX(HoaDonId) FROM HoaDon";
            Database.GetDataBySQL(sql);
            DataTable dataTable = Database.GetDataBySQL(sql);

            
            int highest = 0;
            if (dataTable == null)
            {
                return highest;
            }
            else
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    try
                    {
                        highest = Convert.ToInt32(dataRow[0]);
                        return highest;
                    }
                    catch (Exception e)
                    {
                        return 0;
                    }

                    
                }
            }
            return highest;


        }
    }
}
