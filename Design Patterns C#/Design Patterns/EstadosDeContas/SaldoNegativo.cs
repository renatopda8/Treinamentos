using System;

namespace EstadosDeContas
{
    public class SaldoNegativo : IEstadoDeConta
    {
        public void Deposita(Conta conta, decimal valor)
        {
            conta.Saldo += valor * 0.95m;
            if (conta.Saldo > decimal.Zero)
            {
                conta.Estado = new SaldoPositivo();
            }
        }

        public void Saca(Conta conta, decimal valor)
        {
            throw new Exception("Saque não disponível para conta com saldo negativo");
        }
    }
}