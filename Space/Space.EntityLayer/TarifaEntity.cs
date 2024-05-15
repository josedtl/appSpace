using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.EntityLayer
{
    public partial class TarifaEntity : BaseEntityObject
    {
        public TarifaEntity()
        {
            TarifaId = GetInt32Default();
            ObjetoReferenciaId = GetInt32Default();
            Correlativo = GetStringDefault();
            NomTarifa = GetStringDefault();
            NomComercial = GetStringDefault();
            Descripcion = GetStringDefault();
            FechaRegistro = DateTime.Now;
            CodUsuario = GetStringDefault();
            EstadoRegistro = GetBooleanDefault();
            TipoTarifaEnum = GetInt16Default();
            CostoTarifa = GetDecimalDefault();
            MonedaId = GetInt32Default();
            UnidadMedidaId = GetInt32Default();
        }

        public Int32 TarifaId { get; set; }
        public Int32 ObjetoReferenciaId { get; set; }
        public Int16 TipoTarifaEnum { get; set; }
        public Decimal CostoTarifa { get; set; }
        public Int32 MonedaId { get; set; }
        public Int32 UnidadMedidaId { get; set; }
        public String Correlativo { get; set; }
        public String NomTarifa { get; set; }
        public String NomComercial { get; set; }
        public String Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public String CodUsuario { get; set; }
        public Boolean EstadoRegistro { get; set; }


    }
}
