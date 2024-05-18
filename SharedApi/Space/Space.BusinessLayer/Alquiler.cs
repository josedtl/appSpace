using Space.DataLayer;
using Space.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.BusinessLayer
{
    public class Alquiler
    {

        public static Int32 Registrar(AlquilerEntity Ent)
        {
            AlquilerDB DB = new AlquilerDB();
            DB.Registrar(Ent);
            return Ent.AlquilerId;
        }
    }
}
