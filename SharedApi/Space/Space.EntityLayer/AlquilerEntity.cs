using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.EntityLayer
{
    public class AlquilerEntity : BaseEntityObject
    {
        public AlquilerEntity()
        {

            this.AlquilerId = 0;
            this.EstadoProcesoId = 0;
            this.TarifaId = 0;
            this.ClienteId = 0;
            this.Cantidad = 0m;
            this.Codigo = String.Empty;
            this.FechaInicio = DateTime.MinValue;
            this.FechaTermino = DateTime.MinValue;
            this.FechaCreacion = DateTime.MinValue;
            this.FechaModifica = DateTime.MinValue;
            this.CodUsuario = String.Empty;
            this.Detalles = new List<AlquilerDetalleEntity>();
        }

        public Int32 AlquilerId { get; set; }
        public Int32 EstadoProcesoId { get; set; }
        public Int32 TarifaId { get; set; }
        public Int32 ClienteId { get; set; }
        public Decimal Cantidad { get; set; }
        public String Codigo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModifica { get; set; }
        public String CodUsuario { get; set; }

        public List<AlquilerDetalleEntity> Detalles { get; set; }


    }
}
