using System;
using System.Collections.Generic;

namespace CalculadorDeImposto
{
    public class RelatorioSimples : Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine($"Titular: {c.Titular} - Saldo: R$ {c.Saldo:F2}");
            }
        }

        protected override void Rodape()
        {
            Console.WriteLine("+55 65 92454-4118");
        }
    }
}