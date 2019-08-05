namespace FormatosDeRequisicoes
{
    public interface IResposta
    {
        void Responde(Requisicao req, Conta conta);
        IResposta ProximaResposta { get; }
    }
}