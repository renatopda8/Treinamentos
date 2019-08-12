namespace EstadosDeContas
{
    public class SaldoPositivo : IEstadoDeConta
    {
        public void Deposita(Conta conta, decimal valor)
        {
            conta.Saldo += valor * 0.98m;
        }

        public void Saca(Conta conta, decimal valor)
        {
            conta.Saldo -= valor;
            if (conta.Saldo <= 0)
            {
                conta.Estado = new SaldoNegativo();
            }
        }
    }
}