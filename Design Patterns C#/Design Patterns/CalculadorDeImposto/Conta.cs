namespace CalculadorDeImposto
{
    public class Conta
    {
        public string Numero { get; private set; }
        public string Agencia { get; private set; }
        public string Titular { get; private set; }
        public decimal Saldo { get; private set; }        

        public Conta(string numero, string agencia, string titular, decimal saldo)
        {
            this.Numero = numero;
            this.Agencia = agencia;
            this.Titular = titular;
            this.Saldo = saldo;            
        }
    }
}