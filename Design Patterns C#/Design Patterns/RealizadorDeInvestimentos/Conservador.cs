namespace RealizadorDeInvestimentos
{
    public class Conservador : IInvestimento
    {
        public decimal Calcula(ContaBancaria contaBancaria)
        {
            return contaBancaria.Saldo * 0.008m;
        }
    }
}