using abc_car_traders.AppClass;
using abc_car_traders.LoginClass;
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
    public partial class CustomerDetailsForm : Form
    {
        UserRegitration user = new UserRegitration();
        AppClass.MyComClass comClass = new AppClass.MyComClass();
        string AddMessage = "Pleas Fill all fields"; 
        public CustomerDetailsForm()
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
            user.password = passwordBox.Text;
        }

       

        private void CustomerDetailsForm_Load(object sender, EventArgs e)
        {
            user.myGridView = loadDataTable;
            user.view();
        }

        private void loadDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            user.userId = Convert.ToInt32(loadDataTable.Rows[rowIndex].Cells[0].Value.ToString());
            firstNameBox.Text = loadDataTable.Rows[rowIndex].Cells[1].Value.ToString();
            lastNameBox.Text = loadDataTable.Rows[rowIndex].Cells[2].Value.ToString();
            nicBox.Text = loadDataTable.Rows[rowIndex].Cells[3].Value.ToString();
            telBox.Text = loadDataTable.Rows[rowIndex].Cells[4].Value.ToString();
            addressBox.Text = loadDataTable.Rows[rowIndex].Cells[5].Value.ToString();
            userNameBox.Text = loadDataTable.Rows[rowIndex].Cells[6].Value.ToString();
            passwordBox.Text = loadDataTable.Rows[rowIndex].Cells[7].Value.ToString();

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(IsNotValid())
            {
                MessageBox.Show(AddMessage);
            }else
            {
                user.UserRegistration();
                user.view();
                clearFields();
            }
         
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (IsNotValid())
            {
                MessageBox.Show(AddMessage);
            }
            else
            {
                user.Update();
                user.view();
                clearFields();
            }
         
        }

        private void deletBtn_Click(object sender, EventArgs e)
        {

            if (IsNotValid())
            {
                MessageBox.Show(AddMessage);
            }
            else
            {
                user.delete();
                user.view();
                clearFields();
            }
          
        }

        private void clearFields()
        {
            comClass.clearcontroles(firstNameBox, lastNameBox, nicBox, telBox, addressBox, userNameBox, passwordBox);

        }
        private bool IsNotValid()
        {
            return comClass.CheckValidateFields(firstNameBox, lastNameBox, nicBox, telBox, addressBox, userNameBox, passwordBox);
        }


    }
}
