using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.EntityLayer
{
    public partial class UnidadMedidadEntity : BaseEntityObject
    {
        public UnidadMedidadEntity()
        {
            UnidadMedidaId = GetInt32Default();
            Codigo = GetStringDefault();
            CodigoComercial = GetStringDefault();
            Nombre = GetStringDefault();
            FechaRegistro = GetDateTimeDefault();
            CodUsuario = GetStringDefault();
            EstadoRegistro = GetBooleanDefault();
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
