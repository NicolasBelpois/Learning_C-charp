using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime DateCourante = DateTime.Now;

            if (DateCourante.DayOfWeek == DayOfWeek.Saturday || DateCourante.DayOfWeek == DayOfWeek.Sunday ||
                (DateCourante.DayOfWeek == DayOfWeek.Monday && DateCourante.Hour < 9) ||
                (DateCourante.DayOfWeek == DayOfWeek.Friday && DateCourante.Hour >= 18))
            {
                // Nous somme le weekend
                Console.WriteLine("Bon Weekend !" + Environment.UserName);
            }
            else
            {
                //nous somme en semaine
                if (DateCourante.Hour >= 9 && DateCourante.Hour < 18)
                {
                    //nous somme en journée
                    Console.WriteLine("Bonne Journée !" + Environment.UserName);
                }
                else
                {
                    //nous somme en soirée
                    Console.WriteLine("Bonne soirée !" + Environment.UserName);
                }
            }
           
            string[] jours = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };

            int i = 0;

            bool trouve = false;

            while (i < jours.Length && !trouve)

            {

                string valeur = jours[i];

                if (valeur == "Jeudi")

                {

                    trouve = true;

                }

                else

                {

                    i++;

                }

            }

            if (!trouve)

                Console.WriteLine("Valeur non trouvée");

            else

                Console.WriteLine("Trouvé à l'indice " + i);

        }

    }
}








