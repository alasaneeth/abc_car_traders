using abc_car_traders.MyComClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_car_traders.AppClass
{
    internal class CarPartsOrderDetailForAdmin:DbClass
    {
        public int orderId { get; set; }

        public DataGridView myGridView;

        public DataGridView orderDetailGridView;

        public DataGridView paymentDetailGridView;

        public void view()
        {
            string sql = "SELECT  po.orderId, ut.firstName,ut.lastName, po.totalAmount, po.status, po.date FROM     parts_order po JOIN     users_table ut ON po.customerId = ut.userId;";
            loadDataFromDatabaseInGridView(sql, myGridView);
        }

        public void getOrderDetail()
        {
            string sql = "select description,quantity,unitPrice,total  from parts_order_details where orderId = '" + orderId + "'";
            loadDataFromDatabaseInGridView(sql, orderDetailGridView);

        }

        public void getPaymentDetails()
        {
            string sql = "select cardHolder,cardNo,expiryDate,cvc,amount,paymentDate from payment where orderId = '" + orderId + "'";
            loadDataFromDatabaseInGridView(sql, paymentDetailGridView);
        }

        public void OrderDelivery()
        {
            string sql = "UPDATE parts_order SET status = 'delivered' WHERE orderId = '" + orderId + "'";
            executeQuery(sql, functionType.delivery);
        }
    }
}
