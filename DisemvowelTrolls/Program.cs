using System;
using System.Text.RegularExpressions;

//Link to problem
//https://www.codewars.com/kata/disemvowel-trolls/csharp
namespace DisemvowelTrolls
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string Disemvowel(string str)
        {
            string pattern = "[aeiouAEIOUyY]";
            string replacement = "";

            Regex regEx = new Regex(pattern);
            string trolled = regEx.Replace(str, replacement);
            return trolled;
        }
    }
}
