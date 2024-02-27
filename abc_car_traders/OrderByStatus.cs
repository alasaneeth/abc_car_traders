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
    public partial class OrderByStatus : Form
    {
        OrderReport order = new OrderReport();
        public OrderByStatus()
        {
            InitializeComponent();
        }

        private void statusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            order.status = statusBox.Text;
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            order.orderDetailView = DetailGridView;
            order.orderSummeryGrid = summeryGridView;

            if (itemCoboBox.Text == "Car")  {
                order.carOrderDetailGrid();
                order.carOrderSummeryGrid();
            }else if (itemCoboBox.Text == "Car Parts")
            {
                order.partsOrderDetailGrid();
                order.partsOrderSummeryGrid();
            }

            
            
        }
    }
}
