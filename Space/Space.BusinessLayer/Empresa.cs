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
    public class Empresa
    {
        public static List<EmpresaEntity> GetEmpresaMain()
        {
            EmpresaDB DB = new EmpresaDB();
            return DB.GetEmpresaMain();
        }
        public static List<EmpresaEntity> GetEmpresaItem(Int32 EmpresaId)
        {
            EmpresaDB DB = new EmpresaDB();
            return DB.GetEmpresaItem(EmpresaId);
        }
        public static Int32 Save(EmpresaEntity Ent)
        {
            Conexion.StartTransaction();
            EmpresaDB DB = new EmpresaDB();
            DB.Save(Ent);
            Conexion.EndTransaction();
            return Ent.EmpresaId;
        }

        public static Int32 Update(EmpresaEntity Ent)
        {
            Conexion.StartTransaction();
            EmpresaDB DB = new EmpresaDB();
            DB.Update(Ent);
            Conexion.EndTransaction();
            return Ent.EmpresaId;
        }


    }
}
