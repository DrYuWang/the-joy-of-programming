using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsMammal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose one of the followings. We tell you whether it is a mammal or not. ");
            Console.WriteLine("Monotreme, Pinguin, Platypus, Human, Echidna");
            string animalName = Console.ReadLine();
            if (animalName != "Pinguin")
            {
                Console.WriteLine($"{animalName} is a mammal.");
            }
            else
            {
                Console.WriteLine($"{animalName} is NOT a mammal.");
            }

        }
    }
}
