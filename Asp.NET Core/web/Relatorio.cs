using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace web
{
    public class Relatorio : IRelatorio
    {
        private readonly ICatalogo _catalogo;

        public Relatorio(ICatalogo catalogo)
        {
            this._catalogo = catalogo;
        }

        public async Task Imprimir(HttpContext context)
        {
            foreach (var livro in _catalogo.GetLivros())
            {
                await context.Response.WriteAsync($"{livro.Codigo,-10}{livro.Nome,-40}{livro.Preco,10:C}\r\n");
            }
        }
    }
}