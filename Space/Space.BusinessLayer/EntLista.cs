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
    public class EntLista
    {
        public static List<EntListaEntity> ObtenerCodigo(String codigo)
        {
            EntListaDB DB = new EntListaDB();
            return DB.ObtenerCodigo(codigo);
        }

        public static Int32 SaveDB(EntListaEntity Ent)
        {
            Conexion.StartTransaction();
            EntListaDB DB = new EntListaDB();
            DB.Save(Ent);
            Conexion.EndTransaction();
            return Ent.ListaId;
        }


        public static Int32 Update(EntListaEntity Ent)
        {
            Conexion.StartTransaction();
            EntListaDB DB = new EntListaDB();
            DB.Update(Ent);
            Conexion.EndTransaction();
            return Ent.ListaId;
        }

        public static List<EntListaEntity> GetListaRelacion_Main(String codigo)
        {
            EntListaDB DB = new EntListaDB();
            return DB.GetListaRelacion_Main(codigo);
        }
        public static List<EntListaEntity> GetListaRelacionLike(String codigo, String Nombre)
        {
            EntListaDB DB = new EntListaDB();
            return DB.GetListaRelacionLike(codigo, Nombre);
        }



    }
}
