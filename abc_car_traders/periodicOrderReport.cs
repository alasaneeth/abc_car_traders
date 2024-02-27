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
    public partial class periodicOrderReport : Form
    {
        OrderReport order = new OrderReport();
        public periodicOrderReport()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void periodicOrderReport_Load(object sender, EventArgs e)
        {
            order.periodicOrderGrid = periodicOrderGrid;
        }

        private void fromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            order.fromDate = fromDatePicker.Text;
        }

        private void toDatePicker_ValueChanged(object sender, EventArgs e)
        {
            order.toDate = toDatePicker.Text;
        }

        private void itemCoboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void periodicOrderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void findBtn_Click(object sender, EventArgs e)
        {
          
            if(itemCoboBox.Text == "")
            {
                MessageBox.Show("Please Select any Order Type");
            }
             else if(itemCoboBox.Text == "Car")
            {
                order.periodicCarOrderSummery();

            }else if(itemCoboBox.Text == "Car Parts")
            {
                order.periodicPartsOrderSummery();
            } 
           

        }
    }
}
