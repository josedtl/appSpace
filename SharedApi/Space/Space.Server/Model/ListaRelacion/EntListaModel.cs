using Space.EntityLayer;
using System.Text.Json.Serialization;

namespace Space.Server
{
    public class EntListaModel
    {
        public EntListaModel()
        {
            this.ListaId = 0;
            this.Nombre = String.Empty;
        }
        public EntListaModel(EntListaEntity Item)
        {
            this.ListaId = Item.ListaId;
            this.Nombre = Item.Nombre;
        }
        [JsonPropertyName("ListaId")] public Int32 ListaId { get; set; }
        [JsonPropertyName("Nombre")] public String Nombre { get; set; }

    }
}
