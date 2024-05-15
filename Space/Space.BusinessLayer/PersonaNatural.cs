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
    public class PersonaNatural
    {

        public static List<PersonaNaturalEntity> ObtenerMain()
        {
            PersonaNaturalDB DB = new PersonaNaturalDB();
            return DB.ObtenerMain();
        }
        public static List<PersonaNaturalEntity> ObtenerItem(Int32 PersonaNaturalId)
        {
            PersonaNaturalDB DB = new PersonaNaturalDB();
            return DB.ObtenerItem(PersonaNaturalId);
        }
        public static Int32 Registrar(PersonaNaturalEntity Ent)
        {
            Conexion.StartTransaction();
            PersonaNaturalDB DB = new PersonaNaturalDB();
            DB.Registrar(Ent);
            Conexion.EndTransaction();
            return Ent.PersonaNaturalId;
        }

        public static Int32 Actualizar(PersonaNaturalEntity Ent)
        {
            Conexion.StartTransaction();
            PersonaNaturalDB DB = new PersonaNaturalDB();
            DB.Actualizar(Ent);
            Conexion.EndTransaction();
            return Ent.PersonaNaturalId;
        }
    }
}
