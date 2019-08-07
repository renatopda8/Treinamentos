using System.Collections.Generic;

namespace CalculadorDeImposto
{
    public abstract class Relatorio
    {
        protected abstract void Cabecalho();
        protected abstract void Corpo(IList<Conta> contas);
        protected abstract void Rodape();

        public void Imprime(IList<Conta> contas)
        {
            Cabecalho();
            Corpo(contas);
            Rodape();
        }
    }
}