using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.ServiceConsumer
{
    public class PersonaNaturalSaveModel
    {
        public Int32 PersonaNaturalId { get; set; }
        public Int32 TipoDocumentoIdentidadId { get; set; }
        public String NumDocumento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public String CodUsuario { get; set; }
        public Int32 UbigeoId { get; set; }
        public String Nombres { get; set; }
        public String ApellidoPaterno { get; set; }
        public String ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Correo { get; set; }
        public Int32 SexoId { get; set; }
        public Int32 EstadoCivilId { get; set; }
    }
}
