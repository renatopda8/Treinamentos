using System.Collections.Generic;
using System.Linq;

namespace FiltrosDeContas
{
    public class FiltroSaldoMenorQue100Reais : Filtro
    {
        public FiltroSaldoMenorQue100Reais() : base() { }

        public FiltroSaldoMenorQue100Reais(Filtro outroFiltro) : base(outroFiltro) { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            return ExecutaOutroFiltro(contas, contas.Where(c => c.Saldo < 100).ToList());
        }
    }
}