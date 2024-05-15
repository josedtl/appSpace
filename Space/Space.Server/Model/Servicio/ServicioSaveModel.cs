using Space.EntityLayer;
using System.Text.Json.Serialization;

namespace Space.Server
{
    public class ServicioSaveModel
    {
        public ServicioSaveModel()
        {
            ServicioId = 0;
            Correlativo = String.Empty;
            Nombre = String.Empty;
            Descripcion = String.Empty;
            TipoServicioId = 0;
            FechaRegistro = DateTime.Now;
            CodUsuario = String.Empty;
            EstadoRegistro = true;
        }

        public ServicioSaveModel(ServicioEntity Item)
        {
            this.ServicioId = Item.ServicioId;
            this.Correlativo = Item.Correlativo;
            this.Nombre = Item.Nombre;
            this.Descripcion = Item.Descripcion;
            this.TipoServicioId = Item.TipoServicioId;
            this.FechaRegistro = Item.FechaRegistro;
            this.CodUsuario = Item.CodUsuario;
            this.EstadoRegistro = Item.EstadoRegistro;
        }
         [JsonPropertyName("ServicioId")]  public Int32 ServicioId { get; set; }
         [JsonPropertyName("Correlativo")]  public String Correlativo { get; set; }
         [JsonPropertyName("Nombre")]  public String Nombre { get; set; }
         [JsonPropertyName("Descripcion")]  public String Descripcion { get; set; }
         [JsonPropertyName("TipoServicioId")]  public Int32 TipoServicioId { get; set; }
         [JsonPropertyName("FechaRegistro")]  public DateTime FechaRegistro { get; set; }
         [JsonPropertyName("CodUsuario")]  public String CodUsuario { get; set; }
        [JsonPropertyName("EstadoRegistro")] public Boolean EstadoRegistro { get; set; }
    }
}
