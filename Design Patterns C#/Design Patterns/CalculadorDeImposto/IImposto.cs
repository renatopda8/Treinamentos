namespace CalculadorDeImposto
{
    public interface IImposto
    {
        decimal Calcula(Orcamento orcamento);
        string Nome { get; }
    }
}