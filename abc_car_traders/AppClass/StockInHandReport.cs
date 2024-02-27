using abc_car_traders.MyComClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_car_traders.AppClass
{
    internal class StockInHandReport:DbClass
    {
        public ComboBox carCombo {get; set;}
        public int carId { get; set;}

        public DataGridView carStockTable { get; set;}

        public void loadAllCarStock()
        {

            string sql = "select * from cars";
            loadDataFromDatabaseInGridView(sql, carStockTable);
        }

        public void loadCarbyModel()
        {

            string sql = "select * from cars where id ='"+ carId + "'";
            loadDataFromDatabaseInGridView(sql, carStockTable);
        }
        public void loadCarIncombo()
        {
            string sql = "select id,model from cars";
            string displayMembr = "model";
            string valueMember = "id";
            loadCombobox( sql,carCombo, displayMembr, valueMember);
        }
    }
}
