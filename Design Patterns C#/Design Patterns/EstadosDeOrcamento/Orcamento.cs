using System;
using System.Collections.Generic;

namespace EstadosDeOrcamento
{
    public class Orcamento
    {
        public decimal Valor { get; set; }
        public IList<Item> Itens { get; private set; }
        public IEstadoDeOrcamento Estado { get; set; }

        public Orcamento(decimal valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
            this.Estado = new EmAprovacao();
        }

        public void AplicaDescontoExtra()
        {
            this.Estado.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            this.Estado.Aprova(this);
        }

        public void Reprova()
        {
            this.Estado.Reprova(this);
        }

        public void Finaliza()
        {
            this.Estado.Finaliza(this);
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}