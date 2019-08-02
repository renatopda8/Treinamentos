namespace CalculadorDeDescontos
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public decimal Desconta(Orcamento orcamento)
        {
            return decimal.Zero;
        }
    }
}