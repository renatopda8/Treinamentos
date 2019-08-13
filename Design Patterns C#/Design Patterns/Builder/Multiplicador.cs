using System;

namespace Builder
{
    public class Multiplicador : IAcaoAposGerarNota
    {
        public decimal Fator { get; private set; }

        public Multiplicador(decimal fator)
        {
            this.Fator = fator;
        }

        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine($"Valor multiplicado: R$ {(notaFiscal.ValorBruto * Fator):F2}");
        }
    }
}