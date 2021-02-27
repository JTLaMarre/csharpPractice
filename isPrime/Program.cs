using System;

namespace isPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Prime!");
            isPrime(7);
            isPrime(10);
        }
        static void isPrime(int num)
        {
            int a = 0;
            for (int i = 1; i <= num; i++) 
            {
                if (num % i == 0) 
                {
                     a++;
                }
            }
            if(a>2)
            {
                Console.WriteLine(num+" is not a prime number");
            }
            else
            {
                Console.WriteLine(num+" is a Prime Number");
            }
        }
    }
}
