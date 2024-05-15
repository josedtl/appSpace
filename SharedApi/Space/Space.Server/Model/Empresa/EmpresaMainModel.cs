using Space.EntityLayer;
using System.Text.Json.Serialization;

namespace Space.Server
{
    public class EmpresaMainModel
    {
        public EmpresaMainModel()
        {
    
            this.EmpresaId = 0;
            this.TipoDocumento = String.Empty;
            this.NumDocumento = String.Empty;
            this.RazonSocial = String.Empty;
            this.NombreComercial = String.Empty;
            this.FechaRegistro = DateTime.Now;
            this.CodUsuario = String.Empty;
        }

        public EmpresaMainModel(EmpresaEntity Item)
        {
            this.EmpresaId = Item.EmpresaId;
            this.TipoDocumento = Item.TipoDocumento;
            this.NumDocumento = Item.NumDocumento;
            this.RazonSocial = Item.RazonSocial;
            this.NombreComercial = Item.NombreComercial;
            this.FechaRegistro = Item.FechaRegistro;
            this.CodUsuario = Item.CodUsuario;
        }

        [JsonPropertyName("EmpresaId")] public int EmpresaId { get; set; }
        [JsonPropertyName("TipoDocumento")] public String TipoDocumento { get; set; }
        [JsonPropertyName("NumDocumento")] public String NumDocumento { get; set; }
        [JsonPropertyName("RazonSocial")] public String RazonSocial { get; set; }
        [JsonPropertyName("NombreComercial")] public String NombreComercial { get; set; }
        [JsonPropertyName("FechaRegistro")] public DateTime FechaRegistro { get; set; }
        [JsonPropertyName("CodUsuario")] public String CodUsuario { get; set; }
    }
}
