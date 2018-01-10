using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaPremierApp
{
    public class Animal
    {
        protected string prenom;

        public Animal(string prenomAnimal)
        {
            prenom = prenomAnimal;
        }


        public void Respirer()
        {
            Console.WriteLine("Je suis " + prenom + " et je respire.");
        }
    }
    public class Chien 
    {
        public string Prenom { get; set; }

        public override string ToString()
        {
            return "Je suis un chien et je m'appelle : " + Prenom;
        }
        public virtual void Aboyer()
        {
            Console.WriteLine("Whouf");
        }
    }

    public class ChienMuet : Chien
    {
        public override void Aboyer()
        {
            Console.WriteLine("...");
        }
    }

     
   
    


    
    
    public class Chat : Animal
    {
        public Chat(string PrenomDuChat) : base(PrenomDuChat)
        {
        }

        public void Miauler()
        {
            Console.WriteLine("Miaou !");
        }
    }
}
