using Microsoft.AspNetCore.Mvc;
using Space.BusinessLayer;
using Space.EntityLayer;


namespace Space.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntidadController : ControllerBase
    {


        [HttpGet]
        [Route("GetAll")]
        public List<EntidadEntity> GetEndidad()
        {
            try
            {
                Endidad DB = new Endidad();
                return DB.GetEndidad();

            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }


        [HttpPost]
        [Route("Save")]
        public EntidadEntity Save(EntidadEntity Item)
        {
            try
            {
                Endidad DB = new Endidad();
                return DB.Save(Item);

            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }

    }
}
