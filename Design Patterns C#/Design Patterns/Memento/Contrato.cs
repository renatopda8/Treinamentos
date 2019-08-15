using System;

namespace Memento
{
    public class Contrato
    {
        public DateTime Data { get; set; }
        public string NomeCliente { get; set; }
        public TipoContrato Tipo { get; set; }

        public Contrato(DateTime data, string nomeCliente, TipoContrato tipo)
        {
            this.Data = data;
            this.NomeCliente = nomeCliente;
            this.Tipo = tipo;
        }

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

        public Estado SalvaEstado()
        {
            return new Estado(new Contrato(this.Data, this.NomeCliente, this.Tipo));
        }
    }
}