using Space.EntityLayer;
using System.Text.Json.Serialization;

namespace Space.Server.Model.Tarifa
{
    public class TarifaBuscarItem
    {
        public TarifaBuscarItem()
        {
            TarifaId = 0;
            NomComercial = String.Empty;
            TipoTarifaEnum = 0;
        }

        public TarifaBuscarItem(TarifaEntity Ent)
        {
            this.TarifaId= Ent.TarifaId;
            this.NomComercial = Ent.NomComercial;
            this.TipoTarifaEnum = Ent.TipoTarifaEnum;
        }


        [JsonPropertyName("TarifaId")]
        public Int32 TarifaId { get; set; }
        [JsonPropertyName("NomComercial")]
        public string NomComercial { get; set; }

        [JsonPropertyName("TipoTarifaEnum")]
        public Int16 TipoTarifaEnum { get; set; }

    }
}
