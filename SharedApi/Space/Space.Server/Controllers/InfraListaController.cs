using Framework;
using Microsoft.AspNetCore.Mvc;
using Space.BusinessLayer;
using Space.EntityLayer;

namespace Space.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfraListaController : ControllerBase
    {
        Base d = new Base();
        [HttpGet]
        [Route("ObtenerCodigo/{codigo}")]
        public ResponseAPI<List<InfraListaModel>> ObtenerItemsCodigo(String codigo)
        {
            try
            {
                d.Configurar();
                var Items = InfraLista.ObtenerItemsCodigo(codigo);

                List<InfraListaModel> Lista = new List<InfraListaModel>();

                foreach (var Item in Items) Lista.Add(new InfraListaModel(Item));

                return new ResponseAPI<List<InfraListaModel>>(Lista, true);
            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<InfraListaModel>>(ex.Message.ToString());
            }
        }

        [HttpPost]
        [Route("Buscar")]
        public ResponseAPI<List<InfraListaModel>> BuscarItemCodigo(ItemLikeModel Parametro)
        {
            try
            {
                d.Configurar();
                var Items = InfraLista.BuscarItemCodigo(Parametro.srtValor1, Parametro.srtValor2);

                List<InfraListaModel> Lista = new List<InfraListaModel>();

                foreach (var Item in Items) Lista.Add(new InfraListaModel(Item));

                return new ResponseAPI<List<InfraListaModel>>(Lista, true);
            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<InfraListaModel>>(ex.Message.ToString());
            }
        }

        [HttpGet]
        [Route("ObtenerMain/{codigo}")]
        public ResponseAPI<List<InfraListaMainModel>> ObtenerMain(string codigo)
        {
            try
            {
                d.Configurar();
                List<InfraListaEntity> InfraListaItems = InfraLista.ObtenerMain(codigo);

                List<InfraListaMainModel> ListaNew = new List<InfraListaMainModel>();
                foreach (InfraListaEntity ItemIL in InfraListaItems)
                {
                    ListaNew.Add(new InfraListaMainModel(ItemIL));
                }

                return new ResponseAPI<List<InfraListaMainModel>>(ListaNew, true);
            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<InfraListaMainModel>>(ex.Message.ToString());
            }
        }

        [HttpPost]
        [Route("Registrar")]
        public ResponseAPI<InfraListaSaveModel> Registrar(InfraListaSaveModel Item)
        {
            try
            {
                d.Configurar();
                InfraListaEntity ItemEntity = new InfraListaEntity();

                Item.FechaRegistro = DateTime.Now;
                ItemEntity.ListaId = Item.ListaId;
                ItemEntity.CodigoCampo = Item.CodigoCampo;
                ItemEntity.Codigo = Item.Codigo;
                ItemEntity.Nombre = Item.Nombre;
                ItemEntity.Descripcion = Item.Descripcion;
                ItemEntity.CodUsuario = Item.CodUsuario;
                ItemEntity.FechaRegistro = Item.FechaRegistro;
                ItemEntity.EstadoRegistro = Item.EstadoRegistro;
                ItemEntity.LogicalState = (LogicalState)Item.Action;
                Item.ListaId = InfraLista.Registrar(ItemEntity);
                return new ResponseAPI<InfraListaSaveModel>(Item, true);


            }
            catch (Exception ex)
            {

                return new ResponseAPI<InfraListaSaveModel>(ex.Message.ToString());
            }
        }


        [HttpGet]
        [Route("ObtenerItem/{ListaId}")]
        public ResponseAPI<List<InfraListaSaveModel>> ObtenerItem(Int32 ListaId)
        {
            try
            {
                d.Configurar();
                var Items = InfraLista.ObtenerItem(ListaId);

                List<InfraListaSaveModel> Lista = new List<InfraListaSaveModel>();

                foreach (var Item in Items) Lista.Add(new InfraListaSaveModel(Item));

                return new ResponseAPI<List<InfraListaSaveModel>>(Lista, true);
            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<InfraListaSaveModel>>(ex.Message.ToString());
            }
        }


        [HttpGet]
        [Route("ObtenerItemEnlace/{ListaId}")]
        public ResponseAPI<List<InfraListaModel>> ObtenerItemEnlace(Int32 ListaId)
        {
            try
            {
                d.Configurar();
                var Items = InfraLista.ObtenerEnlaceItem(ListaId);

                List<InfraListaModel> Lista = new List<InfraListaModel>();

                foreach (var Item in Items) Lista.Add(new InfraListaModel(Item));

                return new ResponseAPI<List<InfraListaModel>>(Lista, true);
            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<InfraListaModel>>(ex.Message.ToString());
            }
        }

        [HttpGet]
        [Route("GetInfraCampoTitulo/{codigo}")]
        public ResponseAPI<List<InfraCampoTituloModel>> ObtenerTitulo(String codigo)
        {
            try
            {
                d.Configurar();
                var Items = InfraCampo.ObtenerTitulo(codigo);

                List<InfraCampoTituloModel> Lista = new List<InfraCampoTituloModel>();
                foreach (var Item in Items) Lista.Add(new InfraCampoTituloModel(Item));

                return new ResponseAPI<List<InfraCampoTituloModel>>(Lista, true);
            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<InfraCampoTituloModel>>(ex.Message.ToString());
            }
        }
    }
}
