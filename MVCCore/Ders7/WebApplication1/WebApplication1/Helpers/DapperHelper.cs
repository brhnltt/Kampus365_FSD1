using System.Data.SqlClient;

namespace WebApplication1.Helpers
{
    public interface IDapperHelper
    {
        SqlConnection CreateConnection();
    }

    public class DapperHelper : IDapperHelper
    {
        private readonly string _connectionString;

        //public DapperHelper(string connectionString)
        //{
        //    _connectionString = connectionString;
        //}

        public DapperHelper(IConfiguration configuration)
        {
            //_connectionString = configuration["ConnectionStrings:DefaultConnection"];
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
