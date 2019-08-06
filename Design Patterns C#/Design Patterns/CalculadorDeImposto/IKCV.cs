using System.Linq;

namespace CalculadorDeImposto
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public override string Nome => "IKCV";

        public override bool DeveUserMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemMaiorQue100ReaisNo(orcamento);
        }

        public override decimal MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1m;
        }

        public override decimal MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06m;
        }

        public bool TemItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            return orcamento.Itens.Any(it => it.Valor > 100);
        }
    }
}