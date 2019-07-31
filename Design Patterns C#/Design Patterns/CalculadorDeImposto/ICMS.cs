namespace CalculadorDeImposto
{
    public class ICMS : IImposto
    {
        public string Nome => "ICMS";

        public decimal Calcula(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.05m) + 50;
        }
    }
}