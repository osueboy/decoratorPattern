namespace DecoratorPattern
{
    public class ServicioCuentasPorPagarEmailDecorator : ISalvarCuentaPorPagar, ISendMailCxP
    {
        private readonly ISalvarCuentaPorPagar _servicioPrincipal;
        private readonly IMailService _mailService;

        public ServicioCuentasPorPagarEmailDecorator(ISalvarCuentaPorPagar service, IMailService mailService)
        {
            _mailService = mailService;
            _servicioPrincipal = service;
        }
        public void SaveCxP(CuentaPorPagar cuentaPorPagar)
        {
            _servicioPrincipal.SaveCxP(cuentaPorPagar);
            SendMail(cuentaPorPagar);
        }

        public void SendMail(CuentaPorPagar cuentaPorPagar)
        {
            _mailService.Send("destino", 
                string.Format("se creó la cuenta {0} con importe {1}", cuentaPorPagar.Id, cuentaPorPagar.Importe));
        }
    }
}
