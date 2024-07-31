using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDesk.Model
{
    public class PersonaNaturalMainModel
    {
        public int Item { get; set; }
        public int PersonaNaturaId { get; set; }
        public String TipoDocumento { get; set; }
        public String NumDocumento { get; set; }
        public String Nombres { get; set; }
        public String ApellidoPaterno { get; set; }
        public String ApellidoMaterno { get; set; }
        public DateTime FechaRegistro { get; set; }
        public String CodUsuario { get; set; }
    }
}

