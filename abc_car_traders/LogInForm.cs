using abc_car_traders.LoginClass;
using abc_car_traders.MyComClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_car_traders
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
        private User authenticatedUser;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            string userName = usernameBox.Text;
            string password = passwordBox.Text;
            DbClass authentication = new DbClass();

            string sql = "SELECT users_table.userId,users_table.userName, UserRole_table.UserRole " +
                               "FROM users_table " +
                               "JOIN UserRole_table ON users_table.userId = UserRole_table.userId " +
                               "WHERE users_table.userName = @userName AND users_table.password = @password";


            authenticatedUser = authentication.AuthenticateUser(userName, password, sql);

            if (authenticatedUser != null)
            {
                if (authenticatedUser.UserRole == "admin")
                {
                    new AdminMenu().Show();
                    this.Hide();
                }
                else if (authenticatedUser.UserRole == "customer")
                {
                    new CustomerMenu().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }

            }
        }
    }
}
