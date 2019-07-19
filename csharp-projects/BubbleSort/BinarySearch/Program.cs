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
            int[] nums = { 2, 2, 3, 3, 4, 6, 54, 56 }; // a sorted array.
            int index = GetIndexOf(2, nums);

            Console.WriteLine(index);
        }

        private static int GetIndexOf(int value, int[] array)
        {
            // Write a program that uses the binary search to find the index of a given number in
            // a sorted array. 
            // Note: Binary search only works in a sorted sequence.

            // Array.Sort(nums); // Sorts the array if it's not sorted.
            int lowerBound = 1;
            int upperBound = array.Length;
            int givenNumber = 2;
            int index = 0;

            while (lowerBound <= upperBound)
            {
                int midPoint = (lowerBound + upperBound) / 2;
                if (array[midPoint] > givenNumber)
                    upperBound = midPoint - 1;
                else if (array[midPoint] < givenNumber)
                    lowerBound = midPoint + 1;
                else // equal to value
                {
                    index = midPoint;
                    break;
                }
            }

            return index;
        }
    }
}
