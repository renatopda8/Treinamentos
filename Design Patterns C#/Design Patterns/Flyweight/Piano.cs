using System;
using System.Collections.Generic;

namespace Flyweight
{
    public class Piano
    {
        public void Toca(List<INota> musica)
        {
            foreach (INota nota in musica)
            {
                Console.Beep(nota.Frequencia, 150);
            }
        }
    }
}