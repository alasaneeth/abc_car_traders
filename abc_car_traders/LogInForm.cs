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
        
        User user =  new User();
     

        private void logInBtn_Click(object sender, EventArgs e)
        {
            user.login();

            if (user.loginStatus == true)
            {
                this.Hide();
            }
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
               user.UserName = usernameBox.Text;
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            user.Password = passwordBox.Text;
        }
    }
}
