using System;

namespace RealizadorDeInvestimentos
{
    public class Moderado : IInvestimento
    {
        public decimal Calcula(ContaBancaria contaBancaria)
        {
            return contaBancaria.Saldo * (new Random().Next(2) > 1 ? 2.5m : 0.7m);
        }
    }
}