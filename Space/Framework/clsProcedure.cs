using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class clsProcedure
    {

        #region Fields
        private bool CloseCnn;
        private bool ErrCnn;

        //private SqlCommand Comando;
        private DbCommand Comando;

        #endregion

        #region Properties

        public ConexionItem ObjclsConexion { get; set; }
        public string PathConn { get; set; }
        public string StrConection { get; set; }

        #endregion

        #region Methods

        public void CloseComando()
        {
            Comando = null;
            if (CloseCnn || ErrCnn) ObjclsConexion = null;
            CloseCnn = false;
            ErrCnn = false;
        }

        public void ExecNonQuery()
        {
            Comando.ExecuteNonQuery();

            CloseComando();
        }

        public void ExecNonQueryItem()
        {
            Comando.ExecuteNonQuery();
        }


        //public void ExecNonQueryItem()
        //{
        //}
        public void CloseItem()
        {
            CloseComando();
        }
        public object ParameterItemOUT(String Devolver)
        {
            object valor = Comando.Parameters["@" + Devolver].Value;
            return valor;
        }
        public int ExecNonQueryWithReturn()
        {
            try
            {
                return Comando.ExecuteNonQuery();
            }
            catch
            {
                return -99;
            }
            finally
            {
                CloseComando();
            }
        }

        public DataTable ExecReader()
        {
            try
            {
                DataTable table = new DataTable();
                table.Load(Comando.ExecuteReader());
                return table;
            }
            catch
            {
                return new DataTable();
            }
            finally
            {
                CloseComando();
            }
        }

        public DataTable ExecReaderAlter()
        {
            try
            {
                DataTable table = new DataTable();
                table.Load(Comando.ExecuteReader());
                return table;
            }
            catch
            {
                return new DataTable();
            }
            finally
            {
                //CloseComando();
            }
        }
        public DataSet ExecReaderDts()
        {
            try
            {
                DataSet dts = new DataSet();
                DbDataAdapter adapter = ObjclsConexion.FACT.CreateDataAdapter();
                adapter.SelectCommand = Comando;
                adapter.Fill(dts);
                return dts;
            }
            catch
            {
                return new DataSet();
            }
            finally
            {
                CloseComando();
            }
        }

        public T ExecEscalar<T>()
        {
            try
            {
                object ObjDato = Comando.ExecuteScalar();
                CloseComando();

                if (ObjDato == null)
                {
                    return default(T);
                }
                if (ObjDato == DBNull.Value)
                {
                    return default(T);
                }

                //if (typeof(T) == typeof(String)) return (T)(object)String.Empty;

                if (typeof(T) == typeof(String) && ObjDato.ToString().Equals(""))
                {
                    return default(T);
                }

                return (T)Convert.ChangeType(ObjDato, typeof(T));
            }
            catch
            {
                CloseComando();
                return default(T);
            }

        }

        public void InitComando(CommandType ComandoType, string ComandoText, SqlParameter[] parametros = null)
        {
            if (ObjclsConexion == null) ObjclsConexion = new ConexionItem();

            if (ObjclsConexion.CNN == null || ObjclsConexion.CNN.State == ConnectionState.Closed)
            {
                ObjclsConexion.PathConn = PathConn;
                if (StrConection.Equals(""))
                {
                    if (ObjclsConexion.OpenConnection() != "OK")
                    {
                        ErrCnn = true;
                        return;
                    }
                }
                else
                {
                    if (ObjclsConexion.OpenConnection(StrConection) != "OK")
                    {
                        ErrCnn = true;
                        return;
                    }
                }

                CloseCnn = true;
            }

            Comando = ObjclsConexion.FACT.CreateCommand();
            Comando.Connection = ObjclsConexion.CNN;
            Comando.CommandType = ComandoType;
            Comando.CommandText = ComandoText;
            Comando.CommandTimeout = 0;
            if (parametros != null)
                Comando.Parameters.AddRange(parametros);

            //if (Transaction) SetTransaction();
            if (ObjclsConexion.IsInTRANS) SetTransaction();
        }

        public bool InitComandoBool(CommandType ComandoType, string ComandoText)
        {
            if (ObjclsConexion == null) ObjclsConexion = new ConexionItem();

            if (ObjclsConexion.CNN == null || ObjclsConexion.CNN.State == ConnectionState.Closed)
            {
                ObjclsConexion.PathConn = PathConn;
                if (StrConection.Equals(""))
                {
                    if (ObjclsConexion.OpenConnection() != "OK")
                    {
                        ErrCnn = true;
                        CloseComando();
                        return false;
                    }
                }
                else
                {
                    if (ObjclsConexion.OpenConnection(StrConection) != "OK")
                    {
                        ErrCnn = true;
                        CloseComando();
                        return false;
                    }
                }

                CloseCnn = true;
            }

            Comando = ObjclsConexion.FACT.CreateCommand();
            Comando.Connection = ObjclsConexion.CNN;
            Comando.CommandType = ComandoType;
            Comando.CommandText = ComandoText;
            Comando.CommandTimeout = 0;
            //if (Transaction) SetTransaction();
            if (ObjclsConexion.IsInTRANS) SetTransaction();
            return true;
        }

        public void AddParameter(string ParameterName, object ParameterValue)
        {
            if (Comando != null)
            {
                DbParameter Parameter = ObjclsConexion.FACT.CreateParameter();
                Parameter.ParameterName = ParameterName;
                Parameter.Value = ParameterValue;
                Comando.Parameters.Add(Parameter);
            }
        }

        public void SetTransaction()
        {
            Comando.Transaction = ObjclsConexion.TRANS;
        }

        #endregion
    }
}
