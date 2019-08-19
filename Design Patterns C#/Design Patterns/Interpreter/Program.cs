using System;

namespace Interpreter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //IExpressao expressao = new RaizQuadrada(new Numero(4));
            IExpressao expressao = new Soma(new Numero(110), new Subtracao(new Divisao(new Numero(20), new Numero(8)), new Multiplicacao(new Numero(5), new Numero(10))));
            Console.WriteLine(expressao.Avalia());
            Console.ReadKey();
        }
    }
}