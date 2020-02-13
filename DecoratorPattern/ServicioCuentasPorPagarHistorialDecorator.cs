using System;

namespace DecoratorPattern
{
    public class ServicioCuentasPorPagarHistorialDecorator : ISalvarCuentaPorPagar, ISalvarHistorialCxP
    {
        private readonly ISalvarCuentaPorPagar _servicioPrincipal;
        private readonly IHistorialRepository _historialRepository;

        public ServicioCuentasPorPagarHistorialDecorator(ISalvarCuentaPorPagar servicio, IHistorialRepository historialRepository)
        {
            _servicioPrincipal = servicio;
            _historialRepository = historialRepository;
        }
        public void SaveCxP(CuentaPorPagar cuentaPorPagar)
        {
            _servicioPrincipal.SaveCxP(cuentaPorPagar);
            SaveHistoric(cuentaPorPagar);
        }

        public void SaveHistoric(CuentaPorPagar cuentaPorPagar)
        {
            _historialRepository.Add(
                new HistorialCuentaPorPagar() { 
                    Id = 2908, 
                    Cuenta = cuentaPorPagar, 
                    FechaCreacion = new DateTime()
                });
        }
    }
}
