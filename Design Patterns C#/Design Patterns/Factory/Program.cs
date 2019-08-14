using System.Data;

namespace Factory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IDbConnection conexao = new IDbConnectionFactory().GetConnection();
            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "SELECT * FROM tabela";
        }
    }
}