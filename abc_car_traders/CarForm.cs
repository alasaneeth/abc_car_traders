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

        private void loadDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            car.Id = Convert.ToInt32(loadDataTable.Rows[rowIndex].Cells[0].Value.ToString());
            modelBox.Text = loadDataTable.Rows[rowIndex].Cells[1].Value.ToString();
            fuelBox.Text = loadDataTable.Rows[rowIndex].Cells[2].Value.ToString();
            yearBox.Text = loadDataTable.Rows[rowIndex].Cells[3].Value.ToString();
            priceBox.Text = loadDataTable.Rows[rowIndex].Cells[4].Value.ToString();
            qtyBox.Text = loadDataTable.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            car.myGridView = loadDataTable;
            car.view();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            car.Update();
        }

        private void deletBtn_Click(object sender, EventArgs e)
        {
            car.delete();
        }
    }
}
