using System;

namespace FiltrosDeContas
{
    public class Conta
    {
        public string Titular { get; private set; }
        public decimal Saldo { get; private set; }
        public DateTime DataDeAbertura { get; set; }

        public Conta(string titular, decimal saldo, DateTime dataDeAbertura)
        {
            this.Titular = titular;
            this.Saldo = saldo;
            this.DataDeAbertura = dataDeAbertura;
        }
    }
}