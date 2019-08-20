namespace Command
{
    public class PagaPedido : IComando
    {
        private Pedido Pedido { get; set; }

        public PagaPedido(Pedido pedido)
        {
            this.Pedido = pedido;
        }

        public void Executa()
        {
            this.Pedido.Paga();
        }
    }
}