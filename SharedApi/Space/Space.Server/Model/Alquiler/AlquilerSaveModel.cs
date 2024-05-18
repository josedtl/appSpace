using System.Text.Json.Serialization;

namespace Space.Server
{
    public class AlquilerSaveModel
    {

        public AlquilerSaveModel()
        {

            this.AlquilerId = 0;
            this.EstadoProcesoId = 0;
            this.TarifaId = 0;
            this.ClienteId = 0;
            this.Cantidad = 0m;
            this.Codigo = String.Empty;
            this.FechaInicio = DateTime.MinValue;
            this.FechaTermino = DateTime.MinValue;
            this.FechaCreacion = DateTime.MinValue;
            this.FechaModifica = DateTime.MinValue;
            this.CodUsuario = String.Empty;
            this.Detalles = new List<AlquilerDetalleSaveModel>();

        }

        [JsonPropertyName("AlquilerId")]
        public Int32 AlquilerId { get; set; }
        [JsonPropertyName("EstadoProcesoId")]
        public Int32 EstadoProcesoId { get; set; }
        [JsonPropertyName("TarifaId")]
        public Int32 TarifaId { get; set; }
        [JsonPropertyName("ClienteId")]
        public Int32 ClienteId { get; set; }
        [JsonPropertyName("Cantidad")]
        public Decimal Cantidad { get; set; }
        [JsonPropertyName("Codigo")]
        public String Codigo { get; set; }
        [JsonPropertyName("FechaInicio")]
        public DateTime FechaInicio { get; set; }
        [JsonPropertyName("FechaTermino")]
        public DateTime FechaTermino { get; set; }
        [JsonPropertyName("FechaCreacion")]
        public DateTime FechaCreacion { get; set; }
        [JsonPropertyName("FechaModifica")]
        public DateTime FechaModifica { get; set; }
        [JsonPropertyName("CodUsuario")]
        public String CodUsuario { get; set; }
        [JsonPropertyName("Detalles")]
        public List<AlquilerDetalleSaveModel> Detalles { get; set; }
        [JsonPropertyName("Action")]
        public Int16 Action { get; set; }
    }
}
