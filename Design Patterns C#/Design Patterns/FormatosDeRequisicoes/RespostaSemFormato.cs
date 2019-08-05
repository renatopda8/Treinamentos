using System;

namespace FormatosDeRequisicoes
{
    public class RespostaSemFormato : IResposta
    {
        public RespostaSemFormato(IResposta proximaResposta)
        {
            ProximaResposta = proximaResposta;
        }

        public IResposta ProximaResposta { get; }

        public void Responde(Requisicao req, Conta conta)
        {
            throw new Exception("Formato de resposta não encontrado");
        }
    }
}