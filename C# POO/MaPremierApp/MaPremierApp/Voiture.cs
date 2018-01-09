using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaPremierApp
{
   public class Voiture : IComparable
    {
        public string Couleur { get; set; }
        public string Marque { get; set; }
        public int Vitesse { get; set; }

        public int CompareTo(object obj)
        {
            Voiture voiture = (Voiture)obj;
            return Vitesse.CompareTo(voiture.Vitesse);
        }
    }
    public interface IVolant
    {
        int NombrePropulseurs { get; set; }
        void Voler();
    }
    public class Oiseau : IVolant
    {
        public int NombrePropulseurs { get; set; }
        public void Voler()
        {
            Console.WriteLine("Je vole grâçe a " + NombrePropulseurs + " ailes !");
        }
    }
    public class Avion : IVolant
    {
        public int NombrePropulseurs { get; set; }
        public void Voler()
        {
            Console.WriteLine("Je vole grâçe a " + NombrePropulseurs + " moteurs !");
        }
    }
}
