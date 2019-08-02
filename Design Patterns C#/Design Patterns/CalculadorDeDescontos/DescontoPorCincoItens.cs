namespace CalculadorDeDescontos
{
    public class DescontoPorCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public decimal Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1m;
            }

            return Proximo.Desconta(orcamento);
        }
    }
}