using abc_car_traders.MyComClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace abc_car_traders.AppClass
{
    internal class StockInHandReport:DbClass
    {
        public ComboBox carCombo {get; set;}

        public ComboBox partsCombo { get; set;}
        public int carId { get; set;}

        public string carName { get; set;}
        public string partsName { get; set;}

        public DataGridView carStockTable { get; set;}
        public DataGridView carPartsStockTable { get; set;} 

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

        public void loadAllParts()
        {
            string sql = "select * from car_parts";
            loadDataFromDatabaseInGridView(sql, carPartsStockTable);
        }

        public void loadPartsWithCarModel()
        {
            string sql = "select * from car_parts where name ='"+ partsName + "' And carModel = '"+ carName + "'";
            loadDataFromDatabaseInGridView(sql, carPartsStockTable);
        }

        public void loadpartsByName()
        {
            string sql = "select* from car_parts where name = '"+ partsName + "'; ";
            loadDataFromDatabaseInGridView(sql, carPartsStockTable);
        }

        public void loadPartsbyCarModel()
        {
            string sql = "select * from car_parts where carModel = '"+ carName + "' ";
            loadDataFromDatabaseInGridView(sql, carPartsStockTable);
        }


        public void loadCarIncombo()
        {
            string sql = "select id,model from cars";
            string displayMembr = "model";
            string valueMember = "id";
            loadCombobox( sql,carCombo, displayMembr, valueMember);
        }
        public void loadPartsIncombo()
        {
            string sql = "select id,name from car_parts";
            string displayMembr = "name";
            string valueMember = "id";
            loadCombobox(sql, partsCombo, displayMembr, valueMember);
        }
    }
}
