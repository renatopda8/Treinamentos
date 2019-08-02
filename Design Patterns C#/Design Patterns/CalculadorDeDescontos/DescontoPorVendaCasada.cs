using System.Linq;

namespace CalculadorDeDescontos
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public decimal Desconta(Orcamento orcamento)
        {
            return Existe("LAPIS", orcamento) && Existe("CANETA", orcamento) ? orcamento.Valor * 0.05m : Proximo.Desconta(orcamento);
        }

        private bool Existe(string nomeDoItem, Orcamento orcamento)
        {
            return orcamento.Itens.Any(it => it.Nome.Equals(nomeDoItem));
        }
    }
}