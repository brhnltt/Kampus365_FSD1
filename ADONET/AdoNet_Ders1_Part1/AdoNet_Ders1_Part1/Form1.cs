using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet_Ders1_Part1
{
    public partial class Form1 : Form
    {

        // Windows Auth
        string connectionString = @"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=True;";
        //string connectionString = @"Server=(localdb)\mssqllocaldb;Database=Northwind;Integrated Security=SSPI;";
        //string connectionString = Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;

        // SQL Auth
        //string connectionString = @"Server=(localdb)\mssqllocaldb;Database=Northwind;User Id=sa;Password=123456;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSqlConnectionOpenClose_Click(object sender, EventArgs e)
        {
            // Nuget den kur : System.Data.SqlClient


            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);


            connection.Open();

            MessageBox.Show("Bağlantı açıldı.");



            connection.Close();

            MessageBox.Show("Bağlantı kapatıldı.");

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // bağlantı sağlayıcı
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);

            string query = "SELECT CategoryID, CategoryName FROM Categories ORDER BY CategoryID ASC";

            // sorgu çalıştırıcı.
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);

            try
            {
                connection.Open();

                System.Data.SqlClient.SqlDataReader reader = command.ExecuteReader();
                System.Data.DataTable dt = new DataTable();

                dt.Columns.Add("CatID", typeof(int));
                dt.Columns.Add("CatName", typeof(string));

                while (reader.Read())
                {
                    int catId = (int)reader["CategoryID"];
                    string catName = (string)reader["CategoryName"];

                    DataRow row = dt.NewRow();
                    row["CatID"] = catId;
                    row["CatName"] = catName;

                    dt.Rows.Add(row);
                }

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu.");
                MessageBox.Show($"Hata Mesajı : {ex.Message}");
            }
            finally
            {
                if (connection.State != ConnectionState.Closed && connection.State != ConnectionState.Broken)
                {
                    connection.Close();
                }
            }
        }

        private void btnTotalCategoryIds_Click(object sender, EventArgs e)
        {
            // bağlantı sağlayıcı
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);

            string query = "SELECT CategoryID FROM Categories";

            // sorgu çalıştırıcı.
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);

            try
            {
                connection.Open();

                // Okuma amaçlı, select işlemlerinde.. (ExecuteReader)
                System.Data.SqlClient.SqlDataReader reader = command.ExecuteReader();
                decimal total = 0;

                while (reader.Read())
                {
                    //int catId = (int)reader["CategoryID"];
                    int catId = reader.GetInt32("CategoryID");
                    total += catId;
                }

                MessageBox.Show("Total : " + total);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu.");
                MessageBox.Show($"Hata Mesajı : {ex.Message}");
            }
            finally
            {
                if (connection.State != ConnectionState.Closed && connection.State != ConnectionState.Broken)
                {
                    connection.Close();
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // bağlantı sağlayıcı
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);

            string catName = txtInsertCatName.Text;
            //string query = "INSERT INTO Categories (CategoryName ,Description ,Picture) VALUES ('" + catName + "',NULL,NULL)";
            string query = $"INSERT INTO Categories (CategoryName ,Description ,Picture) VALUES ('{catName}',NULL,NULL)";

            // sorgu çalıştırıcı.
            //System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);

            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand();
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();

                // insert, update, delete ya da bir komut çalıştırma işlemlerinde.. (ExecuteNonQuery)
                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Kayıt eklendi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu.");
                MessageBox.Show($"Hata Mesajı : {ex.Message}");
            }
            finally
            {
                if (connection.State != ConnectionState.Closed && connection.State != ConnectionState.Broken)
                {
                    connection.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // bağlantı sağlayıcı
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);

            string catName = txtUpdCatName.Text;
            int catId = (int)nudUpdCatId.Value;
            //string query = "INSERT INTO Categories (CategoryName ,Description ,Picture) VALUES ('" + catName + "',NULL,NULL)";
            string query = $"UPDATE [dbo].[Categories] SET [CategoryName] = '{catName}' WHERE CategoryID = {catId}";

            // sorgu çalıştırıcı.
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);

            try
            {
                connection.Open();

                // insert, update, delete ya da bir komut çalıştırma işlemlerinde.. (ExecuteNonQuery)
                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("İlgili kayıt(lar) güncellendi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu.");
                MessageBox.Show($"Hata Mesajı : {ex.Message}");
            }
            finally
            {
                if (connection.State != ConnectionState.Closed && connection.State != ConnectionState.Broken)
                {
                    connection.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // bağlantı sağlayıcı
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);

            int catId = (int)nudDelCatId.Value;
            //string query = "INSERT INTO Categories (CategoryName ,Description ,Picture) VALUES ('" + catName + "',NULL,NULL)";
            string query = $"DELETE FROM [dbo].[Categories] WHERE CategoryID = {catId}";

            // sorgu çalıştırıcı.
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);

            try
            {
                connection.Open();

                // insert, update, delete ya da bir komut çalıştırma işlemlerinde.. (ExecuteNonQuery)
                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("İlgili kayıt(lar) silindi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu.");
                MessageBox.Show($"Hata Mesajı : {ex.Message}");
            }
            finally
            {
                if (connection.State != ConnectionState.Closed && connection.State != ConnectionState.Broken)
                {
                    connection.Close();
                }
            }
        }

        private void btnTotalCatExeScalar_Click(object sender, EventArgs e)
        {
            // bağlantı sağlayıcı
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);

            int catId = (int)nudDelCatId.Value;
            //string query = "INSERT INTO Categories (CategoryName ,Description ,Picture) VALUES ('" + catName + "',NULL,NULL)";
            string query = $"SELECT SUM(CategoryID) AS Total FROM Categories";

            // sorgu çalıştırıcı.
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);

            try
            {
                connection.Open();

                // insert, update, delete ya da bir komut çalıştırma işlemlerinde.. (ExecuteNonQuery)
                int result = (int)command.ExecuteScalar();

                MessageBox.Show($"Total Cat Id : {result}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu.");
                MessageBox.Show($"Hata Mesajı : {ex.Message}");
            }
            finally
            {
                if (connection.State != ConnectionState.Closed && connection.State != ConnectionState.Broken)
                {
                    connection.Close();
                }
            }
        }

        private int Execute(string query)
        {
            // bağlantı sağlayıcı
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);

            // sorgu çalıştırıcı.
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);

            int result = 0;

            try
            {
                connection.Open();

                // insert, update, delete ya da bir komut çalıştırma işlemlerinde.. (ExecuteNonQuery)
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu.");
                MessageBox.Show($"Hata Mesajı : {ex.Message}");
            }
            finally
            {
                if (connection.State != ConnectionState.Closed && connection.State != ConnectionState.Broken)
                {
                    connection.Close();
                }
            }

            return result;
        }

        private T ExecuteScalar<T>(string query) where T : struct
        {
            // bağlantı sağlayıcı
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);

            // sorgu çalıştırıcı.
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);

            object result = null;

            try
            {
                connection.Open();

                result = command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu.");
                MessageBox.Show($"Hata Mesajı : {ex.Message}");
            }
            finally
            {
                if (connection.State != ConnectionState.Closed && connection.State != ConnectionState.Broken)
                {
                    connection.Close();
                }
            }

            if (result == null)
            {
                return default(T);
            }
            else
            {
                return (T)result;
            }
        }
    }
}
