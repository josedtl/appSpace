using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.EntityLayer
{
    public partial class EntidadEntity : BaseEntityObject
    {
        public EntidadEntity()
        {
            this.EntidadId = GetInt32Default();
            this.NombreCompleto = GetStringDefault();
            this.TipoEntidadId = GetInt32Default();
        }
        public int EntidadId { get; set; }
        public int TipoEntidadId { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int SexoId { get; set; }
        public int EstadoCivilId { get; set; }
        public string RazonSocial { get; set; }
        public string PagWeb { get; set; }
        public int TipoDocumentoIdentidadId { get; set; }
        public string NumDocumento { get; set; }
        public int UbigeoId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodUsuario { get; set; }
        public string NombreCompleto    {get; set;}

    }
}
