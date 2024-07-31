using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.ServiceConsumer
{
    public class MonedaModel
    {
        public MonedaModel()
        {
            MonedaId = 0;
            Codigo = String.Empty;
            CodigoInterno = String.Empty;
            Simbolo = String.Empty;
            Nombre = String.Empty;
        }
        public Int32 MonedaId { get; set; }
        public String Codigo { get; set; }
        public String CodigoInterno { get; set; }
        public String Simbolo { get; set; }
        public String Nombre { get; set; }

    }
}
