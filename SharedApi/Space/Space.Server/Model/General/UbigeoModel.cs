using Space.EntityLayer;
using System.Text.Json.Serialization;

namespace Space.Server.Model.General
{
    public class UbigeoModel
    {
        public UbigeoModel()
        {
            this.UbigeoId = 0;
            this.CodUbigeo = String.Empty;
            this.DesUbigeo = String.Empty;
        }

        public UbigeoModel(UbigeoEntity Ent)
        {
            this.UbigeoId = Ent.UbigeoId;
            this.CodUbigeo = Ent.CodUbigeo;
            this.DesUbigeo = Ent.DesUbigeo;
        }
        [JsonPropertyName("UbigeoId")]
        public Int32 UbigeoId { get; set; }
        [JsonPropertyName("CodUbigeo")]
        public String CodUbigeo { get; set; }
        [JsonPropertyName("DesUbigeo")]
        public String DesUbigeo { get; set; }
    }
}
