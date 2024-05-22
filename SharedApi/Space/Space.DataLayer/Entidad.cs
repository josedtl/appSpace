using Framework;
using Framework.Data;
using Space.Common;
using Space.EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace Space.DataLayer
{
    public class EntidadDB : BaseDataEntity
    {

   

        public virtual List<EntidadEntity> GetEntidadBuscarItem(String NombreCompleto)
        {
            try
            {
                StartHelper(false);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "NombreCompleto", DbType.String, 50, false, 0, 0, NombreCompleto);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_EntidadBuscarItem");
                FillSchemeTable(dr);
                List<EntidadEntity> EntityList = new List<EntidadEntity>();
                while (dr.Read())
                {
                    EntidadEntity entity = new EntidadEntity();
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

        public virtual List<EntidadEntity> GetEntidadMain()
        {
            try
            {
                StartHelper(false);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "up_Entidad_SelectAll");
                FillSchemeTable(dr);
                List<EntidadEntity> EntityList = new List<EntidadEntity>();
                while (dr.Read())
                {
                    EntidadEntity entity = new EntidadEntity();
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
