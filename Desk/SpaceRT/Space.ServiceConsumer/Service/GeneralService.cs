using Space.ServiceConsumer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Space.ServiceConsumer.Service
{
    public class GeneralService :BaseInvocador
    {
        public static async Task<List<ListaRelacionModel>> GetListaRelacion(String codigo)
        {
            try
            {
                String RoutePrefix = "api/ListaRelacion";
                InstanciaParametros();
                AddParametro(codigo);
                String Url = RemoteAddress(RoutePrefix, "ObtenerCodigo");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
          
                var ResponseItem = JsonConvert.DeserializeObject<ResponseAPI<List<ListaRelacionModel>>>(Content);
                return ResponseItem.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task<List<InfraListaModel>> GetInFraLista_Codigo(String codigo)
        {
            try
            {
                String RoutePrefix = "api/InfraLista";
                InstanciaParametros();
                AddParametro(codigo);
                String Url = RemoteAddress(RoutePrefix, "ObtenerCodigo");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                var ResponseItem = JsonConvert.DeserializeObject<ResponseAPI<List<InfraListaModel>>>(Content);
                return ResponseItem.Value;             }
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
                String Url = RemoteAddress(RoutePrefix, "ObtenerMain");
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

  

        public static async Task<List<InfraListaSaveModel>> GetInfraListaItem(Int32 ListaId)
        {
            try
            {
                String RoutePrefix = "api/Infraestructura";
                InstanciaParametros();
                AddParametro(ListaId);
                String Url = RemoteAddress(RoutePrefix, "GetInfraestructuraItem");
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

        public static async Task<List<InfraCampoTituloModel>> GetInfraCampoTitulo(String codigo)
        {
            try
            {
                String RoutePrefix = "api/General";
                InstanciaParametros();
                AddParametro(codigo);
                String Url = RemoteAddress(RoutePrefix, "GetInfraCampoTitulo");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                List<InfraCampoTituloModel> Items = JsonConvert.DeserializeObject<List<InfraCampoTituloModel>>(Content);
                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //MONEDA

        public static async Task<List<MonedaModel>> GetMonedaItems()
        {
            try
            {
                String RoutePrefix = "api/General";
                InstanciaParametros();
                String Url = RemoteAddress(RoutePrefix, "GetMonedaItems");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                List<MonedaModel> Items = JsonConvert.DeserializeObject<List<MonedaModel>>(Content);
                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task<List<MonedaModel>> GetMoneda_Item( Int32 MonedaId)
        {
            try
            {
                String RoutePrefix = "api/General";
                InstanciaParametros();
                AddParametro(MonedaId);
                String Url = RemoteAddress(RoutePrefix, "GetMoneda_Item");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                List<MonedaModel> Items = JsonConvert.DeserializeObject<List<MonedaModel>>(Content);
                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //UNIDAD MEDIDA

        public static async Task<List<UnidadMedidaModel>> GetUnidadMedidaItems()
        {
            try
            {
                String RoutePrefix = "api/General";
                InstanciaParametros();
                String Url = RemoteAddress(RoutePrefix, "GetUnidadMedidaItems");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                List<UnidadMedidaModel> Items = JsonConvert.DeserializeObject<List<UnidadMedidaModel>>(Content);
                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static async Task<List<UnidadMedidaModel>> GetUnidadMedida_Item(Int32 UnidadMedidaId)
        {
            try
            {
                String RoutePrefix = "api/General";
                InstanciaParametros();
                AddParametro(UnidadMedidaId);
                String Url = RemoteAddress(RoutePrefix, "GetUnidadMedida_Item");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                List<UnidadMedidaModel> Items = JsonConvert.DeserializeObject<List<UnidadMedidaModel>>(Content);
                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
