using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Datos.Conexion;
using Space.EntityLayer;


namespace Space.DataLayer
{

    public class EntCampoTypeDB
    {

        public List<EntCampoTypeEntity> Get_CampoType_PersonaNatural()
        {
            List<EntCampoTypeEntity> ListaData = new List<EntCampoTypeEntity>();
            DatabaseManager dbManager = new DatabaseManager();
            SqlDataReader reader = dbManager.StoreConsulta("sp_EntCampo_PersonaNatural");
            EntCampoTypeEntity Item = null;
            while (reader.Read())
            {
                Item = null;
                Item = new EntCampoTypeEntity();

                Item.EntCampoId = Convert.ToInt32(reader["EntCampoId"]);
                Item.Campo = reader["Campo"].ToString();
                Item.Type = reader["Type"].ToString();

                ListaData.Add(Item);
            }

            reader.Close();

            return ListaData;
        }
    }

}