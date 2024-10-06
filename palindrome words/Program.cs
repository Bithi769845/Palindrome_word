using System;

namespace palindrome_words
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string str ;
            Console.WriteLine("Enter a string");
            str=Console.ReadLine();

            string revString = "";
            string RevStringA = "";
            for (int i = 0; i < str.Length; i++)
            {

                revString += str[str.Length - i - 1];


            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                RevStringA += str[i];
            }



            if (str == revString || str == RevStringA)
            {
                Console.WriteLine("It is a plandrome word");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("It is not a plandrome word");
                Console.ReadLine() ;
            }
         
        }
    }
}
