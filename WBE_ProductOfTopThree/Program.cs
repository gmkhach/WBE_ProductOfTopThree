/*
 * Find the product of the highest 3 numbers of an input array
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WBE_ProductOfTopThree
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("\nInput an array of integers\n\n>>> ");
                    int[] input = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();
                    Console.WriteLine($"\nProduct of top 3 numbers: {ProductOfTopThree(input)}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message);
                }
                Console.Write("\nPress Enter to do another division...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        private static int ProductOfTopThree(int[] arr)
        {
            int max1 = 0;
            int max2 = 0;
            int max3 = 0;
            // compares every number in the array with each other and picks the top three
            foreach (var n in arr)
            {
                if (n > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = n;
                }
                else if (n > max2)
                {
                    max3 = max2;
                    max2 = n;
                }
                else if (n > max3)
                {
                    max3 = n;
                }
            }
            return max1 * max2 * max3;
        }
    }
}
