namespace ComposicaoDeImpostos
{
    public class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto(Imposto outroImposto) : base(outroImposto) { }

        public ImpostoMuitoAlto() : base() { }

        public override decimal Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2m + CalculoDoOutroImposto(orcamento);
        }
    }
}