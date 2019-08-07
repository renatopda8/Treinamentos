using System;
using System.Collections.Generic;

namespace CalculadorDeImposto
{
    public class RelatorioComplexo : Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ - Rua Número 1, 152 - +55 65 92454-4118");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine($"Titular: {c.Titular} - Agência: {c.Agencia} - Número: {c.Numero} - Saldo: R$ {c.Saldo:F2}");
            }
        }

        protected override void Rodape()
        {
            Console.WriteLine($"bancoxyz@acme.com - {DateTime.Now:dd-MM-yyyy}");
        }
    }
}