using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.EntityLayer
{
    public partial class ServicioEntity : Utilitario
    {
        public ServicioEntity()
        {
            ServicioId = GetInt32Default();
            Estado = GetInt16Default();
            Correlativo = GetStringDefault();
            Nombre = GetStringDefault();
            Descripcion = GetStringDefault();
            TipoServicioId = GetInt32Default();
            FechaRegistro = DateTime.Now;
            CodUsuario = GetStringDefault();
            EstadoRegistro = GetBooleanDefault();
        }

        public Int32 ServicioId { get; set; }
        public Int16 Estado { get; set; }
        public String Correlativo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public Int32 TipoServicioId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public String CodUsuario { get; set; }
        public Boolean EstadoRegistro { get; set; }
    }
}
