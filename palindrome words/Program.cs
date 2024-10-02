using System;

namespace palindrome_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a string");
            string str = Console.ReadLine();
            char[] StringArr = str.ToCharArray();
            Array.Reverse(StringArr);
            string ReverseString = new string(StringArr);
            Console.WriteLine(ReverseString);

            Console.ReadLine();
            if (str == ReverseString)
            {
                Console.WriteLine(str + " is palindrome word");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(str + " is not palindrome word");
                Console.ReadLine();
            }
        }
    }
}
