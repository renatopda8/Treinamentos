using System;

namespace CalculadorDeImposto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ISS iss = new ISS();
            ICMS icms = new ICMS();
            ICCC iccc = new ICCC();

            Orcamento orcamento = new Orcamento(500);
            Console.WriteLine("Orçamento de R$ 500,00");
            new CalculadorDeImposto(orcamento, iss);
            new CalculadorDeImposto(orcamento, icms);
            new CalculadorDeImposto(orcamento, iccc);

            Console.WriteLine();
            orcamento = new Orcamento(1200);
            Console.WriteLine("Orçamento de R$ 1200,00");
            new CalculadorDeImposto(orcamento, iss);
            new CalculadorDeImposto(orcamento, icms);
            new CalculadorDeImposto(orcamento, iccc);

            Console.WriteLine();
            orcamento = new Orcamento(3000);
            Console.WriteLine("Orçamento de R$ 3000,00");
            new CalculadorDeImposto(orcamento, iss);
            new CalculadorDeImposto(orcamento, icms);
            new CalculadorDeImposto(orcamento, iccc);

            Console.WriteLine();
            orcamento = new Orcamento(3200);
            Console.WriteLine("Orçamento de R$ 3200,00");
            new CalculadorDeImposto(orcamento, iss);
            new CalculadorDeImposto(orcamento, icms);
            new CalculadorDeImposto(orcamento, iccc);

            Console.ReadKey();
        }
    }
}