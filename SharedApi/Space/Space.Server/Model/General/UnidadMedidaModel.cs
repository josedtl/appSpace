using Space.EntityLayer;
using System.Text.Json.Serialization;

namespace Space.Server.Model.General
{
    public class UnidadMedidaModel
    {
        public UnidadMedidaModel()
        {

            UnidadMedidaId = 0;
            Codigo = String.Empty;
            CodigoComercial = String.Empty;
            Nombre = String.Empty;
            FechaRegistro = DateTime.Now;
            CodUsuario = String.Empty;
            EstadoRegistro = true;

        }

        public UnidadMedidaModel(UnidadMedidadEntity Ent)
        {
            this.UnidadMedidaId = Ent.UnidadMedidaId;
            this.Codigo = Ent.Codigo;
            this.CodigoComercial = Ent.CodigoComercial;
            this.Nombre = Ent.Nombre;
            this.FechaRegistro = Ent.FechaRegistro;
            this.CodUsuario = Ent.CodUsuario;
            this.EstadoRegistro = Ent.EstadoRegistro;

        }
        [JsonPropertyName("UnidadMedidaId")]
        public Int32 UnidadMedidaId { get; set; }
        [JsonPropertyName("Codigo")]
        public String Codigo { get; set; }
        [JsonPropertyName("CodigoComercial")]
        public String CodigoComercial { get; set; }
        [JsonPropertyName("Nombre")]
        public String Nombre { get; set; }
        [JsonPropertyName("FechaRegistro")]
        public DateTime FechaRegistro { get; set; }
        [JsonPropertyName("CodUsuario")]
        public String CodUsuario { get; set; }
        [JsonPropertyName("EstadoRegistro")]
        public Boolean EstadoRegistro { get; set; }
    }
}
