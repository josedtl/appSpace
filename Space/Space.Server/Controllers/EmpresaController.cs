using Microsoft.AspNetCore.Mvc;
using Space.BusinessLayer;
using Space.EntityLayer;

namespace Space.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        Base d = new Base();
        [HttpGet]
        [Route("GetEmpresaMain")]
        public List<EmpresaMainModel> GetEmpresaMain()
        {
            try
            {
                d.Configurar();
                var Items = Empresa.GetEmpresaMain();
                List<EmpresaMainModel> Lista = new List<EmpresaMainModel>();
                foreach (var Item in Items)
                {
                    Lista.Add(new EmpresaMainModel(Item));
                }

                return Lista;
            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetEmpresaItem/{EmpresaId}")]
        public List<EmpresaSaveModel> GetEmpresaItem(Int32 EmpresaId)
        {
            try
            {
                d.Configurar();
                var Items = Empresa.GetEmpresaItem(EmpresaId);

                List<EmpresaSaveModel> Lista = new List<EmpresaSaveModel>();

                foreach (var Item in Items)
                {
                    Lista.Add(new EmpresaSaveModel(Item));
                }

                return Lista;

            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }

        [HttpPost]
        [Route("Registrar")]
        public EmpresaSaveModel Save(EmpresaSaveModel Item)
        {
            try
            {
                d.Configurar();
                EmpresaEntity ItemEntity = new EmpresaEntity();

                ItemEntity.TipoDocumentoIdentidadId = Item.TipoDocumentoIdentidadId;
                ItemEntity.NumDocumento = Item.NumDocumento;
                ItemEntity.FechaRegistro = Item.FechaRegistro;
                ItemEntity.CodUsuario = Item.CodUsuario;
                ItemEntity.UbigeoId = Item.UbigeoId;
                ItemEntity.Direccion = Item.Direccion;
                ItemEntity.Telefono = Item.Telefono;
                ItemEntity.Correo = Item.Correo;
                Empresa.Save(ItemEntity);
                return Item;
            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }

      

    }
}
