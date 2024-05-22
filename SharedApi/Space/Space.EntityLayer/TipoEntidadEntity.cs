using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.EntityLayer
{
    public partial class TipoEntidadEntity : BaseEntityObject
    {
        public TipoEntidadEntity()
        {
            TipoEntidadId = GetInt32Default();
            Codigo = GetStringDefault();
            Nombre = GetStringDefault();
        }

        public Int32 TipoEntidadId { get; set; }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
    }
}
