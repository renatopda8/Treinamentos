namespace Visitor
{
    public interface IVisitor
    {
        void ImprimeSoma(Soma soma);

        void ImprimeSubstracao(Subtracao subtracao);

        void ImprimeNumero(Numero numero);
    }
}