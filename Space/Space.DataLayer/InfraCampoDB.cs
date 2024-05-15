using Framework;
using Space.EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace Space.DataLayer
{
    public class InfraCampoDB : BaseDB
    {

        public List<InfraCampoEntity> ObtenerTitulo(String codigo)
        {
            Conexion.OpenConnection();
            Conexion.Store("sp_InfraCampoObtenerTitulo");
            Conexion.AddParemeter("Codigo", SqlDbType.VarChar, 20, ParameterDirection.Input, codigo);

            SqlDataReader reader = Conexion.ReaderData();
            List<InfraCampoEntity> ListaData = new List<InfraCampoEntity>();
            FillSchemeTable(reader);
            while (reader.Read())
            {
                InfraCampoEntity entity = new InfraCampoEntity();
                if (FillFrom<InfraCampoEntity>(reader, entity)) ListaData.Add(entity);
            }
            reader.Close();
            Conexion.CloseConnection();
            return ListaData;
        }


    }
}
