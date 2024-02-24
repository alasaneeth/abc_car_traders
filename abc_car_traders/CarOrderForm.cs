using abc_car_traders.AppClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace abc_car_traders
{
    public partial class CarOrderForm: Form
    {

        CarOrder car = new CarOrder();
         public int id;
        decimal lastTotal;
        decimal lineTotal;
        int quantity;
        decimal price;


        AppClass.MyComClass comClass = new AppClass.MyComClass();

        public CarOrderForm()
        {
            InitializeComponent();
        }
        public CarOrderForm(int loginUserId)
        {
            InitializeComponent();
            car.userId = loginUserId;
        }

        private void modelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            car.carModel = modelBox.Text;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            car.myGridView = loadDataTable;
            car.search();

        }

        private void loadDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            idBox.Text = loadDataTable.Rows[rowIndex].Cells[0].Value.ToString();
            desBox.Text = loadDataTable.Rows[rowIndex].Cells[1].Value.ToString();
            unitPriceBox.Text = loadDataTable.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {

            if (IsNotValidAdd())
            {
                MessageBox.Show("Please add values!");


            }
            else
            {
                orderDetails.Rows.Add(idBox.Text, desBox.Text, qtyBox.Text, unitPriceBox.Text, totalBox.Text);
                lastTotal += lineTotal;
                car.lastTotal = lastTotal;
                lblNetTotal.Text = lastTotal.ToString("N", CultureInfo.InvariantCulture);
                comClass.clearcontroles(idBox, desBox, qtyBox, unitPriceBox, totalBox);

            }
        }

        private void UpdateTotal()
        {
            lineTotal = price * quantity;

            totalBox.Text = lineTotal.ToString();

        }

        private bool IsNotValidAdd()
        {
            return comClass.CheckValidateFields(idBox, desBox, qtyBox, unitPriceBox, totalBox);
        }

        private void qtyBox_TextChanged(object sender, EventArgs e)
        {
            string qty = qtyBox.Text != "" ? qtyBox.Text : "0";
            quantity = Convert.ToInt32(qty);
            UpdateTotal();
        }

        private void unitPriceBox_TextChanged(object sender, EventArgs e)
        {

            if (Decimal.TryParse(unitPriceBox.Text, out decimal parsedValue))
            {
                // Parsing successful, update the 'price' variable with the parsed value
                price = parsedValue;
            }
        }

        private void holderBox_TextChanged(object sender, EventArgs e)
        {
            car.cardHolder = holderBox.Text;
        }

        private void cardNoBox_TextChanged(object sender, EventArgs e)
        {
            car.cardNo = cardNoBox.Text;
        }

        private void EXPBox_TextChanged(object sender, EventArgs e)
        {
            _ = EXPBox.Text == "MM/YY" ? EXPBox.ForeColor = Color.Silver : EXPBox.ForeColor = Color.Black;
            car.expiryDate = EXPBox.Text;
        }

        private void cvcBox_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(cvcBox.Text, out int cvc))
            {
                car.cvc = cvc;
            }
        }

        private void completeBtn_Click(object sender, EventArgs e)
        {
            if (orderDetails.Rows.Count == 0)
            {
                MessageBox.Show("Please add Order  Details!");
            }
            else if (IsNotValidComplete())
            {
                MessageBox.Show("Please add Payment Details!");
            }
            else
            {
                car.orderDetailGrid = orderDetails;
                car.complete();
                clearFields();
            }
        }
        private bool IsNotValidComplete()
        {
            return comClass.CheckValidateFields(EXPBox, holderBox, cardNoBox, cvcBox, paymentAmount);
        }

        private void paymentAmount_TextChanged(object sender, EventArgs e)
        {
            if (Decimal.TryParse(paymentAmount.Text, out Decimal paidTotal))
            {
                car.paymentAmount = paidTotal;
            }
        }
        private void clearFields()
        {
            comClass.clearcontroles(modelBox, loadDataTable, EXPBox, holderBox, cardNoBox, cvcBox, paymentAmount, orderDetails);
            lblNetTotal.Text = "0.00";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
