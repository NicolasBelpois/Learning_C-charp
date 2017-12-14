using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpboucle
{
    class Program
    {
        static void Main(string[] args)
        {
            var afficheLotto = TirageLoto(); // Ont lance la méthode.
            for (int i = 0; i < 7; i++) // Pour chaque index du tableau,
            { 
               Console.WriteLine(afficheLotto[i]); // ont affiche les nombres dans la console.
            }
            Console.WriteLine("Sont les numéros de ce tirage lotto.");
        }

        static int[] TirageLoto() // Ont crée la méthode du tirage.
        {
            Random aleatoire = new Random(); // Ont crée une méthode aléatoire.
            int[] tableauLotto = new int[7]; // Ont initie un nouveau tableau.
            for (var i = 0; i < 7; i++) // Pour chaque index du tableau,
            {
                int randomNumber;

                do
                {
                    randomNumber = aleatoire.Next(1, 50); // Ont choisi un nombre aléatoire,
                } while (tableauLotto.Contains(randomNumber)); // Tant que ce nombre aléatoire ce trouve dans le tableau,

                tableauLotto[i] = randomNumber; // Ont choisi un nombre aléatoire différent.
            }

            return tableauLotto; // Ont retourne le tableau une fois tout les champs remplis
        }

    }
    
}

