using Space.EntityLayer;
using System.Text.Json.Serialization;

namespace Space.Server
{
    public class InfraestructuraFiltroModel
    {

        public InfraestructuraFiltroModel(InfraestructuraEntity Item) {
        
            this.InfraestructuraId = Item.InfraestructuraId;
            this.ClasificacionId = Item.ClasificacionId;
            this.PisoId = Item.PisoId;
            this.EstadoAdministrativoId = Item.EstadoAdministrativoId;
            this.Clasificacion = Item.Clasificacion;
            this.Piso  = Item.Piso;
            this.EstadoAdministrativo = Item.EstadoAdministrativo;
            this.CodigoInterno =Item.CodigoInterno;
            this.TipoInfraestructuraId =Item.TipoInfraestructuraId;
            this.TipoInfraestructura =Item.TipoInfraestructura;
        }


        [JsonPropertyName("InfraestructuraId")]
        public Int32 InfraestructuraId { get; set; }

        [JsonPropertyName("PisoId")]
        public Int32 PisoId { get; set; }

        [JsonPropertyName("ClasificacionId")]
        public Int32 ClasificacionId { get; set; }

        [JsonPropertyName("EstadoAdministrativoId")]
        public Int32 EstadoAdministrativoId { get; set; }

        [JsonPropertyName("Clasificacion")]
        public String Clasificacion { get; set; }

        [JsonPropertyName("Piso")]
        public String Piso { get; set; }

        [JsonPropertyName("EstadoAdministrativo")]
        public String EstadoAdministrativo { get; set; }


        [JsonPropertyName("CodigoInterno")]
        public String CodigoInterno { get; set; }

        [JsonPropertyName("TipoInfraestructuraId")]
        public Int32 TipoInfraestructuraId { get; set; }

        [JsonPropertyName("TipoInfraestructura")]
        public String TipoInfraestructura { get; set; }
    }
}
