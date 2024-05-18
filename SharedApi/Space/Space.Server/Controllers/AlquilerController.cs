using Framework;
using Microsoft.AspNetCore.Mvc;
using Space.BusinessLayer;
using Space.EntityLayer;


namespace Space.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlquilerController : ControllerBase
    {

        Base d = new Base();

        [HttpPost]
        [Route("Registrar")]
        public AlquilerSaveModel Save(AlquilerSaveModel Item)
        {
            try
            {
                d.Configurar();
                AlquilerEntity ItemEntity = new AlquilerEntity();

                ItemEntity.AlquilerId = Item.AlquilerId;
                ItemEntity.EstadoProcesoId = Item.EstadoProcesoId;
                ItemEntity.TarifaId = Item.TarifaId;
                ItemEntity.ClienteId = Item.ClienteId;
                ItemEntity.Cantidad = Item.Cantidad;
                ItemEntity.Codigo = Item.Codigo;
                ItemEntity.FechaInicio = Item.FechaInicio;
                ItemEntity.FechaTermino = Item.FechaTermino;
                ItemEntity.FechaCreacion = Item.FechaCreacion;
                ItemEntity.FechaModifica = Item.FechaModifica;
                ItemEntity.CodUsuario = Item.CodUsuario;
                ItemEntity.LogicalState = (LogicalState)Item.Action;

                if (Item.Detalles != null && Item.Detalles.Count > 0)
                {
                    ItemEntity.Detalles = new List<AlquilerDetalleEntity>();


                    foreach (var i in Item.Detalles)
                    {
                        ItemEntity.Detalles.Add(new AlquilerDetalleEntity
                        {
                            AlquilerDetalleId = i.AlquilerDetalleId,
                            AlquilerId = i.AlquilerId,
                            TarifaId = i.TarifaId,
                            Cantidad = i.Cantidad,
                            FechaRegistro = i.FechaRegistro,
                            CodUsuario = i.CodUsuario,
                            EstadoAdministrativoId = i.EstadoAdministrativoId,
                            LogicalState=(LogicalState)i.Action
                        });

                    }
                }



                Alquiler.Registrar(ItemEntity);
                return Item;
            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }



    }
}
