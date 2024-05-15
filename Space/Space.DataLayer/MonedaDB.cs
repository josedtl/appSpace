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
    public class MonedaDB : BaseDB
    {

        public List<MonedaEntity> ObtenerMonedaItems()
        {
            try
            {

                List<MonedaEntity> ListaData = new List<MonedaEntity>();
                Conexion.OpenConnection();
                Conexion.Store("sp_MonedaObtenerItems");
                SqlDataReader reader = Conexion.ReaderData();
                FillSchemeTable(reader);
                while (reader.Read())
                {
                    MonedaEntity entity = new MonedaEntity();
                    if (FillFrom<MonedaEntity>(reader, entity)) ListaData.Add(entity);
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


        public List<MonedaEntity> ObtenerMonedaItem(Int32 MonedaId)
        {
            try
            {
                List<MonedaEntity> ListaData = new List<MonedaEntity>();
                Conexion.OpenConnection();
                Conexion.Store("sp_MonedaObtenerItem");
                Conexion.AddParemeter("MonedaId", SqlDbType.Int, 10, ParameterDirection.Input, MonedaId);
                SqlDataReader reader = Conexion.ReaderData();
                FillSchemeTable(reader);
                while (reader.Read())
                {
                    MonedaEntity entity = new MonedaEntity();
                    if (FillFrom<MonedaEntity>(reader, entity)) ListaData.Add(entity);
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
