using System;

namespace EstadosDeOrcamento
{
    public class Finalizado : IEstadoDeOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento) { }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já finalizado");
        }
    }
}