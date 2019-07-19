using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that uses the binary search to find the index of a given number in
            // a sorted array. If the number does not exist, it should return -1.
            // Note: Binary search only works on a sorted sequence.
            
            int[] nums = { 2, 2, 3, 3, 4, 6, 54, 56 }; // a sorted array.
            // Array.Sort(nums); // Sorts the array if it's not sorted.
            int index = GetIndexOf(2, nums);            
            Console.WriteLine(index);
        }
        /// <summary>
        /// Returns the index of a given number in a given array. If the number does not exist, 
        /// returns -1.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        private static int GetIndexOf(int number, int[] array)
        { 
            int lowerBound = 1;
            int upperBound = array.Length;
            while (lowerBound <= upperBound)
            {
                int midPoint = (lowerBound + upperBound) / 2;
                if (array[midPoint] > number)
                    upperBound = midPoint - 1;
                else if (array[midPoint] < number)
                    lowerBound = midPoint + 1;
                else // equal to value
                {
                    return midPoint;                    
                }
            }
            return -1;
        }
    }
}
