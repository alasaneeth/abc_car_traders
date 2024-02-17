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
    public partial class CarForm : Form
    {
        Car car = new Car();
        public CarForm()
        {
            InitializeComponent();
        }

        private void modelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            car.model = modelBox.Text;
        }

        private void fuelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            car.fuelType = fuelBox.Text;    
        }

        private void yearBox_TextChanged(object sender, EventArgs e)
        {
            car.year = Convert.ToInt32(yearBox.Text);
        }

        private void priceBox_TextChanged(object sender, EventArgs e)
        {
            car.price = Convert.ToDecimal(priceBox.Text);
        }

        private void qtyBox_TextChanged(object sender, EventArgs e)
        {
            car.qty = Convert.ToInt32(qtyBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            car.save();
        }
    }
}
