using System;

namespace Builder
{
    public class EnviaPorEmail : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Enviar NF por e-mail");
        }
    }
}