using abc_car_traders.LoginClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace abc_car_traders.MyComClass
{
    enum functionType
    {
        insert,
        update,
        delete,
        view,
        delivery

    }
    
    internal class DbClass
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BQ6F8LG\SQLEXPRESS;Initial Catalog=abc_cars;Integrated Security=True");

        public int id;
        public bool orderSaved = false;

     
        public bool executeQuery(string sql, functionType _functionType)
        {
            bool functionRunStatus = false;
            string message = "";
            bool functioStatus = false;

            if (_functionType == functionType.update)
            {
                if (MessageBox.Show("Do you want to update?", "Update Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    functionRunStatus = true;
                    message = "Update Successfully";
                }
            }
            else if (_functionType == functionType.delete)
            {
                if (MessageBox.Show("Do you Want to delete ? ", "Delet Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    functionRunStatus = true;
                    message = "Deleted Successfully";
                }

            }
            else if (_functionType == functionType.insert)
            {
                functionRunStatus = true;
                message = "Inserted Successfully";
            } else if (_functionType == functionType.delivery)
            {
                functionRunStatus = true;
                message = "Order Deliverd Successfully";
            }

            if (functionRunStatus)
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(sql, con);
                int rowsCount = cmd.ExecuteNonQuery();
                if (rowsCount > 0)
                {
                    MessageBox.Show(message);
                    functioStatus = true;
                }
                else
                {
                    MessageBox.Show("Contact With your IT Departmnet");
                }

                con.Close();
            }
            return functioStatus;

        }
        public User AuthenticateUser(string userName, string password, string sql)
        {
            con.Open();

            using (SqlCommand command = new SqlCommand(sql, con))
            {
                command.Parameters.AddWithValue("@userName", userName);
                command.Parameters.AddWithValue("@password", password);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        User user = new User
                        {
                            UserId = reader.GetInt32(0),
                            UserName = reader.GetString(1),
                            UserRole = reader.GetString(2)
                        };
                        
                        con.Close(); // Close the connection inside the using block
                        return user;
                    }
                }
            }

            con.Close(); // Close the connection in case of no user found
            return null;
        }

        public void loadDataFromDatabaseInGridView(string sql, DataGridView _loadtable)
        {
            SqlDataAdapter data = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            _loadtable.DataSource = dt;
        }
        public void partSearchFunction(string sql, DataGridView _loadtable, string carModel, string partName)
        {
            using (SqlDataAdapter data = new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();
                data.SelectCommand.Parameters.AddWithValue("@partName", (object)partName ?? DBNull.Value);
                data.SelectCommand.Parameters.AddWithValue("@carModel", (object)carModel ?? DBNull.Value);

                con.Open();
                data.Fill(dt);
                _loadtable.DataSource = dt;
                con.Close();
            }
        }
        //Method Over Loading
        public void partSearchFunction(string sql, DataGridView _loadtable, string carModel)
        {
            using (SqlDataAdapter data = new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();
                data.SelectCommand.Parameters.AddWithValue("@carModel", (object)carModel ?? DBNull.Value);

                con.Open();
                data.Fill(dt);
                _loadtable.DataSource = dt;
                con.Close();
            }
        }

        public void saveOrder(string orderQuery)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand(orderQuery, con);
           int rowsCount =  cmd.ExecuteNonQuery();

            cmd = new SqlCommand("SELECT SCOPE_IDENTITY()", con);
            id = Convert.ToInt32(cmd.ExecuteScalar());

            if(rowsCount > 0)
            {
                MessageBox.Show("Create Order Successfully!");
                orderSaved= true;
            }
            else
            {
                MessageBox.Show("Contact With your IT Departmnet");
            }

            con.Close();
        }

        public void executeorderQuery(string sql)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }




        public void loadDataInChart(string sql, Chart chart, string seriesName, string name, string quantity)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            chart.Series.Clear();

            Series series = new Series(seriesName);
            series.ChartType = SeriesChartType.Pie;
            series.Points.DataBind(dt.DefaultView, name, quantity, null);
            chart.Series.Add(series);

            chart.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            chartArea.AxisX.Title = name;
            chartArea.AxisY.Title = seriesName;

        }

    }



}

