namespace CalculadorDeImposto
{
    public abstract class TemplateDeImpostoCondicional : IImposto
    {
        public abstract string Nome { get; }

        public decimal Calcula(Orcamento orcamento)
        {
            if (DeveUserMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }

            return MinimaTaxacao(orcamento);
        }

        protected abstract bool DeveUserMaximaTaxacao(Orcamento orcamento);
        protected abstract decimal MaximaTaxacao(Orcamento orcamento);
        protected abstract decimal MinimaTaxacao(Orcamento orcamento);
    }
}