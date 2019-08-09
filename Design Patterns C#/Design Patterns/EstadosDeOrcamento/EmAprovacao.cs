using System;

namespace EstadosDeOrcamento
{
    public class EmAprovacao : IEstadoDeOrcamento
    {
        private bool DescontoJaAplicado { get; set; } = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (DescontoJaAplicado)
            {
                throw new Exception("Desconto já aplicado");
            }

            orcamento.Valor -= orcamento.Valor * 0.05m;
            this.DescontoJaAplicado = true;
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