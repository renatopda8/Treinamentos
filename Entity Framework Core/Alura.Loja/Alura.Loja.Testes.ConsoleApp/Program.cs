using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fulano = new Cliente
            {
                Nome = "Fulaninho de Tal",
                EnderecoDeEntrega = new Endereco
                {
                    Numero = 12,
                    Logradouro = "Rua dos Inválidos",
                    Complemento = "Sobrado",
                    Bairro = "Centro",
                    Cidade = "Cidade"
                }
            };

            using (var contexto = new LojaContext())
            {
                var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(SqlLoggerProvider.Create());

                contexto.Clientes.Add(fulano);
                contexto.SaveChanges();
            }
        }

        private static void ExibeEntries(IEnumerable<EntityEntry> entries)
        {
            foreach (var e in entries)
            {
                Console.WriteLine(e.Entity + " - " + e.State);
            }
        }
    }
}