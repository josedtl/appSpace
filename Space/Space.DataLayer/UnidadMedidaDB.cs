using Framework;
using Space.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.DataLayer
{
    public class UnidadMedidaDB : BaseDB
    {
        public List<UnidadMedidadEntity> GetUnidadMedidaItems()
        {
            try
            {
                List<UnidadMedidadEntity> ListaData = new List<UnidadMedidadEntity>();
                Conexion.OpenConnection();
                Conexion.Store("sp_UnidadMedidaItems");
                SqlDataReader reader = Conexion.ReaderData();
                FillSchemeTable(reader);
                while (reader.Read())
                {
                    UnidadMedidadEntity entity = new UnidadMedidadEntity();
                    if (FillFrom<UnidadMedidadEntity>(reader, entity)) ListaData.Add(entity);
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


        public List<UnidadMedidadEntity> GetUnidadMedida_Item(Int32 UnidadMedidaId)
        {
            try
            {
                List<UnidadMedidadEntity> ListaData = new List<UnidadMedidadEntity>();
                Conexion.OpenConnection();
                Conexion.Store("sp_UnidadMedida_Item");
                Conexion.AddParemeter("UnidadMedidaId", SqlDbType.Int, 10, ParameterDirection.Input, UnidadMedidaId);
                SqlDataReader reader = Conexion.ReaderData();
                FillSchemeTable(reader);
                while (reader.Read())
                {
                    UnidadMedidadEntity entity = new UnidadMedidadEntity();
                    if (FillFrom<UnidadMedidadEntity>(reader, entity)) ListaData.Add(entity);
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
