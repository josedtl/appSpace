using Framework;
using Framework.Data;
using Space.Common;
using Space.EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace Space.DataLayer
{
    public class EmpresaDB : BaseDataEntity
    {
        public virtual List<EmpresaEntity> GetEmpresaItem(Int32 EmpresaId)
        {
            try
            {
                StartHelper(false);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "EmpresaId", DbType.Int32, 4, false, 0, 0, EmpresaId);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_Persona_Item");
                FillSchemeTable(dr);
                List<EmpresaEntity> EntityList = new List<EmpresaEntity>();
                while (dr.Read())
                {
                    EmpresaEntity entity = new EmpresaEntity();
                    if (FillFrom(dr, entity)) EntityList.Add(entity);
                    entity.OnLogicalLoaded();
                }

                Helper.Close(dr);
                return EntityList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual bool Registrar(EmpresaEntity Ent)
        {
            StartHelper(true);
            try
            {
                RegistrarDB(Ent);
            }
            catch (Exception ex)
            {
                Helper.CancelTransaction();
                throw ex;
            }

            Helper.Close();
            return true;
        }

        private bool RegistrarDB(EmpresaEntity Ent)
        {
            if (Ent.LogicalState == LogicalState.Added || Ent.LogicalState == LogicalState.Updated)
            {
                String storedName = "sp_PersonaActualizar";
                if (Ent.LogicalState == LogicalState.Added) storedName = "sp_PersonaRegistar";
                DbDatabase.GetStoredProcCommand(storedName);
                DbDatabase.SetTransaction(Helper.DbTransaction);


                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "EmpresaId", DbType.Int32, 4, false, 0, 0, Ent.EmpresaId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "TipoDocumentoIdentidadId", DbType.Int32, 4, false, 0, 0, Ent.TipoDocumentoIdentidadId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "NumDocumento", DbType.String, 250, false, 0, 0, Ent.NumDocumento);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "RazonSocial", DbType.String, 250, false, 0, 0, Ent.RazonSocial);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "NombreComercial", DbType.String, 250, false, 0, 0, Ent.NombreComercial);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Direccion", DbType.String, 250, false, 0, 0, Ent.Direccion);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Telefono", DbType.String, 250, false, 0, 0, Ent.Telefono);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Correo", DbType.String, 250, false, 0, 0, Ent.Correo);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "UbigeoId", DbType.Int32, 4, false, 0, 0, Ent.UbigeoId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "FechaRegistro", DbType.DateTime, 8, false, 0, 0, Ent.FechaRegistro);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "CodUsuario", DbType.String, 250, false, 0, 0, Ent.CodUsuario);
                int returnValue = DbDatabase.ExecuteNonQuery();
                if (Ent.LogicalState == LogicalState.Added)
                {
                    if (Ent.EmpresaId <= 0) Ent.EmpresaId = (Int32)DbDatabase.GetParameterValue("EmpresaId");
                    Ent.OnLogicalAdded();
                }
                else
                {
                    if (returnValue <= 0) throw new Exception("ErrorDB.UpdateEntity");
                    Ent.OnLogicalUpdate();
                }
            }


            return true;
        }

        public virtual List<EmpresaEntity> GetEmpresaMain()
        {
            try
            {
                StartHelper(false);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_EmpresaObtenerMain");
                FillSchemeTable(dr);
                List<EmpresaEntity> EntityList = new List<EmpresaEntity>();
                while (dr.Read())
                {
                    EmpresaEntity entity = new EmpresaEntity();
                    if (FillFrom(dr, entity)) EntityList.Add(entity);
                    entity.OnLogicalLoaded();
                }

                Helper.Close(dr);
                return EntityList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
