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
    internal class CustomerReports:DbClass
    {
        public ComboBox customerComboBox;

        public DataGridView customerGridView;
        public int userId;


        public void loadCustomerUnCombo()
        {
            string sql = "SELECT u.lastName, u.userId FROM users_table u JOIN UserRole_table ur ON u.userId = ur.userId WHERE ur.UserRole = 'customer'";
            string displayMember = "lastName";
            string valueMember = "userId"; 
            loadCombobox(sql, customerComboBox, displayMember, valueMember);
        }

        public void findCustomerInGrid ()
        {
            string sql = "select * from users_table where userId = '"+ userId + "';";
            loadDataFromDatabaseInGridView(sql, customerGridView);
        }

        public void findAllCustomer()
        {
            string sql = "SELECT * FROM users_table u JOIN UserRole_table ur ON u.userId = ur.userId WHERE ur.UserRole = 'customer'";
            loadDataFromDatabaseInGridView(sql, customerGridView);
        }

        public void orderSummeryByCar()
        {
            string sql = "SELECT od.description, MIN(od.unitPrice) AS unitPrice, SUM(od.quantity) AS totalQuantity,   SUM(od.total) AS totalOrderAmount FROM  users_table u JOIN   car_orders o ON u.userId = '"+userId+"' JOIN   car_order_details od ON o.orderId = od.orderId GROUP BY  od.description;";
            loadDataFromDatabaseInGridView(sql, customerGridView);
        }

        public void customerSummeryByParts()
        {
            string sql = "SELECT od.description,  MIN(od.unitPrice) AS unitPrice, SUM(od.quantity) AS totalQuantity,  SUM(od.total) AS totalOrderAmount  FROM  users_table u JOIN  parts_order o ON u.userId = '"+userId+"' JOIN parts_order_details od ON o.orderId = od.orderId GROUP BY  od.description";
            loadDataFromDatabaseInGridView(sql, customerGridView);
        }

    }
}
