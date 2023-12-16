using System.Text.Json.Serialization;

namespace Space.EntityLayer
{
    public partial class EntidadEntity : Utilitario
    {

        public EntidadEntity()
            : base()
        {
            this.EntidadId = GetInt32Default();
            this.TipoEntidadId = GetInt32Default();
            this.TipoDocumentoIdentidadId = GetInt32Default();
            this.NumDocumento = GetStringDefault();
            this.NombreCompleto = GetStringDefault();
            this.FechaRegistro = GetDateTimeDefault();
            this.CodUsuario = GetStringDefault();
            this.UbigeoId = GetInt32Default();
        }

        [JsonPropertyName("EntidadId")]
        public Int32 EntidadId { get; set; }

        [JsonPropertyName("TipoEntidadId")]

        public Int32 TipoEntidadId { get; set; }

        [JsonPropertyName("TipoDocumentoIdentidadId")]
        public Int32 TipoDocumentoIdentidadId { get; set; }

        [JsonPropertyName("NumDocumento")]
        public String NumDocumento { get; set; }

        [JsonPropertyName("NombreCompleto")]
        public String NombreCompleto { get; set; }

        [JsonPropertyName("FechaRegistro")]
        public DateTime FechaRegistro { get; set; }

        [JsonPropertyName("CodUsuario")]
        public String CodUsuario { get; set; }

        [JsonPropertyName("UbigeoId")]
        public Int32 UbigeoId { get; set; }

    }
}

