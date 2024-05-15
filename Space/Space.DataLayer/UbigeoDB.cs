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
    public class UbigeoDB : BaseDB
    {
        public List<UbigeoEntity> GetUbigeoBuscarLike(String DesUbigeo)
        {
            try
            {
                List<UbigeoEntity> ListaData = new List<UbigeoEntity>();
                Conexion.OpenConnection();
                Conexion.Store("sp_UbigeoBuscarLike");
                Conexion.AddParemeter("DesUbigeo", SqlDbType.VarChar, 50, ParameterDirection.Input, DesUbigeo);
                SqlDataReader reader = Conexion.ReaderData();
                FillSchemeTable(reader);
                while (reader.Read())
                {
                    UbigeoEntity entity = new UbigeoEntity();
                    if (FillFrom<UbigeoEntity>(reader, entity)) ListaData.Add(entity);
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

        public List<UbigeoEntity> GetUbigeoItem(Int32 UbigeoId)
        {
            try
            {
                List<UbigeoEntity> ListaData = new List<UbigeoEntity>();
                Conexion.OpenConnection();
                Conexion.Store("sp_UbigeoItem");
                Conexion.AddParemeter("UbigeoId", SqlDbType.Int, 12, ParameterDirection.Input, UbigeoId);
                SqlDataReader reader = Conexion.ReaderData();
                FillSchemeTable(reader);
                while (reader.Read())
                {
                    UbigeoEntity entity = new UbigeoEntity();
                    if (FillFrom<UbigeoEntity>(reader, entity)) ListaData.Add(entity);
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
