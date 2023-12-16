using System.Text.Json.Serialization;

namespace Space.EntityLayer
{
	public partial class EntidadEntity : Utilitario
	{

		public EntidadEntity()
			: base()
		{
			EntidadId = GetInt32Default();
			NumDocumento = GetStringDefault();
			Nombres = GetStringDefault();
			ApellidoPaterno = GetStringDefault();
			ApellidoMaterno = GetStringDefault();
			FechaNacimiento = GetDateTimeDefault();
			Direccion = GetStringDefault();
			Telefono = GetStringDefault();
			Correo = GetStringDefault();
			SexoId = GetInt32Default();
			EstadoCivilId = GetInt32Default();
		}
		[JsonPropertyName("EntidadId")]
		public Int32 EntidadId { get; set; }
		[JsonPropertyName("NumDocumento")]
		public String NumDocumento { get; set; }
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

