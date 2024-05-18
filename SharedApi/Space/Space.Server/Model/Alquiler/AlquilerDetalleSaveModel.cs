using System.Text.Json.Serialization;

namespace Space.Server
{
    public class AlquilerDetalleSaveModel
    {
        public AlquilerDetalleSaveModel()
        {
            this.AlquilerDetalleId = 0;
            this.AlquilerId = 0;
            this.TarifaId = 0;
            this.Cantidad = 0;
            this.FechaRegistro = DateTime.Now;
            this.CodUsuario = String.Empty;
            this.EstadoAdministrativoId = 0;
        }
        [JsonPropertyName("AlquilerDetalleId")]
        public Int32 AlquilerDetalleId { get; set; }
        [JsonPropertyName("AlquilerId")]
        public Int32 AlquilerId { get; set; }
        [JsonPropertyName("TarifaId")]
        public Int32 TarifaId { get; set; }
        [JsonPropertyName("Cantidad")]
        public Decimal Cantidad { get; set; }
        [JsonPropertyName("FechaRegistro")]
        public DateTime FechaRegistro { get; set; }
        [JsonPropertyName("CodUsuario")]
        public String CodUsuario { get; set; }
        [JsonPropertyName("EstadoAdministrativoId")]
        public Int32 EstadoAdministrativoId { get; set; }
        [JsonPropertyName("Action")]
        public Int16 Action { get; set; }
    }
}
