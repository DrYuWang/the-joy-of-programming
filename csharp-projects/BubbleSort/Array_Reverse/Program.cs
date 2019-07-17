using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6};
            for (int i = 0; i < nums.Length/2; i++)
            {                
                int temp = nums[i];
                nums[i] = nums[nums.Length - 1 - i];
                nums[nums.Length - 1 - i] = temp;
            }

            // Print out the array.
            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine(nums[j]);
            }
        }
    }
}
