using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.ServiceConsumer
{
    public class UnidadMedidaModel
    {
        public UnidadMedidaModel()
        {

            UnidadMedidaId = 0;
            Codigo = String.Empty;
            CodigoComercial = String.Empty;
            Nombre = String.Empty;
            FechaRegistro = DateTime.Now;
            CodUsuario = String.Empty;
            EstadoRegistro = true;

        }
        public Int32 UnidadMedidaId { get; set; }
        public String Codigo { get; set; }
        public String CodigoComercial { get; set; }
        public String Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }
        public String CodUsuario { get; set; }
        public Boolean EstadoRegistro { get; set; }
    }
}
