using System;

namespace Adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cliente cliente = new Cliente
            {
                Nome = "Teste",
                Endereco = "Rua Teste, 123",
                DataNascimento = new DateTime(2000, 1, 1)
            };

            string xmlCliente = new GeradorDeXml<Cliente>().GeraXml(cliente);
            Console.WriteLine(xmlCliente);
            Console.ReadKey();
        }
    }
}