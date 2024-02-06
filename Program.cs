using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CSLuokkaHarjoituksia1
{
    class Hooman
    {
        // Define properties of Hooman
        public String name = "Peruna Esim";
        public int Age = 30;
        public String gender = "attackhelicopter";

        // constructor with 0 argument
        public Hooman() 
        {

        }
        // constructor with one argument
        public Hooman(string name)
        {
            this.name = name;
        }

        // Constructor with 2 arguments
        public Hooman(string name, int age) 
        {
            this.name = name;
            this.Age = age;
        }
        // Constructor with 3 arguments
        public Hooman(string name, int age, string gender) 
        {
            this.name = name;
            this.Age = age;
            this.gender = gender;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create (instantiate) a Hooman Object from Hooman class
            Hooman owner = new Hooman("Ossi Omistaja", 35, "Suihkuturbiinimoottori");

            // call of SayOpinion method
            owner.SayOpinion();

            // Keep the window open until enter pressed

            string who = owner.name + " " + owner.Age;

            Console.WriteLine("totesi " + who);


            Console.ReadLine();
        }
    }
}