using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TocadorConsole.NotasMusicais;

namespace TocadorConsole.Tocador
{
    internal class Tocador
    {
        public void Play(IList<INota> musica)
        {
            foreach(var nota in musica)
            {
                Console.Beep(nota.Frequencia, 300);
            }
        }
    }
}
