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
    public class ServicioDB : BaseDataEntity
    {
        public virtual List<ServicioEntity> ObtenerMain()
        {
            try
            {
                StartHelper(false);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(System.Data.CommandType.StoredProcedure, "sp_ServicioObtenerMain");
                FillSchemeTable(dr);
                List<ServicioEntity> EntityList = new List<ServicioEntity>();

                while (dr.Read())
                {
                    ServicioEntity entity = new ServicioEntity();
                    if (FillFrom<ServicioEntity>(dr, entity)) EntityList.Add(entity);
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

        public virtual bool Registrar(ServicioEntity Ent)
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

        private bool RegistrarDB(ServicioEntity Ent)
        {
            if (Ent.LogicalState == LogicalState.Added || Ent.LogicalState == LogicalState.Updated)
            {
                String storedName = "sp_ServicioActualizar";
                if (Ent.LogicalState == LogicalState.Added) storedName = "sp_ServicioRegistrar";
                DbDatabase.GetStoredProcCommand(storedName);
                DbDatabase.SetTransaction(Helper.DbTransaction);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(true),"ServicioId", DbType.Int32, 4, false, 0, 0, Ent.ServicioId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(true),"Nombre", DbType.String, 50, false, 0, 0, Ent.Nombre);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(true),"Descripcion", DbType.String, 100, false, 0, 0, Ent.Descripcion);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(true),"TipoServicioId", DbType.Int32, 4, false, 0, 0, Ent.TipoServicioId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(true),"FechaRegistro", DbType.DateTime, 12, false, 0, 0, Ent.FechaRegistro);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(true),"CodUsuario", DbType.String, 20, false, 0, 0, Ent.CodUsuario);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(true), "EstadoRegistro", DbType.Boolean, 3, false, 0, 0, Ent.EstadoRegistro);

                int returnValue = DbDatabase.ExecuteNonQuery();
                if (Ent.LogicalState == LogicalState.Added)
                {
                    if (Ent.ServicioId <= 0) Ent.ServicioId = (Int32)DbDatabase.GetParameterValue("ServicioId");
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

      
        public virtual List<ServicioEntity> ObtenerItem(Int32 ServicioId)
        {
            try
            {
                StartHelper(false);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "ServicioId", DbType.Int32, 4, false, 0, 0, ServicioId);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_ServicioObtenerItem");
                FillSchemeTable(dr);
                List<ServicioEntity> EntityList = new List<ServicioEntity>();
                while (dr.Read())
                {
                    ServicioEntity entity = new ServicioEntity();
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
