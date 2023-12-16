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


        public EntidadEntity Save(EntidadEntity Item)
        {

            EndidadDB DB = new EndidadDB();

            return DB.Save(Item);

        }

    }
}
