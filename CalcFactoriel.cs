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
                         
            for (int i = 2; i <= number; i++)    // We can start multiplying from 2 to save one unnecessay  
            {                                    // cycle and multiplication of  1;
                result = result * i;
            }
            Console.WriteLine(result);

        }
    }
}
