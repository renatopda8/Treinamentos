﻿using System.Collections.Generic;
using System.Linq;
using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public IList<Produto> GetProdutos()
        {
            return dbSet.ToList();
        }

        public void SaveProdutos(List<Livro> livros)
        {
            foreach (var livro in livros)
            {                
                if (!dbSet.Any(p => p.Codigo.Equals(livro.Codigo)))
                {
                    dbSet.Add(new Produto(livro.Codigo, livro.Nome, livro.Preco));
                }                
            }

            contexto.SaveChanges();
        }
    }

    public class Livro
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}