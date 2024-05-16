using Space.EntityLayer;
using System.Text.Json.Serialization;

namespace Space.Server{
    public class InfraListaMainModel
    {
        public InfraListaMainModel()
        {
            ListaId = 0;
            CampoId = 0;
            Codigo = String.Empty;
            Nombre = String.Empty;
            Descripcion = String.Empty;
            FechaRegistro = DateTime.Now;
            CodUsuario = String.Empty;
            EstadoRegistro = true;
        }
        public InfraListaMainModel(InfraListaEntity Ent)
        {
            this.ListaId = Ent.ListaId;
            this.CampoId = Ent.CampoId;
            this.Codigo = Ent.Codigo;
            this.Nombre = Ent.Nombre;
            this.Descripcion = Ent.Descripcion;
            this.FechaRegistro = Ent.FechaRegistro;
            this.CodUsuario = Ent.CodUsuario;
            this.EstadoRegistro = Ent.EstadoRegistro;
        }

        [JsonPropertyName("ListaId")] public Int32 ListaId { get; set; }
        [JsonPropertyName("CampoId")] public Int32 CampoId { get; set; }
        [JsonPropertyName("Codigo")] public String Codigo { get; set; }
        [JsonPropertyName("Nombre")] public String Nombre { get; set; }
        [JsonPropertyName("Descripcion")] public String Descripcion { get; set; }
        [JsonPropertyName("FechaRegistro")] public DateTime FechaRegistro { get; set; }
        [JsonPropertyName("CodUsuario")] public String CodUsuario { get; set; }
        [JsonPropertyName("EstadoRegistro")] public Boolean EstadoRegistro { get; set; }
    }
}
