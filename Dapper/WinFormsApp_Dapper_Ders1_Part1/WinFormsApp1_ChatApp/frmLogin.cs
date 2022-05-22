using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1_ChatApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (SqlConnection connection = new SqlConnection(Common.ConnectionString))
            {
                //string sql = $"SELECT Id, NameSurname, Username FROM Users " +
                //    $"WHERE Username = '{username}' AND Password = '{password}'";

                string sql = $"SELECT Id, NameSurname, Username FROM Users " +
                    $"WHERE Username = @Username AND Password = @Password";

                // SQL Injection
                // WHERE Username = '' OR 'a'='a' AND Password = '' OR 'a'='a'

                dynamic user = connection.QueryFirstOrDefault(sql, new { Username = username, Password = password });

                if (user != null)
                {
                    Common.UserId = user.Id;
                    Common.Username = user.Username;
                    Common.NameSurname = user.NameSurname;

                    this.Visible = false;

                    frmChat frmChat = new frmChat();
                    frmChat.ShowDialog();

                    Application.Exit();
                }

                MessageBox.Show("Kullanıcı adı ya da şifre eşleşmiyor ya da olmayan bir kullanıcı adı yazıldı.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
