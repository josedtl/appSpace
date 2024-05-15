using Space.EntityLayer;
using System.Text.Json.Serialization;

namespace Space.Server.Model.General
{
    public class MonedaModel
    {
        public MonedaModel()
        {
            MonedaId = 0;
            Codigo = String.Empty;
            CodigoInterno = String.Empty;
            Simbolo = String.Empty;
            Nombre = String.Empty;
        }

        public MonedaModel(MonedaEntity Ent)
        {
            this.MonedaId = Ent.MonedaId;
            this.Codigo = Ent.Codigo;
            this.CodigoInterno = Ent.CodigoInterno;
            this.Simbolo = Ent.Simbolo;
            this.Nombre = Ent.Nombre;
        }
        [JsonPropertyName("MonedaId")]
        public Int32 MonedaId { get; set; }
        [JsonPropertyName("Codigo")]
        public String Codigo { get; set; }
        [JsonPropertyName("CodigoInterno")]
        public String CodigoInterno { get; set; }
        [JsonPropertyName("Simbolo")]
        public String Simbolo { get; set; }
        [JsonPropertyName("Nombre")]
        public String Nombre { get; set; }
    }
}
