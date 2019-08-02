using System;

namespace CalculadorDeDescontos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500.0m);
            orcamento.AdicionaItem(new Item("CANETA", 250.0m));
            orcamento.AdicionaItem(new Item("LAPIS", 250.0m));

            decimal desconto = calculador.Calcula(orcamento);

            Console.WriteLine(desconto);
        }
    }
}