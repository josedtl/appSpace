using Newtonsoft.Json;
using System.Text;

namespace Space.ServiceConsumer.Service
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
