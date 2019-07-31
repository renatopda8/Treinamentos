using System;

namespace CalculadorDeImposto
{
    public class CalculadorDeImposto
    {
        public CalculadorDeImposto(Orcamento orcamento, IImposto estrategiaDeImposto)
        {
            decimal valorImposto = estrategiaDeImposto.Calcula(orcamento);
            Console.WriteLine($"Valor de {estrategiaDeImposto.Nome}: R$ {valorImposto:F2}");
        }
    }
}