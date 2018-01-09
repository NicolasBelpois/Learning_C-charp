using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaPremierApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Oiseau oiseau = new Oiseau { NombrePropulseurs = 2 };
            Avion avion = new Avion { NombrePropulseurs = 4 };

            List<IVolant> volants = new List<IVolant> { oiseau, avion };
            foreach(IVolant volant in volants)
            {
                volant.Voler();
            }
        }
      
    }
}
