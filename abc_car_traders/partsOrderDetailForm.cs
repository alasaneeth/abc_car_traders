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
    public partial class partsOrderDetailForm : Form
    {

        CarPartsOrderDetails parts = new CarPartsOrderDetails();
        public partsOrderDetailForm()
        {
            InitializeComponent();
        }

        public partsOrderDetailForm(int userId)
        {
            InitializeComponent();
            parts.userId = userId;
        }

        private void partsOrderDetailForm_Load(object sender, EventArgs e)
        {
            parts.myGridView = loadDataTable;
            parts.view();
        }

        private void orderIdBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(orderIdBox.Text, out int parsedValue))
            {
                // Parsing successful, update the 'price' variable with the parsed value
                parts.orderId = parsedValue;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            parts.orderDetailtable = detailLoadtable;
            parts.getOrderDetail();
            
        }
    }
}
