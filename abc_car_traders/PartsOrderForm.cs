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
        int quantity;
        decimal price;
        int LoginUserId;
        PartsOrder parts = new PartsOrder();
        public PartsOrderForm()
        {
            InitializeComponent();

        }
        public PartsOrderForm(int loginUserId)
        {
            InitializeComponent();
            parts.userId = loginUserId;
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

        private void loadDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            idBox.Text = loadDataTable.Rows[rowIndex].Cells[0].Value.ToString();
            desBox.Text = loadDataTable.Rows[rowIndex].Cells[1].Value.ToString();
            unitPriceBox.Text = loadDataTable.Rows[rowIndex].Cells[3].Value.ToString();
           
        }

        private void qtyBox_TextChanged(object sender, EventArgs e)
        {
           string qty = qtyBox.Text != "" ? qtyBox.Text : "0";
            quantity = Convert.ToInt32(qty); 
            UpdateTotal();
        }

        private void unitPriceBox_TextChanged(object sender, EventArgs e)
        {
          
            price = Convert.ToDecimal(unitPriceBox.Text);
        }

        private void UpdateTotal()
        {
            decimal total = price * quantity;
            totalBox.Text = total.ToString();
         
        }   
        
    }
}
