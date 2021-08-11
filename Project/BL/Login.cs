using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using System.Collections;
using Project.DAL;

namespace Project.BL
{
    class Login
    {
        private int id;
        private string username;
        private string password;

        public Login(int id, string username, string password)
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }

        public Login()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }



        public static List<Login> GetAllLogin()
        {
            List<Login> logins = new List<Login>();
            DataTable dataTable = LoginDAL.GetAllLogin();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                int id = Convert.ToInt32(dataRow["Id"].ToString());
                string pass = dataRow["Password"].ToString();
                string user = dataRow["UserName"].ToString();

                Login login = new Login(id, user, pass);
                logins.Add(login);
            }

            return logins;
        }

        

        
        public static List<Login> searchAccount(string name)
        {
            List<Login> login = new List<Login>();
            DataTable dataTable = LoginDAL.searchAccount(name);
            foreach (DataRow dr in dataTable.Rows)
            {
                int id = Convert.ToInt32(dr["id"].ToString());
                string user = dr["name"].ToString();
                string pass = dr["pass"].ToString();
                Login log = new Login(id, user, pass);
                login.Add(log);
            }
            return login;
        }

       

        internal static int DeleteLogin(string id)
        {
            return LoginDAL.DeleteLogin(id);
        }

    }

}
