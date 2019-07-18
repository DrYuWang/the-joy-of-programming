using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that calculates factorial of a number 
            // (any number below or equal 16)
            Console.WriteLine("Enter a number below or equal 16.");
            int x = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= x; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine($"Its factorial is {factorial}");
        }
    }
}
