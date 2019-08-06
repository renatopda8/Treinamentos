namespace CalculadorDeImposto
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        public override string Nome => "ICPP";

        public override bool DeveUserMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        public override decimal MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07m;
        }

        public override decimal MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05m;
        }
    }
}