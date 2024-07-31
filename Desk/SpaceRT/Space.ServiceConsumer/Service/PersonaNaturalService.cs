using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Space.ServiceConsumer.Service
{
    public class PersonaNaturalService : BaseInvocador
    {
        public static async Task<List<EntidadEntityModel>> GetListaPersona()
        {
            try
            {
                String RoutePrefix = "api/PersonaNatural";
                InstanciaParametros();
                String Url = RemoteAddress(RoutePrefix, "GetAll");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                List<EntidadEntityModel> Items = JsonConvert.DeserializeObject<List<EntidadEntityModel>>(Content);
                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async static Task<Boolean> Save(PersonaNaturalSaveModel Entity)
        {
            try
            {
                String RoutePrefix = "api/PersonaNatural";
                var Json = JsonConvert.SerializeObject(Entity);
                var context = new StringContent(Json, Encoding.UTF8, "application/json");
                String Url = RemoteAddress(RoutePrefix, "Registrar");
                HttpClient client = new HttpClient();
                //client.DefaultRequestHeaders.Add("Authorization", GetToken());
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
        public async static Task<Boolean> Update(PersonaNaturalSaveModel Entity)
        {
            try
            {
                String RoutePrefix = "api/PersonaNatural";
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
        public static async Task<List<PersonaNaturalMainModel>> GetPersonaNaturalMain()
        {
            try
            {
                String RoutePrefix = "api/PersonaNatural";
                InstanciaParametros();
                String Url = RemoteAddress(RoutePrefix, "GetPersonaNaturalMain");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                List<PersonaNaturalMainModel> Items = JsonConvert.DeserializeObject<List<PersonaNaturalMainModel>>(Content);
                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
                throw ex;
            }
        }

        public static async Task<List<PersonaNaturalSaveModel>> GetPersonaNaturalItem(Int32 PersonaNaturalId)
        {
            try
            {
                String RoutePrefix = "api/PersonaNatural";
                InstanciaParametros();
                AddParametro(PersonaNaturalId);
                String Url = RemoteAddress(RoutePrefix, "GetPersonaNaturalItem");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                List<PersonaNaturalSaveModel> Items = JsonConvert.DeserializeObject<List<PersonaNaturalSaveModel>>(Content);
                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
