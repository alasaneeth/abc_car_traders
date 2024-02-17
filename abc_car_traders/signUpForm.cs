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
    public partial class signUpForm : Form
    {

        UserRegitration user = new UserRegitration();
        DbClass dbClass = new DbClass();
        public signUpForm()
        {
            InitializeComponent();
        }

        private void firstNameBox_TextChanged(object sender, EventArgs e)
        {
            user.firstname = firstNameBox.Text;
        }

        private void lastNameBox_TextChanged(object sender, EventArgs e)
        {
            user.lastname = lastNameBox.Text;
        }

        private void nicBox_TextChanged(object sender, EventArgs e)
        {
            user.nic = nicBox.Text;
        }

        private void telBox_TextChanged(object sender, EventArgs e)
        {
            user.tel = telBox.Text;
        }

        private void addressBox_TextChanged(object sender, EventArgs e)
        {
            user.address = addressBox.Text;
        }

        private void userNameBox_TextChanged(object sender, EventArgs e)
        {
            user.userName = userNameBox.Text;
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            user.password = PasswordBox.Text;
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            user.UserRegistration();
           if(user.loginStatus == true)
            {
                new LogInForm().Show();
                this.Hide();

            } 
        }
    }
}
