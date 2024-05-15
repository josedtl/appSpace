using Space.EntityLayer;
using System.Text.Json.Serialization;

namespace Space.Server
{
    public class InfraCampoTituloModel
    {

        public InfraCampoTituloModel()
        {
            this.Titulo = String.Empty;
        }

        public InfraCampoTituloModel(InfraCampoEntity Item)
        {
            this.Titulo = Item.Nombre;
        }

        [JsonPropertyName("Titulo")]
        public String Titulo { get; set; }
    }
}
