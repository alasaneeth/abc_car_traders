using abc_car_traders.MyComClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_car_traders.AppClass
{
    internal class PartsOrder:DbClass
    {
        public string carModel {  get; set; }
        public string partName { get; set; }
        public int customerId { get; set; }
        public decimal lastTotal { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public int userId { get; set; } 
        public DataGridView myGridView { get; set; }

        public ComboBox partsCombo { get; set; }

        public DataGridView orderDetailGrid { get; set; }

        public void search()
        {
            string sql = "SELECT * FROM car_parts WHERE (@partName IS NULL OR name = @partName OR name LIKE '%' + @partName + '%') AND (@carModel IS NULL OR carModel = @carModel OR carModel LIKE '%' + @carModel + '%')";
            partSearchFunction(sql, myGridView, carModel, partName);
        }

       public void complete()
        {
            string orderQuery = "insert into parts_order (customerId,totalAmount,date) values ('"+ userId + "','"+ lastTotal + "',GETDATE())";
            saveOrder(orderQuery);
            OrderDetails();

        }

        public void OrderDetails()
        {
            for(int i = 0; i < orderDetailGrid.Rows.Count; i++)
            {
                string orderDetailQuery = $"INSERT INTO parts_order_details (orderId, description, quantity, unitPrice, total) VALUES ('" + id + "', '" + orderDetailGrid.Rows[i].Cells[0].Value + "', '" + orderDetailGrid.Rows[i].Cells[1].Value + "', '" + orderDetailGrid.Rows[i].Cells[2].Value + "', '" + orderDetailGrid.Rows[i].Cells[3].Value + "')";
                saveOrderDetails(orderDetailQuery);
            }

        }



    }
}
