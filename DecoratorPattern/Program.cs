using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMailService mailService = new MailService();
            IHistorialRepository historialRepository = new HistorialRepository();
            ICuentaPorPagarRepository cuentaPorPagarRepository = new CuentaPorPagarRepository();
            ISalvarCuentaPorPagar servicioSimple = new ServicioCuentasPorPagar(cuentaPorPagarRepository);
            ISalvarCuentaPorPagar servicioHistorial = new ServicioCuentasPorPagarHistorialDecorator(servicioSimple, historialRepository);
            ISalvarCuentaPorPagar servicioMail = new ServicioCuentasPorPagarEmailDecorator(servicioSimple, mailService);
            ISalvarCuentaPorPagar servicioDoble = 
                new ServicioCuentasPorPagarHistorialMailDecorator(servicioHistorial, (ISendMailCxP)servicioMail);

            Console.WriteLine("Para guardar una Cuenta por pagar proporcione el importe");
            decimal importe = decimal.Parse(Console.ReadLine());

            CuentaPorPagar cuentaPorPagar = new CuentaPorPagar() { 
                Importe = importe,
                Id = 1,
                Naturaleza = Naturaleza.Acreedora
            };

            servicioDoble.SaveCxP(cuentaPorPagar);

            Console.ReadKey();
        }
    }
}
