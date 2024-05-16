using Space.EntityLayer;
using System.Text.Json.Serialization;

namespace Space.Server
{
    public class EntidadModel
    {
        public EntidadModel()
        {
            this.EntidadId = 0;
            this.NombreCompleto = String.Empty;
        }

        public EntidadModel(EntidadEntity Item)
        {
            this.EntidadId = Item.EntidadId;
            this.NombreCompleto = Item.NombreCompleto;
        }
        [JsonPropertyName("EntidadId")]
        public Int32 EntidadId { get; set; }
        [JsonPropertyName("NombreCompleto")]
        public String NombreCompleto { get; set; }
    }
}
