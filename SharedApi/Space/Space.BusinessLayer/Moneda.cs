using Space.DataLayer;
using Space.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.BusinessLayer
{
    public class Moneda
    {
        public static List<MonedaEntity> ObtenerMonedaItems()
        {
            MonedaDB DB = new MonedaDB();
            return DB.ObtenerMonedaItems();
        }

        public static List<MonedaEntity> ObtenerMonedaItem(Int32 MonedaId)
        {
            MonedaDB DB = new MonedaDB();
            return DB.ObtenerMonedaItem(MonedaId);
        }

    }
}
