namespace EstadosDeOrcamento
{
    public class Item
    {
        public string Nome { get; private set; }
        public decimal Valor { get; private set; }

        public Item(string nome, decimal valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
    }
}