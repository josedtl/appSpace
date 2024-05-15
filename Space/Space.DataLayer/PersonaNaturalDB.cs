using Framework;
using Space.EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace Space.DataLayer
{
    public class PersonaNaturalDB : BaseDB
    {

        public List<PersonaNaturalEntity> ObtenerItem(Int32 PersonaNaturalId)
        {
            try
            {
                List<PersonaNaturalEntity> ListaData = new List<PersonaNaturalEntity>();
                Conexion.OpenConnection();
                Conexion.Store("sp_PersonaObtenerItem");
                Conexion.AddParemeter("PersonaNaturaId", SqlDbType.Int, 10, ParameterDirection.Input, PersonaNaturalId);
                SqlDataReader reader = Conexion.ReaderData();
                FillSchemeTable(reader);
                while (reader.Read())
                {
                    PersonaNaturalEntity entity = new PersonaNaturalEntity();
                    if (FillFrom<PersonaNaturalEntity>(reader, entity)) ListaData.Add(entity);
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

        public Int32 Registrar(PersonaNaturalEntity Ent)
        {
            try
            {
                String NameStore = "sp_PersonaRegistar";

                Conexion.Store(NameStore);
                Conexion.AddParemeter("PersonaNaturalId", SqlDbType.Int, 10, ParameterDirection.InputOutput, Ent.PersonaNaturalId);
                Conexion.AddParemeter("TipoDocumentoIdentidadId", SqlDbType.Int, 10, ParameterDirection.Input, Ent.TipoDocumentoIdentidadId);
                Conexion.AddParemeter("NumDocumento", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.NumDocumento);
                Conexion.AddParemeter("Nombres", SqlDbType.VarChar, 50, ParameterDirection.Input, Ent.Nombres);
                Conexion.AddParemeter("ApellidoPaterno", SqlDbType.VarChar, 50, ParameterDirection.Input, Ent.ApellidoPaterno);
                Conexion.AddParemeter("ApellidoMaterno", SqlDbType.VarChar, 50, ParameterDirection.Input, Ent.ApellidoMaterno);
                Conexion.AddParemeter("FechaNacimiento", SqlDbType.DateTime, 15, ParameterDirection.Input, Ent.FechaNacimiento);
                Conexion.AddParemeter("Direccion", SqlDbType.VarChar, 200, ParameterDirection.Input, Ent.Direccion);
                Conexion.AddParemeter("Telefono", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.Telefono);
                Conexion.AddParemeter("Correo", SqlDbType.VarChar, 50, ParameterDirection.Input, Ent.Correo);
                Conexion.AddParemeter("SexoId", SqlDbType.Int, 10, ParameterDirection.Input, Ent.SexoId);
                Conexion.AddParemeter("EstadoCivilId", SqlDbType.Int, 10, ParameterDirection.Input, Ent.EstadoCivilId);
                Conexion.AddParemeter("UbigeoId", SqlDbType.Int, 10, ParameterDirection.Input, Ent.UbigeoId);
                Conexion.AddParemeter("CodUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.CodUsuario);
                Conexion.AddParemeter("FechaRegistro", SqlDbType.DateTime, 15, ParameterDirection.Input, Ent.FechaRegistro);
                Ent.PersonaNaturalId = Conexion.ExecuteQueryItem("PersonaNaturalId");

                return Ent.PersonaNaturalId;
            }
            catch (Exception ex)
            {
                Conexion.Restore();
                throw ex;
            }

        }


        public Int32 Actualizar(PersonaNaturalEntity Ent)
        {
            try
            {

                String NameStore = "sp_PersonaActualizar";

                Conexion.Store(NameStore);
                Conexion.AddParemeter("PersonaNaturalId", SqlDbType.Int, 10, ParameterDirection.InputOutput, Ent.PersonaNaturalId);
                Conexion.AddParemeter("TipoDocumentoIdentidadId", SqlDbType.Int, 10, ParameterDirection.Input, Ent.TipoDocumentoIdentidadId);
                Conexion.AddParemeter("NumDocumento", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.NumDocumento);
                Conexion.AddParemeter("Nombres", SqlDbType.VarChar, 50, ParameterDirection.Input, Ent.Nombres);
                Conexion.AddParemeter("ApellidoPaterno", SqlDbType.VarChar, 50, ParameterDirection.Input, Ent.ApellidoPaterno);
                Conexion.AddParemeter("ApellidoMaterno", SqlDbType.VarChar, 50, ParameterDirection.Input, Ent.ApellidoMaterno);
                Conexion.AddParemeter("FechaNacimiento", SqlDbType.DateTime, 15, ParameterDirection.Input, Ent.FechaNacimiento);
                Conexion.AddParemeter("Direccion", SqlDbType.VarChar, 200, ParameterDirection.Input, Ent.Direccion);
                Conexion.AddParemeter("Telefono", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.Telefono);
                Conexion.AddParemeter("Correo", SqlDbType.VarChar, 50, ParameterDirection.Input, Ent.Correo);
                Conexion.AddParemeter("SexoId", SqlDbType.Int, 10, ParameterDirection.Input, Ent.SexoId);
                Conexion.AddParemeter("EstadoCivilId", SqlDbType.Int, 10, ParameterDirection.Input, Ent.EstadoCivilId);
                Conexion.AddParemeter("UbigeoId", SqlDbType.Int, 10, ParameterDirection.Input, Ent.UbigeoId);
                Conexion.AddParemeter("CodUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.CodUsuario);
                Conexion.AddParemeter("FechaRegistro", SqlDbType.DateTime, 15, ParameterDirection.Input, Ent.FechaRegistro);
                Ent.PersonaNaturalId = Conexion.ExecuteQueryItem("PersonaNaturalId");

                return Ent.PersonaNaturalId;
            }
            catch (Exception ex)
            {
                Conexion.Restore();
                throw ex;
            }

        }

        public List<PersonaNaturalEntity> ObtenerMain()
        {
            try
            {
                List<PersonaNaturalEntity> ListaData = new List<PersonaNaturalEntity>();
                Conexion.OpenConnection();
                Conexion.Store("sp_PersonaObtenerMain");
                SqlDataReader reader = Conexion.ReaderData();
                FillSchemeTable(reader);
                while (reader.Read())
                {
                    PersonaNaturalEntity entity = new PersonaNaturalEntity();
                    if (FillFrom<PersonaNaturalEntity>(reader, entity)) ListaData.Add(entity);
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
    }
}
