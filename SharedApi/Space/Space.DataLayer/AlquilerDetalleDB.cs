using Framework;
using Space.Common;
using Space.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.DataLayer
{
    public class AlquilerDetalleDetalleDB : BaseDataEntity
    {


        public virtual bool Registrar(AlquilerDetalleEntity Ent)
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

    

        private bool RegistrarDB(AlquilerDetalleEntity Ent)
        {
            if (Ent.LogicalState == LogicalState.Added || Ent.LogicalState == LogicalState.Updated)
            {
                String storedName = "sp_AlquilerDetalle_Actualizar";
                if (Ent.LogicalState == LogicalState.Added) storedName = "sp_AlquilerDetalle_Registrar";
                DbDatabase.GetStoredProcCommand(storedName);
                DbDatabase.SetTransaction(Helper.DbTransaction);

                DbDatabase.AddParameter(MyUtils.GetOutputDirection(true), "AlquilerDetalleId", DbType.Int32, 4, false, 0, 0, Ent.AlquilerDetalleId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "AlquilerId", DbType.Int32, 4, false, 0, 0, Ent.AlquilerId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "TarifaId", DbType.Int32, 4, false, 0, 0, Ent.TarifaId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Cantidad", DbType.Decimal, 12, false, 0, 0, Ent.Cantidad);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "FechaRegistro", DbType.DateTime, 8, false, 0, 0, Ent.FechaRegistro);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "CodUsuario", DbType.String, 20, false, 0, 0, Ent.CodUsuario);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "EstadoAdministrativoId", DbType.Int32, 4, false, 0, 0, Ent.EstadoAdministrativoId);
                int returnValue = DbDatabase.ExecuteNonQuery();
                if (Ent.LogicalState == LogicalState.Added)
                {
                    if (Ent.AlquilerDetalleId <= 0) Ent.AlquilerDetalleId = (Int32)DbDatabase.GetParameterValue("AlquilerDetalleId");
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

        private bool DeleteDB(AlquilerDetalleEntity Ent)
        {
            if (Ent.AlquilerDetalleId == 0) return true;
            int returnValue = 0;
            try
            {
                if (m_Helper.IsTransactional)
                {
                    DbDatabase.GetStoredProcCommand("up_ServicioActividad_DeleteByKey");
                    DbDatabase.SetTransaction(Helper.DbTransaction);
                    DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "AlquilerDetalleId", DbType.Int32, 4, false, 0, 0, Ent.AlquilerDetalleId);
                    returnValue = DbDatabase.ExecuteNonQuery();
                }
                else
                {
                    returnValue = DbDatabase.ExecuteNonQuery("up_ServicioActividad_DeleteByKey", Ent.AlquilerDetalleId);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (returnValue < 0) throw new Exception("ErrorDB.DeleteEntity");
            return true;
        }

    }
}
