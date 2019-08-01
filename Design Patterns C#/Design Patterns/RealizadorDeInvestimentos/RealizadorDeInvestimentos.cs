using System;

namespace RealizadorDeInvestimentos
{
    public class RealizadorDeInvestimentos
    {
        public RealizadorDeInvestimentos(IInvestimento estrategiaDeInvestimento, ContaBancaria contaBancaria)
        {
            decimal retorno = estrategiaDeInvestimento.Calcula(contaBancaria);
            Console.WriteLine($"Saldo da conta bancária: R$ {contaBancaria.Saldo:F2}");
            contaBancaria.Deposita(retorno * 0.75m);
            Console.WriteLine($"Retorno do investimento: R$ {retorno:F2}");
            Console.WriteLine($"Novo saldo da conta bancária: R$ {contaBancaria.Saldo:F2}");
            Console.WriteLine();
        }
    }
}