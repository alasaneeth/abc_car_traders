using abc_car_traders.AppClass;
using abc_car_traders.LoginClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace abc_car_traders
{
    public partial class CarForm : Form
    {
        Car car = new Car();
        AppClass.MyComClass comClass = new AppClass.MyComClass();
        string AddMessage = "Pleas Fill all fields";

        public CarForm()
        {
            InitializeComponent();
        }

       

        private void fuelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            car.fuelType = fuelBox.Text;    
        }

        private void yearBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(yearBox.Text, out int year))
            {
                car.year =year;
            }
           
        }

        private void priceBox_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(priceBox.Text, out int price))
            {
                car.price = price;
            }
           
        }

        private void qtyBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(qtyBox.Text, out int qty))
            {
                car.qty = qty;
            }
        }

        private void saveBtn(object sender, EventArgs e)
        {
            if (IsNotValid())
            {
                MessageBox.Show(AddMessage);
            }
            else
            {
                car.save();
                car.view();
                clearFields();
            }
           
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
            if (IsNotValid())
            {
                MessageBox.Show(AddMessage);
            }
            else
            {
                car.Update();
                car.view();
                clearFields();
            }
           
        }

        private void deletBtn_Click(object sender, EventArgs e)
        {

            if (IsNotValid())
            {
                MessageBox.Show(AddMessage);
            }
            else
            {
                car.delete();
                car.view();
                clearFields();
            }
          
        }

        private void modelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            car.model = modelBox.Text;

        }
        private void clearFields()
        {
            comClass.clearcontroles(modelBox, fuelBox, yearBox, priceBox, qtyBox);

        }
        private bool IsNotValid()
        {
            return comClass.CheckValidateFields(modelBox, fuelBox, yearBox, priceBox, qtyBox);

        }

    }
}
