using Framework.Lib;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text.Json;

namespace Framework
{
    public class Conexion
    {
        private static SqlConnection _connection = null;
        private static string connectionString = "";
        private static SqlTransaction transaction;
        private static SqlCommand cmd;
        public static SqlConnection ConexionDB()
        {
            SetConexion();
            return new SqlConnection(connectionString);
        }
        public static void SetConexion()
        {
            string rutaArchivo = "appsettings.json";
            string json = File.ReadAllText(rutaArchivo);
            ConexionModel ItemConexion = JsonSerializer.Deserialize<ConexionModel>(json);

            string Server = ItemConexion.ConnectionStrings.Server;
            string Database = ItemConexion.ConnectionStrings.Database;
            string Puerto = ItemConexion.ConnectionStrings.Puerto;
            string User = ItemConexion.ConnectionStrings.User;
            string Pwd = ItemConexion.ConnectionStrings.Pwd;

            connectionString = $"Data Source={Server}, {Puerto};Initial Catalog={Database};User ID={User};Password={Pwd};";
        }

        public static void OpenConnection()
        {
            if (_connection == null) _connection = ConexionDB();


            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }

        }
        public static void CloseConnection()
        {
            _connection.Close();

        }

        public static void StartTransaction()
        {
            OpenConnection();
            transaction = _connection.BeginTransaction();
        }


        public static void EndTransaction()
        {
            transaction.Commit();
            _connection.Close();
        }

        public static void Restore()
        {
            transaction.Rollback();
        }


        public static void Store(String nombreProcedimiento)
        {
            cmd = new SqlCommand(nombreProcedimiento, _connection);
            cmd.CommandType = CommandType.StoredProcedure;
        }

        public static void AddParemeter(String Parametro, SqlDbType TypeItem, Int32 SizeItem, ParameterDirection PDirec, Object ValueItem)
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
        public static Int32 ExecuteQueryItem(String Devolver)

        {
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            object valor = cmd.Parameters["@" + Devolver].Value;
            int idNuevo = 0;
            if (valor != DBNull.Value)
            {
                idNuevo = Convert.ToInt32(valor);
            }
            return idNuevo;
        }

    }
}
