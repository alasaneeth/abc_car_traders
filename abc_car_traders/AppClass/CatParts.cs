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
        public string carmodel { get; set; }
        public decimal price { get; set; }
        public int qty { get; set; }
        public DataGridView myGridView { get; set; }

        public void save()
        {
            string sql = "INSERT INTO car_parts ( name, carModel, price, availableQty) VALUES  ( '" + partName + "','" + carmodel + "'," + price + ", " + qty + ")";
            if (executeQuery(sql, functionType.insert))
            {
                view();
            };

        }
        public void view()
        {
            string sql = "select * from car_parts;";
            loadDataFromDatabaseInGridView(sql, myGridView);
        }

        public void Update()
        {
            string sql = "update car_parts set carModel ='" + carmodel + "', Price='" + price + "', availableQty='" + qty + "' where id  = '" + Id + "'";
            if (executeQuery(sql, functionType.update))
            {
                view();
            }
        }

        public void delete()
        {
            string sql = "Delete from car_parts where id =" + Id;
            if (executeQuery(sql, functionType.delete))
            {
                view();
            }

        }

    }
}
