namespace DecoratorPattern
{
    public class ServicioCuentasPorPagarHistorialMailDecorator : ISalvarCuentaPorPagar, ISendMailCxP
    {

        private readonly ISalvarCuentaPorPagar _decoradorPrincipal;
        private readonly ISendMailCxP _emailDecorator;
        public ServicioCuentasPorPagarHistorialMailDecorator(
            ISalvarCuentaPorPagar decoradorPrincipal,
            ISendMailCxP emailDecorator)
        {
            _decoradorPrincipal = decoradorPrincipal;
            _emailDecorator = emailDecorator;
        }

        public void SaveCxP(CuentaPorPagar cuentaPorPagar)
        {
            _decoradorPrincipal.SaveCxP(cuentaPorPagar);
            SendMail(cuentaPorPagar);
        }


        public void SendMail(CuentaPorPagar cuentaPorPagar)
        {
            _emailDecorator.SendMail(cuentaPorPagar);
        }
    }
}
