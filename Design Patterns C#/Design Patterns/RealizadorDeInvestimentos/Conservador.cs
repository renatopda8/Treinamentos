namespace RealizadorDeInvestimentos
{
    class Conservador : IInvestimento
    {
        public decimal Calcula(ContaBancaria contaBancaria)
        {
            return contaBancaria.Saldo * 0.8m;
        }
    }
}
