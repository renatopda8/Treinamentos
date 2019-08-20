namespace Command
{
    public class FinalizaPedido : IComando
    {
        private Pedido Pedido { get; set; }

        public FinalizaPedido(Pedido pedido)
        {
            this.Pedido = pedido;
        }

        public void Executa()
        {
            this.Pedido.Finaliza();
        }
    }
}