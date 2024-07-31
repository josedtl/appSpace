using ClientDesk.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClientDesk.Service
{
    public class ServListaService : BaseInvocador
    {
        public static async Task<List<ServListaModel>> GetServLista_Codigo(String codigo)
        {
            try
            {
                String RoutePrefix = "api/ServLista";
                InstanciaParametros();
                AddParametro(codigo);
                String Url = RemoteAddress(RoutePrefix, "GetServLista_Codigo");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                List<ServListaModel> Items = JsonConvert.DeserializeObject<List<ServListaModel>>(Content);
                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static async Task<List<ServListaMainModel>> GetServLista_Main(String codigo)
        {
            try
            {
                String RoutePrefix = "api/ServLista";
                InstanciaParametros();
                AddParametro(codigo);
                String Url = RemoteAddress(RoutePrefix, "GetServLista_Main");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                List<ServListaMainModel> Items = JsonConvert.DeserializeObject<List<ServListaMainModel>>(Content);
                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        internal static Task<IEnumerable<object>> GetServLista_Main(object codigo)
        {
            throw new NotImplementedException();
        }

        public async static Task<ServListaSaveModel> Save(ServListaSaveModel Entity)
        {
            try
            {
                String RoutePrefix = "api/ServLista";
                var Json = JsonConvert.SerializeObject(Entity);
                var context = new StringContent(Json, Encoding.UTF8, "application/json");
                String Url = RemoteAddress(RoutePrefix, "Registrar");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.PostAsync(Url, context);
                String Content = ValidarHttp(Data);
                ServListaSaveModel Items = JsonConvert.DeserializeObject<ServListaSaveModel>(Content);

                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public async static Task<Boolean> Update(ServListaSaveModel Entity)
        {
            try
            {
                String RoutePrefix = "api/ServLista";
                var Json = JsonConvert.SerializeObject(Entity);
                var context = new StringContent(Json, Encoding.UTF8, "application/json");
                String Url = RemoteAddress(RoutePrefix, "Actualizar");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.PostAsync(Url, context);
                String Content = ValidarHttp(Data);
                Boolean Items = JsonConvert.DeserializeObject<Boolean>(Content);

                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static async Task<List<ServListaSaveModel>> GetServListaItem(Int32 ListaId)
        {
            try
            {
                String RoutePrefix = "api/ServLista";
                InstanciaParametros();
                AddParametro(ListaId);
                String Url = RemoteAddress(RoutePrefix, "GetServListaItem");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                List<ServListaSaveModel> Items = JsonConvert.DeserializeObject<List<ServListaSaveModel>>(Content);
                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
