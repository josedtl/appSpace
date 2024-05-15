using Space.EntityLayer;
using System.Text.Json.Serialization;

namespace Space.Server.Model.Tarifa
{
    public class TarifaBuscarRecursoModel
    {
        public TarifaBuscarRecursoModel()
        {
            ObjetoReferenciaId = 0;
            NomCompleto = String.Empty;
            TipoTarifaEnum = 0;
        }

        public TarifaBuscarRecursoModel(TarifaEntity Ent)
        {
            this.ObjetoReferenciaId= Ent.ObjetoReferenciaId;
            this.NomCompleto = Ent.NomCompleto;
            this.TipoTarifaEnum = Ent.TipoTarifaEnum;
        }


        [JsonPropertyName("ObjetoReferenciaId")]
        public Int32 ObjetoReferenciaId { get; set; }
        [JsonPropertyName("NomCompleto")]
        public string NomCompleto { get; set; }

        [JsonPropertyName("TipoTarifaEnum")]
        public Int16 TipoTarifaEnum { get; set; }

    }
}
