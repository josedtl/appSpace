using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.ServiceConsumer.Service
{
    public class TarifaService : BaseInvocador
    {
        public static async Task<List<TarifaMainModel>> GetTarifaMain()
        {
            try
            {
                String RoutePrefix = "api/Tarifa";
                InstanciaParametros();
                String Url = RemoteAddress(RoutePrefix, "GetTarifaMain");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                var ResponseItem = JsonConvert.DeserializeObject<ResponseAPI<List<TarifaMainModel>>>(Content);

                return ResponseItem.Value;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async static Task<Boolean> Save(TarifaSaveModel Entity)
        {
            try
            {
                String RoutePrefix = "api/Tarifa";
                var Json = JsonConvert.SerializeObject(Entity);
                var context = new StringContent(Json, Encoding.UTF8, "application/json");
                String Url = RemoteAddress(RoutePrefix, "Registrar");
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
        public async static Task<Boolean> Update(TarifaSaveModel Entity)
        {
            try
            {
                String RoutePrefix = "api/Tarifa";
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

        public static async Task<List<TarifaSaveModel>> GetTarifaItem(Int32 TarifaId)
        {
            try
            {
                String RoutePrefix = "api/Tarifa";
                InstanciaParametros();
                AddParametro(TarifaId);
                String Url = RemoteAddress(RoutePrefix, "GetTarifaItem");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                List<TarifaSaveModel> Items = JsonConvert.DeserializeObject<List<TarifaSaveModel>>(Content);
                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
