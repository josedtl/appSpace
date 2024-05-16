using Framework;
using Microsoft.AspNetCore.Mvc;
using Space.BusinessLayer;
using Space.EntityLayer;
using System.Collections;
using System.Collections.Generic;

namespace Space.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfraestructuraController : ControllerBase
    {
        Base d = new Base();
        [HttpGet]
        [Route("ObtenerMain")]
        public ResponseAPI<List<InfraestructuraMainModel>> ObtenerMain()
        {
            try
            {
                d.Configurar();
                var Items = Infraestructura.ObtenerMain();

                List<InfraestructuraMainModel> Lista = new List<InfraestructuraMainModel>();

                foreach (var Item in Items) Lista.Add(new InfraestructuraMainModel(Item));

                return new ResponseAPI<List<InfraestructuraMainModel>>(Lista, true);

            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<InfraestructuraMainModel>>( ex.Message.ToString());
            }
        }

        [HttpPost]
        [Route("Registrar")]
        public ResponseAPI<InfraestructuraSaveModel> Registrar([FromBody] InfraestructuraSaveModel Item)
        {
            try
            {
                d.Configurar();
                InfraestructuraEntity ItemEntity = new InfraestructuraEntity();

                ItemEntity.InfraestructuraId = Item.InfraestructuraId;
                ItemEntity.EstadoAdministrativoId = Item.EstadoAdministrativoId;
                ItemEntity.SucursalId = Item.SucursalId;
                ItemEntity.CodigoSistema = Item.CodigoSistema;
                ItemEntity.CodigoInterno = Item.CodigoInterno;
                ItemEntity.Descripcion = Item.Descripcion;
                ItemEntity.TipoInfraestructuraId = Item.TipoInfraestructuraId;
                ItemEntity.InfraestructuraDimensionId = Item.InfraestructuraDimensionId;
                ItemEntity.Aforo = Item.Aforo;
                ItemEntity.PisoId = Item.PisoId;
                ItemEntity.FechaRegistro = Item.FechaRegistro;
                ItemEntity.CodUsuario = Item.CodUsuario;
                ItemEntity.EstadoRegistro = Item.EstadoRegistro;
                ItemEntity.LogicalState = (LogicalState)Item.Action;

                Infraestructura.Registrar(ItemEntity);
                Item.InfraestructuraId = ItemEntity.InfraestructuraId;
                return new ResponseAPI<InfraestructuraSaveModel>(Item, true);

            }
            catch (Exception ex)
            {

                return new ResponseAPI<InfraestructuraSaveModel>(ex.Message.ToString());
            }
        }

    

        [HttpGet]
        [Route("ObtenerItem/{InfraestructuraId}")]
        public ResponseAPI<List<InfraestructuraSaveModel>> ObtenerItem(Int32 InfraestructuraId)
        {
            try
            {
                d.Configurar();
                var Items = Infraestructura.ObtenerItem(InfraestructuraId);

                List<InfraestructuraSaveModel> Lista = new List<InfraestructuraSaveModel>();

                foreach (var Item in Items)
                {
                    Lista.Add(new InfraestructuraSaveModel(Item));
                }

                return new ResponseAPI<List<InfraestructuraSaveModel>>(Lista, true);

            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<InfraestructuraSaveModel>>(ex.Message.ToString());
            }
        }

        [HttpGet]
        [Route("ObtenerFiltroAlquiler")]
        public ResponseAPI<List<InfraestructuraFiltroModel>> ObtenerFiltroAlquiler()
        {
            try
            {
                d.Configurar();
                var Items = Infraestructura.ObtenerFiltroAlquiler();

                List<InfraestructuraFiltroModel> Lista = new List<InfraestructuraFiltroModel>();

                foreach (var Item in Items) Lista.Add(new InfraestructuraFiltroModel(Item));

                return new ResponseAPI<List<InfraestructuraFiltroModel>>(Lista, true);

            }
            catch (Exception ex)
            {
                return new ResponseAPI<List<InfraestructuraFiltroModel>>(ex.Message.ToString());
            }
        }

    }

}
