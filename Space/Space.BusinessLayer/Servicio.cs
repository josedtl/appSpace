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
    public class Servicio
    {
        public List<ServicioEntity> ObtenerMain()
        {
            ServicioDB DB = new ServicioDB();
            return DB.ObtenerMain();
        }
        public Int32 Registrar(ServicioEntity Ent)
        {
            ServicioDB DB = new ServicioDB();
            DB.Registrar(Ent);
            return Ent.ServicioId;
        }
      
        public List<ServicioEntity> ObtenerItem(Int32 ServicioId)
        {
            ServicioDB DB = new ServicioDB();
            return DB.ObtenerItem(ServicioId);
        }

    }
}
