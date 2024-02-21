using abc_car_traders.MyComClass;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_car_traders.AppClass
{
    class createCar:DbClass
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string brand { get; set; }
        public DataGridView myGridView { get; set; }

        public void save() {
            string sql = "insert into carnames (name, brand) values ('"+ name + "','"+ brand + "')";
            if (executeQuery(sql, functionType.insert)) {
                view();
            }
           
        }

        public void view()
        {
            string sql = "select * from carnames;";
            loadDataFromDatabaseInGridView(sql, myGridView);
        }
        public void Update()
        {
            string sql = "update carnames set name='" + name + "' , brand='" + brand + "'  where id = '" + Id + "'";
            if (executeQuery(sql, functionType.update))
            {
                view();
            }
        }

        public void delete()
        {
            string sql = "Delete from carnames where id =" + Id;
            if (executeQuery(sql, functionType.delete))
            {
                view();
            }

        }

        

    }
}
