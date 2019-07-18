using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNoodleCooker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the noodle cooker's water temperature:");
            double temperature = double.Parse(Console.ReadLine());
            bool isCold = temperature < 90; // [Centigrade]
            if (isCold)
                Console.WriteLine("The heating element turns ON.");
        }
    }
}
