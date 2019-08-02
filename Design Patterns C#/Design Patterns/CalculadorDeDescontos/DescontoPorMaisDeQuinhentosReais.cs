namespace CalculadorDeDescontos
{
    public class DescontoPorMaisDeQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public decimal Desconta(Orcamento orcamento)
        {
            return orcamento.Valor > 500 ? orcamento.Valor * 0.07m : Proximo.Desconta(orcamento);
        }
    }
}