using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Space.BusinessLayer;
using Space.EntityLayer;
using Space.Server.Model.Tarifa;

namespace Space.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarifaController : ControllerBase
    {

        [HttpGet]
        [Route("ObtenerMain")]
        public ResponseAPI<List<TarifaMainModel>> ObtenerMain()
        {
            try
            {
                Tarifa DB = new Tarifa();
                var Items = DB.ObtenerMain();

                List<TarifaMainModel> Lista = new List<TarifaMainModel>();

                foreach (var Item in Items)
                {
                    Lista.Add(new TarifaMainModel(Item));
                }

                return new ResponseAPI<List<TarifaMainModel>>(Lista, true);

            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<TarifaMainModel>>(new List<TarifaMainModel>(), false, ex.Message);
            }
        }

        [HttpPost]
        [Route("Registrar")]
        public ResponseAPI<TarifaSaveModel> Registrar([FromBody] TarifaSaveModel Item)
        {
            try
            {
                Tarifa DB = new Tarifa();

                TarifaEntity ItemEntity = new TarifaEntity();

                ItemEntity.TarifaId = Item.TarifaId;
                ItemEntity.TipoTarifaEnum = Item.TipoTarifaEnum;
                ItemEntity.ObjetoReferenciaId = Item.ObjetoReferenciaId;
                ItemEntity.Correlativo = Item.Correlativo;
                ItemEntity.MonedaId = Item.MonedaId;
                ItemEntity.CostoTarifa = Item.CostoTarifa;
                ItemEntity.UnidadMedidaId = Item.UnidadMedidaId;
                ItemEntity.NomTarifa = Item.NomTarifa;
                ItemEntity.NomComercial = Item.NomComercial;
                ItemEntity.Descripcion = Item.Descripcion;
                ItemEntity.FechaRegistro = Item.FechaRegistro;
                ItemEntity.CodUsuario = Item.CodUsuario;
                ItemEntity.EstadoRegistro = Item.EstadoRegistro;

                DB.Registrar(ItemEntity);
                Item.TarifaId = ItemEntity.TarifaId;

                return new ResponseAPI<TarifaSaveModel>(Item, true);
            }
            catch (Exception ex)
            {
                return new ResponseAPI<TarifaSaveModel>(new TarifaSaveModel(), false, ex.Message);
            }
        }

        [HttpPost]
        [Route("Actualizar")]
        public ResponseAPI<TarifaSaveModel> Actualizar(TarifaSaveModel Item)
        {
            try
            {
                Tarifa DB = new Tarifa();

                TarifaEntity ItemEntity = new TarifaEntity();

                ItemEntity.TarifaId = Item.TarifaId;
                ItemEntity.Correlativo = Item.Correlativo;
                ItemEntity.MonedaId = Item.MonedaId;
                ItemEntity.CostoTarifa = Item.CostoTarifa;
                ItemEntity.UnidadMedidaId = Item.UnidadMedidaId;
                ItemEntity.TipoTarifaEnum = Item.TipoTarifaEnum;
                ItemEntity.NomTarifa = Item.NomTarifa;
                ItemEntity.NomComercial = Item.NomComercial;
                ItemEntity.Descripcion = Item.Descripcion;
                ItemEntity.FechaRegistro = Item.FechaRegistro;
                ItemEntity.CodUsuario = Item.CodUsuario;
                ItemEntity.EstadoRegistro = Item.EstadoRegistro;


                DB.Actualizar(ItemEntity);
                return new ResponseAPI<TarifaSaveModel>(Item, true);

            }
            catch (Exception ex)
            {
                return new ResponseAPI<TarifaSaveModel>(new TarifaSaveModel(), false, ex.Message);
            }
        }

        [HttpGet]
        [Route("ObtenerItem/{TarifaId}")]
        public ResponseAPI<List<TarifaSaveModel>> ObtenerItem(Int32 TarifaId)
        {
            try
            {
                Tarifa DB = new Tarifa();
                var Items = DB.ObtenerItem(TarifaId);

                List<TarifaSaveModel> Lista = new List<TarifaSaveModel>();

                foreach (var Item in Items)
                {
                    Lista.Add(new TarifaSaveModel(Item));
                }

                return new ResponseAPI<List<TarifaSaveModel>>(Lista, true);

            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<TarifaSaveModel>>(new List<TarifaSaveModel>(), false, ex.Message);
            }
        }


        [HttpPost]
        [Route("BuscarRecurso")]
        public ResponseAPI<List<TarifaBuscarRecursoModel>> BuscarRecurso(ItemLikeModel Value)
        {
            try
            {
                Tarifa DB = new Tarifa();
                var Items = DB.BuscarRecurso(Value.srtValor1, Value.intValor1);

                List<TarifaBuscarRecursoModel> Lista = new List<TarifaBuscarRecursoModel>();

                foreach (var Item in Items)   Lista.Add(new TarifaBuscarRecursoModel(Item));


                return new ResponseAPI<List<TarifaBuscarRecursoModel>>(Lista, true);

            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<TarifaBuscarRecursoModel>>(new List<TarifaBuscarRecursoModel>(), false, ex.Message);
            }
        }

    }
}
