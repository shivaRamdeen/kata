using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tribonacci Sequence");
            Xbonacci x = new Xbonacci();
            double[] sig = { 17, 7, 4 };
            x.Tribonacci(sig,7);
            Console.ReadLine();
        }
    }
}
