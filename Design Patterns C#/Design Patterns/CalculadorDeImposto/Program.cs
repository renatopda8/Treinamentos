using System;
using CalculadorDeImpostos;

namespace CalculadorDeImposto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ISS iss = new ISS();
            ICMS icms = new ICMS();
            ICCC iccc = new ICCC();
            ICPP icpp = new ICPP();
            IKCV ikcv = new IKCV();
            IHIT ihit = new IHIT();

            Orcamento orcamento = new Orcamento(600);
            orcamento.Itens.Add(new Item("CANETA", 100));
            orcamento.Itens.Add(new Item("LÁPIS", 100));
            orcamento.Itens.Add(new Item("CELULAR", 90));
            orcamento.Itens.Add(new Item("MONITOR", 10));

            Console.WriteLine($"Orçamento de R$ {orcamento.Valor:F2}");
            new CalculadorDeImposto(orcamento, iss);
            new CalculadorDeImposto(orcamento, icms);
            new CalculadorDeImposto(orcamento, iccc);
            new CalculadorDeImposto(orcamento, icpp);
            new CalculadorDeImposto(orcamento, ikcv);
            new CalculadorDeImposto(orcamento, ihit);

            Console.WriteLine();
            orcamento = new Orcamento(1200);
            orcamento.Itens.Add(new Item("CANETA", 20));
            orcamento.Itens.Add(new Item("LÁPIS", 40));
            orcamento.Itens.Add(new Item("CELULAR", 300));
            orcamento.Itens.Add(new Item("MONITOR", 500));

            Console.WriteLine($"Orçamento de R$ {orcamento.Valor:F2}");
            new CalculadorDeImposto(orcamento, iss);
            new CalculadorDeImposto(orcamento, icms);
            new CalculadorDeImposto(orcamento, iccc);
            new CalculadorDeImposto(orcamento, icpp);
            new CalculadorDeImposto(orcamento, ikcv);
            new CalculadorDeImposto(orcamento, ihit);

            Console.WriteLine();
            orcamento = new Orcamento(3000);
            orcamento.Itens.Add(new Item("CANETA", 20));
            orcamento.Itens.Add(new Item("LÁPIS", 40));
            orcamento.Itens.Add(new Item("CELULAR", 300));
            orcamento.Itens.Add(new Item("MONITOR", 500));
            orcamento.Itens.Add(new Item("MONITOR", 500));

            Console.WriteLine($"Orçamento de R$ {orcamento.Valor:F2}");
            new CalculadorDeImposto(orcamento, iss);
            new CalculadorDeImposto(orcamento, icms);
            new CalculadorDeImposto(orcamento, iccc);
            new CalculadorDeImposto(orcamento, icpp);
            new CalculadorDeImposto(orcamento, ikcv);
            new CalculadorDeImposto(orcamento, ihit);

            Console.WriteLine();
            orcamento = new Orcamento(3200);
            orcamento.Itens.Add(new Item("CANETA", 20));
            orcamento.Itens.Add(new Item("LÁPIS", 40));
            orcamento.Itens.Add(new Item("CELULAR", 300));
            orcamento.Itens.Add(new Item("MONITOR", 500));

            Console.WriteLine($"Orçamento de R$ {orcamento.Valor:F2}");
            new CalculadorDeImposto(orcamento, iss);
            new CalculadorDeImposto(orcamento, icms);
            new CalculadorDeImposto(orcamento, iccc);
            new CalculadorDeImposto(orcamento, icpp);
            new CalculadorDeImposto(orcamento, ikcv);
            new CalculadorDeImposto(orcamento, ihit);

            Console.ReadKey();
        }
    }
}