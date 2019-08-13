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
        private List<IAcaoAposGerarNota> AcoesAposGerarNota { get; }

        public NotaFiscalBuilder()
        {
            DataDeEmissao = DateTime.Now;
            ItensDaNota = new List<ItemDaNota>();
            AcoesAposGerarNota = new List<IAcaoAposGerarNota>();
        }

        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, ValorBruto, Impostos, DataDeEmissao, Observacoes, ItensDaNota);
            AcoesAposGerarNota.ForEach(acao => acao.Executa(nf));
            return nf;
        }

        public void AdicionaAcao(IAcaoAposGerarNota novaAcao)
        {
            AcoesAposGerarNota.Add(novaAcao);
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

        public NotaFiscalBuilder Com(ItemDaNota item)
        {
            ItensDaNota.Add(item);
            ValorBruto += item.Valor;
            Impostos += item.Valor * 0.05m;

            return this;
        }
    }
}