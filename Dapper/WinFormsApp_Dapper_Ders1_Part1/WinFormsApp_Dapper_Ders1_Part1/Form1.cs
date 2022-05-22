using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp_Dapper_Ders1_Part1
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Categories(CategoryName, Description, Picture) VALUES(@CategoryName,@Description,@Picture)";

            object nesne = new
            {
                Name = "Yiyecek",
                Desc = "Deneme",
                IsActive = true,
                Count = 15
            };


            byte[] picture = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int affectedRows = connection.Execute(sql, new
                {
                    CategoryName = "Test",
                    Description = "Lorem ipsum dolor sit a met.",
                    Picture = picture
                });

                if (affectedRows > 0)
                {
                    MessageBox.Show("Katgeori eklendi.");
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string sql = "SELECT CategoryID, CategoryName, Description FROM Categories ORDER BY CategoryName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<Category> categories = connection.Query<Category>(sql).ToList();

                listBox1.DataSource = null;
                listBox1.DataSource = categories;
                //listBox1.DisplayMember = nameof(Category.CategoryName);
                //listBox1.ValueMember = nameof(Category.CategoryID);
            }
        }

        private void btnSelect2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT CategoryID, CategoryName, Description FROM Categories WHERE CategoryName = @CategoryName ORDER BY CategoryName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                object parameters = new
                {
                    CategoryName = "Beverages"
                };

                List<Category> categories = connection.Query<Category>(sql, parameters).ToList();

                listBox1.DataSource = null;
                listBox1.DataSource = categories;
                //listBox1.DisplayMember = nameof(Category.CategoryName);
                //listBox1.ValueMember = nameof(Category.CategoryID);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Categories SET " +
                "CategoryName = @CategoryName, " +
                "Description = @Description " +
                "WHERE CategoryName = @UpdatedCategoryName";

            object parameters = new
            {
                CategoryName = "Test 2",
                Description = "Deneme deneme deneme",
                UpdatedCategoryName = "Test"
            };

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int affectedRows = connection.Execute(sql, parameters);

                if (affectedRows > 0)
                {
                    MessageBox.Show("Kategori(ler) güncellendi.");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Categories " +
                "WHERE CategoryName = @CategoryName";

            object parameters = new
            {
                CategoryName = "Test 2"
            };

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int affectedRows = connection.Execute(sql, parameters);

                if (affectedRows > 0)
                {
                    MessageBox.Show("Kategori(ler) silindi.");
                }
            }
        }

        private void btnSelect3_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();

            //dynamic random = rnd;
            //int rastgele = random.Next();

            //MessageBox.Show(rastgele.ToString());

            //dynamic nesne = new
            //{
            //    Name = "Murat",
            //    Surname = "Başeren"
            //};

            //MessageBox.Show(nesne.name);

            string sql = "SELECT CategoryID, CategoryName, Description FROM Categories ORDER BY CategoryName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<dynamic> categories = connection.Query(sql).ToList();

                listBox1.DataSource = null;
                listBox1.DataSource = categories;
                listBox1.DisplayMember = "CategoryName";
                listBox1.ValueMember = "CategoryID";
            }
        }

        private void btnMultipleInsert_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Categories(CategoryName, Description, Picture) VALUES(@CategoryName,@Description, NULL)";

            object param1 = new
            {
                CategoryName = "Cat 1",
                Description = "Desc 1"
            };

            object param2 = new
            {
                CategoryName = "Cat 2",
                Description = "Desc 2"
            };

            object param3 = new
            {
                CategoryName = "Cat 3",
                Description = "Desc 3"
            };

            object parametreler = new[]
            {
                param1,
                param2,
                param3
            };


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //int affectedRows = connection.Execute(sql, new[]
                //{
                //    param1,
                //    param2,
                //    param3
                //});

                int affectedRows = connection.Execute(sql, parametreler);

                if (affectedRows > 0)
                {
                    MessageBox.Show($"Kategori(ler) eklendi. Etkilenen kayıt sayısı : {affectedRows}");
                }
            }
        }

        private void btnSelectIn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT CategoryID, CategoryName, Description " +
                "FROM Categories " +
                "WHERE CategoryName IN @CategoryNames " +
                "ORDER BY CategoryName";

            object parameter = new
            {
                CategoryNames = new string[] { "Cat 1", "Cat 2", "Cat 3" }
            };

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<dynamic> categories = connection.Query(sql, parameter).ToList();

                listBox1.DataSource = null;
                listBox1.DataSource = categories;
                listBox1.DisplayMember = "CategoryName";
                listBox1.ValueMember = "CategoryID";
            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            object param1 = new
            {
                CategoryName = "transaction 1",
                Description = "transaction 1"
            };

            object param2 = new
            {
                CategoryName = "transaction 2",
                Description = "transaction 2"
            };

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction("tran1"))
                {
                    try
                    {
                        int affectedRows1 = connection.Execute("INSERT INTO Categories(CategoryName, Description) VALUES(@CategoryName, @Description)", param1, transaction);

                        int affectedRows2 = connection.Execute("INSER INTO Categories(CategoryName, Description) VALUES(@CategoryName, @Description)", param2, transaction);

                        transaction.Commit();

                        if (affectedRows1 + affectedRows2 > 0)
                        {
                            MessageBox.Show($"Kategori(ler) eklendi.\n" +
                                $"affectedRows1 : {affectedRows1}\n" +
                                $"affectedRows2 : {affectedRows2}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,"Hata Oluştu!");
                        transaction.Rollback();
                    }
                }
            }
        }

        private void btnStoredProcedure_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "AddCategory";
                int affectedRows = connection.Execute(sql, new { CategoryName = "sp test", Description = "sp test test" }, 
                    commandType: System.Data.CommandType.StoredProcedure);

                if (affectedRows > 0)
                {
                    MessageBox.Show($"Kategori(ler) eklendi.\n" +
                        $"affectedRows : {affectedRows}");
                }
            }
        }
    }

    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{CategoryName} ({Description}) [{CategoryID}]";
        }

    }
}
