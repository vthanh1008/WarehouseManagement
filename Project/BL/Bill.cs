using Project.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Project.BL
{
    class Bill
    {
        private int billId;
        private int productId;
        private string name;
        private int quantity;
        private DateTime date;
        private int price;
        private string type;

        public Bill(int billId, int productId, string name, int quantity, DateTime date,int price, string type)
        {
            BillId = billId;
            ProductId = productId;
            Name = name;
            Quantity = quantity;
            Date = date;
            Price = price;
            Type = type;
        }

        public Bill()
        {
        }

        public int BillId { get => billId; set => billId = value; }
        public int ProductId { get => productId; set => productId = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Price { get => price; set => price = value; }
        public string Type { get => type; set => type = value; }

        //internal static int AddBill(List<Bill> bill)
        //{
        //    return BillDAL.AddBill(bill);
        //}

        internal static int AddBill1(Bill bill)
        {
            return BillDAL.AddBill1(bill);
        }

        //internal static int GetHighestId()
        //{
        //    DataTable dataTable = BillDAL.GetHighestId();
        //    int highest=0;
        //    foreach (DataRow dataRow in dataTable.Rows)
        //    {
        //        highest = Convert.ToInt32(dataRow[0]);
        //        return highest;
        //    }
        //    return highest;

        //}
        public static List<Bill> getAllBill()
        {
            List<Bill> bills = new List<Bill>();
            DataTable dataTable = BillDAL.GetAllBill();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                int billId = Convert.ToInt32(dataRow["BillId"].ToString());
                int productId = Convert.ToInt32(dataRow["ProductId"].ToString());
                string name = dataRow["Name"].ToString();
                int quantity = Convert.ToInt32(dataRow["Quantity"].ToString());
                DateTime date = Convert.ToDateTime(dataRow["Date"].ToString());
                int price = Convert.ToInt32(dataRow["Price"].ToString());
                string type = dataRow["Type"].ToString();

                Bill b = new Bill(billId, productId, name, quantity, date, price,type);
                bills.Add(b);
            }

            return bills;
        }
    }
}
