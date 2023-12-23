using System.Data;
using System.Data.SqlClient;

namespace DRFramework
{
    public class Conexion
    {

        private readonly SqlConnection _connection;
        private static string connectionString = "Data Source=localhost, 14333;Initial Catalog=SpaceDB;User ID=sa;Password=Admin123;";
        private static SqlTransaction transaction;
        public static SqlConnection ConexionDB()
        {
            SqlConnection _connection = new SqlConnection(connectionString); ;

            return _connection;
        }


        public void OpenConnection()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }


        public void StartTransaction()
        {

            transaction = ConexionDB().BeginTransaction();
        }


        public void EndTransaction()
        {
            transaction.Commit();
        }

        public void Restore()
        {
            transaction.Rollback();
        }


    }
}