using System;
using System.Numerics;

//In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
//Write a program to calculate the Nth Catalan number by given N.
//The task is presented in 10.


class CatalanFormula
{
    static void Main()
    {
        int n;
        do
        {
            n = int.Parse(Console.ReadLine());
        } while (n < 0);
        BigInteger n2Fact = 1;
        BigInteger n2Plus1Fact = 1;
        BigInteger Nfact = 1;
        for (int i = 1; i <= n; i++)
        {
            Nfact *= i;
        }
        for (int k = 1; k <= 2 * n; k++)
        {
            n2Fact *= k;
        }
        for (int j = 1; j <= n + 1; j++)
        {
            n2Plus1Fact *= j;
        }
        Console.WriteLine(n2Fact / (n2Plus1Fact * Nfact));
    }
}

