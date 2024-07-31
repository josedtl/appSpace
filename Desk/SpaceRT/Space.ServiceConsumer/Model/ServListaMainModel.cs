using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.ServiceConsumer
{
    public class ServListaMainModel
    {
        public ServListaMainModel()
        {

            ListaId = 0;
            CampoId = 0;
            Codigo = String.Empty;
            Nombre = String.Empty;
            Descripcion = String.Empty;
            FechaRegistro = DateTime.Now;
            CodUsuario = String.Empty;
            EstadoRegistro = true;
        }
        public int Item { get; set; }
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
