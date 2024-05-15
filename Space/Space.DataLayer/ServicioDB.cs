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
    public class ServicioDB : BaseDB
    {
        public List<ServicioEntity> ObtenerMain()
        {
            try
            {
                List<ServicioEntity> ListaData = new List<ServicioEntity>();
                Conexion.OpenConnection();
                Conexion.Store("sp_ServicioObtenerMain");
                SqlDataReader reader = Conexion.ReaderData();
                FillSchemeTable(reader);
                while (reader.Read())
                {
                    ServicioEntity entity = new ServicioEntity();
                    if (FillFrom<ServicioEntity>(reader, entity)) ListaData.Add(entity);
                }
                reader.Close();
                Conexion.CloseConnection();
                return ListaData;

            }
            catch (Exception ex)
            {
                Conexion.Restore();
                throw ex;
            }
        }

        public Int32 Registrar(ServicioEntity Ent)
        {
            try
            {

                String NameStore = "sp_ServicioRegistrar";

                Conexion.Store(NameStore);
                Conexion.AddParemeter("ServicioId", SqlDbType.Int, 10, ParameterDirection.InputOutput, Ent.ServicioId);
                Conexion.AddParemeter("Nombre", SqlDbType.VarChar, 150, ParameterDirection.Input, Ent.Nombre);
                Conexion.AddParemeter("Descripcion", SqlDbType.VarChar, 250, ParameterDirection.Input, Ent.Descripcion);
                Conexion.AddParemeter("TipoServicioId", SqlDbType.Int, 10, ParameterDirection.Input, Ent.TipoServicioId);
                Conexion.AddParemeter("FechaRegistro", SqlDbType.DateTime, 15, ParameterDirection.Input, Ent.FechaRegistro);
                Conexion.AddParemeter("CodUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.CodUsuario);
                Conexion.AddParemeter("EstadoRegistro", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.EstadoRegistro);

                Ent.ServicioId = Conexion.ExecuteQueryItem("ServicioId");
                return Ent.ServicioId;
            }
            catch (Exception ex)
            {
                Conexion.Restore();
                throw ex;
            }
        }


        public Int32 Actualizar(ServicioEntity Ent)
        {
            try
            {

                String NameStore = "sp_ServicioActualizar";

                Conexion.Store(NameStore);
                Conexion.AddParemeter("ServicioId", SqlDbType.Int, 10, ParameterDirection.InputOutput, Ent.ServicioId);
                Conexion.AddParemeter("Nombre", SqlDbType.VarChar, 150, ParameterDirection.Input, Ent.Nombre);
                Conexion.AddParemeter("Descripcion", SqlDbType.VarChar, 250, ParameterDirection.Input, Ent.Descripcion);
                Conexion.AddParemeter("TipoServicioId", SqlDbType.Int, 10, ParameterDirection.Input, Ent.TipoServicioId);
                Conexion.AddParemeter("FechaRegistro", SqlDbType.DateTime, 15, ParameterDirection.Input, Ent.FechaRegistro);
                Conexion.AddParemeter("CodUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.CodUsuario);
                Conexion.AddParemeter("EstadoRegistro", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.EstadoRegistro);

                Ent.ServicioId = Conexion.ExecuteQueryItem("ServicioId");
                return Ent.ServicioId;
            }
            catch (Exception ex)
            {
                Conexion.Restore();
                throw ex;
            }
        }

        public List<ServicioEntity> ObtenerItem(Int32 ServicioId)
        {
            try
            {
                List<ServicioEntity> ListaData = new List<ServicioEntity>();
                Conexion.OpenConnection();
                Conexion.Store("sp_ServicioObtenerItem");
                Conexion.AddParemeter("ServicioId", SqlDbType.Int, 10, ParameterDirection.Input, ServicioId);
                SqlDataReader reader = Conexion.ReaderData();
                FillSchemeTable(reader);
                while (reader.Read())
                {
                    ServicioEntity entity = new ServicioEntity();
                    if (FillFrom<ServicioEntity>(reader, entity)) ListaData.Add(entity);
                }
                reader.Close();
                return ListaData;

            }
            catch (Exception ex)
            {
                Conexion.Restore();
                throw ex;
            }
        }


    }
}
