using abc_car_traders.MyComClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_car_traders.AppClass
{
    internal class CarPartsOrderDetails:DbClass
    {
        public int userId { get; set; }
        public int orderId { get; set; }

        public DataGridView myGridView;

        public DataGridView orderDetailtable;

        public void view()
        {
            string sql = "select orderId,totalAmount,status,date from parts_order where customerId ='" + userId + "'";
            loadDataFromDatabaseInGridView(sql, myGridView);
        }

        public void getOrderDetail()
        {
            string sql = "select description,quantity,unitPrice,total  from parts_order_details where orderId = '" + orderId + "'";
            loadDataFromDatabaseInGridView(sql, orderDetailtable);
        }

    }
}
