using abc_car_traders.AppClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_car_traders
{
    public partial class CarOrderDetailFormForAdmin : Form
    {
        CarOrderDetailForAdmin car = new CarOrderDetailForAdmin();
        public CarOrderDetailFormForAdmin()
        {
            InitializeComponent();
        }

        private void CarOrderDetailForAdmin_Load(object sender, EventArgs e)
        {
            car.myGridView = loadDataTable;
            car.view();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(orderIdBox.Text == "")
            {
                MessageBox.Show("Please Select Any Order Id!");
            } else
            {
                car.orderDetailGridView = detailLoadtable;
                car.paymentDetailGridView = paymentDetailGridView;
                car.getOrderDetail();
                car.getPaymentDetails();
            }
           
        }   

        private void orderIdBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(orderIdBox.Text, out int parsedValue))
            {
                car.orderId = parsedValue;
            }
        }

        private void orderBtnDelivery_Click(object sender, EventArgs e)
        {
            if(orderIdBox.Text == "")
            {
                MessageBox.Show("Please Select Any Order Id!");
            } else
            {
                car.OrderDelivery();
                car.view();
                orderIdBox.Text = "";
            }
         
        }
    }
}
