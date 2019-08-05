namespace FormatosDeRequisicoes
{
    public class Conta
    {
        public string Titular { get; private set; }
        public decimal Saldo { get; private set; }

        public Conta(string titular, decimal saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }
    }
}