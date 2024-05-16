using Framework;
using Space.Common;
using Space.EntityLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.DataLayer
{
    public class InfraestructuraDB : BaseDataEntity
    {

        public virtual List<InfraestructuraEntity> ObtenerMain()
        {
            try
            {
                StartHelper(false);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(System.Data.CommandType.StoredProcedure, "sp_InfraestructuraObtenerMain");
                FillSchemeTable(dr);
                List<InfraestructuraEntity> EntityList = new List<InfraestructuraEntity>();

                while (dr.Read())
                {
                    InfraestructuraEntity entity = new InfraestructuraEntity();
                    if (FillFrom<InfraestructuraEntity>(dr, entity)) EntityList.Add(entity);
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
        public virtual List<InfraestructuraEntity> ObtenerItem(Int32 InfraestructuraId)
        {
            try
            {
                StartHelper(false);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "InfraestructuraId", DbType.Int32, 4, false, 0, 0, InfraestructuraId);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_InfraestructuraObtenerItem");
                FillSchemeTable(dr);
                List<InfraestructuraEntity> EntityList = new List<InfraestructuraEntity>();
                while (dr.Read())
                {
                    InfraestructuraEntity entity = new InfraestructuraEntity();
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

        public virtual bool Registrar(InfraestructuraEntity Ent)
        {
            StartHelper(true);
            try
            {
                if (Ent.LogicalState == LogicalState.Deleted) DeleteDB(Ent);
                else RegistrarDB(Ent);
            }
            catch (Exception ex)
            {
                Helper.CancelTransaction();
                throw ex;
            }

            Helper.Close();
            return true;
        }

       
        private bool RegistrarDB(InfraestructuraEntity Ent)
        {
            if (Ent.LogicalState == LogicalState.Added || Ent.LogicalState == LogicalState.Updated)
            {
                String storedName = "sp_InfraestructuraActualizar";
                if (Ent.LogicalState == LogicalState.Added) storedName = "sp_InfraestructuraRegistar";
                DbDatabase.GetStoredProcCommand(storedName);
                DbDatabase.SetTransaction(Helper.DbTransaction);

                DbDatabase.AddParameter(MyUtils.GetOutputDirection(true), "InfraestructuraId", DbType.Int32, 4, false, 0, 0, Ent.InfraestructuraId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "EstadoAdministrativoId", DbType.Int16, 2, false, 0, 0, Ent.EstadoAdministrativoId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "SucursalId", DbType.Int32, 4, false, 0, 0, Ent.SucursalId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "CodigoSistema", DbType.String, 50, false, 0, 0, Ent.CodigoSistema);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "CodigoInterno", DbType.String, 50, false, 0, 0, Ent.CodigoInterno);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Descripcion", DbType.String, 250, false, 0, 0, Ent.Descripcion);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "TipoInfraestructuraId", DbType.Int32, 4, false, 0, 0, Ent.TipoInfraestructuraId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "ClasificacionId", DbType.Int32, 4, false, 0, 0, Ent.ClasificacionId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "InfraestructuraDimensionId", DbType.Int32, 4, false, 0, 0, Ent.InfraestructuraDimensionId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Aforo", DbType.Int32, 4, false, 0, 0, Ent.Aforo);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "PisoId", DbType.Int32, 4, false, 0, 0, Ent.PisoId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "FechaRegistro", DbType.DateTime, 8, false, 0, 0, Ent.FechaRegistro);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "CodUsuario", DbType.String, 20, false, 0, 0, Ent.CodUsuario);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "EstadoRegistro", DbType.Boolean, 1, false, 0, 0, Ent.EstadoRegistro);
                int returnValue = DbDatabase.ExecuteNonQuery();
                if (Ent.LogicalState == LogicalState.Added)
                {
                    if (Ent.InfraestructuraId <= 0) Ent.InfraestructuraId = (Int32)DbDatabase.GetParameterValue("InfraestructuraId");
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

        public virtual bool Delete(InfraestructuraEntity Item)
        {
            StartHelper(true);
            try
            {
                if (DeleteDB(Item)) Item.LogicalState = LogicalState.Deleted;
            }
            catch (Exception ex)
            {
                Helper.CancelTransaction();
                throw ex;
            }
            Helper.Close();
            return true;
        }

        public virtual List<InfraestructuraEntity> Delete(List<InfraestructuraEntity> Items)
        {
            StartHelper(true);
            try
            {
                for (int o = 0; o < Items.Count; o++) if (DeleteDB(Items[o])) Items[o].LogicalState = LogicalState.Deleted;
            }
            catch (Exception ex)
            {
                Helper.CancelTransaction();
                throw ex;
            }

            Helper.Close();
            return Items;
        }

        private bool DeleteDB(InfraestructuraEntity Ent)
        {
            if (Ent.InfraestructuraId == 0) return true;
            int returnValue = 0;
            try
            {
                if (m_Helper.IsTransactional)
                {
                    DbDatabase.GetStoredProcCommand("up_Actividad_DeleteByKey");
                    DbDatabase.SetTransaction(Helper.DbTransaction);
                    DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "ActividadId", DbType.Int32, 4, false, 0, 0, Ent.InfraestructuraId);
                    returnValue = DbDatabase.ExecuteNonQuery();
                }
                else
                {
                    returnValue = DbDatabase.ExecuteNonQuery("up_Actividad_DeleteByKey", Ent.InfraestructuraId);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (returnValue < 0) throw new Exception("ErrorDB.DeleteEntity");
            return true;
        }

        public virtual List<InfraestructuraEntity> ObtenerFiltroAlquiler()
        {
            try
            {
                StartHelper(false);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(System.Data.CommandType.StoredProcedure, "sp_InfraestructuraObtenerFiltro");
                FillSchemeTable(dr);
                List<InfraestructuraEntity> EntityList = new List<InfraestructuraEntity>();

                while (dr.Read())
                {
                    InfraestructuraEntity entity = new InfraestructuraEntity();
                    if (FillFrom<InfraestructuraEntity>(dr, entity)) EntityList.Add(entity);
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
