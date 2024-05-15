using Space.EntityLayer;
using System.Text.Json.Serialization;

namespace Space.Server
{
    public class ServListaSaveModel
    {
        public ServListaSaveModel()
        {
            ListaId = 0;
            CodigoCampo = String.Empty;
            Codigo = String.Empty;
            Nombre = String.Empty;
            Descripcion = String.Empty;
            FechaRegistro = DateTime.Now;
            CodUsuario = String.Empty;
            EstadoRegistro = true;
        }
        public ServListaSaveModel(ServListaEntity Ent)
        {
            this.ListaId = Ent.ListaId;
            this.CodigoCampo = Ent.CodigoCampo;
            this.Nombre = Ent.Nombre;
            this.Codigo = Ent.Codigo;
            this.Descripcion = Ent.Descripcion;
            this.FechaRegistro = Ent.FechaRegistro;
            this.CodUsuario = Ent.CodUsuario;
            this.EstadoRegistro = Ent.EstadoRegistro;
        }
        [JsonPropertyName("ListaId")] public Int32 ListaId { get; set; }
        [JsonPropertyName("CodigoCampo")] public string CodigoCampo { get; set; }
        [JsonPropertyName("Codigo")] public String Codigo { get; set; }
        [JsonPropertyName("Nombre")] public String Nombre { get; set; }
        [JsonPropertyName("Descripcion")] public String Descripcion { get; set; }
        [JsonPropertyName("FechaRegistro")] public DateTime FechaRegistro { get; set; }
        [JsonPropertyName("CodUsuario")] public String CodUsuario { get; set; }
        [JsonPropertyName("EstadoRegistro")] public Boolean EstadoRegistro { get; set; }
    }
}
