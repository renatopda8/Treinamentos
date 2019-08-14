using System.Collections.Generic;

namespace Flyweight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NotasMusicais notasMusicais = new NotasMusicais();

            List<INota> musica = new List<INota>
            {
                notasMusicais.Recupera("Do"),
                notasMusicais.Recupera("Re"),
                notasMusicais.Recupera("Mi"),
                notasMusicais.Recupera("Fa"),
                notasMusicais.Recupera("Fa"),
                notasMusicais.Recupera("Fa"),
                notasMusicais.Recupera("Do"),
                notasMusicais.Recupera("Re"),
                notasMusicais.Recupera("Do"),
                notasMusicais.Recupera("Re"),
                notasMusicais.Recupera("Re"),
                notasMusicais.Recupera("Re"),
                notasMusicais.Recupera("Do"),
                notasMusicais.Recupera("Sol"),
                notasMusicais.Recupera("Fa"),
                notasMusicais.Recupera("Mi"),
                notasMusicais.Recupera("Mi"),
                notasMusicais.Recupera("Mi"),
                notasMusicais.Recupera("Do"),
                notasMusicais.Recupera("Re"),
                notasMusicais.Recupera("Mi"),
                notasMusicais.Recupera("Fa"),
                notasMusicais.Recupera("Fa"),
                notasMusicais.Recupera("Fa")
            };

            Piano piano = new Piano();
            piano.Toca(musica);
        }
    }
}