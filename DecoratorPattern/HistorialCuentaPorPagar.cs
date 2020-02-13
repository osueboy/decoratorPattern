using System;

namespace DecoratorPattern
{
    public class HistorialCuentaPorPagar
    {
        public int Id { get; set; }
        public CuentaPorPagar Cuenta { get; set; }
        public DateTime FechaCreacion {get;set;}
    }
}
