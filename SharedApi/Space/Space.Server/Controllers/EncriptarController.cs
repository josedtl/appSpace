using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using Space.BusinessLayer;
using System.Security.Cryptography;
using System.Text;

namespace Space.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncriptarController : ControllerBase
    {
        private readonly EncryptionService _encryptionService;

        public EncriptarController(EncryptionService encryptionService)
        {
            _encryptionService = encryptionService;
        }

        [HttpGet]
        [Route("Encriptar/{Texto}")]
        public String Encriptar(String Texto)
        {
            // Ejemplo de uso de la lógica de cifrado
            //string originalText = "Hola, esto es un mensaje secreto.";
            string key = "claveSecreta12345";
            string iv = "vectorInicial123";

            string encryptedText = _encryptionService.Encrypt(Texto, key, iv);

            return encryptedText;
        }

      
    }
}
