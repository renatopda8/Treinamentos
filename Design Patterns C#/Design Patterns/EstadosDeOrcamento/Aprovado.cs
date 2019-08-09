using System;

namespace EstadosDeOrcamento
{
    public class Aprovado : IEstadoDeOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.02m;
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.Estado = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já aprovado");
        }
    }
}