using Framework;
using Framework.Data;
using Space.Common;
using Space.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.DataLayer
{
    public class TarifaDB : BaseDataEntity
    {
        public virtual List<TarifaEntity> ObtenerMain()
        {
            try
            {
                StartHelper(false);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(System.Data.CommandType.StoredProcedure, "sp_TarifaObtenerMain");
                FillSchemeTable(dr);
                List<TarifaEntity> EntityList = new List<TarifaEntity>();

                while (dr.Read())
                {
                    TarifaEntity entity = new TarifaEntity();
                    if (FillFrom<TarifaEntity>(dr, entity)) EntityList.Add(entity);
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

        public virtual bool Registrar(TarifaEntity Ent)
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

        private bool RegistrarDB(TarifaEntity Ent)
        {
            if (Ent.LogicalState == LogicalState.Added || Ent.LogicalState == LogicalState.Updated)
            {
                String storedName = "sp_TarifaActualizar";
                if (Ent.LogicalState == LogicalState.Added) storedName = "sp_TarifaRegistrar";
                DbDatabase.GetStoredProcCommand(storedName);
                DbDatabase.SetTransaction(Helper.DbTransaction);
         

                DbDatabase.AddParameter(MyUtils.GetOutputDirection(true), "TarifaId", DbType.Int32, 4, false, 0, 0, Ent.TarifaId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false),"ObjetoRefereciaId", DbType.Int32, 4, false, 0, 0, Ent.ObjetoReferenciaId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false),"Correlativo", DbType.String, 200, false, 0, 0, Ent.Correlativo);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false),"MonedaId", DbType.Int32, 10, false, 0, 0, Ent.MonedaId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false),"TipoTarifaEnum", DbType.Int32, 10, false, 0, 0, Ent.TipoTarifaEnum);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false),"UnidadMedidaId", DbType.Int32, 10, false, 0, 0, Ent.UnidadMedidaId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false),"CostoTarifa", DbType.Decimal, 17, false, 0, 0, Ent.CostoTarifa);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false),"NomTarifa", DbType.String, 200, false, 0, 0, Ent.NomTarifa);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false),"NomComercial", DbType.String, 200, false, 0, 0, Ent.NomComercial);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false),"Descripcion", DbType.String, 200, false, 0, 0, Ent.Descripcion);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false),"FechaRegistro", DbType.DateTime, 15, false, 0, 0, Ent.FechaRegistro);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false),"CodUsuario", DbType.String, 20, false, 0, 0, Ent.CodUsuario);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "EstadoRegistro", DbType.String, 20, false, 0, 0, Ent.EstadoRegistro);

                int returnValue = DbDatabase.ExecuteNonQuery();
                if (Ent.LogicalState == LogicalState.Added)
                {
                    if (Ent.TarifaId <= 0) Ent.TarifaId = (Int32)DbDatabase.GetParameterValue("TarifaId");
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

        public virtual List<TarifaEntity> ObtenerItem(Int32 TarifaId)
        {
            try
            {
                StartHelper(false);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "TarifaId", DbType.Int32, 4, false, 0, 0, TarifaId);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_TarifaObtenerItem");
                FillSchemeTable(dr);
                List<TarifaEntity> EntityList = new List<TarifaEntity>();
                while (dr.Read())
                {
                    TarifaEntity entity = new TarifaEntity();
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


        public virtual List<TarifaEntity> BuscarRecurso(String Nombre, int Tipo)
        {
            try
            {
                StartHelper(false);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Nombre", DbType.String, 20, false, 0, 0, Nombre);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Tipo", DbType.Int32, 4, false, 0, 0, Tipo);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_TarifaBuscarRecurso");
                FillSchemeTable(dr);
                List<TarifaEntity> EntityList = new List<TarifaEntity>();
                while (dr.Read())
                {
                    TarifaEntity entity = new TarifaEntity();
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

        
        public virtual List<TarifaEntity> GetTarifaBuscarItem(String NomComercial)
        {
            try
            {
                StartHelper(false);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "NomComercial", DbType.String, 20, false, 0, 0, NomComercial);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_TarifaBuscarItem");
                FillSchemeTable(dr);
                List<TarifaEntity> EntityList = new List<TarifaEntity>();
                while (dr.Read())
                {
                    TarifaEntity entity = new TarifaEntity();
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
