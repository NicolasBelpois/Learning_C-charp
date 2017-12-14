using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appMusic
{
    class Program
    {
        static void Main(string[] args)
        {
            int noteDo = 262;
            int noteRe = 294;
            int noteMi = 330;
            int noire = 400;
            int blanche = 800;

            Console.Beep(noteDo, noire);
            Console.Beep(noteDo, noire);
            Console.Beep(noteDo, noire);
            Console.Beep(noteRe, noire);
            Console.Beep(noteMi, blanche);
            Console.Beep(noteRe, blanche);
            Console.Beep(noteDo, noire);
            Console.Beep(noteMi, noire);
            Console.Beep(noteRe, noire);
            Console.Beep(noteRe, noire);
            Console.Beep(noteDo, noire);
        }
    }
}
