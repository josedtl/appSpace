using Space.EntityLayer;
using System.Text.Json.Serialization;

namespace Space.Server.Model.Tarifa
{
    public class TarifaMainModel
    {
        public TarifaMainModel()
        {
            TarifaId = 0;
            Correlativo = String.Empty;
            NomTarifa = String.Empty;
            NomComercial = String.Empty;
            Descripcion = String.Empty;
            FechaRegistro = DateTime.Now;
            CodUsuario = String.Empty;
            EstadoRegistro = true;
            CodigoUnidad = string.Empty;
            SimboloMoneda = String.Empty;
            TipoTarifaEnum = 0;
            CostoTarifa = 0;
        }
        public TarifaMainModel(TarifaEntity Item)
        {
            this.TarifaId = Item.TarifaId;
            this.Correlativo = Item.Correlativo;
            this.NomTarifa = Item.NomTarifa;
            this.NomComercial = Item.NomComercial;
            this.Descripcion = Item.Descripcion;
            this.FechaRegistro = Item.FechaRegistro;
            this.CodUsuario = Item.CodUsuario;
            this.EstadoRegistro = Item.EstadoRegistro;
            this.CodigoUnidad = Item.CodigoUnidad;
            this.SimboloMoneda = Item.SimboloMoneda;
            this.CostoTarifa = Item.CostoTarifa;
            this.TipoTarifaEnum = Item.TipoTarifaEnum;
        }
        [JsonPropertyName("TarifaId")] public Int32 TarifaId { get; set; }
        [JsonPropertyName("Correlativo")]public String Correlativo { get; set; }

        [JsonPropertyName("NomTarifa")] public String NomTarifa { get; set; }
        [JsonPropertyName("NomComercial")] public String NomComercial { get; set; }
        [JsonPropertyName("Descripcion")] public String Descripcion { get; set; }
        [JsonPropertyName("FechaRegistro")] public DateTime FechaRegistro { get; set; }
        [JsonPropertyName("CodUsuario")] public String CodUsuario { get; set; }
        [JsonPropertyName("EstadoRegistro")] public Boolean EstadoRegistro { get; set; }
        [JsonPropertyName("CodigoUnidad")] public String CodigoUnidad { get; set; }
        [JsonPropertyName("SimboloMoneda")] public String SimboloMoneda { get; set; }
        [JsonPropertyName("TipoTarifaEnum")] public Int16 TipoTarifaEnum { get; set; }
        [JsonPropertyName("CostoTarifa")] public decimal CostoTarifa { get; set; }
    }
}
