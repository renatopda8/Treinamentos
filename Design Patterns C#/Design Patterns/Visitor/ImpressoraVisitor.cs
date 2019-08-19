using System;

namespace Visitor
{
    public class ImpressoraVisitor : IVisitor
    {
        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }

        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            soma.Esquerda.Aceita(this);
            Console.Write(" + ");
            soma.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSubstracao(Subtracao subtracao)
        {
            Console.Write("(");
            subtracao.Esquerda.Aceita(this);
            Console.Write(" - ");
            subtracao.Direita.Aceita(this);
            Console.Write(")");
        }
    }
}