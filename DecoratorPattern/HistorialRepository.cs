using System;

namespace DecoratorPattern
{
    public class HistorialRepository : IHistorialRepository
    {
        public void Add(HistorialCuentaPorPagar historialCuentaPorPagar)
        {
            Console.WriteLine("Se guardó historial con Id {0}, de cuenta {1}", historialCuentaPorPagar.Id, historialCuentaPorPagar.Cuenta.Id);
        }
    }
}
