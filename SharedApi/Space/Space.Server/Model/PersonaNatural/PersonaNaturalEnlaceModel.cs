using Space.EntityLayer;
using System.Text.Json.Serialization;

namespace Space.Server.Model.PersonaNatural
{
    public class PersonaNaturalEnlaceModel
    {

        public PersonaNaturalEnlaceModel(PersonaNaturalEntity Item)
        {
            this.PersonaNaturalId = Item.PersonaNaturalId;
            this.NumDocumento = Item.NumDocumento;
            this.Nombres = Item.Nombres;
            this.ApellidoPaterno = Item.ApellidoPaterno;
            this.ApellidoMaterno = Item.ApellidoMaterno;
            this.TipoDocumentoIdentidadId = Item.TipoDocumentoIdentidadId;
            this.FechaRegistro = Item.FechaRegistro;
            this.CodUsuario = Item.CodUsuario;
        }
        public PersonaNaturalEnlaceModel()
        {
            this.PersonaNaturalId = 0;
            this.NumDocumento = String.Empty;
            this.Nombres = String.Empty;
            this.ApellidoPaterno = String.Empty;
            this.ApellidoMaterno = String.Empty;
            this.TipoDocumentoIdentidadId = 0;
            this.FechaRegistro = DateTime.Now;
            this.CodUsuario = String.Empty;
        }

        [JsonPropertyName("PersonaNaturalId")]
        public Int32 PersonaNaturalId { get; set; }

        [JsonPropertyName("TipoDocumentoIdentidadId")]
        public Int32 TipoDocumentoIdentidadId { get; set; }

        [JsonPropertyName("NumDocumento")]
        public String NumDocumento { get; set; }

        [JsonPropertyName("Nombres")]
        public String Nombres { get; set; }

        [JsonPropertyName("ApellidoPaterno")]
        public String ApellidoPaterno { get; set; }
        [JsonPropertyName("ApellidoMaterno")]
        public String ApellidoMaterno { get; set; } 

        [JsonPropertyName("FechaRegistro")]
        public DateTime FechaRegistro { get; set; }

        [JsonPropertyName("CodUsuario")]
        public String CodUsuario { get; set; }

        [JsonPropertyName("Action")]
        public Int16 Action { get; set; }
    }
}
