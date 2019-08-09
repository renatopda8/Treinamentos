using System.Collections.Generic;
using System.Linq;

namespace FiltrosDeContas
{
    public class FiltroSaldoMaiorQue500MilReais : Filtro
    {
        public FiltroSaldoMaiorQue500MilReais() : base() { }

        public FiltroSaldoMaiorQue500MilReais(Filtro outroFiltro) : base(outroFiltro) { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            return ExecutaOutroFiltro(contas, contas.Where(c => c.Saldo > 500000).ToList());
        }
    }
}