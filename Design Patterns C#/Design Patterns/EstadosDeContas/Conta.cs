using System;

namespace EstadosDeContas
{
    public class Conta
    {
        public string Titular { get; private set; }
        public decimal Saldo { get; set; }
        public DateTime DataDeAbertura { get; set; }
        public IEstadoDeConta Estado { get; set; }

        public Conta(string titular, decimal saldo, DateTime dataDeAbertura)
        {
            this.Titular = titular;
            this.Saldo = saldo;
            this.DataDeAbertura = dataDeAbertura;
        }

        public void Saca(decimal valor)
        {
            Estado.Saca(this, valor);
        }

        public void Deposita(decimal valor)
        {
            Estado.Deposita(this, valor);
        }
    }
}