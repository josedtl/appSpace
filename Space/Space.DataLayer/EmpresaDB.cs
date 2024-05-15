using Framework;
using Space.EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace Space.DataLayer
{
    public class EmpresaDB : BaseDB
    {

        public List<EmpresaEntity> GetEmpresaItem(Int32 EmpresaId)
        {
            try
            {

                List<EmpresaEntity> ListaData = new List<EmpresaEntity>();
                Conexion.OpenConnection();
                Conexion.Store("sp_Persona_Item");
                Conexion.AddParemeter("EmpresaId", SqlDbType.Int, 10, ParameterDirection.Input, EmpresaId);
                SqlDataReader reader = Conexion.ReaderData();
                FillSchemeTable(reader);
                while (reader.Read())
                {
                    EmpresaEntity entity = new EmpresaEntity();
                    if (FillFrom<EmpresaEntity>(reader, entity)) ListaData.Add(entity);
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

        public Int32 Save(EmpresaEntity Ent)
        {
            try
            {
                String NameStore = "sp_PersonaRegistar";

                Conexion.Store(NameStore);
                Conexion.AddParemeter("EmpresaId", SqlDbType.Int, 10, ParameterDirection.InputOutput, Ent.EmpresaId);
                Conexion.AddParemeter("TipoDocumentoIdentidadId", SqlDbType.Int, 10, ParameterDirection.Input, Ent.TipoDocumentoIdentidadId);
                Conexion.AddParemeter("NumDocumento", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.NumDocumento);
                Conexion.AddParemeter("RazonSocial", SqlDbType.VarChar, 50, ParameterDirection.Input, Ent.RazonSocial);
                Conexion.AddParemeter("NombreComercial", SqlDbType.VarChar, 50, ParameterDirection.Input, Ent.NombreComercial);
                Conexion.AddParemeter("Direccion", SqlDbType.VarChar, 200, ParameterDirection.Input, Ent.Direccion);
                Conexion.AddParemeter("Telefono", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.Telefono);
                Conexion.AddParemeter("Correo", SqlDbType.VarChar, 50, ParameterDirection.Input, Ent.Correo);
                Conexion.AddParemeter("UbigeoId", SqlDbType.Int, 10, ParameterDirection.Input, Ent.UbigeoId);
                Conexion.AddParemeter("FechaRegistro", SqlDbType.DateTime, 15, ParameterDirection.Input, Ent.FechaRegistro);
                Conexion.AddParemeter("CodUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.CodUsuario);
                Ent.EmpresaId = Conexion.ExecuteQueryItem("EmpresaId");

                return Ent.EmpresaId;
            }
            catch (Exception ex)
            {
                Conexion.Restore();
                throw ex;
            }

        }


        public Int32 Update(EmpresaEntity Ent)
        {
            try
            {

                String NameStore = "sp_PersonaActualizar";

                Conexion.Store(NameStore);
                Conexion.AddParemeter("EmpresaId", SqlDbType.Int, 10, ParameterDirection.InputOutput, Ent.EmpresaId);
                Conexion.AddParemeter("TipoDocumentoIdentidadId", SqlDbType.Int, 10, ParameterDirection.Input, Ent.TipoDocumentoIdentidadId);
                Conexion.AddParemeter("NumDocumento", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.NumDocumento);
                Conexion.AddParemeter("Nombres", SqlDbType.VarChar, 50, ParameterDirection.Input, Ent.RazonSocial);
                Conexion.AddParemeter("ApellidoPaterno", SqlDbType.VarChar, 50, ParameterDirection.Input, Ent.NombreComercial);
                Conexion.AddParemeter("Direccion", SqlDbType.VarChar, 200, ParameterDirection.Input, Ent.Direccion);
                Conexion.AddParemeter("Telefono", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.Telefono);
                Conexion.AddParemeter("Correo", SqlDbType.VarChar, 50, ParameterDirection.Input, Ent.Correo);
                Conexion.AddParemeter("UbigeoId", SqlDbType.Int, 10, ParameterDirection.Input, Ent.UbigeoId);
                Conexion.AddParemeter("FechaRegistro", SqlDbType.DateTime, 15, ParameterDirection.Input, Ent.FechaRegistro);
                Conexion.AddParemeter("CodUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.CodUsuario);
                Ent.EmpresaId = Conexion.ExecuteQueryItem("EmpresaId");

                return Ent.EmpresaId;
            }
            catch (Exception ex)
            {
                Conexion.Restore();
                throw ex;
            }

        }

        public List<EmpresaEntity> GetEmpresaMain()
        {
            try
            {

                List<EmpresaEntity> ListaData = new List<EmpresaEntity>();
                Conexion.OpenConnection();
                Conexion.Store("sp_PersonaMainAll");
                SqlDataReader reader = Conexion.ReaderData();
                FillSchemeTable(reader);
                while (reader.Read())
                {
                    EmpresaEntity entity = new EmpresaEntity();
                    if (FillFrom<EmpresaEntity>(reader, entity)) ListaData.Add(entity);
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
