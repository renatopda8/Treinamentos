using System;
using System.Collections.Generic;

namespace Builder
{
    public class NotaFiscal
    {
        public NotaFiscal(string razaoSocial, string cnpj, decimal valorBruto, decimal impostos, DateTime dataDeEmissao, string observacoes, List<ItemDaNota> itensDaNota)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
            this.DataDeEmissao = dataDeEmissao;
            this.Observacoes = observacoes;
            this.ItensDaNota = itensDaNota;
        }

        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal Impostos { get; set; }
        public DateTime DataDeEmissao { get; set; }
        public string Observacoes { get; set; }
        public List<ItemDaNota> ItensDaNota { get; set; }
    }
}