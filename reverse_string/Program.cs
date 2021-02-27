using System;

namespace reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseString("Hello World!");
        }
        internal static void ReverseString(string st)
        {
            char[] charArray = st.ToCharArray();
            for(int i=0, j=st.Length-1;i<j;i++,j--)
            {
                charArray[i]=st[j];
                charArray[j]=st[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }
    }
}
