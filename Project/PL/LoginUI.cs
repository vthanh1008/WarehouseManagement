using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Project.BL;
using Project.DAL;

namespace Project.PL
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            List<Login> list = new List<Login>();
            list = Login.GetAllLogin();
            int temp = 1;
            if (list!=null)
            {
                foreach(Login lg in list)
                {
                    if (usertxt.Text.Equals(lg.Username) && passtxt.Text.Equals(lg.Password) && usertxt.Text.Equals("admin"))
                    {
                        
                        AdminUI admin = new AdminUI();
                        admin.Show();
                        temp = 0;
                        
                        break;
                    }
                    if (usertxt.Text.Equals(lg.Username) && passtxt.Text.Equals(lg.Password) && !usertxt.Text.Equals("admin"))
                    {
                        
                        SaleUI sale = new SaleUI();
                        sale.Show();
                        temp = 0;
                        
                        break;
                    }

                };
                if(temp==1)
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu! Hãy thử lại.");

                };



            }
            else
            {
                MessageBox.Show("DatabaseNull!");
                
            }
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {
            passtxt.PasswordChar = '*';
        }
    }
}
