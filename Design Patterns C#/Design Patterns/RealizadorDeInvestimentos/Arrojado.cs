using System;

namespace RealizadorDeInvestimentos
{
    public class Arrojado : IInvestimento
    {
        private Random Random { get; }

        public Arrojado()
        {
            this.Random = new Random();
        }

        public decimal Calcula(ContaBancaria contaBancaria)
        {
            int chance = Random.Next(101);
            return contaBancaria.Saldo * (chance < 20 ? 0.05m : (chance < 30 ? 0.03m : 0.006m));
        }
    }
}