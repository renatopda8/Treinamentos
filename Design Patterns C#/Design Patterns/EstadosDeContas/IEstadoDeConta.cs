namespace EstadosDeContas
{
    public interface IEstadoDeConta
    {
        void Deposita(Conta conta, decimal valor);

        void Saca(Conta conta, decimal valor);
    }
}