namespace Visitor
{
    public interface IExpressao
    {
        decimal Avalia();

        void Aceita(IVisitor visitor);
    }
}