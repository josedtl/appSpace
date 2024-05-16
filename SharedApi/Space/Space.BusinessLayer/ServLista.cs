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
    public class ServLista
    {
        public static List<ServListaEntity> ObtenerServListaCodigo(String codigo)
        {
            ServListaDB DB = new ServListaDB();
            return DB.ObtenerServListaCodigo(codigo);
        }
        public static List<ServListaEntity> BuscarServLista(String codigo, String Nombre)
        {
            ServListaDB DB = new ServListaDB();
            return DB.BuscarServLista(codigo, Nombre);
        }

        public static List<ServListaEntity> ObtenerServListaMain(String codigo)
        {
            ServListaDB DB = new ServListaDB();
            return DB.ObtenerServListaMain(codigo);
        }
        public static Int32 Registrar(ServListaEntity Ent)
        {
            ServListaDB DB = new ServListaDB();
            DB.Registrar(Ent);
            return Ent.ListaId;
        }

    
        public static List<ServListaEntity> ObtenerServListaItem(Int32 ListaId)
        {
            ServListaDB DB = new ServListaDB();
            return DB.ObtenerServListaItem(ListaId);
        }
    }
}
