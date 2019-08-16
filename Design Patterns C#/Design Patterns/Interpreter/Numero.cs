namespace Interpreter
{
    public class Numero : IExpressao
    {
        private int Valor { get; set; }

        public Numero(int valor)
        {
            Valor = valor;
        }

        public int Avalia()
        {
            return Valor;
        }
    }
}