namespace ComposicaoDeImpostos
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }

        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        public Imposto() {
            this.OutroImposto = null;
        }

        public abstract decimal Calcula(Orcamento orcamento);

        protected decimal CalculoDoOutroImposto(Orcamento orcamento)
        {
            return OutroImposto?.Calcula(orcamento) ?? decimal.Zero;
        }
    }
}