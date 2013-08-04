using System;
using System.Numerics;


class FactorialsNAndKNext
{
    static void Main()
    {

        BigInteger result = 1;

        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
            
        if (k > n && n > 1)
        {
            for (uint i = 1; i <= k; i++)
            {
                if (i <= n)
                {
                    result *= i;
                }

                if (i >= (k - n + 1))
                {
                    result *= i;
                }
            }

            Console.WriteLine("The result is: {0}", result);
        }
        else
        {
            Console.WriteLine("Wrong numbers entered!");
        }
        
    }
}

