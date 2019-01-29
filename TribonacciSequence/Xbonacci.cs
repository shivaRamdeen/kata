using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribonacciSequence
{
    public class Xbonacci
    {
        public double[] Tribonacci(double[] signature, int n)
        {
            List<double> result = new List<double>();
            if(n == 0)
            {
                return result.ToArray();
            }

            //push inital values to list
            result.AddRange(signature);

            for(int i=3;i<n;i++)
            {
                var last3 = result.Skip(Math.Max(0, result.Count()) - 3);
                var answer = last3.Sum();
                Console.Write(answer + ",");
                result.Add(answer);
            }

            return result.ToArray();

        }
    }
}
