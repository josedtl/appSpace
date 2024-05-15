using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.EntityLayer
{
    public class UbigeoEntity : BaseEntityObject
    {

        public UbigeoEntity()
        {
            this.UbigeoId = GetInt32Default();
            this.CodUbigeo = GetStringDefault();
            this.DesUbigeo = GetStringDefault();
            this.CodDepartamento = GetStringDefault();
            this.CodProvincia = GetStringDefault();
            this.CodDistrito = GetStringDefault();
        }


        public Int32 UbigeoId { get; set; }
        public String CodUbigeo { get; set; }
        public String DesUbigeo { get; set; }
        public String CodDepartamento { get; set; }
        public String CodProvincia { get; set; }
        public String CodDistrito { get; set; }

    }
}
