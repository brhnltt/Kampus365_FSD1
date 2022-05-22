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
    public partial class frmChat : Form
    {
        public frmChat()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Common.ConnectionString))
            {
                //string sql = $"SELECT Id, NameSurname, Username FROM Users " +
                //    $"WHERE Username = '{username}' AND Password = '{password}'";

                string sql = $"INSERT INTO Conversations(Id, FromId, ToId, SendDate, Message, IsDelete) " +
                    $"VALUES (@Id, @FromId, @ToId, @SendDate, @Message, @IsDelete)";

                object parameters = new
                {
                    Id = Guid.NewGuid(),
                    FromId = Common.UserId,
                    ToId = 2,   // bu combo box dan gelmeli.
                    SendDate = DateTime.Now,
                    Message = txtMessage.Text,
                    IsDelete = false
                };

                int affectedRows = connection.Execute(sql, parameters);

                if (affectedRows > 0)
                {
                    Label label = new Label();
                    label.Text = txtMessage.Text;
                    label.TextAlign = ContentAlignment.MiddleRight;
                    label.Size = new Size(614, 40);

                    flpMessages.Controls.Add(label);
                    txtMessage.Clear();
                }
                else
                {
                    MessageBox.Show("Mesaj gönderilemedi", "Hata");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Common.ConnectionString))
            {
                string sql = "SELECT * FROM Conversations " +
                    "WHERE FromId=@FromId AND ToId=@ToId AND IsDelete=@IsDelete " +
                    "ORDER BY SendDate ASC";

                object parameters = new
                {
                    FromId = 2,
                    ToId = Common.UserId,   // bu combo box dan gelmeli.
                    IsDelete = false
                };

                List<dynamic> messages = connection.Query(sql, parameters).ToList();

                foreach (dynamic item in messages)
                {
                    bool varMi = false;

                    foreach (Label lbl in flpMessages.Controls)
                    {
                        if(lbl.Tag != null)
                        {
                            if(lbl.Tag.ToString() == item.Id.ToString())
                            {
                                varMi = true;
                            }
                        }
                    }

                    if (varMi == false)
                    {
                        Label label = new Label();
                        label.Text = item.Message;
                        label.TextAlign = ContentAlignment.MiddleLeft;
                        label.Size = new Size(614, 40);
                        label.Tag = item.Id.ToString();

                        flpMessages.Controls.Add(label);
                    }
                }
            }
        }

        private void frmChat_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
