using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that tells you whether a name is a palindrome or not. Assume all letters are lower-case.
            // A 'palindrome' name is a name that reads the same backward as forward, e.g., "hannah" or "kayak".
            string name = Console.ReadLine();
            bool flag = true; // 'false' if we have found a character that is not equal to its corresponding character.'true' otherwise.
            for (int i = 0; i < name.Length / 2; i++) // we only need to iterate through half of the string.(that means we have traversed all of the string).
            {                
                if (name[i] != name[name.Length - 1 - i]) // if the character and its corresponding one are not equal.
                {
                    flag = false;
                    // We found a character that is not the same as it corresponding one. Jump out.
                    break;
                }
            }

            if (flag == false)
                Console.WriteLine("It is Not a palindrome.");
            else
                Console.WriteLine("It is a palindrome.");
        }
    }    
}
