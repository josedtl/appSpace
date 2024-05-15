using Space.EntityLayer;
using System.Text.Json.Serialization;

namespace Space.Server
{
    public class ServicioMainModel
    {

        public ServicioMainModel(ServicioEntity Item)
        {
            this.ServicioId = Item.ServicioId;
            this.Correlativo = Item.Correlativo;
            this.Nombre = Item.Nombre;
            this.Descripcion = Item.Descripcion;
            this.TipoServicio = Item.TipoServicio;
            this.FechaRegistro = Item.FechaRegistro;
            this.CodUsuario = Item.CodUsuario;
            this.EstadoRegistro = Item.EstadoRegistro;
        }

        [JsonPropertyName("ServicioId")] public Int32 ServicioId { get; set; }
        [JsonPropertyName("Correlativo")] public String Correlativo { get; set; }
        [JsonPropertyName("Nombre")] public String Nombre { get; set; }
        [JsonPropertyName("Descripcion")] public String Descripcion { get; set; }
        [JsonPropertyName("TipoServicio")] public String TipoServicio { get; set; }
        [JsonPropertyName("FechaRegistro")] public DateTime FechaRegistro { get; set; }
        [JsonPropertyName("CodUsuario")] public String CodUsuario { get; set; }
        [JsonPropertyName("EstadoRegistro")] public Boolean EstadoRegistro { get; set; }
    }
}
