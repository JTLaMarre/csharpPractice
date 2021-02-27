using System;
using System.Collections.Generic;

namespace find_n_pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding the amount of pairs that equal 7 in the array.");
            int[] array ={5,2,3,4};
            var dict = new Dictionary<int, int>();

            find_n_pairs(array);
        }

        static void find_n_pairs(int[] array)
        {
            foreach(var number in array)
            {
                
            }
        }
    }
}
