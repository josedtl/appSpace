using Space.EntityLayer;
using System.Text.Json.Serialization;

namespace Space.Server
{
    public class TipoEntidadItemModel
    {
        public TipoEntidadItemModel(TipoEntidadEntity Ent)
        {
            TipoEntidadId = Ent.TipoEntidadId;
            Codigo = Ent.Codigo;
            Nombre = Ent.Nombre;
        }
        [JsonPropertyName("TipoEntidadId")]
        public int TipoEntidadId { get; set; }
        [JsonPropertyName("Codigo")]
        public string Codigo { get; set; }
        [JsonPropertyName("Nombre")]
        public string Nombre { get; set; }
    }
}
