using Framework;
using Space.DataLayer;
using Space.EntityLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.BusinessLayer
{
    public class Infraestructura
    {

        public static List<InfraestructuraEntity> ObtenerMain()
        {
            try
            {
                InfraestructuraDB x = new InfraestructuraDB();
                return x.ObtenerMain();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<InfraestructuraEntity> ObtenerItem(Int32 InfraestructuraId)
        {
            try
            {
                InfraestructuraDB x = new InfraestructuraDB();
                return x.ObtenerItem(InfraestructuraId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Delete(InfraestructuraEntity Actividad)
        {
            try
            {
                InfraestructuraDB row = new InfraestructuraDB();
                return row.Delete(Actividad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<InfraestructuraEntity> Delete(List<InfraestructuraEntity> Actividades)
        {
            try
            {
                InfraestructuraDB row = new InfraestructuraDB();
                return row.Delete(Actividades);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Registrar(InfraestructuraEntity Actividad)
        {
            try
            {
                InfraestructuraDB row = new InfraestructuraDB();
                return row.Registrar(Actividad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
