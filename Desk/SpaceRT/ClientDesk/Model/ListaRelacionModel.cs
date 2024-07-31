
using System;

namespace ClientDesk.Model
{
    public class ListaRelacionModel
    {

        public ListaRelacionModel()
        {
            this.ListaId = 0;
            this.Nombre = String.Empty;
        }
        public Int32 ListaId { get; set; }
        public String Nombre { get; set; }

    }
}
