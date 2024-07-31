using ClientDesk.Formulario.Infraestructura;
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
    public class InfraestructuraService : BaseInvocador
    {
        public static async Task<List<InfraestructuraMainModel>> GetInfraestructuraMain()
        {
            try
            {
                String RoutePrefix = "api/Infraestructura";
                InstanciaParametros();
                String Url = RemoteAddress(RoutePrefix, "GetInfraestructuraMain");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                List<InfraestructuraMainModel> Items = JsonConvert.DeserializeObject<List<InfraestructuraMainModel>>(Content);
                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
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
                String Url = RemoteAddress(RoutePrefix, "GetInfraestructuraItem");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                List<InfraestructuraSaveModel> Items = JsonConvert.DeserializeObject<List<InfraestructuraSaveModel>>(Content);
                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
