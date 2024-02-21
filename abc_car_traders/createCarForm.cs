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
    public partial class createCarForm : Form
    {
        createCar car = new createCar();
        myComClass comClass = new myComClass();
        string addMessage = "Please Add Any Value";
        public createCarForm()
        {
            InitializeComponent();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            car.name = nameBox.Text;
        }

        private void brandBox_TextChanged(object sender, EventArgs e)
        {
            car.brand = brandBox.Text;
        }

        private void createCarForm_Load(object sender, EventArgs e)
        {
         
            car.myGridView = loadDataTable;
            car.view();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (comClass.IsAnyValueEmpty(nameBox.Text, brandBox.Text))
            {
                MessageBox.Show(addMessage);
            }else
            {
                car.save();
                clearFields();
            }
            
        }

        private void loadDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            car.Id = Convert.ToInt32(loadDataTable.Rows[rowIndex].Cells[0].Value.ToString());
            nameBox.Text = loadDataTable.Rows[rowIndex].Cells[1].Value.ToString();
            brandBox.Text = loadDataTable.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (comClass.IsAnyValueEmpty(nameBox.Text, brandBox.Text))
            {
                MessageBox.Show(addMessage);
            }
            else
            {
                car.Update();
                clearFields();
            }
           
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            if (comClass.IsAnyValueEmpty(nameBox.Text, brandBox.Text))
            {
                MessageBox.Show(addMessage);
            }
            else
            {
                car.delete();
                clearFields();
            }
          
        }

        private void clearFields()
        {
            nameBox.Text = "";
            brandBox.Text = "";
        }

      
    }
}
