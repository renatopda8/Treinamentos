using System.Collections.Generic;

namespace Memento
{
    public class Historico
    {
        private List<Estado> Estados { get; set; }

        public Historico()
        {
            this.Estados = new List<Estado>();
        }

        public Estado Pega(int index)
        {
            return Estados[index];
        }

        public void Adiciona(Estado estado)
        {
            Estados.Add(estado);
        }
    }
}