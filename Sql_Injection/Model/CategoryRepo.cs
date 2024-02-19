using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sql_Injection.Model
{
    public class CategoryRepo
    {
        private readonly string _connectionString = "";
        public CategoryRepo(string ConnectionString)
        {
            _connectionString = ConnectionString;
        }

        public List<Category> GetCategoryList()
        {
            List<Category> categoryList = new List<Category>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("SELECT CategoryID,CategoryName,CategoryDescription FROM Categories",connection);
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
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

        public void AddCategory(Category category)
        {
            if (category is null)
                return;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Categories(CategoryID,CategoryName,CategoryDescription) VALUES(@CategoryID,@CategoryName,@CategoryDescription)");
                    command.Parameters.AddWithValue("CategoryID", Guid.NewGuid());
                    command.Parameters.AddWithValue("CategoryName", category.CategoryName);
                    command.Parameters.AddWithValue("CategoryDescription", category.CategoryDescription);

                    command.Connection = connection;

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();


                    var result = command.ExecuteNonQuery();
                    if (result > 0)
                        MessageBox.Show("Başarılı");
                    else
                        MessageBox.Show("Başarısız");

                    command.Dispose();
                    connection.Close();
                    connection.Dispose();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        public void UpdateCategory(Category category)
        {
            if (category is null)
                return;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("UPDATE Categories SET CategoryName = @CategoryName, CategoryDescription=@CategoryDescription WHERE CategoryID=@CategoryID");
                    command.Parameters.AddWithValue("CategoryID", category.CategoryID);
                    command.Parameters.AddWithValue("CategoryName", category.CategoryName);
                    command.Parameters.AddWithValue("CategoryDescription", category.CategoryDescription);

                    command.Connection = connection;

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();


                    var result = command.ExecuteNonQuery();
                    if (result > 0)
                        MessageBox.Show("Başarılı");
                    else
                        MessageBox.Show("Başarısız");

                    command.Dispose();
                    connection.Close();
                    connection.Dispose();

                }
                catch (SqlException ex)
                { 
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Delete(Guid ID)
        {
            if (ID == Guid.Empty)
                return;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("DELETE Categories WHERE CategoryID=@CategoryID");
                    command.Parameters.AddWithValue("CategoryID", ID);
 
                    command.Connection = connection;

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();


                    var result = command.ExecuteNonQuery();
                    if (result > 0)
                        MessageBox.Show("Başarılı");
                    else
                        MessageBox.Show("Başarısız");

                    command.Dispose();
                    connection.Close();
                    connection.Dispose();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
