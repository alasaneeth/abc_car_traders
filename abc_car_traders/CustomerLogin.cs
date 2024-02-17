using ABC_Car_TRADERS.MyAppClass;
using ABC_Car_TRADERS.MyComClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_TRADERS
{
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            string sql = "SELECT COUNT(*) FROM Customer WHERE Username = @Username AND Password = @Password";
           
            if (user.Login(sql))
            {
            
                new CustomerMenu().Show();
                this.Hide();
             
            }
         
           
        }

       
    }
}
