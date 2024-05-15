using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.EntityLayer
{
    public partial class ServListaEntity : Utilitario
    {

        public ServListaEntity()
        {
            ListaId = GetInt32Default();
            CampoId = GetInt32Default();
            Codigo = GetStringDefault();
            Nombre = GetStringDefault();
            Descripcion = GetStringDefault();
            FechaRegistro = GetDateTimeDefault();
            CodUsuario = GetStringDefault();
            EstadoRegistro = GetBooleanDefault();
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
