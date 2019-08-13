using System;

namespace Builder
{
    public class NotaFiscalDAO : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Persistir NF no banco de dados");
        }
    }
}