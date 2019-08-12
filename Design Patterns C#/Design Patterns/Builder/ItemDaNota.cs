namespace Builder
{
    public class ItemDaNota
    {
        public ItemDaNota(string descricao, decimal valor)
        {
            this.Descricao = descricao;
            this.Valor = valor;
        }

        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}