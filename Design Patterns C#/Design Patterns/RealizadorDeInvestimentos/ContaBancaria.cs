namespace RealizadorDeInvestimentos
{
    public class ContaBancaria
    {
        public ContaBancaria(decimal saldo)
        {
            this.Saldo = saldo;
        }

        public decimal Saldo { get; set; }
    }
}
