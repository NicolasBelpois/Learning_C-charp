using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusouMoin
{
    class Program
    {
        static void Main(string[] args)
        {
            int valeurAtrouver = new Random().Next(1, 100);  //Ont crée un nombre aléatoire.
            int nombreDeCoup = 0; // Ont initie une variable pour le nombre de coup.
            bool trouver = false; // Ont initie la variable pour vérifier que le nombre corespond bien.
            Console.WriteLine("Merci de choisir un nombre compris entre 1 et 100."); // Ont demande un nombre de l'utilisateur.
            while (!trouver)
            {
                string saisi = Console.ReadLine();
                int valeurSaisie;
                if (int.TryParse(saisi, out valeurSaisie))
                {
                    if (valeurSaisie == valeurAtrouver)
                        trouver = true;
                    else
                    {
                        if (valeurSaisie < valeurAtrouver)
                            Console.WriteLine("Trop petit ...");
                        else
                            Console.WriteLine("Trop grand ...");
                    }
                    nombreDeCoup++;
                }
                else
                    Console.WriteLine("La valeur saisie est incorrecte, veuillez recommencer ...");
            }
            Console.WriteLine("Vous avez trouvé en " + nombreDeCoup + " coup(s)");
        }
    }
}
         
        
    

