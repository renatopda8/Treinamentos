using System;

namespace Interpreter
{
    public class RaizQuadrada : IExpressao
    {
        private IExpressao Valor { get; set; }

        public RaizQuadrada(IExpressao valor)
        {
            Valor = valor;
        }

        public decimal Avalia()
        {
            return (decimal) Math.Sqrt((double) this.Valor.Avalia());
        }
    }
}