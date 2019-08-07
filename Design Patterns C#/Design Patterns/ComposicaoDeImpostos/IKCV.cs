using System.Linq;

namespace ComposicaoDeImpostos
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV(Imposto outroImposto) : base(outroImposto) { }

        public IKCV() : base() { }

        protected override bool DeveUserMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemMaiorQue100ReaisNo(orcamento);
        }

        protected override decimal MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1m;
        }

        protected override decimal MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06m;
        }

        private bool TemItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            return orcamento.Itens.Any(it => it.Valor > 100);
        }
    }
}
