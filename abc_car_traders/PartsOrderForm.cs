using abc_car_traders.AppClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        decimal lastTotal;
        int LoginUserId;
        decimal lineTotal;
        PartsOrder parts = new PartsOrder();
        public PartsOrderForm()
        {
            InitializeComponent();
            parts.orderDetailGrid = orderDetails;

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
             lineTotal = price * quantity;
          
            totalBox.Text = lineTotal.ToString("N", CultureInfo.InvariantCulture);// display as coma sepearator

        }


        private void totalBox_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            orderDetails.Rows.Add(idBox.Text, desBox.Text, qtyBox.Text, unitPriceBox.Text, totalBox.Text);
            lastTotal += lineTotal;
            parts.lastTotal = lastTotal;
            lblNetTotal.Text = lastTotal.ToString("N", CultureInfo.InvariantCulture);

        }

        private void completeBtn_Click(object sender, EventArgs e)
        {
            parts.orderDetailGrid = orderDetails;
            parts.complete();
        }

 

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    

        private void nameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            parts.partName = nameBox.Text;
        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            new PaymentForm().Show();
        }

        private void EXPBox_TextChanged(object sender, EventArgs e)
        {
            _ = EXPBox.Text == "MM/YY" ? EXPBox.ForeColor = Color.Silver : EXPBox.ForeColor = Color.Black;
            parts.expiryDate = EXPBox.Text;
        }

        private void holderBox_TextChanged(object sender, EventArgs e)
        {
            parts.cardHolder = holderBox.Text;
        }

        private void cardNoBox_TextChanged(object sender, EventArgs e)
        {
            parts.cardNo = cardNoBox.Text;
        }

        private void cvcBox_TextChanged(object sender, EventArgs e)
        {
            parts.cvc = Convert.ToInt16(cvcBox.Text);
        }

        private void paymentAmount_TextChanged(object sender, EventArgs e)
        {
            parts.paymentAmount = Convert.ToDecimal(paymentAmount.Text);
        }
    }
}
