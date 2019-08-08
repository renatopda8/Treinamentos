using System;
using System.Collections.Generic;
using System.Linq;

namespace FiltrosDeContas
{
    public class FiltroDataAberturaNoMesCorrente : Filtro
    {
        public FiltroDataAberturaNoMesCorrente() : base() { }

        public FiltroDataAberturaNoMesCorrente(Filtro outroFiltro) : base(outroFiltro) { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IEnumerable<Conta> filtradas = contas.Where(c => EhMesCorrente(c.DataDeAbertura));
            return filtradas.Concat(OutroFiltro.Filtra(contas.Except(filtradas).ToList())).ToList();
        }

        private bool EhMesCorrente(DateTime data)
        {
            DateTime today = DateTime.Today;
            return today.Year.Equals(data.Year) && today.Month.Equals(data.Month);
        }
    }
}