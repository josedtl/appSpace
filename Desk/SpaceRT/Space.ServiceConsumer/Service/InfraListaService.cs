using Newtonsoft.Json;
using System.Text;


namespace Space.ServiceConsumer.Service
{
    public class InfraListaService : BaseInvocador
    {
      
        public static async Task<List<InfraListaModel>> GetInFraLista_Codigo(String codigo)
        {
            try
            {
                String RoutePrefix = "api/InfraLista";
                InstanciaParametros();
                AddParametro(codigo);
                String Url = RemoteAddress(RoutePrefix, "GetInFraLista_Codigo");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                List<InfraListaModel> Items = JsonConvert.DeserializeObject<List<InfraListaModel>>(Content);
                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task<List<InfraListaMainModel>> GetInfraLista_Main(String codigo)
        {
            try
            {
                String RoutePrefix = "api/InfraLista";
                InstanciaParametros();
                AddParametro(codigo);
                String Url = RemoteAddress(RoutePrefix, "GetInfraLista_Main");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                List<InfraListaMainModel> Items = JsonConvert.DeserializeObject<List<InfraListaMainModel>>(Content);
                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal static Task<IEnumerable<object>> GetInfraLista_Main(object codigo)
        {
            throw new NotImplementedException();
        }

     
        public async static Task<InfraListaSaveModel> Save(InfraListaSaveModel Entity)
        {
            try
            {
                String RoutePrefix = "api/InfraLista";
                var Json = JsonConvert.SerializeObject(Entity);
                var context = new StringContent(Json, Encoding.UTF8, "application/json");
                String Url = RemoteAddress(RoutePrefix, "Registrar");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.PostAsync(Url, context);
                String Content = ValidarHttp(Data);
                InfraListaSaveModel Items = JsonConvert.DeserializeObject<InfraListaSaveModel>(Content);

                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async static Task<Boolean> Update(InfraListaSaveModel Entity)
        {
            try
            {
                String RoutePrefix = "api/InfraLista";
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
        public static async Task<List<InfraListaSaveModel>> GetInfraListaItem(Int32 ListaId)
        {
            try
            {
                String RoutePrefix = "api/InfraLista";
                InstanciaParametros();
                AddParametro(ListaId);
                String Url = RemoteAddress(RoutePrefix, "GetInfraListaItem");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                List<InfraListaSaveModel> Items = JsonConvert.DeserializeObject<List<InfraListaSaveModel>>(Content);
                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
