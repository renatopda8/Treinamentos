using System;

namespace EstadosDeOrcamento
{
    public class Aprovado : IEstadoDeOrcamento
    {
        private bool DescontoJaAplicado { get; set; } = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (DescontoJaAplicado)
            {
                throw new Exception("Desconto já aplicado");
            }

            orcamento.Valor -= orcamento.Valor * 0.02m;
            this.DescontoJaAplicado = true;
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