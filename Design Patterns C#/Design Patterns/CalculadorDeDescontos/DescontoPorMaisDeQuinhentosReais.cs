namespace CalculadorDeDescontos
{
    public class DescontoPorMaisDeQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public decimal Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07m;
            }

            return Proximo.Desconta(orcamento);
        }
    }
}