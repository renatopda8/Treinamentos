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

        public abstract bool DeveUserMaximaTaxacao(Orcamento orcamento);
        public abstract decimal MaximaTaxacao(Orcamento orcamento);
        public abstract decimal MinimaTaxacao(Orcamento orcamento);
    }
}