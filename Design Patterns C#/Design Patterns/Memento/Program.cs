using System;

namespace Memento
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Historico historico = new Historico();

            Contrato contrato = new Contrato(DateTime.Now, "Mauricio", TipoContrato.Novo);
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());
            Console.WriteLine(contrato.Tipo);

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());
            Console.WriteLine(contrato.Tipo);

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());
            Console.WriteLine(contrato.Tipo);

            Console.ReadKey();
        }
    }
}