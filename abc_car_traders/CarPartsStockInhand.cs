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
    public partial class CarPartsStockInhand : Form
    {

        StockInHandReport stock = new StockInHandReport();
        public CarPartsStockInhand()
        {
            InitializeComponent();
        }

        private void partsCobmoBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            stock.partsName = partsCobmoBox.Text;
        }

        private void carComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stock.carName = carComboBox.Text;
        }

        private void CarPartsStockInhand_Load(object sender, EventArgs e)
        {
            stock.carCombo = carComboBox;
            stock.partsCombo = partsCobmoBox;
            stock.loadCarIncombo();
            stock.loadPartsIncombo();
            stock.carPartsStockTable = carPartsStockTable;
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            if(carComboBox.Text == "" && partsCobmoBox.Text == "")
            {
                stock.loadAllParts();
            }else if(carComboBox.Text == "")
            {
                stock.loadpartsByName();
            }else if(partsCobmoBox.Text == "")
            {
                stock.loadPartsbyCarModel();
            }else
            {
                stock.loadPartsWithCarModel();
            }
        }
    }
}
