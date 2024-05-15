using Microsoft.AspNetCore.Mvc;
using Space.BusinessLayer;
using Space.EntityLayer;

namespace Space.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServListaController : ControllerBase
    {
        [HttpGet]
        [Route("ObtenerServListaCodigo/{codigo}")]

        public ResponseAPI<List<ServListaModel>> ObtenerServListaCodigo(String codigo)
        {
            try
            {
                var Items = ServLista.ObtenerServListaCodigo(codigo);
                List<ServListaModel> Lista = new List<ServListaModel>();
                foreach (var Item in Items) Lista.Add(new ServListaModel(Item));

                return new ResponseAPI<List<ServListaModel>>(Lista, true);
            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<ServListaModel>>(ex.Message.ToString());
            }
        }
        [HttpPost]
        [Route("BuscarServLista")]
        public ResponseAPI<List<ServListaModel>> BuscarServLista(ParametroItemModel Parametro)
        {
            try
            {
                var Items = ServLista.BuscarServLista(Parametro.Codigo, Parametro.Nombre);
                List<ServListaModel> Lista = new List<ServListaModel>();
                foreach (var Item in Items) Lista.Add(new ServListaModel(Item));

                return new ResponseAPI<List<ServListaModel>>(Lista, true);

            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<ServListaModel>>(ex.Message.ToString());
            }
        }


        [HttpGet]
        [Route("ObtenerServListaMain/{codigo}")]
        public ResponseAPI<List<ServListaMainModel>> ObtenerServListaMain(String codigo)
        {
            try
            {
                var ItemMain = ServLista.ObtenerServListaMain(codigo);

                List<ServListaMainModel> Lista = new List<ServListaMainModel>();
                foreach (var Item in ItemMain) Lista.Add(new ServListaMainModel(Item));

                return new ResponseAPI<List<ServListaMainModel>>(Lista, true);
            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<ServListaMainModel>>(ex.Message.ToString());
            }
        }

        [HttpPost]
        [Route("Registrar")]
        public ResponseAPI<ServListaSaveModel> Registrar(ServListaSaveModel Item)
        {
            try
            {
                ServListaEntity ItemEntity = new ServListaEntity();

                Item.FechaRegistro = DateTime.Now;
                ItemEntity.ListaId = Item.ListaId;
                ItemEntity.CodigoCampo = Item.CodigoCampo;
                ItemEntity.Codigo = Item.Codigo;
                ItemEntity.Nombre = Item.Nombre;
                ItemEntity.Descripcion = Item.Descripcion;
                ItemEntity.CodUsuario = Item.CodUsuario;
                ItemEntity.FechaRegistro = Item.FechaRegistro;
                ItemEntity.EstadoRegistro = Item.EstadoRegistro;

                Item.ListaId = ServLista.Registrar(ItemEntity);

                return new ResponseAPI<ServListaSaveModel>(Item, true);
            }
            catch (Exception ex)
            {
                return new ResponseAPI<ServListaSaveModel>(ex.Message.ToString());
            }
        }
        [HttpPost]
        [Route("Actualizar")]
        public ResponseAPI<ServListaSaveModel> Actualizar(ServListaSaveModel Item)
        {

            try
            {
                ServListaEntity ItemEntity = new ServListaEntity();
                ItemEntity.ListaId = Item.ListaId;
                ItemEntity.CodigoCampo = Item.CodigoCampo;
                ItemEntity.Codigo = Item.Codigo;
                ItemEntity.Nombre = Item.Nombre;
                ItemEntity.Descripcion = Item.Descripcion;
                ItemEntity.FechaRegistro = Item.FechaRegistro;
                ItemEntity.CodUsuario = Item.CodUsuario;
                ItemEntity.EstadoRegistro = Item.EstadoRegistro;

                ServLista.Actualizar(ItemEntity);

                return new ResponseAPI<ServListaSaveModel>(Item, true);
            }
            catch (Exception ex)
            {
                return new ResponseAPI<ServListaSaveModel>(ex.Message.ToString());
            }
        }

        [HttpGet]
        [Route("ObtenerServListaItem/{ListaId}")]
        public ResponseAPI<List<ServListaSaveModel>> ObtenerServListaItem(Int32 ListaId)
        {
            try
            {
                var Items = ServLista.ObtenerServListaItem(ListaId);
                List<ServListaSaveModel> Lista = new List<ServListaSaveModel>();
                foreach (var Item in Items) Lista.Add(new ServListaSaveModel(Item));

                return new ResponseAPI<List<ServListaSaveModel>>(Lista, true);
            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<ServListaSaveModel>>(ex.Message.ToString());
            }
        }
    }
}
