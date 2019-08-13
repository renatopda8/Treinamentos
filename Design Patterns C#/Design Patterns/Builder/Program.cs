using System;
using System.Collections.Generic;

namespace Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ItemDaNotaBuilder idnb = new ItemDaNotaBuilder();
            idnb.ComDescricao("Item 1")
                .ComValor(100);

            ItemDaNota item1 = idnb.Constroi();

            idnb = new ItemDaNotaBuilder();
            idnb.ComDescricao("Item 2")
                .ComValor(200);

            ItemDaNota item2 = idnb.Constroi();

            NotaFiscalBuilder builder = new NotaFiscalBuilder(new List<IAcaoAposGerarNota> { new EnviaPorEmail(), new NotaFiscalDAO(), new Multiplicador(2) });
            builder.ParaEmpresa("Empresa Teste")
                .ComCnpj("123456789")
                .ComObservacoes("Observações da nota fiscal")
                .Com(item1)
                .Com(item2);

            NotaFiscal nf = builder.Constroi();

            Console.WriteLine($"Valor da nota fiscal: R$ {nf.ValorBruto:F2}");
            Console.WriteLine($"Valor dos impostos: R$ {nf.Impostos:F2}");

            Console.ReadKey();
        }
    }
}