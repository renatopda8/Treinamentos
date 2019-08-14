using System.Collections.Generic;

namespace Flyweight
{
    public class NotasMusicais
    {
        private Dictionary<string, INota> Notas { get; }

        public NotasMusicais()
        {
            Notas = new Dictionary<string, INota>
            {
                { "Do", new Do() },
                { "Re", new Re() },
                { "Mi", new Mi() },
                { "Fa", new Fa() },
                { "Sol", new Sol() },
                { "La", new La() },
                { "Si", new Si() }
            };
        }

        public INota Recupera(string nota)
        {
            return Notas[nota];
        }
    }
}