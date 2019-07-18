using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDeepFryer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the deep fryer's oil temperature:");
            double temperature = double.Parse(Console.ReadLine());
            bool isCold = temperature < 370;  // [Fahrenheit]
            bool tooHot = temperature > 380;  // [Fahrenheit]

            if (isCold)
                Console.WriteLine("The heating element turns ON.");
            if (tooHot)
                Console.WriteLine("The heating element turns OFF.");
        }
    }
}
