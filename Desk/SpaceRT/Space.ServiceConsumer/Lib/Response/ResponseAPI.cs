using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.ServiceConsumer
{
    public class ResponseAPI<T>
    {

        public ResponseAPI()
        {
            State = true;
            Message = "";
        }

        public bool State { get; set; }
        public string? Message { get; set; }
        public T Value { get; set; }
    }
}
