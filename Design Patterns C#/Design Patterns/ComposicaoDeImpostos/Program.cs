using System;

namespace ComposicaoDeImpostos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Imposto imposto = new ISS(new ICMS(new ImpostoMuitoAlto(new IKCV(new ICPP()))));

            Orcamento orcamento = new Orcamento(600);
            orcamento.Itens.Add(new Item("CANETA", 100));
            orcamento.Itens.Add(new Item("LÁPIS", 200));
            orcamento.Itens.Add(new Item("CELULAR", 200));
            orcamento.Itens.Add(new Item("MONITOR", 100));

            decimal valor = imposto.Calcula(orcamento);
            Console.WriteLine($"Valor do imposto composto: R$ {valor:F2}");

            Console.ReadKey();
        }
    }
}