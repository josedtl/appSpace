using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.ServiceConsumer.Service
{
    public class MercaderiaService : BaseInvocador
    {
        public static async Task<List<MercaderiaMainModel>> GetMercaderiaMain()
        {
            try
            {
                String RoutePrefix = "api/Mercaderia";
                InstanciaParametros();
                String Url = RemoteAddress(RoutePrefix, "GetMercaderiaMain");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", GetToken());
                HttpResponseMessage Data = await client.GetAsync(GetUrlParametros(Url));
                String Content = ValidarHttp(Data);
                var ResponseItem = JsonConvert.DeserializeObject<ResponseAPI<List<MercaderiaMainModel>>>(Content);

                return ResponseItem.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
