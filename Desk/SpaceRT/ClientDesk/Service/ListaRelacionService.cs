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
    public class ListaRelacionService : BaseInvocador
    {


        public async static Task<List<ListaRelacionModel>> GetListaRelacionLike(String _Codigo, String _Nombre)
        {
            try
            {
                ParametroItemModel Entity = new ParametroItemModel { Codigo = _Codigo, Nombre = _Nombre };

                String RoutePrefix = "api/ListaRelacion";
                var Json = JsonConvert.SerializeObject(Entity);
                var context = new StringContent(Json, Encoding.UTF8, "application/json");
                String Url = RemoteAddress(RoutePrefix, "GetListaRelacionLike");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.PostAsync(Url, context);
                String Content = ValidarHttp(Data);
                List<ListaRelacionModel> Items = JsonConvert.DeserializeObject<List<ListaRelacionModel>>(Content);

                return Items;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
