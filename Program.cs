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
        String name = "Peruna Esim";
        int Age = 30;
        String gender = "attackhelicopter";

        // constructor with 0 argument
        Hooman() 
        {

        }
        // constructor with one argument
        Hooman(string name)
        {
            this.name = name;
        }

        // Constructor with 2 arguments
        Hooman(string name, int age) 
        {
            this.name = name;
            this.Age = age;
        }
        // Constructor with 3 arguments
        Hooman(string name, int age, string gender) 
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
        }
    }
}