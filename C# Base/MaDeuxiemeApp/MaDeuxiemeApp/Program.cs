using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaDeuxiemeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("nicolas", 28);
            person.SayHi();
        }
        public class Person
        {
            public string m_name { get; set; }

            public int m_age { get; set; }

            public Person()
            {
                Console.WriteLine("Nouvelle personne créée.");
            }

            public Person(string name, ushort age)
            {
                this.m_age = age;
                this.m_name = name;
                Console.WriteLine("Nouvelle personne créée. Cette personne s'appelle " + name + " et a " + age + " an(s).");
            }
            ~Person()
            {
                Console.WriteLine("Objet détruit.");
            }
            public void SayHi()
            {
                Console.WriteLine("Bonjour ! Je m'appelle " + this.m_name + " et j'ai " + this.m_age + " ans.");
            }
        }
    }
}
