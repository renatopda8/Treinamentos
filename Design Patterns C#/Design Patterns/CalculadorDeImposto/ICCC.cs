namespace CalculadorDeImposto
{
    public class ICCC : IImposto
    {
        public string Nome => "ICCC";

        public decimal Calcula(Orcamento orcamento)
        {
            return orcamento.Valor < 1000
                ? orcamento.Valor * 0.05m
                : (orcamento.Valor <= 3000
                    ? orcamento.Valor * 0.07m
                    : (orcamento.Valor * 0.08m) + 30);
        }
    }
}