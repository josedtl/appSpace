using Space.ServiceConsumer;
using Newtonsoft.Json;
using System.Text;
using System.Collections.Generic;


namespace Space.ServiceConsumer.Service
{
    public class InfraestructuraService : BaseInvocador
    {
        public static async Task<List<InfraestructuraMainModel>> GetInfraestructuraMain()
        {
            try
            {
                String RoutePrefix = "api/Infraestructura";
                InstanciaParametros();
                String Url = RemoteAddress(RoutePrefix, "ObtenerMain");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                var ResponseItem = JsonConvert.DeserializeObject<ResponseAPI<List<InfraestructuraMainModel>>>(Content);

                return ResponseItem.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async static Task<Boolean> Save(InfraestructuraSaveModel Entity)
        {
            try
            {
                String RoutePrefix = "api/Infraestructura";
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

        public async static Task<Boolean> Update(InfraestructuraSaveModel Entity)
        {
            try
            {
                String RoutePrefix = "api/Infraestructura";
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

        public static async Task<List<InfraestructuraSaveModel>> GetInfraestructuraItem(Int32 InfraestructuraId)
        {
            try
            {
                String RoutePrefix = "api/Infraestructura";
                InstanciaParametros();
                AddParametro(InfraestructuraId);
                String Url = RemoteAddress(RoutePrefix, "ObtenerItem");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                var ResponseItem = JsonConvert.DeserializeObject<ResponseAPI<List<InfraestructuraSaveModel>>>(Content);

                return ResponseItem.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
