using Framework;
using Framework.Data;
using Space.Common;
using Space.EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace Space.DataLayer
{
    public class PersonaNaturalDB : BaseDataEntity
    {

        public virtual List<PersonaNaturalEntity> ObtenerItem(Int32 PersonaNaturaId)
        {
            try
            {
                StartHelper(false);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "PersonaNaturalId", DbType.Int32, 4, false, 0, 0, PersonaNaturaId);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_PersonaObtenerItem");
                FillSchemeTable(dr);
                List<PersonaNaturalEntity> EntityList = new List<PersonaNaturalEntity>();
                while (dr.Read())
                {
                    PersonaNaturalEntity entity = new PersonaNaturalEntity();
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
        public virtual bool Registrar(PersonaNaturalEntity Ent)
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

        public virtual List<PersonaNaturalEntity> Registrar(List<PersonaNaturalEntity> Items)
        {
            StartHelper(true);
            try
            {
                for (int o = 0; o < Items.Count; o++) Registrar(Items[o]);
            }
            catch (Exception ex)
            {
                Helper.CancelTransaction();
                throw ex;
            }

            Helper.Close();
            return Items;
        }


        private bool RegistrarDB(PersonaNaturalEntity Ent)
        {
            if (Ent.LogicalState == LogicalState.Added || Ent.LogicalState == LogicalState.Updated)
            {
                String storedName = "sp_PersonaActualizar";
                if (Ent.LogicalState == LogicalState.Added) storedName = "sp_PersonaRegistar";
                DbDatabase.GetStoredProcCommand(storedName);
                DbDatabase.SetTransaction(Helper.DbTransaction);



                DbDatabase.AddParameter(MyUtils.GetOutputDirection(true), "PersonaNaturalId", DbType.Int32, 4, false, 0, 0, Ent.PersonaNaturalId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "TipoDocumentoIdentidadId", DbType.Int32, 4, false, 0, 0, Ent.TipoDocumentoIdentidadId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "NumDocumento", DbType.String, 100, false, 0, 0, Ent.NumDocumento);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Nombres", DbType.String, 100, false, 0, 0, Ent.Nombres);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "ApellidoPaterno", DbType.String, 100, false, 0, 0, Ent.ApellidoPaterno);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "ApellidoMaterno", DbType.String, 100, false, 0, 0, Ent.ApellidoMaterno);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "FechaNacimiento", DbType.DateTime, 12, false, 0, 0, Ent.FechaNacimiento);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Direccion", DbType.String, 20, false, 0, 0, Ent.Direccion);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Telefono", DbType.String, 20, false, 0, 0, Ent.Telefono);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Correo", DbType.String, 20, false, 0, 0, Ent.Correo);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "SexoId", DbType.Int32, 4, false, 0, 0, Ent.SexoId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "EstadoCivilId", DbType.Int32, 4, false, 0, 0, Ent.EstadoCivilId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "UbigeoId", DbType.Int32, 4, false, 0, 0, Ent.UbigeoId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "CodUsuario", DbType.String, 20, false, 0, 0, Ent.CodUsuario);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "FechaRegistro", DbType.DateTime, 12, false, 0, 0, Ent.FechaRegistro);
                int returnValue = DbDatabase.ExecuteNonQuery();
                if (Ent.LogicalState == LogicalState.Added)
                {
                    if (Ent.PersonaNaturalId <= 0) Ent.PersonaNaturalId = (Int32)DbDatabase.GetParameterValue("PersonaNaturalId");
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



        public virtual List<PersonaNaturalEntity> ObtenerMain()
        {
            try
            {
                StartHelper(false);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(System.Data.CommandType.StoredProcedure, "sp_PersonaObtenerMain");
                FillSchemeTable(dr);
                List<PersonaNaturalEntity> EntityList = new List<PersonaNaturalEntity>();

                while (dr.Read())
                {
                    PersonaNaturalEntity entity = new PersonaNaturalEntity();
                    if (FillFrom<PersonaNaturalEntity>(dr, entity)) EntityList.Add(entity);
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
