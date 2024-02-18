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


        public Parts()
        {
            InitializeComponent();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
          parts.partName = nameBox.Text;    

        }

        private void modelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            parts.carModel = modelBox.Text;
        }

        private void priceBox_TextChanged(object sender, EventArgs e)
        {
            parts.price = Convert.ToDecimal(priceBox.Text);
        }

        private void qtyBox_TextChanged(object sender, EventArgs e)
        {
            parts.qty = Convert.ToInt32(qtyBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parts.save();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            parts.Update();
        }

        private void deletBtn_Click(object sender, EventArgs e)
        {
            parts.delete();
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
    }
}
