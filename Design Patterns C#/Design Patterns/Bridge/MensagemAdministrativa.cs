namespace Bridge
{
    public class MensagemAdministrativa : IMensagem
    {
        public IEnviador Enviador { get; }
        private string Nome { get; set; }

        public MensagemAdministrativa(IEnviador enviador, string nome)
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
            return $"Mensagem administrativa para {Nome}";
        }
    }
}