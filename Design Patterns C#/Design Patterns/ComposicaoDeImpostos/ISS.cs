namespace ComposicaoDeImpostos
{
    public class ISS : Imposto
    {
        public ISS(Imposto outroImposto) : base(outroImposto) { }

        public ISS() : base() { }

        public override decimal Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06m + CalculoDoOutroImposto(orcamento);
        }
    }
}