namespace Space.EntityLayer
{
    public class Utilitario
    {

        public Int32 GetInt32Default()
        {
            return 0;
        }

        public Int16 GetInt16Default()
        {
            return (Int16)0;
        }

        public Decimal GetDecimalDefault()
        {
            return 0;
        }
        public Boolean GetBooleanDefault()
        {
            return false;
        }

        public String GetStringDefault()
        {
            return String.Empty;
        }

        public DateTime GetDateTimeDefault()
        {
            return new DateTime();
        }



    }

}