namespace Visitor
{
    public class Soma : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public decimal Avalia()
        {
            return Esquerda.Avalia() + Direita.Avalia();
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeSoma(this);
        }
    }
}