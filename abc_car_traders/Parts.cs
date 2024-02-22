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

    public partial class Parts : Form
    {
        CatParts parts = new CatParts();
        AppClass.MyComClass comClass = new AppClass.MyComClass();
        string AddMessage = "Pleas Fill all fields";

        public Parts()
        {
            InitializeComponent();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
          parts.partName = nameBox.Text;    

        }

        private void priceBox_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(priceBox.Text, out int price))
            {
                parts.price = price;
            }
        }

        private void qtyBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(qtyBox.Text, out int qty))
            {
                parts.qty = qty;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (IsNotValid())
            {
                MessageBox.Show(AddMessage);
            }
            else
            {
                parts.save();
                parts.view();
                clearFields();
            }
          
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (IsNotValid())
            {
                MessageBox.Show(AddMessage);
            }
            else
            {
                parts.Update();
                parts.view();
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
                parts.delete();
                parts.view();
                clearFields();
            }
        }

        private void Parts_Load(object sender, EventArgs e)
        {
            parts.myGridView = loadDataTable;
            parts.view();
        }

        private void loadDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            parts.Id = Convert.ToInt32(loadDataTable.Rows[rowIndex].Cells[0].Value.ToString());
            nameBox.Text = loadDataTable.Rows[rowIndex].Cells[1].Value.ToString();
            modelBox.Text = loadDataTable.Rows[rowIndex].Cells[2].Value.ToString();
            priceBox.Text = loadDataTable.Rows[rowIndex].Cells[3].Value.ToString();
            qtyBox.Text = loadDataTable.Rows[rowIndex].Cells[4].Value.ToString();

        }

        private void modelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            parts.carmodel = modelBox.Text;
        }
        private void clearFields()
        {
            comClass.clearcontroles(nameBox, modelBox, priceBox, qtyBox);

        }
        private bool IsNotValid()
        {
           
                return comClass.CheckValidateFields(nameBox, modelBox, priceBox, qtyBox); 

        }
    }
}
