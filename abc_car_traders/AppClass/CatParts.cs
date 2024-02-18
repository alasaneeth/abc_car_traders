using abc_car_traders.MyComClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace abc_car_traders.AppClass
{
    internal class CatParts:DbClass
    {
        public int Id { get; set; }
        public string partName { get; set; }
        public string carModel { get; set; }
        public decimal price { get; set; }
        public int qty { get; set; }
        public DataGridView myGridView { get; set; }

        public void save()
        {
            string sql = "INSERT INTO Parts ( partName, carModel, Price, AvailableQuantity) VALUES  ( '" + partName + "','" + carModel + "'," + price + ", " + qty + ")";
            if (executeQuery(sql, functionType.insert))
            {
                view();
            };

        }
        public void view()
        {
            string sql = "select * from Parts;";
            loadDataFromDatabaseInGridView(sql, myGridView);
        }

        public void Update()
        {
            string sql = "update Parts set carModel ='" + carModel + "', Price='" + price + "', AvailableQuantity='" + qty + "' where partId  = '" + Id + "'";
            if (executeQuery(sql, functionType.update))
            {
                view();
            }
        }

        public void delete()
        {
            string sql = "Delete from Parts where partId =" + Id;
            if (executeQuery(sql, functionType.delete))
            {
                view();
            }

        }

    }
}
