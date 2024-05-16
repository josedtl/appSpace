using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.EntityLayer
{
    public class EntidadEntity : BaseEntityObject
    {
        public EntidadEntity()
        {
            this.EntidadId = GetInt32Default();
            this.NombreCompleto = GetStringDefault();

        }

        public Int32 EntidadId { get; set; }
        public String NombreCompleto { get; set; }


    }
}
