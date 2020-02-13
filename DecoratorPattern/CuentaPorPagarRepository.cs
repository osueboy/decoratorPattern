using System;

namespace DecoratorPattern
{
    public class CuentaPorPagarRepository : ICuentaPorPagarRepository
    {
        public void Add(CuentaPorPagar cuentaPorPagar)
        {
            Console.WriteLine("Se guardo la cuenta por pagar {0}, importe {1}",
                cuentaPorPagar.Id, 
                cuentaPorPagar.Importe);
        }
    }
}
