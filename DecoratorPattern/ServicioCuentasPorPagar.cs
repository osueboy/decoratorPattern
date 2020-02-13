namespace DecoratorPattern
{
    public class ServicioCuentasPorPagar : ISalvarCuentaPorPagar
    {
        ICuentaPorPagarRepository _repo;
        public ServicioCuentasPorPagar(ICuentaPorPagarRepository repo)
        {
            _repo = repo;
        }
        public void SaveCxP(CuentaPorPagar cuentaPorPagar)
        {
            _repo.Add(cuentaPorPagar);
        }
    }
}
