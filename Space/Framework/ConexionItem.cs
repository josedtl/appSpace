using Framework.Lib;
using System.Data;
using System.Data.Common;
using System.Text.Json;

namespace Framework
{
    public class ConexionItem
    {


        public string RespCnn { get; set; }
        public string PathConn { get; set; }
        public bool IsInTRANS { get; set; }

        public enum DB
        {
            SQL = 1,
            PGSQL = 2
        }

        public DbTransaction TRANS { get; private set; }

        //public SqlConnection CNN
        public DbConnection CNN { get; private set; }

        //public DbProviderFactory FACT = DbProviderFactories.GetFactory("System.Data.SqlClient");
        public DbProviderFactory FACT;

        public string OpenConnection()
        {
            string rutaArchivo = "appsettings.json";
            string json = File.ReadAllText(rutaArchivo);
            ConexionModel ItemConexion = JsonSerializer.Deserialize<ConexionModel>(json);

            string _Servidor;
            string _DBase;
            string _Puerto;
            string _User;
            string _Pass;

            try
            {
                _Servidor = ItemConexion.ConnectionStrings.Server;
                _DBase = ItemConexion.ConnectionStrings.Database;
                _Puerto = ItemConexion.ConnectionStrings.Puerto;
                _User = ItemConexion.ConnectionStrings.User;
                _Pass = ItemConexion.ConnectionStrings.Pwd;


                 DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);

                FACT = DbProviderFactories.GetFactory("System.Data.SqlClient");
                CNN = FACT.CreateConnection();
                CNN.ConnectionString = string.Format("Data Source={0}, {1};Initial Catalog={2};Persist Security Info=True;User ID={3};Password={4};Connect Timeout=10", _Servidor, _Puerto, _DBase, _User, _Pass);
                CNN.Open();
                //AES = null;
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        public string OpenConnection(string StrCnn, DB BaseDatos = DB.SQL)
        {
            try
            {
                switch (BaseDatos)
                {
                    case DB.SQL:
                        FACT = DbProviderFactories.GetFactory("System.Data.SqlClient");
                        break;
                    case DB.PGSQL:
                        FACT = DbProviderFactories.GetFactory("Npgsql");
                        break;
                }

                CNN = FACT.CreateConnection();
                CNN.ConnectionString = StrCnn;
                CNN.Open();
                return "OK";
            }
            catch (DbException ex)
            {
                CloseConnection();
                return ex.Message;
            }
        }

        public void CloseConnection()
        {
            try
            {
                //if (CNN.State != ConnectionState.Closed)
                //{
                //    CNN.Close();

                //}
                CNN.Close();
                CNN.Dispose();
                CNN = null;
            }
            catch
            {
                CNN = null;
            }

        }

        public void BeginTransaction()
        {
            RespCnn = OpenConnection();

            if (RespCnn == "OK")
            {
                TRANS = CNN.BeginTransaction(IsolationLevel.ReadCommitted);
                IsInTRANS = true;
            }
            else
            {
                IsInTRANS = false;
                throw new Exception(RespCnn);
            }
        }

        public void BeginTransaction(string StrCnn)
        {
            RespCnn = OpenConnection(StrCnn);

            if (RespCnn == "OK")
            {
                TRANS = CNN.BeginTransaction(IsolationLevel.ReadCommitted);
                IsInTRANS = true;
            }
            else
            {
                IsInTRANS = false;
                throw new Exception(RespCnn);
            }
        }

        public void CommitTransaction()
        {
            if (TRANS != null) TRANS.Commit();
            IsInTRANS = false;
        }

        public void RollBackTransaction()
        {
            if (TRANS != null) TRANS.Rollback();
            IsInTRANS = false;
        }

        public void CloseTransaction()
        {
            if (TRANS != null)
            {
                TRANS.Dispose();
                TRANS = null;
                CloseConnection();
            }
            IsInTRANS = false;
        }

    }
}
