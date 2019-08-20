using System;

namespace Bridge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IMensagem mensagem = new MensagemAdministrativa(new EnviaPorSms(), "Victor");
            mensagem.Envia();
            Console.ReadKey();
        }
    }
}