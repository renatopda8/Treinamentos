namespace CalculadorDeImposto
{
    public class ISS : IImposto
    {
        public string Nome => "ISS";

        public decimal Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06m;
        }
    }
}