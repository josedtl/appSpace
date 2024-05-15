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
    public class Servicio
    {
        public List<ServicioEntity> ObtenerMain()
        {
            ServicioDB DB = new ServicioDB();
            return DB.ObtenerMain();
        }
        public Int32 Registrar(ServicioEntity Ent)
        {
            Conexion.StartTransaction();
            ServicioDB DB = new ServicioDB();
            DB.Registrar(Ent);
            Conexion.EndTransaction();
            return Ent.ServicioId;
        }
        public Int32 Actualizar(ServicioEntity Ent)
        {
            Conexion.StartTransaction();
            ServicioDB DB = new ServicioDB();
            DB.Actualizar(Ent);
            Conexion.EndTransaction();
            return Ent.ServicioId;
        }

        public List<ServicioEntity> ObtenerItem(Int32 ServicioId)
        {
            ServicioDB DB = new ServicioDB();
            return DB.ObtenerItem(ServicioId);
        }

    }
}
