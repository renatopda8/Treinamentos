using System.Collections.Generic;

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

        protected IList<Conta> FiltraOutroFiltro(IList<Conta> contas)
        {
            return OutroFiltro.Filtra(contas);
        }
    }
}