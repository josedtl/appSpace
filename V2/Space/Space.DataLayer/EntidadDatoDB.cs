using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Datos.Conexion;
using Space.EntityLayer;


namespace Space.DataLayer
{

    public class EntidadDatoDB
    {
        public List<EntidadEntity> GetEndidad()
        {
            List<EntidadEntity> ListaData = new List<EntidadEntity>();
            DatabaseManager dbManager = new DatabaseManager();
            SqlDataReader reader = dbManager.StoreConsulta("sp_PersonaAll");
            EntidadEntity Item = null;
            while (reader.Read())
            {
                Item = null;
                Item = new EntidadEntity();

                Item.EntidadId = Convert.ToInt32(reader["EntidadId"]);
                Item.NumDocumento = reader["NumDocumento"].ToString();
                //Item.Nombres = reader["Nombres"].ToString();
                //Item.ApellidoPaterno = reader["ApellidoPaterno"].ToString();
                //Item.ApellidoMaterno = reader["ApellidoMaterno"].ToString();
                //Item.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                //Item.Direccion = reader["Direccion"].ToString();
                //Item.Telefono = reader["Telefono"].ToString();
                //Item.Correo = reader["Correo"].ToString();
                //Item.SexoId = Convert.ToInt32(reader["SexoId"].ToString());
                //Item.EstadoCivilId = Convert.ToInt32(reader["EstadoCivilId"].ToString());

                ListaData.Add(Item);
            }

            reader.Close();

            return ListaData;
        }

        public EntidadEntity Save(EntidadEntity Ent)
        {
            DatabaseManager dbManager = new DatabaseManager();

            String NameStore = "up_Entidad_Insert";
            if (Ent.EntidadId > 0) NameStore = "up_Entidad_UpdateByKey";


            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@EntidadId", Ent.EntidadId)
            {
                Direction= ParameterDirection.InputOutput,
                SqlDbType= SqlDbType.Int
            },
            new SqlParameter("@TipoEntidadId", Ent.TipoEntidadId),
            new SqlParameter("@TipoDocumentoIdentidadId", Ent.TipoDocumentoIdentidadId),
            new SqlParameter("@NumDocumento", Ent.NumDocumento),
            new SqlParameter("@NombreCompleto",Ent.Nombres+" "+Ent.ApellidoPaterno + " "+ Ent.ApellidoMaterno),
            new SqlParameter("@FechaRegistro", Ent.FechaRegistro),
            new SqlParameter("@CodUsuario",Ent.CodUsuario),
            new SqlParameter("@UbigeoId", Ent.UbigeoId),
            };


            Ent.EntidadId = dbManager.ProcedimientoSave(NameStore, parametros, "@EntidadId");



            EntidadDatoEntity EntDato = new EntidadDatoEntity(Ent);

            //EntidadEntity persona = new PersonaNatural
            //{
            //    Nombre = "Juan",
            //    Edad = 30,
            //    DNI = "12345678"
            //    // ... inicializar otros atributos
            //};

            Type tipoPersona = EntDato.GetType();
            PropertyInfo[] propiedades = tipoPersona.GetProperties();

            foreach (PropertyInfo propiedad in propiedades)
            {
                string nombrePropiedad = propiedad.Name;
                object valorPropiedad = propiedad.GetValue(EntDato);
                Console.WriteLine($"Nombre del atributo: {nombrePropiedad}, Valor: {valorPropiedad}");

            }

            return Ent;

        }
    }

}