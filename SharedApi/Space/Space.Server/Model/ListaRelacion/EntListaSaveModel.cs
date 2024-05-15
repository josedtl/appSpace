using Space.EntityLayer;
using System.Text.Json.Serialization;

namespace Space.Server
{
    public class EntListaSaveModel
    {

        public EntListaSaveModel()
        {
            this.ListaId = 0;
            this.CampoId = 0;
            this.Codigo = String.Empty;
            this.Nombre = String.Empty;
            this.Descripcion = String.Empty;
            this.CodUsuario = String.Empty;
            this.EstadoRegistro = false;
        }
        public EntListaSaveModel(EntListaEntity Item)
        {
            this.ListaId = Item.ListaId;
            this.CampoId = Item.EntCampoId;
            this.Codigo = Item.Codigo;
            this.Nombre = Item.Nombre;
            this.Descripcion = Item.Descripcion;
            this.CodUsuario = Item.CodUsuario;
            this.EstadoRegistro = Item.EstadoRegistro;
        }
        [JsonPropertyName("ListaId")] public Int32 ListaId { get; set; }
        [JsonPropertyName("CampoId")] public Int32 CampoId { get; set; }
        [JsonPropertyName("Codigo")] public string Codigo { get; set; }
        [JsonPropertyName("Nombre")] public string Nombre { get; set; }
        [JsonPropertyName("Descripcion")] public string Descripcion { get; set; }
        [JsonPropertyName("FechaRegistro")] public DateTime FechaRegistro { get; set; }
        [JsonPropertyName("CodUsuario")] public String CodUsuario { get; set; }
        [JsonPropertyName("EstadoRegistro")] public Boolean EstadoRegistro { get; set; }
    }
}
