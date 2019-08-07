namespace ComposicaoDeImpostos
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public TemplateDeImpostoCondicional(Imposto outroImposto) : base(outroImposto) { }

        public TemplateDeImpostoCondicional() : base() { }

        public override decimal Calcula(Orcamento orcamento)
        {
            return (DeveUserMaximaTaxacao(orcamento) ? MaximaTaxacao(orcamento) : MinimaTaxacao(orcamento)) + CalculoDoOutroImposto(orcamento);
        }

        protected abstract bool DeveUserMaximaTaxacao(Orcamento orcamento);
        protected abstract decimal MaximaTaxacao(Orcamento orcamento);
        protected abstract decimal MinimaTaxacao(Orcamento orcamento);
    }
}