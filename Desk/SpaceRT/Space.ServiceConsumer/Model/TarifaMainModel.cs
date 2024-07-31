using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.ServiceConsumer
{
    public class TarifaMainModel
    {
        public int Item { get; set; }
        public Int32 TarifaId { get; set; }
        public String Correlativo { get; set; }
        public String NomTarifa { get; set; }
        public String NomComercial { get; set; }
        public String Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public String CodUsuario { get; set; }
        public Boolean EstadoRegistro { get; set; }
        public String CodigoUnidad { get; set; }
        public String SimboloMoneda { get; set; }
        public Int16 TipoTarifaEnum { get; set; }
        public decimal CostoTarifa { get; set; }
    }
}
