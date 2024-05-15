using Space.EntityLayer;
using System.Text.Json.Serialization;

namespace Space.Server
{
    public class ServListaModel
    {
        public ServListaModel()
        {
            this.ListaId = 0;
            this.Nombre = String.Empty;
        }
        public ServListaModel(ServListaEntity Ent)
        {
            this.ListaId = Ent.ListaId;
            this.Nombre = Ent.Nombre;
        }
        [JsonPropertyName("ListaId")] public Int32 ListaId { get; set; }
        [JsonPropertyName("Nombre")] public String Nombre { get; set; }
    }
}
