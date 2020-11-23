using System;

namespace ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            string unicodestring =
                "this string has 2 characters outside the" +
                "ASCII range: \n" +
                "Pi (\u03A0) , and sigma (\u03A0).";
            Console.WriteLine("stringa originale/oriinal string");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine(unicodestring);
            Console.WriteLine();
        }
    }
}
