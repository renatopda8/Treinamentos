using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //GravarUsandoAdoNet();
            //GravarUsandoEntity();
            //RecuperarProdutos();
            //ExcluirProdutos();
            //RecuperarProdutos();
            AtualizarProdutos();
        }

        private static void AtualizarProdutos()
        {
            GravarUsandoEntity();
            RecuperarProdutos();

            using (var context = new ProdutoDAOEntity())
            {
                Produto primeiro = context.Produtos().FirstOrDefault();
                primeiro.Nome = "Harry Potter e a Ordem da Fênix - Editado";
                context.Atualizar(primeiro);
            }

            RecuperarProdutos();
        }

        private static void ExcluirProdutos()
        {
            using (var context = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = context.Produtos().ToList();
                foreach (Produto produto in produtos)
                {
                    context.Remover(produto);
                }
            }
        }

        private static void RecuperarProdutos()
        {
            using (var context = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = context.Produtos().ToList();
                Console.WriteLine($"Foram encontrados {produtos.Count} produto(s).");
                foreach (Produto produto in produtos)
                {
                    Console.WriteLine(produto.Nome);
                }
            }
        }

        private static void GravarUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var context = new ProdutoDAOEntity())
            {
                context.Adicionar(p);
            }
        }

        private static void GravarUsandoAdoNet()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var repo = new ProdutoDAO())
            {
                repo.Adicionar(p);
            }
        }
    }
}
