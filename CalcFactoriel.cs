using System;
using System.Numerics;

namespace Factoriel
{
    class CalcFactoriel
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());  // read number from console
            BigInteger result = 1;  // lets result be of a type BigInteger to avoid  small type limits

            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);

        }
    }
}
