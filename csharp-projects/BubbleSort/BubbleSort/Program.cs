using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort an array from smallest to largest.
            int[] num = new int[] { 1, 2, 7, 1, 4, 3};
            bool flag = true; // Tells whether at least one swapping action has happened.
            do
            {
                flag = true;
                // Traverse the array and swap any two adjacent elements that are not in the increasing order.
                for (int i = 0; i < num.Length - 1; i++)
                {
                    if (num[i + 1] < num[i]) // if in decreasing order
                    {
                        // Swap them
                        int temp = num[i + 1];
                        num[i + 1] = num[i];
                        num[i] = temp;
                        flag = false; // a swap has happended.
                    }
                }
            } while (!flag); // continue the loop as long as one swapping action has happened. Otherwise, jump out.
            // Print out the array.
            for (int j = 0; j < num.Length; j++)
            {
                Console.WriteLine(num[j]);
            }
        }
    }
}
