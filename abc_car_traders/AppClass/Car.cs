using abc_car_traders.MyComClass;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace abc_car_traders.AppClass
{
    internal class Car:DbClass
    {
        public int Id { get; set; }
        public string model { get; set; }
        public string fuelType { get; set; }
        public int year { get; set; }
        public decimal price { get; set; }
        public int qty { get; set; }
        public DataGridView myGridView { get; set; }

        public void save()
        {
            string sql = "INSERT INTO Cars (carModel,fuelType, year, Price, AvailableQuantity) VALUES  ( '" + model + "','" + fuelType + "'," + year + ", " + price + ", " + qty + ")";
            executeQuery(sql, functionType.insert);
        }

    }
}
