using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.EntityLayer
{
    public partial class InfraestructuraEntity : BaseEntityObject
    {
        public InfraestructuraEntity()
        {
            InfraestructuraId = 0;
            EstadoAdministrativoId = 0;
            SucursalId = 0;
            CodigoSistema = String.Empty;
            CodigoInterno = String.Empty;
            Descripcion = String.Empty;
            TipoInfraestructuraId = 0;
            ClasificacionId = 0;
            InfraestructuraDimensionId = 0;
            Aforo = 0;
            PisoId = 0;
            FechaRegistro = DateTime.Now;
            CodUsuario = String.Empty;
            EstadoRegistro = false;
        }
        public Int32 InfraestructuraId { get; set; }
        public Int32 EstadoAdministrativoId { get; set; }
        public Int32 SucursalId { get; set; }
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
        public Boolean EstadoRegistro { get; set; }
    }
}
