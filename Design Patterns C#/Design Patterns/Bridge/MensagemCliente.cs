namespace Bridge
{
    public class MensagemCliente : IMensagem
    {
        public IEnviador Enviador { get; }
        private string Nome { get; set; }

        public MensagemCliente(IEnviador enviador, string nome)
        {
            this.Nome = nome;
            this.Enviador = enviador;
        }

        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return $"Mensagem para o cliente {this.Nome}";
        }
    }
}