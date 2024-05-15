using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.EntityLayer
{
    public partial class EmpresaEntity : Utilitario
    {

        public EmpresaEntity()
        {
            EmpresaId = GetInt32Default();
            TipoDocumentoIdentidadId = GetInt32Default();
            NumDocumento = GetStringDefault();
            RazonSocial = GetStringDefault();
            NombreComercial = GetStringDefault();
            Direccion = GetStringDefault();
            Telefono = GetStringDefault();
            Correo = GetStringDefault();
            UbigeoId = GetInt32Default();
            FechaRegistro = DateTime.Now;
            CodUsuario = GetStringDefault();
        }

        public Int32 EmpresaId { get; set; }
        public Int32 TipoDocumentoIdentidadId { get; set; }
        public String NumDocumento { get; set; }
        public String RazonSocial { get; set; }
        public String NombreComercial { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Correo { get; set; }
        public Int32 UbigeoId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public String CodUsuario { get; set; }

    }
}
