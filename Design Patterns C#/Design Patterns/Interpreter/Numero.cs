namespace Interpreter
{
    public class Numero : IExpressao
    {
        private decimal Valor { get; set; }

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
    }
}