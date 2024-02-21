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

        private void loadDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            idBox.Text = loadDataTable.Rows[rowIndex].Cells[0].Value.ToString();
            desBox.Text = loadDataTable.Rows[rowIndex].Cells[1].Value.ToString();
            unitPriceBox.Text = loadDataTable.Rows[rowIndex].Cells[3].Value.ToString();
           
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            stockHistry.Rows.Add(idBox.Text, desBox.Text, qtyBox.Text, unitPriceBox.Text,totalBox.Text);
            clearFiled();
            CalculateTotalSum();
        }

        private void clearFiled()
        {
            idBox.Text = "";
            desBox.Text = "";
            qtyBox.Text = "0";
            unitPriceBox.Text ="0.00";
            totalBox.Text = "0.00";
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

        private void CalculateTotalSum()
        {
            decimal sum = 0;

            foreach (DataGridViewRow row in stockHistry.Rows)
            {
                string totalStringValue = row.Cells[4].Value?.ToString();

                sum += decimal.TryParse(totalStringValue, out decimal totalValue) ? totalValue : 0;
            }
           parts.lastTotal = sum;
           lastTotal.Text = sum.ToString();
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            //if(stockHistry.Rows.Count == 0)
            //{
            //    MessageBox.Show("Please Add Products");
            //    return;

            //}
            //if(nameBox.Text== "" || bankBox.Text == "" ||  cardNoBox.Text == "" ||  cvcBox.Text == "" ||  amountBox.Text == "")
            //{
            //    MessageBox.Show("Please fill Payment Details");
            //    return;
            //}

            parts.saveParcelOrder();
        }
    }
}
