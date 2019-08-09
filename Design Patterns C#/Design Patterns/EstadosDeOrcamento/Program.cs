using System;

namespace EstadosDeOrcamento
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento(500);

            Console.WriteLine($"Valor: {orcamento.Valor}");
            orcamento.AplicaDescontoExtra();
            Console.WriteLine($"Valor: {orcamento.Valor}");
            orcamento.Aprova();
            orcamento.AplicaDescontoExtra();
            Console.WriteLine($"Valor: {orcamento.Valor}");
            orcamento.Finaliza();

            Console.ReadKey();
        }
    }
}