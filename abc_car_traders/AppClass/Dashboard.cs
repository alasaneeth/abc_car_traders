using abc_car_traders.MyComClass;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace abc_car_traders.AppClass
{
    internal class Dashboard:DbClass
    {
        public Chart carOrderChart;
        public Chart partsOrderChart;
     public void displayCarOrder()
      {
            string sql = "SELECT description, SUM(quantity) AS totalQuantity FROM car_order_details GROUP BY description;";
            string serisName = "Total Car Orders";
            string name = "description";
            string qunatity = "totalQuantity";
            loadDataInChart(sql, carOrderChart, serisName, name, qunatity);
           
      }

      public void displayPartsOrder()
        {
            string sql = "SELECT description, SUM(quantity) AS totalQuantity FROM parts_order_details GROUP BY description;";
            string serisName = "Total Prts Orders";
            string name = "description";
            string qunatity = "totalQuantity";
            loadDataInChart(sql, partsOrderChart, serisName, name, qunatity);

        }
    }
}
