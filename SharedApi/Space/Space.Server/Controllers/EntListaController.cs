using Microsoft.AspNetCore.Mvc;
using Space.BusinessLayer;
using Space.EntityLayer;


namespace Space.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntListaController : ControllerBase
    {

        Base d = new Base();
        [HttpGet]
        [Route("ObtenerItemsCodigo/{codigo}")]
        public ResponseAPI<List<EntListaModel>> ObtenerItemsCodigo(String codigo)
        {
            try
            {
                d.Configurar();
                List<EntListaModel> Lista = new List<EntListaModel>();

                var Items = EntLista.ObtenerCodigo(codigo);
                foreach (var Item in Items)
                {
                    Lista.Add(new EntListaModel
                    {
                        ListaId= Item.ListaId,
                        Nombre= Item.Nombre
                    });
                }

                return new ResponseAPI<List<EntListaModel>>(Lista, true);
            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<EntListaModel>>(ex.Message.ToString());
            }
        }


      

    }
}
