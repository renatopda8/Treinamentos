using System;
using System.Collections.Generic;

namespace Builder
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public decimal ValorBruto { get; private set; }
        public decimal Impostos { get; private set; }
        public DateTime DataDeEmissao { get; private set; }
        public string Observacoes { get; private set; }
        public List<ItemDaNota> ItensDaNota { get; private set; }

        public NotaFiscalBuilder()
        {
            DataDeEmissao = DateTime.Now;
            ItensDaNota = new List<ItemDaNota>();
        }

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, ValorBruto, Impostos, DataDeEmissao, Observacoes, ItensDaNota);
        }

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder NaData(DateTime dataDeEmissao)
        {
            DataDeEmissao = dataDeEmissao;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            ItensDaNota.Add(item);
            ValorBruto += item.Valor;
            Impostos += item.Valor * 0.05m;

            return this;
        }
    }
}