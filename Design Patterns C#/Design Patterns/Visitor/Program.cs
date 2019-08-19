using System;

namespace Visitor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IExpressao expressao = new Soma(new Numero(110), new Subtracao(new Numero(20), new Numero(8)));
            Console.WriteLine(expressao.Avalia());

            IVisitor visitor = new ImpressoraVisitor();
            expressao.Aceita(visitor);

            Console.WriteLine("");
            visitor = new PreFixaVisitor();
            expressao.Aceita(visitor);

            Console.ReadKey();
        }
    }
}