using System;

namespace EstadosDeOrcamento
{
    public class Reprovado : IEstadoDeOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento) { }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.Estado = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já reprovado");
        }
    }
}