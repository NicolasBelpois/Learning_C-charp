using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minijeu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(0, 7);
            CentrerLeTexte("Salut !");
            Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(0, 7);
            CentrerLeTexte("Sa va bien ?");
            Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(0, 7);
            CentrerLeTexte("Bon, je pense que tu a compris le principe non ?");
            Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(0, 7);
            CentrerLeTexte("Tu appuie sur Entrée, et je me met à parler...");
            Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(0, 7);
            CentrerLeTexte("C'est cool non ?");
            Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(0, 7);
            CentrerLeTexte("Non ??");
            Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(0, 7);
            CentrerLeTexte("Allo ???");
            Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(0, 7);
            CentrerLeTexte("Nan mais ALLO ??");
            Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(0, 7);
            CentrerLeTexte("Ha oui ... tu peut pas me repondre en faite...");
            Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(0, 7);
            CentrerLeTexte("Oki, je vais esseyer de règler sa, bouge surtout pas !");
            Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(0, 7);
            CentrerLeTexte("...");
            Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(0, 7);
            CentrerLeTexte(".....");
            Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(0, 7);
            CentrerLeTexte(".....................");
            Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(0, 7);
            CentrerLeTexte("Okay !! C'est bon !");
            CentrerLeTexte("Alors... aime tu la couleur bleu ? (tu peut repondre par oui ou non !)");           
            string reponse = Console.ReadLine();
            if (reponse.Equals("oui"))
            {
                CentrerLeTexte("Hahaha sa marche ! et je sais maintenant que tu aime la couleur bleu !");
                Console.ReadLine();
                Console.Clear();
                Console.SetCursorPosition(0, 7);
                CentrerLeTexte("Bon maintenant que je sais sa, voyont si je peut esseyer autre chose...");
                Console.ReadLine();
                Console.Clear();
                Console.SetCursorPosition(0, 7);
                CentrerLeTexte("Tu ma dit aimé le bleu... voyont voir...");
                Console.ReadLine();
                Console.Clear();
                Console.SetCursorPosition(0, 7);
                CentrerLeTexte("...");
                Console.ReadLine();
                Console.Clear();
                Console.SetCursorPosition(0, 7);
                CentrerLeTexte("......");
                Console.ReadLine();
                Console.Clear();
                Console.SetCursorPosition(0, 7);
                CentrerLeTexte(".................");
                Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(0, 7);
                CentrerLeTexte("Ha haaaaaa !!! ");
                Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(0, 7);
                CentrerLeTexte("Pas mal non ? et encore c'est rien comparé au possibilité offert par mon ingénieux intelec !");
                Console.ReadLine();
                Console.Clear();
            }
            else if (reponse.Equals("non"))
            {
                CentrerLeTexte("Ok alors sa marche.. mais tu n'aime pas le bleu (bon à savoir.)");
                Console.ReadLine();
                Console.Clear();
                Console.SetCursorPosition(0, 7);
                CentrerLeTexte("Bon maintenant que je sais sa, voyont si je peut esseyer autre chose...");
            }
            else
            {
                CentrerLeTexte("Tu doit juste répondre \"oui\" ou \"non\" !");
                Console.ReadLine();
                Console.Clear();
                Console.SetCursorPosition(0, 7);
                CentrerLeTexte("Je vais pas me prendre la tête avec toi, si tu sais même pas répondre a un simple \"oui\" ou \"non\"...");
                Console.ReadLine();
                Console.Clear();
                Console.SetCursorPosition(0, 7);
                CentrerLeTexte("Je préfère mettre un terme à notre relation tout de suite !");
                Console.ReadLine();
                Console.Clear();
                Console.SetCursorPosition(0, 7);
                CentrerLeTexte("Désoler...");
                Console.ReadLine();
                Console.Clear();
                Console.SetCursorPosition(0, 7);
                CentrerLeTexte("C'est pas toi ... c'est moi");
            }
            

           
            


        }
        private static void CentrerLeTexte(string texte) // Cette méthode centre le text 
        {
            int nbEspaces = (Console.WindowWidth - texte.Length) / 2;
            Console.SetCursorPosition(nbEspaces, Console.CursorTop);
            Console.WriteLine(texte);
        }
    }
}
