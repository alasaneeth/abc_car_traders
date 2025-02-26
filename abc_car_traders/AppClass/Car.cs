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
    internal class Car : DbClass
    {
      
        public int Id { get; set; }

        public string Model { get; set; }

        public string FuelType { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public DataGridView MyGridView { get; set; }

        /// Saves a new car record to the database.
        public void Save()
        {
            string sql = "INSERT INTO cars (model, fuelType, year, Price, AvailableQuantity) VALUES  ('" + Model + "','" + FuelType + "'," + Year + ", " + Price + ", " + Quantity + ")";
            if (ExecuteQuery(sql, FunctionType.Insert))
            {
                View();
            }
        }

        /// Retrieves and displays all car records from the database.
        public void View()
        {
            string sql = "SELECT * FROM Cars;";
            LoadDataFromDatabaseInGridView(sql, MyGridView);
        }

        /// Updates an existing car record in the database.
        public void Update()
        {
            string sql = "UPDATE cars SET model = '" + Model + "', fuelType = '" + FuelType + "', year = " + Year + ", Price = " + Price + ", AvailableQuantity = " + Quantity + " WHERE id = '" + Id + "'";
            if (ExecuteQuery(sql, FunctionType.Update))
            {
                View();
            }
        }

        /// Deletes a car record from the database.
        public void Delete()
        {
            string sql = "DELETE FROM cars WHERE id =" + Id;
            if (ExecuteQuery(sql, FunctionType.Delete))
            {
                View();
            }
        }
    }
}
