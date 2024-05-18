using Framework;
using Space.Common;
using Space.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Space.DataLayer
{
    public class AlquilerDB : BaseDataEntity
    {

        public virtual List<AlquilerEntity> ObtenerMain(String EstadoProcesoIds,DateTime FechaInicio, DateTime FechaTermino)
        {
            try
            {
                StartHelper(false);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "EstadoProcesoIds", DbType.String, 20, false, 0, 0, EstadoProcesoIds);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "FechaInicio", DbType.String, 20, false, 0, 0, FechaInicio);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "FechaTermino", DbType.String, 20, false, 0, 0, FechaTermino);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_AlquilerObtenerMain");
                FillSchemeTable(dr);
                List<AlquilerEntity> EntityList = new List<AlquilerEntity>();
                while (dr.Read())
                {
                    AlquilerEntity entity = new AlquilerEntity();
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
        public virtual bool Registrar(AlquilerEntity Ent)
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

       


        private bool RegistrarDB(AlquilerEntity Ent)
        {
            if (Ent.LogicalState == LogicalState.Added || Ent.LogicalState == LogicalState.Updated)
            {
                String storedName = "sp_Alquiler_Actualizar";
                if (Ent.LogicalState == LogicalState.Added) storedName = "sp_Alquiler_Registrar";
                DbDatabase.GetStoredProcCommand(storedName);
                DbDatabase.SetTransaction(Helper.DbTransaction);

                DbDatabase.AddParameter(MyUtils.GetOutputDirection(true), "AlquilerId", DbType.Int32, 4, false, 0, 0, Ent.AlquilerId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "EstadoProcesoId", DbType.Int32, 4, false, 0, 0, Ent.EstadoProcesoId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "TarifaId", DbType.Int32, 4, false, 0, 0, Ent.TarifaId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "ClienteId", DbType.Int32, 4, false, 0, 0, Ent.ClienteId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Cantidad", DbType.Decimal, 12, false, 0, 0, Ent.Cantidad);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Codigo", DbType.String, 40, false, 0, 0, Ent.Codigo);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "FechaInicio", DbType.DateTime, 8, false, 0, 0, Ent.FechaInicio);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "FechaTermino", DbType.DateTime, 8, false, 0, 0, Ent.FechaTermino);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "FechaCreacion", DbType.DateTime, 8, false, 0, 0, Ent.FechaCreacion);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "FechaModifica", DbType.DateTime, 8, false, 0, 0, Ent.FechaModifica);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "CodUsuario", DbType.String, 20, false, 0, 0, Ent.CodUsuario);
                int returnValue = DbDatabase.ExecuteNonQuery();
                if (Ent.LogicalState == LogicalState.Added)
                {
                    if (Ent.AlquilerId <= 0) Ent.AlquilerId = (Int32)DbDatabase.GetParameterValue("AlquilerId");
                    Ent.OnLogicalAdded();
                }
                else
                {
                    if (returnValue <= 0) throw new Exception("ErrorDB.UpdateEntity");
                    Ent.OnLogicalUpdate();
                }
            }

            if (Ent.Detalles != null && Ent.Detalles.Count > 0)
            {
                AlquilerDetalleDetalleDB AlquilerDetalleDetalleDB = new AlquilerDetalleDetalleDB();
                AlquilerDetalleDetalleDB.SetHelper(Helper);

                foreach (AlquilerDetalleEntity detalle in Ent.Detalles)
                {
                    if (Ent.LogicalState == LogicalState.Added)
                    {
                        if (detalle.LogicalState != LogicalState.Deleted) detalle.LogicalState = LogicalState.Added;
                    }
                    detalle.AlquilerId = Ent.AlquilerId;
                    AlquilerDetalleDetalleDB.Registrar(detalle);
                }

            }


            return true;
        }

        public virtual List<AlquilerEntity> ObtenerItem(Int32 AlquilerId)
        {
            try
            {
                StartHelper(false);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "AlquilerId", DbType.Int32, 4, false, 0, 0, AlquilerId);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_AlquilerObtener");
                FillSchemeTable(dr);
                List<AlquilerEntity> EntityList = new List<AlquilerEntity>();
                while (dr.Read())
                {
                    AlquilerEntity entity = new AlquilerEntity();
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
