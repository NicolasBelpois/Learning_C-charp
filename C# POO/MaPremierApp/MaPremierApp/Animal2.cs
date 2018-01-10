using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaPremierApp
{
    public abstract class Animal2
    {
        private Coeur coeur;    
        public Animal2()
        {
            coeur = new Coeur();
        }
        public abstract void SeDeplacer();

        public void Vivre()
        {
            coeur.Battre();
        }

        public void Mourir()
        {
            coeur.Stop();
        }

    }
    public class Coeur
    {
        public void Battre()
        {
            Console.WriteLine("Boom Boom");
        }
        public void Stop()
        {
            Console.WriteLine("Bip bip biiiiiiiiiiiiiip");
        }
    }
    public class Chien2 : Animal2
    {
        public override void SeDeplacer()
        {
           Console.WriteLine("whouf whouf je me déplace avec mes 4 pattes !");
        }
    }
}
