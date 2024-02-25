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
    public partial class CarPrtsOrderDetaiFormForAdmin : Form
    {
        public CarPrtsOrderDetaiFormForAdmin()
        {
            InitializeComponent();
        }
        CarPartsOrderDetailForAdmin parts = new CarPartsOrderDetailForAdmin();
        private void CarPrtsOrderDetaiFormForAdmin_Load(object sender, EventArgs e)
        {
            parts.myGridView = loadDataTable;
            parts.view();
        }

        private void orderIdBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(orderIdBox.Text, out int parsedValue))
            {
                parts.orderId = parsedValue;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (orderIdBox.Text == "")
            {
                MessageBox.Show("Please Select Any Order Id!");
            }
            else
            {
                parts.orderDetailGridView = detailLoadtable;
                parts.paymentDetailGridView = paymentDetailGridView;
                parts.getOrderDetail();
                parts.getPaymentDetails();
            }
        }

        private void orderBtnDelivery_Click(object sender, EventArgs e)
        {

            if (orderIdBox.Text == "")
            {
                MessageBox.Show("Please Select Any Order Id!");
            }
            else
            {
                parts.OrderDelivery();
                parts.view();
                orderIdBox.Text = "";
            }
        }
    }
}
