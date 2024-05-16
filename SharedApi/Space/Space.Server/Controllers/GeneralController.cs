using Microsoft.AspNetCore.Mvc;
using Space.BusinessLayer;
using Space.Server.Model;
using Space.Server.Model.General;
using Space.Server.Model.Tarifa;

namespace Space.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralController : ControllerBase
    {
        Base d = new Base();
        #region MONEDA

        [HttpGet]
        [Route("ObtenerMonedaItems")]
        public ResponseAPI<List<MonedaModel>> ObtenerMonedaItems()
        {
            try
            {
                d.Configurar();
                var Items = Moneda.ObtenerMonedaItems();

                List<MonedaModel> Lista = new List<MonedaModel>();

                foreach (var Item in Items) Lista.Add(new MonedaModel(Item));

                return new ResponseAPI<List<MonedaModel>>(Lista, true);

            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<MonedaModel>>(new List<MonedaModel>(), false, ex.Message);
            }

        }

        [HttpGet]
        [Route("ObtenerMonedaItem/{MonedaId}")]
        public ResponseAPI<List<MonedaModel>> ObtenerMonedaItem(Int32 MonedaId)
        {
            try
            {
                d.Configurar();
                var Items = Moneda.ObtenerMonedaItem(MonedaId);

                List<MonedaModel> Lista = new List<MonedaModel>();

                foreach (var Item in Items) Lista.Add(new MonedaModel(Item));
                return new ResponseAPI<List<MonedaModel>>(Lista, true);

            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<MonedaModel>>(new List<MonedaModel>(), false, ex.Message);
            }

        }

        #endregion


        #region UNIDAD DE MEDIDA

        [HttpGet]
        [Route("ObtenerUnidadMedidaItems")]
        public ResponseAPI<List<UnidadMedidaModel>> ObtenerUnidadMedidaItems()
        {
            try
            {
                d.Configurar();
                var Items = UnidadMedida.GetUnidadMedidaItems();

                List<UnidadMedidaModel> Lista = new List<UnidadMedidaModel>();

                foreach (var Item in Items) Lista.Add(new UnidadMedidaModel(Item));
                return new ResponseAPI<List<UnidadMedidaModel>>(Lista, true);


            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<UnidadMedidaModel>>(new List<UnidadMedidaModel>(), false, ex.Message);
            }

        }

        [HttpGet]
        [Route("ObtenerUnidadMedidaItem/{UnidadMedidaId}")]
        public ResponseAPI<List<UnidadMedidaModel>> ObtenerUnidadMedidaItem(Int32 UnidadMedidaId)
        {
            try
            {
                d.Configurar();
                var Items = UnidadMedida.GetUnidadMedida_Item(UnidadMedidaId);

                List<UnidadMedidaModel> Lista = new List<UnidadMedidaModel>();

                foreach (var Item in Items) Lista.Add(new UnidadMedidaModel(Item));
                return new ResponseAPI<List<UnidadMedidaModel>>(Lista, true);

            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<UnidadMedidaModel>>(new List<UnidadMedidaModel>(), false, ex.Message);
            }

        }

        #endregion


        #region UBIGEO

        [HttpPost]
        [Route("BuscarUbigeoItem")]
        public ResponseAPI<List<UbigeoModel>> BuscarUbigeoItem(ItemLikeModel ItemLike)
        {
            try
            {
                d.Configurar();
                var Items = Ubigeo.GetUbigeoBuscarLike(ItemLike.srtValor1);
                List<UbigeoModel> Lista = new List<UbigeoModel>();
                foreach (var Item in Items) Lista.Add(new UbigeoModel(Item));
                return new ResponseAPI<List<UbigeoModel>>(Lista, true);

            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<UbigeoModel>>(new List<UbigeoModel>(), false, ex.Message);
            }

        }

        [HttpGet]
        [Route("ObtenerUbigeoItem/{UbigeoId}")]
        public ResponseAPI<List<UbigeoModel>> ObtenerUbigeoItem(Int32 UbigeoId)
        {
            try
            {
                d.Configurar();
                var Items = Ubigeo.GetUbigeoItem(UbigeoId);
                List<UbigeoModel> Lista = new List<UbigeoModel>();
                foreach (var Item in Items) Lista.Add(new UbigeoModel(Item));
                return new ResponseAPI<List<UbigeoModel>>(Lista, true);

            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<UbigeoModel>>(new List<UbigeoModel>(), false, ex.Message);
            }

        }

        #endregion



        [HttpPost]
        [Route("GetEntidadBuscarItem")]
        public ResponseAPI<List<EntidadModel>> GetEntidadBuscarItem(ItemLikeModel ItemLike)
        {
            try
            {
                d.Configurar();
                var Items = Entidad.GetEntidadBuscarItem(ItemLike.srtValor1);
                List<EntidadModel> Lista = new List<EntidadModel>();
                foreach (var Item in Items) Lista.Add(new EntidadModel(Item));
                return new ResponseAPI<List<EntidadModel>>(Lista, true);

            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<EntidadModel>>(new List<EntidadModel>(), false, ex.Message);
            }

        }
    }
}
