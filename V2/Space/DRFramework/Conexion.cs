using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;
using System.Transactions;

namespace DRFramework
{
    public class Conexion
    {

        private static  SqlConnection _connection = null;
        private static string connectionString = "Data Source=localhost, 14333;Initial Catalog=SpaceDB;User ID=sa;Password=Admin123;";
        private static SqlTransaction transaction;
        private static SqlCommand cmd;
        public static SqlConnection ConexionDB()
        {
            return new SqlConnection(connectionString); 
        }


        public static void OpenConnection()
        {
            _connection = ConexionDB();
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }


        public static void StartTransaction()
        {
            OpenConnection();
            transaction = _connection.BeginTransaction();
        }


        public static void EndTransaction()
        {
            _connection.Close();
            //transaction.Commit();
        }

        public void Restore()
        {
            transaction.Rollback();
        }


        public static void Store(String nombreProcedimiento)
        {
            cmd = new SqlCommand(nombreProcedimiento, _connection);
            cmd.CommandType = CommandType.StoredProcedure;
        }

        public void AddParemeter(String Parametro, SqlDbType TypeItem, Int32 SizeItem, ParameterDirection PDirec, Object ValueItem)
        {

            SqlParameter ItemPmt = new SqlParameter("@" + Parametro, TypeItem);
            ItemPmt.Value = ValueItem;
            ItemPmt.Size = SizeItem;
            ItemPmt.Size = SizeItem;
            ItemPmt.Direction = PDirec;
            cmd.Parameters.Add(ItemPmt);
        }
        public static SqlDataReader ReaderData()

        {
            cmd.Transaction = transaction;
            return cmd.ExecuteReader();
        }

    }
}