using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.BL
{
    class TempBill
    {
        private int billID;
        private int productID;
        private string name;
        private int quantity;
        private int price;

        public TempBill(int billID, int productID, string name, int quantity, int price)
        {
            this.billID = billID;
            this.productID = productID;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

        public int BillID { get => billID; set => billID = value; }
        public int ProductID { get => productID; set => productID = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
    }
}
