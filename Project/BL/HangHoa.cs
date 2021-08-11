using Project.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Project.BL
{
    class HangHoa
    {
        private int id;
        private string tenHangHoa;
        private int soLuong;
        private int khoId;
        private int danhMucId;
        private int giaNhap;
        private int giaBan;

        public HangHoa(int id, string tenHangHoa, int soLuong, int khoId, int danhMucId, int giaNhap, int giaBan)
        {
            this.id = id;
            this.tenHangHoa = tenHangHoa;
            this.soLuong = soLuong;
            this.khoId = khoId;
            this.danhMucId = danhMucId;
            this.giaNhap = giaNhap;
            this.giaBan = giaBan;
        }

        

        public int Id { get => id; set => id = value; }
        public string TenHangHoa { get => tenHangHoa; set => tenHangHoa = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int KhoId { get => khoId; set => khoId = value; }
        public int DanhMucId { get => danhMucId; set => danhMucId = value; }
        public int GiaNhap { get => giaNhap; set => giaNhap = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }

        public static List<HangHoa> GetAllHangHoa()
        {
            List<HangHoa> products = new List<HangHoa>();
            DataTable dataTable = HangHoaDAL.GetAllHangHoa();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                int id = Convert.ToInt32(dataRow["Id"].ToString());
                string name = dataRow["Ten"].ToString();
                int quantity = Convert.ToInt32(dataRow["SoLuong"].ToString());
                int storeId = Convert.ToInt32(dataRow["KhoId"].ToString());
                int typeId = Convert.ToInt32(dataRow["DanhMucId"].ToString());
                int price = Convert.ToInt32(dataRow["GiaNhap"].ToString());
                int price2 = Convert.ToInt32(dataRow["GiaBan"].ToString());

                HangHoa product = new HangHoa(id, name, quantity, storeId, typeId, price, price2);
                products.Add(product);
            }

            return products;
        }


         
        public static int searchHangHoa(string str,int danhmuc)
        {
            ArrayList products = new ArrayList();
            DataTable dataTable = HangHoaDAL.SearchProduct(str,danhmuc);
            foreach (DataRow dr in dataTable.Rows)
            {
                products.Add("value");
            }
            return products.Count;
        }




        internal static int AddHangHoa(HangHoa product)
        {
            return HangHoaDAL.AddProduct(product);
        }
        public static int UpdateHangHoa(HangHoa product)
        {
            return HangHoaDAL.UpdateProduct(product);
        }

        public static int UpdateListProduct(List<Product> product)
        {
            return ProductDAL.UpdateListProduct(product);
        }
        internal static int DeleteHangHoa(string categoryId)
        {
            return HangHoaDAL.DeleteHangHoa(categoryId);
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

