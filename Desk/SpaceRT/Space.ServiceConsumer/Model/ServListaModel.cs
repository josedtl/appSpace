﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.ServiceConsumer
{
    public class ServListaModel
    {
        public ServListaModel()
        {
            this.ListaId = 0;
            this.Nombre = String.Empty;
        }
        public Int32 ListaId { get; set; }
        public String Nombre { get; set; }
    }
}