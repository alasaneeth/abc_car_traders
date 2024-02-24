using abc_car_traders.MyComClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_car_traders.AppClass
{
    internal class CarOrder:DbClass
    {
        public string carModel { get; set; }
        public int customerId { get; set; }
        public decimal lastTotal { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public int userId { get; set; }
        public string cardHolder { get; set; }
        public string cardNo { get; set; }
        public string expiryDate { get; set; }
        public int cvc { get; set; }
        public decimal paymentAmount { get; set; }
        public DataGridView myGridView { get; set; }
        public string status = "Pending";
        public DataGridView orderDetailGrid { get; set; }

        public void search()
        {
            string sql = "SELECT * FROM cars WHERE (@carModel IS NULL OR model = @carModel OR model LIKE '%' + @carModel + '%')";
            partSearchFunction(sql, myGridView, carModel);
        }

        public void complete()
        {
            string orderQuery = "insert into car_orders (customerId,totalAmount,status,date) values ('" + userId + "','" + lastTotal + "','" + status + "', GETDATE())";
            saveOrder(orderQuery);
            string paymentQuery = "insert into car_order_payment (orderId,cardHolder,cardNo,expiryDate,cvc,amount,paymentDate)  values ('" + id + "','" + cardHolder + "','" + cardNo + "', '" + expiryDate + "','" + cvc + "','" + paymentAmount + "', GETDATE())";
            executeorderQuery(paymentQuery);
            OrderDetails();
        }

        public void OrderDetails()
        {
            for (int i = 0; i < orderDetailGrid.Rows.Count; i++)
            {
                string orderDetailQuery = $"INSERT INTO car_order_details (orderId, description, quantity, unitPrice, total) VALUES ('" + id + "', '" + orderDetailGrid.Rows[i].Cells[1].Value + "', '" + orderDetailGrid.Rows[i].Cells[2].Value + "', '" + orderDetailGrid.Rows[i].Cells[3].Value + "', '" + orderDetailGrid.Rows[i].Cells[4].Value + "')";

                executeorderQuery(orderDetailQuery);
                string StockUpdate = $"  UPDATE cars SET AvailableQuantity = AvailableQuantity - '" + orderDetailGrid.Rows[i].Cells[2].Value + "'  WHERE id = '" + orderDetailGrid.Rows[i].Cells[0].Value + "' ";
                executeorderQuery(StockUpdate);

            }


        }


    }
}
