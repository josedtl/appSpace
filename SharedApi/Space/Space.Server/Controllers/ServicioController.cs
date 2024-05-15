using Microsoft.AspNetCore.Mvc;
using Space.BusinessLayer;
using Space.EntityLayer;

namespace Space.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicioController : ControllerBase
    {
        Base d = new Base();
        [HttpGet]
        [Route("ObtenerMain")]
        public ResponseAPI<List<ServicioMainModel>> ObtenerMain()
        {
            try
            {
                d.Configurar();
                Servicio BS = new Servicio();
                var Items = BS.ObtenerMain();
                List<ServicioMainModel> Lista = new List<ServicioMainModel>();

                foreach (var Item in Items) Lista.Add(new ServicioMainModel(Item));

                return new ResponseAPI<List<ServicioMainModel>>(Lista, true);
            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<ServicioMainModel>>(ex.Message.ToString());
            }
        }
        [HttpPost]
        [Route("Registrar")]
        public ResponseAPI<ServicioSaveModel> Registrar(ServicioSaveModel Item)
        {
            try
            {
                d.Configurar();
                Servicio BS = new Servicio();
                ServicioEntity ItemEntity = new ServicioEntity();

                ItemEntity.ServicioId = Item.ServicioId;
                ItemEntity.Correlativo = Item.Correlativo;
                ItemEntity.Nombre = Item.Nombre;
                ItemEntity.Descripcion = Item.Descripcion;
                ItemEntity.TipoServicioId = Item.TipoServicioId;
                ItemEntity.FechaRegistro = Item.FechaRegistro;
                ItemEntity.CodUsuario = Item.CodUsuario;
                ItemEntity.EstadoRegistro = Item.EstadoRegistro;

                Item.ServicioId= BS.Registrar(ItemEntity);

                return new ResponseAPI<ServicioSaveModel>(Item, true);
            }
            catch (Exception ex)
            {
                return new ResponseAPI<ServicioSaveModel>(ex.Message.ToString());
            }
        }



        [HttpGet]
        [Route("ObtenerItem/{ServicioId}")]
        public ResponseAPI<List<ServicioSaveModel>> ObtenerItem(Int32 ServicioId)
        {
            try
            {
                d.Configurar();
                Servicio BS = new Servicio();

                var Items = BS.ObtenerItem(ServicioId);

                List<ServicioSaveModel> Lista = new List<ServicioSaveModel>();

                foreach (var Item in Items)Lista.Add(new ServicioSaveModel(Item));

                return new ResponseAPI<List<ServicioSaveModel>>(Lista, true);

            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<ServicioSaveModel>>(ex.Message.ToString());
            }
        }
    }
}
