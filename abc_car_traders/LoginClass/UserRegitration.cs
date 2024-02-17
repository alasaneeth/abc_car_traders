using abc_car_traders.MyComClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace abc_car_traders.LoginClass
{
    internal class UserRegitration:DbClass
    {
        public int userId { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string nic { get; set; }
        public string tel { get; set; }
        public string address { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string userRole { get; set; }

        public bool loginStatus;

        public void UserRegistration()
        {
            string sql = "INSERT INTO users_table (firstName, lastName, nic, tel, address, username, password) " +
                         "VALUES ('" + firstname + "', '" + lastname + "', '" + nic + "', '" + tel + "', '" + address + "', '" + userName + "', '" + password + "');" +
                         "INSERT INTO UserRole_table (UserRole, userId) " +
                         "SELECT 'customer', userId " +
                         "FROM users_table " +
                         "WHERE userName = '" + userName + "'";

                         loginStatus = executeQuery(sql, functionType.insert);
        }


    }
}
