using Framework;
using Space.DataLayer;
using Space.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.BusinessLayer
{
    public class Entidad
    {

        public static List<EntidadEntity> GetEntidadBuscarItem(String NombreCompleto)
        {
            EntidadDB DB = new EntidadDB();
            return DB.GetEntidadBuscarItem(NombreCompleto);
        }
        public virtual List<EntidadEntity> GetEntidadMain() {
            EntidadDB DB = new EntidadDB();
            return DB.GetEntidadMain();
        }



    }
}
