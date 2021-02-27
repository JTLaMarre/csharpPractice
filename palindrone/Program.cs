using System;

namespace palindrone
{
    class Program
    {
        static void Main(string[] args)
        {
            chkPalindrome("tacocat");
            chkPalindrome("taco cat");
            chkPalindrome("Hello World");
        }

        internal static void chkPalindrome(string str)
        {
            bool flag = false;
            for(int i=0,j=str.Length-1;i<str.Length/2;i++,j--)
            {
                if(str[i]!=str[j])
                {
                    flag =false;
                    break;
                }
                else
                {
                    flag=true;
                }
            }
            if(flag)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
