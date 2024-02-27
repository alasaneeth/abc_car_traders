using abc_car_traders.MyComClass;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_car_traders.AppClass
{
    internal class OrderReport : DbClass
    {
        public DataGridView orderDetailView {get;set;}
        public DataGridView orderSummeryGrid { get;set;}    
        public string status { get;set;}    

        public void carOrderDetailGrid()
        {
            string sql = "SELECT users_table.userId, users_table.firstName, users_table.lastName, car_orders.orderId, COUNT(car_orders.orderId) AS NoOrders,  SUM(car_orders.totalAmount) AS amoun FROM users_table INNER JOIN car_orders ON users_table.userId = car_orders.customerId WHERE car_orders.status = '" + status + "' GROUP BY users_table.userId, users_table.firstName, users_table.lastName, car_orders.orderId";
            loadDataFromDatabaseInGridView(sql, orderDetailView);
        }

        public void carOrderSummeryGrid()
        {
            string sql = "SELECT users_table.userId, users_table.firstName, users_table.lastName, COUNT(car_orders.orderId) AS NoOfOrders, SUM(car_orders.totalAmount) AS amount FROM users_table INNER JOIN car_orders ON users_table.userId = car_orders.customerId WHERE car_orders.status = '" + status + "' GROUP BY users_table.userId, users_table.firstName, users_table.lastName;";
            loadDataFromDatabaseInGridView(sql, orderSummeryGrid);
        }

        public void partsOrderDetailGrid()
        {
            string sql = "SELECT users_table.userId, users_table.firstName,  users_table.lastName, parts_order.orderId,  COUNT(parts_order.orderId) AS number Of Orders, SUM(parts_order.totalAmount) AS total Amount FROM users_table INNER JOIN parts_order ON users_table.userId = parts_order.customerId WHERE parts_order.status = '" + status + "' GROUP BY users_table.userId, users_table.firstName, users_table.lastName, parts_order.orderId;";
            loadDataFromDatabaseInGridView(sql, orderDetailView);
        }

        public void partsOrderSummeryGrid()
        {
            string sql = "SELECT users_table.userId, users_table.firstName,  users_table.lastName, COUNT(parts_order.orderId) AS number Of Orders,  SUM(parts_order.totalAmount) AS total Amount FROM users_table INNER JOIN parts_order ON users_table.userId = parts_order.customerId\r\n WHERE parts_order.status = 'Pending'\r\nGROUP BY users_table.userId, users_table.firstName, users_table.lastName;\r\n";
            loadDataFromDatabaseInGridView(sql, orderSummeryGrid);
        }
    }
}
