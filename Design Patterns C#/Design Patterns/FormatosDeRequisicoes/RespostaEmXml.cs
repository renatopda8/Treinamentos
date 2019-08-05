using System;

namespace FormatosDeRequisicoes
{
    public class RespostaEmXml : IResposta
    {
        public RespostaEmXml(IResposta proximaResposta)
        {
            ProximaResposta = proximaResposta;
        }

        public IResposta ProximaResposta { get; }

        public void Responde(Requisicao req, Conta conta)
        {
            if (Formato.XML.Equals(req.Formato))
            {
                Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
                return;
            }

            ProximaResposta.Responde(req, conta);
        }
    }
}