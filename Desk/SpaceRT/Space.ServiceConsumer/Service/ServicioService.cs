
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Space.ServiceConsumer.Service
{
    public class ServicioService : BaseInvocador
    {
        public static async Task<List<ServicioMainModel>> GetServicioMain()
        {
            try
            {
                String RoutePrefix = "api/Servicio";
                InstanciaParametros();
                String Url = RemoteAddress(RoutePrefix, "GetServicioMain");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                List<ServicioMainModel> Items = JsonConvert.DeserializeObject<List<ServicioMainModel>>(Content);
                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async static Task<Boolean> Save(ServicioSaveModel Entity)
        {
            try
            {
                String RoutePrefix = "api/Servicio";
                var Json = JsonConvert.SerializeObject(Entity);
                var context = new StringContent(Json, Encoding.UTF8, "application/json");
                String Url = RemoteAddress(RoutePrefix, "Registrar");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.PostAsync(Url, context);
                String Content = ValidarHttp(Data);
                Boolean Items = JsonConvert.DeserializeObject<Boolean>(Content);
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async static Task<Boolean> Update(ServicioSaveModel Entity)
        {
            try
            {
                String RoutePrefix = "api/Servicio";
                var Json = JsonConvert.SerializeObject(Entity);
                var context = new StringContent(Json, Encoding.UTF8, "application/json");
                String Url = RemoteAddress(RoutePrefix, "Actualizar");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.PostAsync(Url, context);
                String Content = ValidarHttp(Data);
                Boolean Items = JsonConvert.DeserializeObject<Boolean>(Content);
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task<List<ServicioSaveModel>> GetServicio_Item(Int32 ServicioId)
        {
            try
            {
                String RoutePrefix = "api/Servicio";
                InstanciaParametros();
                AddParametro(ServicioId);
                String Url = RemoteAddress(RoutePrefix, "GetServicio_Item");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                List<ServicioSaveModel> Items = JsonConvert.DeserializeObject<List<ServicioSaveModel>>(Content);

                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
