using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_Injection.Model
{
    public class HackRepo
    {
        private readonly string _connectionString = "";

        public HackRepo(string connectionString)
        {
            _connectionString = connectionString;
        }


        public List<Category> FilterProducts(string category)
        {
            List<Category> categoryList = new List<Category>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand($"SELECT CategoryID,CategoryName,CategoryDescription FROM Categories WHERE CategoryName Like '"+category+"%'");
                    command.Connection = connection;

                    if (connection.State == System.Data.ConnectionState.Closed)
                        connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if(reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            categoryList.Add(new Category()
                            {
                                CategoryID = Guid.Parse(reader["CategoryID"].ToString()),
                                CategoryName = reader["CategoryName"].ToString(),
                                CategoryDescription = reader["CategoryDescription"].ToString()
                            });
                        }
                    }

                    command.Dispose();
                    connection.Close();
                    connection.Dispose();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
 
                }


                return categoryList;
            }
        }
    }
}
