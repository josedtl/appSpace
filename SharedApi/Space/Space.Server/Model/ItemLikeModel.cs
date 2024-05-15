namespace Space.Server
{
    public class ItemLikeModel
    {
        public ItemLikeModel()
        {
            this.srtValor1 = String.Empty;
            this.srtValor2 = String.Empty;
            this.intValor1 = 0;
            this.intValor2 = 0;
        }
        public String srtValor1 { get; set; }
        public String srtValor2 { get; set; }
        public Int32 intValor1 { get; set; }
        public Int32 intValor2 { get; set; }
    }
}
