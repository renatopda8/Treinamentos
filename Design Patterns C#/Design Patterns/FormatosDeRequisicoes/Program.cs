using System;

namespace FormatosDeRequisicoes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Conta conta = new Conta("Teste", 500);
            Requisicao requisicao = new Requisicao(Formato.XML);

            new ProcessaRequisicao(requisicao, conta);

            Console.ReadKey();
        }
    }
}