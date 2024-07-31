using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.ServiceConsumer
{
    public class InfraestructuraSaveModel
    {

        public Int32 InfraestructuraId { get; set; }
        public Int32 SucursalId { get; set; }
        public Int16 Estado { get; set; }
        public String CodigoSistema { get; set; }
        public String CodigoInterno { get; set; }
        public String Descripcion { get; set; }
        public Int32 TipoInfraestructuraId { get; set; }
        public Int32 ClasificacionId { get; set; }
        public Int32 InfraestructuraDimensionId { get; set; }
        public Int32 Aforo { get; set; }
        public Int32 PisoId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public String CodUsuario { get; set; }
        public Boolean EstadoRegistro { get; set; } = true;
    }
}
