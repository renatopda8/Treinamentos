using System;

namespace Interpreter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IExpressao expressao = new Soma(new Numero(10), new Subtracao(new Numero(20), new Numero(5)));
            Console.WriteLine(expressao.Avalia());
            Console.ReadKey();
        }
    }
}