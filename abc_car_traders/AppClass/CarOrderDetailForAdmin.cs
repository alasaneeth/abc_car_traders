using abc_car_traders.LoginClass;
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
    internal class CarOrderDetailForAdmin : DbClass
    {
        public int orderId { get; set; }

        public DataGridView myGridView;

        public DataGridView orderDetailGridView;

        public DataGridView paymentDetailGridView;

        public void view()
        {
            string sql = "SELECT  co.orderId,u.firstName,u.lastName,co.totalAmount,co.status,co.date FROM   car_orders co JOIN    users_table u ON co.customerId = u.userId;";
            loadDataFromDatabaseInGridView(sql, myGridView);
        }

        public void getOrderDetail()
        {
            string sql = "select description,quantity,unitPrice,total  from parts_order_details where orderId = '"+ orderId + "'";
            loadDataFromDatabaseInGridView(sql, orderDetailGridView);
          
        }
        
        public void getPaymentDetails()
        {
            string sql = "select cardHolder,cardNo,expiryDate,cvc,amount,paymentDate from car_order_payment where orderId = '"+ orderId + "'";
            loadDataFromDatabaseInGridView(sql, paymentDetailGridView);
        } 

        public void OrderDelivery()
        {
            string sql = "UPDATE car_orders SET status = 'delivered' WHERE orderId = '"+ orderId + "'";
            executeQuery(sql,functionType.delivery);
        }

    }
}
