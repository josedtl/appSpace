using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.EntityLayer
{
    public class EntDatoEntity : Utilitario
    {


        public EntDatoEntity()
        {
            this.EntDatoId = GetInt32Default();
            this.EntidadId = GetInt32Default();
            this.ValorAlfaNumerico = GetStringDefault();
            this.ValorFecha = GetDateTimeDefault();
            this.ListaRelacionId = GetInt32Default();
            this.EntCampoId = GetInt32Default();

        }

        public Int32 EntDatoId { get; set; }
        public Int32 EntidadId { get; set; }
        public String? ValorAlfaNumerico { get; set; }
        public DateTime? ValorFecha { get; set; }
        public Int32? ListaRelacionId { get; set; }
        public Int32 EntCampoId { get; set; }
    }
}
