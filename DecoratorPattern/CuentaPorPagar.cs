using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class CuentaPorPagar
    {
        public int Id { get; set; }
        public decimal Importe { get; set; }
        public Naturaleza Naturaleza { get; set; }
    }
}
