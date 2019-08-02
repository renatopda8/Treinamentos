namespace CalculadorDeDescontos
{
    public class DescontoPorCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public decimal Desconta(Orcamento orcamento)
        {
            return orcamento.Itens.Count > 5 ? orcamento.Valor * 0.1m : Proximo.Desconta(orcamento);
        }
    }
}