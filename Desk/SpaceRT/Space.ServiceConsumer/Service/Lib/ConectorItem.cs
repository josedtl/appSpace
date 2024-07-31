using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.ServiceConsumer.Service
{
    public class ConectorItem
    {

        private static String m_CodSistema = String.Empty;
        private static String m_NombreConexion = String.Empty;
        private static String m_ServidorLocal = String.Empty;
        private static String m_ServiceConfig = String.Empty;
        private static String m_Token = String.Empty;

        public static String CodSistema
        {
            get { return m_CodSistema; }
            set { m_CodSistema = value; }
        }
        public static String NombreConexion
        {
            get { return m_NombreConexion; }
            set { m_NombreConexion = value; }
        }
        public static String Servidor
        {
            get { return m_ServidorLocal; }
            set { m_ServidorLocal = value; }
        }

        public static String Token
        {
            get { return m_Token; }
            set { m_Token = value; }
        }

        public static String ServiceConfig
        {
            get { return m_ServiceConfig; }
            set { m_ServiceConfig = value; }
        }

    }
}
