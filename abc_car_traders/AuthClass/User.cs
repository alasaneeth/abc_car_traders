using abc_car_traders.MyComClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_car_traders.LoginClass
{
    internal class User:DbClass
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }

        public bool loginStatus = false;

        
        



        public void login()
        {

            string sql = "SELECT users_table.userId,users_table.userName, UserRole_table.UserRole " +
                               "FROM users_table " +
                               "JOIN UserRole_table ON users_table.userId = UserRole_table.userId " +
                               "WHERE users_table.userName = @userName AND users_table.password = @password";

           User authernicateduser = AuthenticateUser(UserName, Password, sql);

            UserId = authernicateduser.UserId;

            

            if (authernicateduser.UserRole != null)
            {
                if (authernicateduser.UserRole == "admin")
                {
                    new AdminMenu().Show();
                    loginStatus = true;
                }
                else if (authernicateduser.UserRole == "customer")
                {
                    new CustomerMenu(UserId).Show();
                    loginStatus = true;
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }


        }
    }


}
