using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.EntityLayer
{
    public class AlquilerDetalleEntity : BaseEntityObject
    {
        public AlquilerDetalleEntity() { 
        
        
            this.AlquilerDetalleId = 0;
            this.AlquilerId = 0;
            this.TarifaId = 0;  
            this.Cantidad = 0;
            this.FechaRegistro=DateTime.Now;
            this.CodUsuario =String.Empty;
            this.EstadoAdministrativoId = 0;
        }

        public Int32 AlquilerDetalleId { get; set; }
        public Int32 AlquilerId { get; set; }
        public Int32 TarifaId { get; set; }
        public Decimal Cantidad { get; set; }
        public DateTime FechaRegistro { get; set; }
        public String CodUsuario { get; set; }
        public Int32 EstadoAdministrativoId { get; set; }
    }
}
