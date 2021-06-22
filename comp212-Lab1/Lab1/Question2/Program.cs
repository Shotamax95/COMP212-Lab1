using System;
using System.Text;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("This is to test whether the extension method count can return a right answer or not");
            Console.WriteLine("Number of words : " + sb.WordsCount());
            Console.ReadKey();
        }
    }

    public static class StringExtension
    {
        public static int WordsCount(this StringBuilder sb)
        {
            return sb.ToString().Split(' ').Length;
        }

    }
}

