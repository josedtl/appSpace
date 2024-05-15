using Space.EntityLayer;
using System.Text.Json.Serialization;

namespace Space.Server
{
    public class InfraestructuraSaveModel
    {
        public InfraestructuraSaveModel(InfraestructuraEntity Item)
        {
            this.InfraestructuraId = Item.InfraestructuraId;
            this.SucursalId = Item.SucursalId;
            this.Estado = Item.Estado;
            this.CodigoSistema = Item.CodigoSistema;
            this.CodigoInterno = Item.CodigoInterno;
            this.Descripcion = Item.Descripcion;
            this.TipoInfraestructuraId = Item.TipoInfraestructuraId;
            this.ClasificacionId = Item.ClasificacionId;
            this.InfraestructuraDimensionId = Item.InfraestructuraDimensionId;
            this.Aforo = Item.Aforo;
            this.PisoId = Item.PisoId;
            this.EstadoRegistro = Item.EstadoRegistro;
            this.FechaRegistro = Item.FechaRegistro;
            this.CodUsuario = Item.CodUsuario;
        }
        public InfraestructuraSaveModel () {
            InfraestructuraId = 0;
            SucursalId = 0;
            Estado = 0;
            CodigoSistema = String.Empty;
            CodigoInterno = String.Empty;
            Descripcion = String.Empty;
            TipoInfraestructuraId = 0;
            ClasificacionId = 0;
            InfraestructuraDimensionId = 0;
            Aforo = 0;
            PisoId = 0;
            FechaRegistro = DateTime.Now;
            CodUsuario = String.Empty;
            EstadoRegistro = true;

        }


        [JsonPropertyName("InfraestructuraId")]
        public Int32 InfraestructuraId { get; set; }

        [JsonPropertyName("SucursalId")]
        public Int32 SucursalId { get; set; }

        [JsonPropertyName("Estado")]
        public Int16 Estado { get; set; }

        
        [JsonPropertyName("CodigoSistema")]
        public String CodigoSistema { get; set; }
        
        [JsonPropertyName("CodigoInterno")]
        public String CodigoInterno { get; set; }
        
        [JsonPropertyName("Descripcion")]
        public String Descripcion { get; set; }
        
        [JsonPropertyName("TipoInfraestructuraId")]
        public Int32 TipoInfraestructuraId { get; set; }
        [JsonPropertyName("ClasificacionId")]
        public Int32 ClasificacionId { get; set; }

        [JsonPropertyName("InfraestructuraDimensionId")]
        public Int32 InfraestructuraDimensionId { get; set; }
        
        [JsonPropertyName("Aforo")]
        public Int32 Aforo { get; set; }
        
        [JsonPropertyName("PisoId")]
        public Int32 PisoId { get; set; }
        
        [JsonPropertyName("FechaRegistro")]
        public DateTime FechaRegistro { get; set; }
        
        [JsonPropertyName("CodUsuario")]
        public String CodUsuario { get; set; }
        [JsonPropertyName("EstadoRegistro")]
        public Boolean EstadoRegistro { get; set; }

    }
}
