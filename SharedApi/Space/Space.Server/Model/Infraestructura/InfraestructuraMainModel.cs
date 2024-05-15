using Space.EntityLayer;
using System.Text.Json.Serialization;

namespace Space.Server
{
    public class InfraestructuraMainModel
    {

        public InfraestructuraMainModel(InfraestructuraEntity Item) {
        
            this.InfraestructuraId = Item.InfraestructuraId;
            this.Sucursal = Item.Sucursal;
            this.CodigoSistema = Item.CodigoSistema;
            this.CodigoInterno  = Item.CodigoInterno;   
            this.Descripcion = Item.Descripcion;    
            this.TipoInfraestructura  = Item.TipoInfraestructura;
            this.Clasificacion = Item.Clasificacion;
            this.InfraestructuraDimension = Item.InfraestructuraDimension;
            this.Aforo = Item.Aforo;
            this.Piso  = Item.Piso;
            this.FechaRegistro = Item.FechaRegistro;
            this.CodUsuario = Item.CodUsuario;
            this.EstadoRegistro = Item.EstadoRegistro;

        }


        [JsonPropertyName("InfraestructuraId")]
        public Int32 InfraestructuraId { get; set; }

        [JsonPropertyName("Sucursal")]
        public String Sucursal { get; set; }
        [JsonPropertyName("CodigoSistema")]
        public String CodigoSistema { get; set; }
        [JsonPropertyName("CodigoInterno")]
        public String CodigoInterno { get; set; }
        [JsonPropertyName("Descripcion")]
        public String Descripcion { get; set; }
        [JsonPropertyName("TipoInfraestructura")]
        public String TipoInfraestructura { get; set; }
        [JsonPropertyName("Clasificacion")]
        public String Clasificacion { get; set; }
        [JsonPropertyName("InfraestructuraDimension")]
        public String InfraestructuraDimension { get; set; }
        [JsonPropertyName("Aforo")]
        public Int32 Aforo { get; set; }
        [JsonPropertyName("Piso")]
        public String Piso { get; set; }
        [JsonPropertyName("FechaRegistro")]
        public DateTime FechaRegistro { get; set; }
        [JsonPropertyName("CodUsuario")]
        public String CodUsuario { get; set; }
        [JsonPropertyName("EstadoRegistro")]
        public Boolean EstadoRegistro { get; set; }
    }
}
