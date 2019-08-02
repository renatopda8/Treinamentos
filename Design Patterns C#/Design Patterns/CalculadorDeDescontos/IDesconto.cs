namespace CalculadorDeDescontos
{
    public interface IDesconto
    {
        decimal Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}