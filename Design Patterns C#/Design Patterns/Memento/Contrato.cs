using System;

namespace Memento
{
    public class Contrato
    {
        public DateTime Data { get; set; }
        public string NomeCliente { get; set; }
        public TipoContrato Tipo { get; set; }

        public void Avanca()
        {
            if (TipoContrato.Novo.Equals(this.Tipo))
            {
                this.Tipo = TipoContrato.EmAndamento;
            }
            else if (TipoContrato.EmAndamento.Equals(this.Tipo))
            {
                this.Tipo = TipoContrato.Acertado;
            }
            else if (TipoContrato.Acertado.Equals(this.Tipo))
            {
                this.Tipo = TipoContrato.Concluido;
            }
        }
    }
}