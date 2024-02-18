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
    public partial class PartsOrderForm : Form
    {
        PartsOrder parts = new PartsOrder();
        public PartsOrderForm()
        {
            InitializeComponent();
        }

        private void modelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            parts.carModel = modelBox.Text;
        }

        private void partNameBox_TextChanged(object sender, EventArgs e)
        {
            parts.partName = partNameBox.Text;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            parts.myGridView = loadDataTable;
            parts.search();
        }
    }
}
