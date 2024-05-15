using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.EntityLayer
{
    public partial class InfraListaEntity : BaseEntityObject
    {
        public InfraListaEntity()
        {
            ListaId = 0;
            CampoId = 0;
            Codigo = String.Empty;
            Nombre = String.Empty;
            Descripcion = String.Empty;
            FechaRegistro =DateTime.Now;
            CodUsuario = String.Empty;
            EstadoRegistro = false;
        }
        public Int32 ListaId { get; set; }
        public Int32 CampoId { get; set; }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public String CodUsuario { get; set; }
        public Boolean EstadoRegistro { get; set; }
    }
}
