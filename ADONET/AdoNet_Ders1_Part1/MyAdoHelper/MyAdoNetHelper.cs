using System;
using System.Data;
using System.Data.SqlClient;

namespace MyAdoHelper
{
    public class MyAdoNetHelper
    {
        public string ConnectionString { get; private set; }

        public MyAdoNetHelper(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public int Execute(string query, params SqlParameter[] parameters)
        {
            // bağlantı sağlayıcı
            SqlConnection connection = new SqlConnection(ConnectionString);

            // sorgu çalıştırıcı.
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddRange(parameters);

            int result = 0;

            try
            {
                connection.Open();

                // insert, update, delete ya da bir komut çalıştırma işlemlerinde.. (ExecuteNonQuery)
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (connection.State != ConnectionState.Closed && connection.State != ConnectionState.Broken)
                {
                    connection.Close();
                }

                throw ex;
            }

            return result;
        }

        public T ExecuteScalar<T>(string query, CommandType commandType = CommandType.Text, params SqlParameter[] parameters) where T : struct
        {
            // bağlantı sağlayıcı
            SqlConnection connection = new SqlConnection(ConnectionString);

            // sorgu çalıştırıcı.
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = commandType;

            command.Parameters.AddRange(parameters);

            object result = null;

            try
            {
                connection.Open();

                result = command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                if (connection.State != ConnectionState.Closed && connection.State != ConnectionState.Broken)
                {
                    connection.Close();
                }

                throw ex;
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

        public DataTable ExecuteReader(string query, CommandType commandType = CommandType.Text, params SqlParameter[] parameters)
        {
            // bağlantı sağlayıcı
            SqlConnection connection = new SqlConnection(ConnectionString);

            // sorgu çalıştırıcı.
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = commandType;

            command.Parameters.AddRange(parameters);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dt = null;

            try
            {
                dt = new DataTable();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                if (connection.State != ConnectionState.Closed && connection.State != ConnectionState.Broken)
                {
                    connection.Close();
                }

                throw ex;
            }

            return dt;
        }
    }
}
