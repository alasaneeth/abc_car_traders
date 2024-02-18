using abc_car_traders.MyComClass;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public DataGridView myGridView { get; set; }


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

        public void view()
        {
            string sql = "SELECT users_table.* FROM users_table JOIN UserRole_table ON users_table.userId = UserRole_table.userId WHERE UserRole_table.UserRole = 'customer'";
            loadDataFromDatabaseInGridView(sql, myGridView);
        }

        public void Update()
        {
            string sql = "UPDATE users_table " +
                        "SET firstName = '" + firstname + "', " +
                        "lastName = '" + lastname + "', " +
                        "nic = '" + nic + "', " +
                        "tel = '" + tel + "', " +
                        "address = '" + address + "', " +
                        "password = '" + password + "' " +
                        "WHERE userId = '" + userId + "'";

            if (executeQuery(sql, functionType.update))
            {
                view();
            }
        }

        public void delete()
        {
            string sql = "DELETE FROM UserRole_table " +
                         "FROM UserRole_table INNER JOIN users_table " +
                         "ON UserRole_table.userId = users_table.userId " +
                         "WHERE users_table.userId = '" + userId + "'; " +
                         "DELETE FROM users_table " +
                         "WHERE userId = '" + userId + "';";

            if (executeQuery(sql, functionType.delete))
            {
                view();
            }
        }


    }
}
