namespace FormatosDeRequisicoes
{
    public class ProcessaRequisicao
    {
        public ProcessaRequisicao(Requisicao requisicao, Conta conta)
        {
            IResposta r1 = new RespostaSemFormato(null);
            IResposta r2 = new RespostaEmPorcento(r1);
            IResposta r3 = new RespostaEmCsv(r2);
            IResposta r4 = new RespostaEmXml(r3);

            r4.Responde(requisicao, conta);
        }
    }
}