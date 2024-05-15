using Framework;
using Space.DataLayer;
using Space.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.BusinessLayer
{
    public class Tarifa
    {

        public List<TarifaEntity> ObtenerMain()
        {
            TarifaDB DB = new TarifaDB();
            return DB.ObtenerMain();
        }

        public Int32 Registrar(TarifaEntity Ent)
        {
            Conexion.StartTransaction();
            TarifaDB DB = new TarifaDB();
            DB.Registrar(Ent);
            Conexion.EndTransaction();
            return Ent.TarifaId;
        }

        public Int32 Actualizar(TarifaEntity Ent)
        {
            Conexion.StartTransaction();
            TarifaDB DB = new TarifaDB();
            DB.Actualizar(Ent);
            Conexion.EndTransaction();
            return Ent.TarifaId;
        }

        public List<TarifaEntity> ObtenerItem(Int32 TarifaId)
        {
            TarifaDB DB = new TarifaDB();

            return DB.ObtenerItem(TarifaId);
        }

        public List<TarifaEntity> BuscarRecurso(String Nombre, Int32 Tipo)
        {
            TarifaDB DB = new TarifaDB();
            return DB.BuscarRecurso(Nombre, Tipo);
        }

    }
}
