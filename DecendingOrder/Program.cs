using System;
using System.Collections.Generic;

//Link to problem
//https://www.codewars.com/kata/descending-order/train/csharp
namespace DescendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DescendingOrder(1021).ToString());
            Console.ReadLine();
        }

        public static int DescendingOrder(int num)
        {
            List<int> numAsList = Listify(num);
            numAsList.Sort();
            numAsList.Reverse();
            return Intify(numAsList);
        }

        private static List<int> Listify(int num)
        {
            string s = num.ToString();
            List<int> result = new List<int>();
            
            for( int i=0; i < s.Length; i++)
            {
                int thisInt;
                Int32.TryParse(s.Substring(i, 1), out thisInt);
                result.Add(thisInt);
            }

            return result;

        }

        private static int Intify(List<int> sortedInt)
        {
            int result = 0;
            int[] arr = sortedInt.ToArray();
            for( int i = 0; i< arr.Length; i++ )
            {
                result = 10 * result + arr[i];
            }

            return result;
        }
    }
}