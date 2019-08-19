namespace Interpreter
{
    public class Soma : IExpressao
    {
        private IExpressao Esquerda { get; set; }
        private IExpressao Direita { get; set; }

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public decimal Avalia()
        {
            return Esquerda.Avalia() + Direita.Avalia();
        }
    }
}