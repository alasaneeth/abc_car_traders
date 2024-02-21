using abc_car_traders.MyComClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_car_traders.AppClass
{
    internal class PartsOrder:DbClass
    {
        public string carModel {  get; set; }
        public string partName { get; set; }
        public int userId { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public decimal lastTotal { get; set; }
        public DataGridView myGridView { get; set; }


     
        public void search()
        {
            string sql = "SELECT * FROM Parts WHERE (@partName IS NULL OR partName = @partName OR partName LIKE '%' + @partName + '%') AND (@carModel IS NULL OR carModel = @carModel OR carModel LIKE '%' + @carModel + '%')";
            partSearchFunction(sql, myGridView, carModel, partName);
        }

        public void saveParcelOrder()
        {
            MessageBox.Show(lastTotal.ToString());
        }
        

    }
}
