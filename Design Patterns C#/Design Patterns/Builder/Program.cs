using System;

namespace Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NotaFiscalBuilder builder = new NotaFiscalBuilder();
            builder.ParaEmpresa("Empresa Teste")
                .ComCnpj("123456789")
                .NaDataAtual()
                .ComObservacoes("Observações da nota fiscal")
                .ComItem(new ItemDaNota("Item 1", 100))
                .ComItem(new ItemDaNota("Item 2", 200));

            NotaFiscal nf = builder.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);

            Console.ReadKey();
        }
    }
}