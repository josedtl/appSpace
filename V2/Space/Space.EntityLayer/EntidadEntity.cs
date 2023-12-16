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

        [JsonPropertyName("FechaRegistro")]
        public DateTime FechaRegistro { get; set; }

        [JsonPropertyName("CodUsuario")]
        public String CodUsuario { get; set; }

        [JsonPropertyName("UbigeoId")]
        public Int32 UbigeoId { get; set; }




        [JsonPropertyName("Nombres")]
        public String Nombres { get; set; }

        [JsonPropertyName("ApellidoPaterno")]
        public String ApellidoPaterno { get; set; }
        [JsonPropertyName("ApellidoMaterno")]
        public String ApellidoMaterno { get; set; }

        [JsonPropertyName("FechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [JsonPropertyName("Direccion")]
        public String Direccion { get; set; }

        [JsonPropertyName("Telefono")]
        public String Telefono { get; set; }

        [JsonPropertyName("Correo")]
        public String Correo { get; set; }

        [JsonPropertyName("SexoId")]
        public Int32 SexoId { get; set; }

        [JsonPropertyName("EstadoCivilId")]
        public Int32 EstadoCivilId { get; set; }
    }


    public partial class EntidadDatoEntity : Utilitario
    {
        public EntidadDatoEntity()
               : base()
        {
            this.Nombres = GetStringDefault();
            this.ApellidoPaterno = GetStringDefault();
            this.ApellidoMaterno = GetStringDefault();
            this.FechaNacimiento = GetDateTimeDefault();
            this.Direccion = GetStringDefault();
            this.Telefono = GetStringDefault();
            this.Correo = GetStringDefault();
            this.SexoId = GetInt32Default();
            this.EstadoCivilId = GetInt32Default();
        }
        public EntidadDatoEntity(EntidadEntity i)
            : base()
        {
            this.Nombres = i.Nombres;
            this.ApellidoPaterno = i.ApellidoPaterno;
            this.ApellidoMaterno = i.ApellidoMaterno;
            this.FechaNacimiento = i.FechaNacimiento;
            this.Direccion = i.Direccion;
            this.Telefono = i.Telefono;
            this.Correo = i.Correo;
            this.SexoId = i.SexoId;
            this.EstadoCivilId = i.EstadoCivilId;
        }



        [JsonPropertyName("Nombres")]
        public String Nombres { get; set; }

        [JsonPropertyName("ApellidoPaterno")]
        public String ApellidoPaterno { get; set; }
        [JsonPropertyName("ApellidoMaterno")]
        public String ApellidoMaterno { get; set; }

        [JsonPropertyName("FechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [JsonPropertyName("Direccion")]
        public String Direccion { get; set; }

        [JsonPropertyName("Telefono")]
        public String Telefono { get; set; }

        [JsonPropertyName("Correo")]
        public String Correo { get; set; }

        [JsonPropertyName("SexoId")]
        public Int32 SexoId { get; set; }

        [JsonPropertyName("EstadoCivilId")]
        public Int32 EstadoCivilId { get; set; }
    }
}

