using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.EntityLayer
{
    public class InfraCampoEntity : BaseEntityObject
    {
        public InfraCampoEntity()
        {
            this.CampoId = GetInt32Default();
            this.Codigo = GetStringDefault();
            this.Campo = GetStringDefault();
            this.Nombre = GetStringDefault();
            this.TypeValorId = GetInt32Default();
        }

        public Int32 CampoId { get; set; }
        public String Codigo { get; set; }
        public String Campo { get; set; }
        public String Nombre { get; set; }
        public Int32 TypeValorId { get; set; }


    }
}
