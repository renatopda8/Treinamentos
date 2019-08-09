using System;

namespace EstadosDeOrcamento
{
    public class Reprovado : IEstadoDeOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Descontos não são permitidos para orçamentos reprovados");
        }

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