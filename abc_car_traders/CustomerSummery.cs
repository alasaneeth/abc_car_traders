using abc_car_traders.AppClass;
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
    public partial class CustomerSummery : Form
    {
        CustomerReports customer = new CustomerReports();
        public CustomerSummery()
        {
            InitializeComponent();
            customer.customerComboBox = customerCombo;
            customer.loadCustomerUnCombo();
        }

    

        private void item_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomerSummery_Load(object sender, EventArgs e)
        {

        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            {
                customer.customerGridView = customerListGridView;

                if (itemCoboBox.Text == "Car")
                {
                    customer.orderSummeryByCar();
                }
                else if (itemCoboBox.Text == "Car Parts")
                {
                    customer.customerSummeryByParts();
                }
            }

        }

        private void customerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerCombo.SelectedValue != null && int.TryParse(customerCombo.SelectedValue.ToString(), out int selectedUserId))
            {
                customer.userId = selectedUserId;
            }
        }
    }
}