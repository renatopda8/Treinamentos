﻿using System;

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

            NotaFiscalBuilder builder = new NotaFiscalBuilder();
            builder.ParaEmpresa("Empresa Teste")
                .ComCnpj("123456789")
                .ComObservacoes("Observações da nota fiscal")
                .Com(item1)
                .Com(item2);

            builder.AdicionaAcao(new EnviaPorEmail());
            builder.AdicionaAcao(new NotaFiscalDAO());

            NotaFiscal nf = builder.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);

            Console.ReadKey();
        }
    }
}