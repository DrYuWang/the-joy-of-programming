using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MargaretHamilton
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that gets 4 string values as follows:
            //  1.	your name
            //  2.	date of birth
            //  3.	place of your birth
            //  4.	a cool project you will worked on in the future
            //  Then print the following(sample output):
            //  Margaret Hamilton is a software engineer.This person was born on August 17, 1936 in Paoli, Indiana, USA.This person worked on the Apollo project.

            Console.WriteLine("Please, enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please, enter your birth date:  ");
            string birthdate = Console.ReadLine();
            Console.WriteLine("Please, enter your birth place:  ");
            string birthPlace = Console.ReadLine();
            Console.WriteLine("Please, enter your cool project name:  ");
            string projectName = Console.ReadLine();
            Console.WriteLine($"{name} is a software engineer. This person was born on {birthdate} in {birthPlace}. This person worked on {projectName}.");
        }
    }
}
