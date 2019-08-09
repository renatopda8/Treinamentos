using System;

namespace EstadosDeOrcamento
{
    public class EmAprovacao : IEstadoDeOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.05m;
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.Estado = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento em aprovação não pode ser finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.Estado = new Reprovado();
        }
    }
}