using abc_car_traders.MyComClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_car_traders.AppClass
{
    internal class CarOrderDetails:DbClass
    {
        public int userId { get; set; }
        public int orderId { get; set; }


        public DataGridView myGridView;

        public DataGridView orderDetailGridView;
        public void view()
        {
            string sql = "select orderId,totalAmount,status,date from car_orders where customerId ='" + userId + "'";
            loadDataFromDatabaseInGridView(sql, myGridView);
        }

        public void getOrderDetail ()
        {
            string sql = "select description,quantity,unitPrice,total  from car_order_details where orderId = '" + orderId+"'";
            loadDataFromDatabaseInGridView(sql, orderDetailGridView);
        }
    }
}

