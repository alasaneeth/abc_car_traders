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
    public partial class CarStockInHandReport : Form
    {
        StockInHandReport stock = new StockInHandReport();
        public CarStockInHandReport()
        {
            InitializeComponent();
        }

        private void carComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carComboBox.SelectedValue != null && int.TryParse(carComboBox.SelectedValue.ToString(), out int selectedcarId))
            {
                stock.carId = selectedcarId;
            }
        }

        private void CarStockInHandReport_Load(object sender, EventArgs e)
        {
            stock.carCombo = carComboBox;
            stock.loadCarIncombo();
            stock.carStockTable = carStockTable;
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            if(carComboBox.SelectedIndex == -1) 
            {
                stock.loadAllCarStock();
            }else
            {
                stock.loadCarbyModel();
            }
        }
    }
}
