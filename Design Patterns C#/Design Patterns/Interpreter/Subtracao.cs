namespace Interpreter
{
    public class Subtracao : IExpressao
    {
        private IExpressao Esquerda { get; set; }
        private IExpressao Direita { get; set; }

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public int Avalia()
        {
            return Esquerda.Avalia() - Direita.Avalia();
        }
    }
}