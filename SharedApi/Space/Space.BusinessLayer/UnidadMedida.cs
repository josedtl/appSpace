using Space.DataLayer;
using Space.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.BusinessLayer
{
    public class UnidadMedida
    {
        public static List<UnidadMedidadEntity> GetUnidadMedidaItems()
        {
            UnidadMedidaDB DB = new UnidadMedidaDB();
            return DB.GetUnidadMedidaItems();
        }

        public static List<UnidadMedidadEntity> GetUnidadMedida_Item(Int32 UnidadMedidaId)
        {
            UnidadMedidaDB DB = new UnidadMedidaDB();
            return DB.GetUnidadMedida_Item(UnidadMedidaId);
        }
    }
}
