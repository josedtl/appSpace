using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.ServiceConsumer
{
    public class ServicioMainModel
    {
        public int Item { get; set; }
        public Int32 ServicioId { get; set; }
        public String Correlativo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public String TipoServicio { get; set; }
        public DateTime FechaRegistro { get; set; }
        public String CodUsuario { get; set; }
        public Boolean EstadoRegistro { get; set; }
    }
}
