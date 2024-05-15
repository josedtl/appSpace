using Space.DataLayer;
using Space.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.BusinessLayer
{
    public class InfraCampo
    {
        public static List<InfraCampoEntity> ObtenerTitulo(String codigo)
        {
            InfraCampoDB DB = new InfraCampoDB();
            return DB.ObtenerTitulo(codigo);
        }

    }
}
