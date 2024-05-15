
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.EntityLayer
{
    public class MonedaEntity: BaseEntityObject
    {
        public MonedaEntity()
        {

            MonedaId = GetInt32Default();
            Codigo = GetStringDefault();
            CodigoInterno = GetStringDefault();
            Simbolo = GetStringDefault();
            Nombre = GetStringDefault();
            EstadoRegistro = true;

        }
        public Int32 MonedaId { get; set; }
        public String Codigo { get; set; }
        public String CodigoInterno { get; set; }
        public String Simbolo { get; set; }
        public String Nombre { get; set; }
        public Boolean EstadoRegistro { get; set; }
    }
}
