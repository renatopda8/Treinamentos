using System;

namespace RealizadorDeInvestimentos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IInvestimento conservador = new Conservador();
            IInvestimento moderado = new Moderado();
            IInvestimento arrojado = new Arrojado();

            ContaBancaria contaBancaria = new ContaBancaria(600);
            new RealizadorDeInvestimentos(conservador, contaBancaria);
            contaBancaria = new ContaBancaria(600);
            new RealizadorDeInvestimentos(moderado, contaBancaria);
            contaBancaria = new ContaBancaria(600);
            new RealizadorDeInvestimentos(arrojado, contaBancaria);

            Console.ReadKey();
        }
    }
}