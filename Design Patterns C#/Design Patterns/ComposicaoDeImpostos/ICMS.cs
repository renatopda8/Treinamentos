namespace ComposicaoDeImpostos
{
    public class ICMS : Imposto
    {
        public ICMS(Imposto outroImposto) : base(outroImposto) { }

        public ICMS() : base() { }

        public override decimal Calcula(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.05m) + 50 + CalculoDoOutroImposto(orcamento);
        }
    }
}