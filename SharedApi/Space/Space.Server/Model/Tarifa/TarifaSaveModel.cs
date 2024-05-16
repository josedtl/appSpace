using Space.EntityLayer;
using System.Text.Json.Serialization;

namespace Space.Server.Model.Tarifa
{
    public class TarifaSaveModel
    {
        public TarifaSaveModel()
        {
            TarifaId = 0;
            ObjetoReferenciaId = 0;
            Correlativo = String.Empty;
            NomTarifa = String.Empty;
            NomComercial = String.Empty;
            Descripcion = String.Empty;
            FechaRegistro = DateTime.Now;
            CodUsuario = String.Empty;
            EstadoRegistro = true;
            TipoTarifaEnum = 0;
            CostoTarifa = 0;
            MonedaId = 0;
            UnidadMedidaId = 0;
            NomCompleto = String.Empty;
        }
        public TarifaSaveModel(TarifaEntity Item)
        {
            this.TarifaId = Item.TarifaId;
            this.ObjetoReferenciaId = Item.ObjetoReferenciaId;
            this.Correlativo = Item.Correlativo;
            this.NomTarifa = Item.NomTarifa;
            this.NomComercial = Item.NomComercial;
            this.Descripcion = Item.Descripcion;
            this.FechaRegistro = Item.FechaRegistro;
            this.CodUsuario = Item.CodUsuario;
            this.EstadoRegistro = Item.EstadoRegistro;
            this.TipoTarifaEnum = Item.TipoTarifaEnum;
            this.CostoTarifa = Item.CostoTarifa;
            this.MonedaId = Item.MonedaId;
            this.MonedaId = Item.MonedaId;
            this.UnidadMedidaId = Item.UnidadMedidaId;
            this.NomCompleto = Item.NomCompleto;
        }
        [JsonPropertyName("TarifaId")]
        public Int32 TarifaId { get; set; }
        [JsonPropertyName("ObjetoReferenciaId")]
        public Int32 ObjetoReferenciaId { get; set; }
        [JsonPropertyName("TipoTarifaEnum")]
        public Int16 TipoTarifaEnum { get; set; }
        [JsonPropertyName("CostoTarifa")]
        public Decimal CostoTarifa { get; set; }
        [JsonPropertyName("MonedaId")]
        public Int32 MonedaId { get; set; }
        [JsonPropertyName("UnidadMedidaId")]
        public Int32 UnidadMedidaId { get; set; }
        [JsonPropertyName("Correlativo")]
        public String Correlativo { get; set; }
        [JsonPropertyName("NomTarifa")]
        public String NomTarifa { get; set; }
        [JsonPropertyName("NomComercial")]
        public String NomComercial { get; set; }
        [JsonPropertyName("Descripcion")]
        public String Descripcion { get; set; }
        [JsonPropertyName("FechaRegistro")]
        public DateTime FechaRegistro { get; set; }
        [JsonPropertyName("CodUsuario")]
        public String CodUsuario { get; set; }
        [JsonPropertyName("EstadoRegistro")]
        public Boolean EstadoRegistro { get; set; }
        [JsonPropertyName("NomCompleto")]
        public string NomCompleto { get; set; }
    }
}
