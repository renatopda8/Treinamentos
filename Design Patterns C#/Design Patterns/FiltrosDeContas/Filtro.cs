using System.Collections.Generic;
using System.Linq;

namespace FiltrosDeContas
{
    public abstract class Filtro
    {
        public Filtro OutroFiltro { get; set; }

        public Filtro(Filtro outroFiltro)
        {
            this.OutroFiltro = outroFiltro;
        }

        public Filtro()
        {
            this.OutroFiltro = null;
        }

        public abstract IList<Conta> Filtra(IList<Conta> contas);

        protected IList<Conta> ExecutaOutroFiltro(IList<Conta> contas, IList<Conta> jaFiltradas)
        {
            return OutroFiltro == null ? jaFiltradas : jaFiltradas.Concat(OutroFiltro.Filtra(contas.Except(jaFiltradas).ToList())).ToList();
        }
    }
}