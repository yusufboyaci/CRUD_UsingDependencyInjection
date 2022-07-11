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
        //public List<string> GetValues(string Query)
        //{
        //    SqlConnection sqlConnection = new SqlConnection(_connection.ConnectionString);
        //    _connection.ConnectionString = sqlConnection.ConnectionString;
        //    SqlCommand cmd = sqlConnection.CreateCommand();
        //    cmd.Connection = sqlConnection;
        //    cmd.CommandText = Query;
        //    sqlConnection.Open();
        //    object res1 = cmd.ExecuteScalar();
        //    sqlConnection.Close();
        //    return  res1.ToString().ToList();
        //}
        public string GetValue(string Query)
        {
            SqlConnection sqlConnection = new SqlConnection(_connection.ConnectionString);
            _connection.ConnectionString = sqlConnection.ConnectionString;
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = Query;
            sqlConnection.Open();
            object res1 = cmd.ExecuteScalar();
            sqlConnection.Close();
            return res1.ToString();
        }
        public string InsertValue(string Query)
        {
            SqlConnection sqlConnection = new SqlConnection(_connection.ConnectionString);
            _connection.ConnectionString = sqlConnection.ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = Query;
            sqlConnection.Open();
            object res2 = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return res2.ToString();
        }
        public string UpdateValues(string Query)
        {
            SqlConnection sqlConnection = new SqlConnection(_connection.ConnectionString);
            _connection.ConnectionString = sqlConnection.ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = Query;
            sqlConnection.Open();
            object res3 = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return res3.ToString();
        }
        public string DeleteValues(string Query)
        {
            SqlConnection sqlConnection = new SqlConnection(_connection.ConnectionString);
            _connection.ConnectionString = sqlConnection.ConnectionString;
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = Query;
            sqlConnection.Open();
            object res4 = command.ExecuteNonQuery();
            sqlConnection.Close();
            return res4.ToString();
        }
    }
}
