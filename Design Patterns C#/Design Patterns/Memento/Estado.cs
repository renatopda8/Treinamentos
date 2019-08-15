namespace Memento
{
    public class Estado
    {
        public Contrato Contrato { get; set; }

        public Estado(Contrato contrato)
        {
            this.Contrato = contrato;
        }
    }
}