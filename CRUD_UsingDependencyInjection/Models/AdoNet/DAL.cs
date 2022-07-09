using Microsoft.Data.SqlClient;
namespace CRUD_UsingDependencyInjection.Models.AdoNet
{
    public class DAL
    {
        Connection _connection;
        public DAL(Connection connection)
        {
            _connection = connection;
        }
        public string GetValue(string Query)
        {
            SqlConnection sqlConnection = new SqlConnection(_connection.ConnectionString);
            _connection.ConnectionString = sqlConnection.ConnectionString;
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = Query;
            sqlConnection.Open();
            var res1 = cmd.ExecuteScalar();
            sqlConnection.Close();
            return res1.ToString();
        }
    }
}
