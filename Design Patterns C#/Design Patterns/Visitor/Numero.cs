namespace Visitor
{
    public class Numero : IExpressao
    {
        public decimal Valor { get; private set; }

        public Numero(int valor)
        {
            Valor = valor;
        }

        public Numero(decimal valor)
        {
            Valor = valor;
        }

        public decimal Avalia()
        {
            return Valor;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeNumero(this);
        }
    }
}