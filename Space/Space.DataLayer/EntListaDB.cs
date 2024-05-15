using Framework;
using Space.EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace Space.DataLayer
{
    public class EntListaDB : BaseDB
    {

        public List<EntListaEntity> ObtenerCodigo(String codigo)
        {
            Conexion.OpenConnection();
            Conexion.Store("sp_EntListaObtenerCodigo");
            Conexion.AddParemeter("Codigo", SqlDbType.VarChar, 20, ParameterDirection.Input, codigo);

            SqlDataReader reader = Conexion.ReaderData();
            List<EntListaEntity> ListaData = new List<EntListaEntity>();
            FillSchemeTable(reader);
            while (reader.Read())
            {
                EntListaEntity entity = new EntListaEntity();
                if (FillFrom<EntListaEntity>(reader, entity)) ListaData.Add(entity);
            }
            reader.Close();
            Conexion.CloseConnection();
            return ListaData;
        }

        public List<EntListaEntity> GetListaRelacion_Main(String codigo)
        {
            Conexion.OpenConnection();
            Conexion.Store("sp_ListaRelacion_Main");
            Conexion.AddParemeter("Codigo", SqlDbType.VarChar, 20, ParameterDirection.Input, codigo);

            SqlDataReader reader = Conexion.ReaderData();
            List<EntListaEntity> ListaData = new List<EntListaEntity>();
            FillSchemeTable(reader);
            while (reader.Read())
            {
                EntListaEntity entity = new EntListaEntity();
                if (FillFrom<EntListaEntity>(reader, entity)) ListaData.Add(entity);
            }
            reader.Close();
            return ListaData;
        }

        public Int32 Save(EntListaEntity Ent)
        {
            try
            {

                String NameStore = "sp_ListaRelacion_Save";

                Conexion.Store(NameStore);
                Conexion.AddParemeter("ListaRelacionId", SqlDbType.Int, 10, ParameterDirection.InputOutput, Ent.ListaId);
                Conexion.AddParemeter("EntCampoId", SqlDbType.Int, 10, ParameterDirection.Input, Ent.EntCampoId);
                Conexion.AddParemeter("Codigo", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.Codigo);
                Conexion.AddParemeter("Nombre", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.Nombre);
                Conexion.AddParemeter("Descripcion", SqlDbType.VarChar, 200, ParameterDirection.Input, Ent.Descripcion);
                Conexion.AddParemeter("CodUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.CodUsuario);
                Conexion.AddParemeter("FechaRegistro", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.FechaRegistro);
                Conexion.AddParemeter("EstadoRegistro", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.EstadoRegistro);
                Ent.ListaId = Conexion.ExecuteQueryItem("ListaRelacionId");

                return Ent.ListaId;
            }
            catch (Exception ex)
            {
                Conexion.Restore();
                throw ex;
            }

        }

        public Int32 Update(EntListaEntity Ent)
        {
            try
            {

                String NameStore = "sp_ListaRelacion_Update";

                Conexion.Store(NameStore);
                Conexion.AddParemeter("ListaRelacionId", SqlDbType.Int, 10, ParameterDirection.InputOutput, Ent.ListaId);
                Conexion.AddParemeter("EntCampoId", SqlDbType.Int, 10, ParameterDirection.Input, Ent.EntCampoId);
                Conexion.AddParemeter("Codigo", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.Codigo);
                Conexion.AddParemeter("Nombre", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.Nombre);
                Conexion.AddParemeter("Descripcion", SqlDbType.VarChar, 200, ParameterDirection.Input, Ent.Descripcion);
                Conexion.AddParemeter("CodUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.CodUsuario);
                Conexion.AddParemeter("FechaRegistro", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.FechaRegistro);
                Conexion.AddParemeter("EstadoRegistro", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.EstadoRegistro);
                Ent.ListaId = Conexion.ExecuteQueryItem("ListaId");

                return Ent.ListaId;
            }
            catch (Exception ex)
            {
                Conexion.Restore();
                throw ex;
            }

        }

        public List<EntListaEntity> GetListaRelacionLike(String codigo, String Nombre)
        {
            Conexion.OpenConnection();
            Conexion.Store("sp_ListaGenericaSelectCodigoLike");
            Conexion.AddParemeter("Codigo", SqlDbType.VarChar, 20, ParameterDirection.Input, codigo);
            Conexion.AddParemeter("Nombre", SqlDbType.VarChar, 100, ParameterDirection.Input, Nombre);
            SqlDataReader reader = Conexion.ReaderData();
            List<EntListaEntity> ListaData = new List<EntListaEntity>();
            FillSchemeTable(reader);
            while (reader.Read())
            {
                EntListaEntity entity = new EntListaEntity();
                if (FillFrom<EntListaEntity>(reader, entity)) ListaData.Add(entity);
            }
            reader.Close();
            Conexion.CloseConnection();
            return ListaData;
        }

    }
}
