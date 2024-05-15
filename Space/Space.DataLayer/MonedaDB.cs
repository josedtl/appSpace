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
    public class MonedaDB : BaseDataEntity
    {
        public virtual List<MonedaEntity> ObtenerMonedaItems()
        {
            try
            {
                StartHelper(false);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(System.Data.CommandType.StoredProcedure, "sp_MonedaObtenerItems");
                FillSchemeTable(dr);
                List<MonedaEntity> EntityList = new List<MonedaEntity>();

                while (dr.Read())
                {
                    MonedaEntity entity = new MonedaEntity();
                    if (FillFrom<MonedaEntity>(dr, entity)) EntityList.Add(entity);
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
        public virtual List<MonedaEntity> ObtenerMonedaItem(Int32 MonedaId)
        {
            try
            {
                StartHelper(false);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "MonedaId", DbType.Int32, 4, false, 0, 0, MonedaId);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_MonedaObtenerItem");
                FillSchemeTable(dr);
                List<MonedaEntity> EntityList = new List<MonedaEntity>();
                while (dr.Read())
                {
                    MonedaEntity entity = new MonedaEntity();
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
