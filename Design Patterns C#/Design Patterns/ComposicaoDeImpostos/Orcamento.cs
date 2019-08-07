﻿using System.Collections.Generic;

namespace ComposicaoDeImpostos
{
    public class Orcamento
    {
        public decimal Valor { get; private set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento(decimal valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}