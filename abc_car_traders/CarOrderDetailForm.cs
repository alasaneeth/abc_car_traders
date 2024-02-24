﻿using abc_car_traders.AppClass;
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
    public partial class CarOrderDetailsForm : Form
    {

        CarOrderDetails car = new CarOrderDetails();
        public CarOrderDetailsForm()
        {
            InitializeComponent();
        }
        public CarOrderDetailsForm(int userId)
        {
            InitializeComponent();
            car.userId = userId;
        }

        private void CarOrderDetailsForm_Load(object sender, EventArgs e)
        {
            car.myGridView = loadDataTable;
            car.view();
        }

        private void desBox_TextChanged(object sender, EventArgs e)
        {
            car.orderId = Convert.ToInt16(orderIdBox.Text);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            car.orderDetailGridView = detailLoadtable;
            car.getOrderDetail();
        }
    }
}
