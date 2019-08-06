using System.Linq;

namespace CalculadorDeImposto
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public override string Nome => "IHIT";

        protected override bool DeveUserMaximaTaxacao(Orcamento orcamento)
        {
            return ExisteMaisDeUmItemComMesmoNomeNo(orcamento);
        }

        protected override decimal MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13m + 100;
        }

        protected override decimal MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01m * orcamento.Itens.Count);
        }

        private bool ExisteMaisDeUmItemComMesmoNomeNo(Orcamento orcamento)
        {
            return orcamento.Itens.GroupBy(it => it.Nome).Any(g => g.Count() > 1);
        }
    }
}