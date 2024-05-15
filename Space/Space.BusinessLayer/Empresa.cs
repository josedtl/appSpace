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
            EmpresaDB DB = new EmpresaDB();
            DB.Registrar(Ent);
            return Ent.EmpresaId;
        }

     

    }
}
