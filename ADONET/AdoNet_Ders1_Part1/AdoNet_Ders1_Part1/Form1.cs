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
            string catName = txtInsertCatName.Text;
            string query = $"INSERT INTO Categories (CategoryName ,Description ,Picture) VALUES ('{catName}',NULL,NULL)";

            // insert, update, delete ya da bir komut çalıştırma işlemlerinde.. (ExecuteNonQuery)
            int result = Execute(query);

            if (result > 0)
            {
                MessageBox.Show("Kayıt eklendi.");
                btnSelect_Click(btnSelect, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Kayıt eklenemedi.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string catName = txtUpdCatName.Text;

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seçili satır yok. Güncelleme için lütfen bir ya da birden çok satır seçiniz.");
                return;
            }

            //if (dataGridView1.SelectedRows.Count > 1)
            //{
            //    MessageBox.Show("Lütfen güncelleme için sadece bir satır seçiniz.");
            //    return;
            //}

            int result = 0;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int catId = (int)row.Cells[0].Value;

                string query = $"UPDATE [dbo].[Categories] SET [CategoryName] = '{catName}' WHERE CategoryID = {catId}";

                // insert, update, delete ya da bir komut çalıştırma işlemlerinde.. (ExecuteNonQuery)
                result += Execute(query);
            }

            if (result > 0)
            {
                //MessageBox.Show("İlgili kayıt(lar) güncellendi.");
                MessageBox.Show($"{result} adet kayıt güncellendi.");
                btnSelect_Click(btnSelect, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("İlgili kayıt(lar) güncellenemedi.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int result = 0;

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seçili satır yok. Silmek için lütfen bir ya da birden çok satır seçiniz.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Seçili kayıtları silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

            if (dialogResult != DialogResult.Yes)
            {
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int catId = (int)row.Cells[0].Value;

                string query = $"DELETE FROM [dbo].[Categories] WHERE CategoryID = {catId}";

                // insert, update, delete ya da bir komut çalıştırma işlemlerinde.. (ExecuteNonQuery)
                result += Execute(query);
            }

            if (result > 0)
            {
                MessageBox.Show("İlgili kayıt(lar) silindi.");
                btnSelect_Click(btnSelect, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("İlgili kayıt(lar) silinemedi.");
            }
        }

        private void btnTotalCatExeScalar_Click(object sender, EventArgs e)
        {
            string query = $"SELECT SUM(CategoryID) AS Total FROM Categories";

            int result = ExecuteScalar<int>(query);

            MessageBox.Show($"Total Cat Id : {result}");
        }

        private void btnReadFromStoredProcedure_Click(object sender, EventArgs e)
        {
            // bağlantı sağlayıcı
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);

            string query = "[Sales by Year]";

            // sorgu çalıştırıcı.
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Beginning_Date", new DateTime(1996, 1, 1));
            command.Parameters.AddWithValue("@Ending_Date", new DateTime(2000, 12, 31));

            try
            {
                connection.Open();

                System.Data.SqlClient.SqlDataReader reader = command.ExecuteReader();
                System.Data.DataTable dt = new DataTable();

                dt.Columns.Add("OrderID", typeof(int));
                dt.Columns.Add("SubTotal", typeof(decimal));
                dt.Columns.Add("Year", typeof(string));

                while (reader.Read())
                {
                    int id = (int)reader["OrderID"];
                    decimal total = (decimal)reader["SubTotal"];
                    string year = (string)reader["Year"];

                    DataRow row = dt.NewRow();
                    row["OrderID"] = id;
                    row["SubTotal"] = total;
                    row["Year"] = year;

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

        private void btnSqlAdapterVeriCekme_Click(object sender, EventArgs e)
        {
            // bağlantı sağlayıcı
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);

            string query = "SELECT CategoryID, CategoryName FROM Categories ORDER BY CategoryID ASC";

            // sorgu çalıştırıcı.
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);
            System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(command);

            try
            {
                System.Data.DataTable dt = new DataTable();
                adapter.Fill(dt);

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

        private void btnSqlAdapterVeriCekme2_Click(object sender, EventArgs e)
        {
            string query = "SELECT CategoryID, CategoryName FROM Categories ORDER BY CategoryID ASC";
            DataTable dt = ExecuteReader(query);
            dataGridView1.DataSource = dt;
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

        private DataTable ExecuteReader(string query)
        {
            // bağlantı sağlayıcı
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);

            // sorgu çalıştırıcı.
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);
            System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(command);

            System.Data.DataTable dt = null;

            try
            {
                dt = new DataTable();
                adapter.Fill(dt);
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

            return dt;
        }
    }
}
