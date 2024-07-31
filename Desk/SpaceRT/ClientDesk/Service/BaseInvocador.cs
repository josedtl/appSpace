using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClientDesk.Service
{
    public class BaseInvocador
    {
        private static String remoteAddress = String.Empty;


        public static String RemoteAddress(String RoutePrefix, String NameControlador)
        {

            ConectorItem.Servidor = "localhost";
            ConectorItem.ServiceConfig = "ServiceSpace";

            remoteAddress = String.Format("http://{0}/{1}/{2}/{3}", ConectorItem.Servidor, ConectorItem.ServiceConfig, RoutePrefix, NameControlador);

            return remoteAddress;
        }
        public static String GetUrl(String Url)
        {
            return Url;
        }
        public static String GetUrlParametros(String Url)
        {
            String Url_Parametros = String.Format("{0}/{1}", Url, GetParametros());

            return Url_Parametros;
        }



        public static void InstanciaParametros()
        {

            m_ListParametros = null;
            m_ListParametros = new List<String>();

        }


        public static void AddParametro(Object Item)
        {

            m_ListParametros.Add(Convert.ToString(Item));

        }

        private static List<String> m_ListParametros = new List<String>();


        public static String GetParametros()
        {
            String cadena = String.Empty;

            for (int o = 0; o < m_ListParametros.Count; o++)
            {
                cadena += Convert.ToString(m_ListParametros[o]);
                if (m_ListParametros.Count != o) cadena += "/";

            }
            //cadena = cadena.TrimEnd(Separador);
            return cadena;
        }

        public static String GetToken()
        {

            return "Bearer " + ConectorItem.Token;
        }

        public static String ValidarHttp(HttpResponseMessage Data)
        {
            String Content = String.Empty;

            if (Data.StatusCode == HttpStatusCode.NotFound)
            {
                throw new Exception(Data.Content.ReadAsStringAsync().Result.ToString());
            }
            if (Data.StatusCode == HttpStatusCode.OK)
            {
                Content = Data.Content.ReadAsStringAsync().Result.ToString();
            }

            return Content;
        }



    }
}

