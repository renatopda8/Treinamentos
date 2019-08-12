namespace Builder
{
    public class ItemDaNotaBuilder
    {
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }

        public ItemDaNotaBuilder ComDescricao(string descricao)
        {
            Descricao = descricao;
            return this;
        }

        public ItemDaNotaBuilder ComValor(decimal valor)
        {
            Valor = valor;
            return this;
        }

        public ItemDaNota Constroi()
        {
            return new ItemDaNota(Descricao, Valor);
        }
    }
}