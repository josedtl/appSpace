using Framework;
using Space.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.DataLayer
{
    public class ServListaDB : BaseDB
    {
        public List<ServListaEntity> ObtenerServListaCodigo(String codigo)
        {
            Conexion.OpenConnection();
            Conexion.Store("sp_ServListaObtenerCodigo");
            Conexion.AddParemeter("Codigo", SqlDbType.VarChar, 20, ParameterDirection.Input, codigo);

            SqlDataReader reader = Conexion.ReaderData();
            List<ServListaEntity> ListaData = new List<ServListaEntity>();
            FillSchemeTable(reader);
            while (reader.Read())
            {
                ServListaEntity entity = new ServListaEntity();
                if (FillFrom<ServListaEntity>(reader, entity)) ListaData.Add(entity);
            }
            reader.Close();
            Conexion.CloseConnection();
            return ListaData;
        }
        public List<ServListaEntity> BuscarServLista(String codigo, String Nombre)
        {
            Conexion.OpenConnection();
            Conexion.Store("sp_ServListaBuscar");
            Conexion.AddParemeter("Codigo", SqlDbType.VarChar, 20, ParameterDirection.Input, codigo);
            Conexion.AddParemeter("Nombre", SqlDbType.VarChar, 100, ParameterDirection.Input, Nombre);
            SqlDataReader reader = Conexion.ReaderData();
            List<ServListaEntity> ListaData = new List<ServListaEntity>();
            FillSchemeTable(reader);
            while (reader.Read())
            {
                ServListaEntity entity = new ServListaEntity();
                if (FillFrom<ServListaEntity>(reader, entity)) ListaData.Add(entity);
            }
            reader.Close();
            return ListaData;
        }

        public List<ServListaEntity> ObtenerServListaMain(String codigo)
        {
            Conexion.OpenConnection();
            Conexion.Store("sp_ServListaObtenerMain");
            Conexion.AddParemeter("Codigo", SqlDbType.VarChar, 20, ParameterDirection.Input, codigo);

            SqlDataReader reader = Conexion.ReaderData();
            List<ServListaEntity> ListaData = new List<ServListaEntity>();
            FillSchemeTable(reader);
            while (reader.Read())
            {
                ServListaEntity entity = new ServListaEntity();
                if (FillFrom<ServListaEntity>(reader, entity)) ListaData.Add(entity);
            }
            reader.Close();
            Conexion.CloseConnection();
            return ListaData;
        }
        public Int32 Registrar(ServListaEntity Ent)
        {
            try
            {

                String NameStore = "sp_ServListaRegistrar";

                Conexion.Store(NameStore);
                Conexion.AddParemeter("ListaId", SqlDbType.Int, 10, ParameterDirection.InputOutput, Ent.ListaId);
                Conexion.AddParemeter("CodigoCampo", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.CodigoCampo);
                Conexion.AddParemeter("Codigo", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.Codigo);
                Conexion.AddParemeter("Nombre", SqlDbType.VarChar, 200, ParameterDirection.Input, Ent.Nombre);
                Conexion.AddParemeter("Descripcion", SqlDbType.VarChar, 200, ParameterDirection.Input, Ent.Descripcion);
                Conexion.AddParemeter("FechaRegistro", SqlDbType.DateTime, 15, ParameterDirection.Input, Ent.FechaRegistro);
                Conexion.AddParemeter("CodUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.CodUsuario);
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



        public Int32 Actualizar(ServListaEntity Ent)
        {
            try
            {

                String NameStore = "sp_ServListaActualizar";

                Conexion.Store(NameStore);
                Conexion.AddParemeter("ListaId", SqlDbType.Int, 10, ParameterDirection.InputOutput, Ent.ListaId);
                Conexion.AddParemeter("CodigoCampo", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.CodigoCampo);
                Conexion.AddParemeter("Codigo", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.Codigo);
                Conexion.AddParemeter("Nombre", SqlDbType.VarChar, 100, ParameterDirection.Input, Ent.Nombre);
                Conexion.AddParemeter("Descripcion", SqlDbType.VarChar, 200, ParameterDirection.Input, Ent.Descripcion);
                Conexion.AddParemeter("FechaRegistro", SqlDbType.DateTime, 15, ParameterDirection.Input, Ent.FechaRegistro);
                Conexion.AddParemeter("CodUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.CodUsuario);
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
        public List<ServListaEntity> ObtenerServListaItem(Int32 ListaId)
        {
            Conexion.OpenConnection();
            Conexion.Store("sp_ServListaObtenerItem");
            Conexion.AddParemeter("ListaId", SqlDbType.Int, 20, ParameterDirection.Input, ListaId);

            SqlDataReader reader = Conexion.ReaderData();
            List<ServListaEntity> ListaData = new List<ServListaEntity>();
            FillSchemeTable(reader);
            while (reader.Read())
            {
                ServListaEntity entity = new ServListaEntity();
                if (FillFrom<ServListaEntity>(reader, entity)) ListaData.Add(entity);
            }
            reader.Close();
            Conexion.CloseConnection();
            return ListaData;
        }
    }
}
