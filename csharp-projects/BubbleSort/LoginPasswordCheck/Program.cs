using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPasswordCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the password to enter our secret cult: ");
            string userInput = Console.ReadLine();
            if (userInput.Equals("JackIsBack!"))
            {
                Console.WriteLine("Correct!, enter to our world with unfounded beliefs!");
            }
            else
            {
                Console.WriteLine("Wrong value for password! Go away!");
            }
        }
    }
}
