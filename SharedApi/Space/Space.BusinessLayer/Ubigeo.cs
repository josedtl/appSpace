using Space.DataLayer;
using Space.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.BusinessLayer
{
    public class Ubigeo
    {
        public static List<UbigeoEntity> GetUbigeoBuscarLike(String DesUbigeo)
        {
            UbigeoDB DB = new UbigeoDB();
            return DB.GetUbigeoBuscarLike(DesUbigeo);
        }
        public static List<UbigeoEntity> GetUbigeoItem(Int32 UbigeoId)
        {
            UbigeoDB DB = new UbigeoDB();
            return DB.GetUbigeoItem(UbigeoId);
        }
    }
}
