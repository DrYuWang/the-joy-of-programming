using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that calculates the average of
            // a given double array and returns it.                                   
            double[] myNums = new double[] { 1, 2, 3, 4 };
            Console.WriteLine($"The average is {GetAverage(myNums)}");
        }
        /// <summary>
        /// Returns the average of a double array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        static public double GetAverage(double[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum / nums.Length;
        }
    }
}
