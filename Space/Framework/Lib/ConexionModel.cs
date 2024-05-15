using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Lib
{
    public class ConexionModel
    {

        public ConnectionStringsModel ConnectionStrings { get; set; }
    }

    public class ConnectionStringsModel
    {
        public String Server { get; set; }
        public String Database { get; set; }
        public String User { get; set; }
        public String Pwd { get; set; }
        public String Puerto { get; set; }

    }

}
