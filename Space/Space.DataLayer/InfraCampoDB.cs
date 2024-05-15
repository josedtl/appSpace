using Framework;
using Framework.Data;
using Space.Common;
using Space.EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace Space.DataLayer
{
    public class InfraCampoDB : BaseDataEntity
    {

   

        public virtual List<InfraCampoEntity> ObtenerTitulo(String codigo)
        {
            try
            {
                StartHelper(false);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Codigo", DbType.String, 20, false, 0, 0, codigo);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_InfraCampoObtenerTitulo");
                FillSchemeTable(dr);
                List<InfraCampoEntity> EntityList = new List<InfraCampoEntity>();
                while (dr.Read())
                {
                    InfraCampoEntity entity = new InfraCampoEntity();
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
