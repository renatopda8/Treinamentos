using System;

namespace FormatosDeRequisicoes
{
    public class RespostaEmPorcento : IResposta
    {
        public RespostaEmPorcento(IResposta proximaResposta)
        {
            ProximaResposta = proximaResposta;
        }

        public IResposta ProximaResposta { get; }

        public void Responde(Requisicao req, Conta conta)
        {
            if (Formato.PORCENTO.Equals(req.Formato))
            {
                Console.WriteLine(conta.Titular + "%" + conta.Saldo);
                return;
            }

            ProximaResposta.Responde(req, conta);
        }
    }
}