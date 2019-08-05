using System;

namespace FormatosDeRequisicoes
{
    public class RespostaEmCsv : IResposta
    {
        public RespostaEmCsv(IResposta proximaResposta)
        {
            ProximaResposta = proximaResposta;
        }

        public IResposta ProximaResposta { get; }

        public void Responde(Requisicao req, Conta conta)
        {
            if (Formato.CSV.Equals(req.Formato))
            {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
                return;
            }

            ProximaResposta.Responde(req, conta);
        }
    }
}