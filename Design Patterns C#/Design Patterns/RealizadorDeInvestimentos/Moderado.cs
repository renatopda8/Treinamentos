using System;

namespace RealizadorDeInvestimentos
{
    public class Moderado : IInvestimento
    {
        private Random Random { get; }

        public Moderado()
        {
            this.Random = new Random();
        }

        public decimal Calcula(ContaBancaria contaBancaria)
        {
            return contaBancaria.Saldo * (Random.Next(101) < 50 ? 0.025m : 0.007m);
        }
    }
}