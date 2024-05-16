using Framework;
using Space.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Data;
using Space.Common;

namespace Space.DataLayer
{
    public class UbigeoDB : BaseDataEntity
    {

        public virtual List<UbigeoEntity> GetUbigeoBuscarLike(String DesUbigeo)
        {
            try
            {
                StartHelper(false);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "DesUbigeo", DbType.String, 40, false, 0, 0, DesUbigeo);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_UbigeoBuscarLike");
                FillSchemeTable(dr);
                List<UbigeoEntity> EntityList = new List<UbigeoEntity>();
                while (dr.Read())
                {
                    UbigeoEntity entity = new UbigeoEntity();
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

        public virtual List<UbigeoEntity> GetUbigeoItem(Int32 UbigeoId)
        {
            try
            {
                StartHelper(false);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "UbigeoId", DbType.Int32, 4, false, 0, 0, UbigeoId);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_UbigeoItem");
                FillSchemeTable(dr);
                List<UbigeoEntity> EntityList = new List<UbigeoEntity>();
                while (dr.Read())
                {
                    UbigeoEntity entity = new UbigeoEntity();
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
