using Framework;
using Space.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Space.Common;

namespace Space.DataLayer
{
    public class UnidadMedidaDB : BaseDataEntity
    {

        public virtual List<UnidadMedidadEntity> GetUnidadMedidaItems()
        {
            try
            {
                StartHelper(false);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_UnidadMedidaItems");
                FillSchemeTable(dr);
                List<UnidadMedidadEntity> EntityList = new List<UnidadMedidadEntity>();
                while (dr.Read())
                {
                    UnidadMedidadEntity entity = new UnidadMedidadEntity();
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

        public virtual List<UnidadMedidadEntity> GetUnidadMedida_Item(Int32 UnidadMedidaId)
        {
            try
            {
                StartHelper(false);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "UnidadMedidaId", DbType.Int32, 4, false, 0, 0, UnidadMedidaId);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_UnidadMedida_Item");
                FillSchemeTable(dr);
                List<UnidadMedidadEntity> EntityList = new List<UnidadMedidadEntity>();
                while (dr.Read())
                {
                    UnidadMedidadEntity entity = new UnidadMedidadEntity();
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
