using System;
using System.Collections.Generic;

namespace FiltrosDeContas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Filtro filtro = new FiltroSaldoMenorQue100Reais(new FiltroSaldoMaiorQue500MilReais(new FiltroDataAberturaNoMesCorrente()));

            IList<Conta> contas = new List<Conta>()
            {
                new Conta("Teste1", 200000000, new DateTime(2019, 05, 01)),
                new Conta("Teste2", 3000, new DateTime(2019, 06, 07)),
                new Conta("Teste3", 1000, new DateTime(2019, 01, 18))
            };


            IList<Conta> filtradas = filtro.Filtra(contas);
            foreach (Conta c in filtradas)
            {
                Console.WriteLine($"Titular: {c.Titular} - Saldo: {c.Saldo} - Data da Abertura: {c.DataDeAbertura:dd/MM/yyyy}");
            }

            Console.ReadKey();
        }
    }
}