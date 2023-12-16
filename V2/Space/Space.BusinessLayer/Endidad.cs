using Space.EntityLayer;
using Space.DataLayer;


namespace Space.BusinessLayer
{


    public class Endidad
    {
        public List<EntidadEntity> GetEndidad()
        {

            EndidadDB DB = new EndidadDB();

            return DB.GetEndidad();

        }

    }
}
