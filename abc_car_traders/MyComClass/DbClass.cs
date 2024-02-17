using abc_car_traders.LoginClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_car_traders.MyComClass
{
    enum functionType
    {
        insert,
        update,
        delete,
        view
       
    }
    internal class DbClass
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BQ6F8LG\SQLEXPRESS;Initial Catalog=abc_cars;Integrated Security=True");

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
                    // loadTablefun();
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

                            return user;
                        }
                    }
                }
            

            return null;
        }
    }

}

