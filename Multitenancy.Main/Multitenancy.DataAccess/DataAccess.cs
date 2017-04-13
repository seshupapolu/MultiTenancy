
using System.Data.SqlClient;

namespace Multitenancy.DataAccess
{
    public class DataAccess
    {
        public DataAccess(string connectionString)
        {
            _connectionString = connectionString;

        }
        private string _connectionString;

        public bool Execute(string query)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = connection;
                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }

        }
    }
}
