using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Space.EntityLayer 
{
    public class EntListaEntity : Utilitario
    {
        public EntListaEntity()
        {
            this.ListaId = GetInt32Default();
            this.EntCampoId = GetInt32Default();
            this.Codigo = GetStringDefault();
            this.Nombre = GetStringDefault();
            this.Descripcion = GetStringDefault();
            this.FechaRegistro = GetDateTimeDefault();
            this.CodUsuario = GetStringDefault();
            this.EstadoRegistro = GetBooleanDefault();
        }
        public Int32 ListaId { get; set; }

        public Int32 EntCampoId { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public String CodUsuario { get; set; }
        public Boolean EstadoRegistro { get; set; }

    }
}
