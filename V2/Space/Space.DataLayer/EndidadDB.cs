using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Datos.Conexion;
using Space.EntityLayer;
using DRFramework;


namespace Space.DataLayer
{

    public class EndidadDB : BaseDB
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
                Item.Nombres = reader["Nombres"].ToString();
                Item.ApellidoPaterno = reader["ApellidoPaterno"].ToString();
                Item.ApellidoMaterno = reader["ApellidoMaterno"].ToString();
                Item.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                Item.Direccion = reader["Direccion"].ToString();
                Item.Telefono = reader["Telefono"].ToString();
                Item.Correo = reader["Correo"].ToString();
                Item.SexoId = Convert.ToInt32(reader["SexoId"].ToString());
                Item.EstadoCivilId = Convert.ToInt32(reader["EstadoCivilId"].ToString());

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



            EntCampoTypeDB entCampoTypeDB = new EntCampoTypeDB();

            var ItemDataType = entCampoTypeDB.Get_CampoType_PersonaNatural();



            EntidadDatoEntity EntDato = new EntidadDatoEntity(Ent);

            Type tipoPersona = EntDato.GetType();
            PropertyInfo[] propiedades = tipoPersona.GetProperties();

            foreach (PropertyInfo propiedad in propiedades)
            {

                Type tipoDato = propiedad.PropertyType; // Obtener el tipo de dato de la propiedad

                string nombrePropiedad = propiedad.Name;
                object valorPropiedad = propiedad.GetValue(EntDato);
                Console.WriteLine($"Nombre del atributo: {nombrePropiedad}, Valor: {valorPropiedad},  Tipo de dato: {tipoDato}");

                EntDatoDB entDatoDB = new EntDatoDB();


                String? m_ValorAlfaNumerico = null;
                DateTime? m_ValorFecha = null;
                Int32? m_ListaRelacionId = null;


                Int32 Index = ItemDataType.FindIndex(S => S.Campo == nombrePropiedad);

                if (Index == -1) continue;


                switch (ItemDataType[Index].Type)
                {
                    case "Array":
                        m_ListaRelacionId = (Int32)valorPropiedad;
                        break;
                    case "Datetime":
                        m_ValorFecha = (DateTime)valorPropiedad;
                        break;
                    default:
                        m_ValorAlfaNumerico = valorPropiedad.ToString();
                        break;

                }

                entDatoDB.Save(new EntDatoEntity
                {
                    EntDatoId = 0,
                    EntidadId = Ent.EntidadId,
                    ValorAlfaNumerico = m_ValorAlfaNumerico,
                    ValorFecha = m_ValorFecha,
                    ListaRelacionId = m_ListaRelacionId,
                    EntCampoId = ItemDataType[Index].EntCampoId
                });

            }

            return Ent;

        }

        public EntidadEntity SaveAlter(EntidadEntity Ent)
        {
            DatabaseManager dbManager = new DatabaseManager();
            string connectionString = "Data Source=tu_servidor;Initial Catalog=nombre_base_datos;User ID=usuario;Password=contraseña";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();


            transaction.Rollback();
            // 1. Insertar la cabecera utilizando el procedimiento almacenado
            SqlCommand insertCabeceraCmd = new SqlCommand("InsertarCabecera", connection, transaction);
            insertCabeceraCmd.CommandType = CommandType.StoredProcedure;

            // Configurar el parámetro de salida para obtener el Id de la cabecera insertada



            insertCabeceraCmd.Parameters.Add(new SqlParameter("@EntidadId", Ent.EntidadId)
            {
                Direction = ParameterDirection.InputOutput,
                SqlDbType = SqlDbType.Int,
                Size = 4,

            });
            insertCabeceraCmd.Parameters.Add(new SqlParameter("@TipoEntidadId", Ent.TipoEntidadId)
            {
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.Int,
                Size = 4,
            });
            insertCabeceraCmd.Parameters.Add(new SqlParameter("@TipoDocumentoIdentidadId", Ent.TipoDocumentoIdentidadId)
            {
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.Int,
                Size = 4,
            });
            insertCabeceraCmd.Parameters.Add(new SqlParameter("@NumDocumento", Ent.NumDocumento)
            {
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.VarChar,
                Size = 11,
            });
            insertCabeceraCmd.Parameters.Add(new SqlParameter("@NombreCompleto", Ent.Nombres + " " + Ent.ApellidoPaterno + " " + Ent.ApellidoMaterno)
            {
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
            });
            insertCabeceraCmd.Parameters.Add(new SqlParameter("@FechaRegistro", Ent.FechaRegistro)
            {
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.DateTime,
                Size = 12,
            });
            insertCabeceraCmd.Parameters.Add(new SqlParameter("@CodUsuario", Ent.CodUsuario)
            {
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.VarChar,
                Size = 15,
            });
            insertCabeceraCmd.Parameters.Add(new SqlParameter("@UbigeoId", Ent.UbigeoId)
            {
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.Int,
                Size = 4,
            });
            // Ejecutar el procedimiento almacenado para insertar la cabecera
            insertCabeceraCmd.ExecuteNonQuery();

            // Obtener el valor de la variable OUT (IdCabecera) después de la ejecución del procedimiento
            Ent.EntidadId = Convert.ToInt32(insertCabeceraCmd.Parameters["@EntidadId"].Value);

            // ... (resto del código para insertar el detalle o realizar otras operaciones)

            // Realizar el commit si todo se ejecutó correctamente
            transaction.Commit();

            return Ent;


        }

        public List<EntidadEntity> GetEndidadAlter()
        {
            List<EntidadEntity> ListaData = new List<EntidadEntity>();
            Conexion.OpenConnection();
            Conexion.Store("sp_PersonaAll");
            SqlDataReader reader = Conexion.ReaderData();
            FillSchemeTable(reader);
            while (reader.Read())
            {
                EntidadEntity entity = new EntidadEntity();
                if (FillFrom<EntidadEntity>(reader, entity)) ListaData.Add(entity);
            }
            reader.Close();
            return ListaData;
        }

    }

}