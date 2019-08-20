namespace Bridge
{
    public interface IMensagem
    {
        IEnviador Enviador { get; }

        void Envia();

        string Formata();
    }
}
