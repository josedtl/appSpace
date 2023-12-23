using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.EntityLayer
{
    public class EntCampoTypeEntity : Utilitario
    {


        public EntCampoTypeEntity()
        {
            this.EntCampoId = GetInt32Default();
            this.Campo = GetStringDefault();
            this.Type = GetStringDefault();
        }

        public Int32 EntCampoId { get; set; }
        public String Campo { get; set; }
        public String Type { get; set; }
    }
}
