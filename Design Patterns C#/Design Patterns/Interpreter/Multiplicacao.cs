namespace Interpreter
{
    public class Multiplicacao : IExpressao
    {
        private IExpressao Esquerda { get; set; }
        private IExpressao Direita { get; set; }

        public Multiplicacao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public decimal Avalia()
        {
            return Esquerda.Avalia() * Direita.Avalia();
        }
    }
}
