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
    public class InfraLista
    {

  

     

        public static List<InfraListaEntity> ObtenerItemsCodigo(String codigo)
        {
            try
            {
                InfraListaDB DB = new InfraListaDB();
                return DB.ObtenerItemsCodigo(codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<InfraListaEntity> BuscarItemCodigo(String codigo, String Nombre)
        {
            try
            {
                InfraListaDB DB = new InfraListaDB();
                return DB.BuscarItemCodigo(codigo, Nombre);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<InfraListaEntity> ObtenerMain(String codigo)
        {
            try
            {
                InfraListaDB DB = new InfraListaDB();
                return DB.ObtenerMain(codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static Int32 Registrar(InfraListaEntity Ent)
        {
            try
            {
                InfraListaDB DB = new InfraListaDB();
                DB.Save(Ent);
                return Ent.ListaId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public static List<InfraListaEntity> ObtenerItem(Int32 ListaId)
        {
            try
            {
                InfraListaDB DB = new InfraListaDB();
                return DB.ObtenerItem(ListaId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<InfraListaEntity> ObtenerEnlaceItem(Int32 ListaId)
        {
            try
            {
                InfraListaDB DB = new InfraListaDB();
                return DB.ObtenerEnlaceItem(ListaId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
