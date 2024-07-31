using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDesk.Model
{
    public class InfraestructuraMainModel
    {
        public int Item { get; set; }
        public Int32 InfraestructuraId { get; set; }
        public String Sucursal { get; set; }
        public String CodigoSistema { get; set; }
        public String CodigoInterno { get; set; }
        public String Descripcion { get; set; }
        public String TipoInfraestructura { get; set; }
        public String InfraestructuraDimension { get; set; }
        public Int32 Aforo { get; set; }
        public String Piso { get; set; }
        public DateTime FechaRegistro { get; set; }
        public String CodUsuario { get; set; }
        public Boolean EstadoRegistro { get; set; }
    }
}
