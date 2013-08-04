using System;
using System.Numerics;
//Write a program that calculates N!/K! for given N and K (1<K<N).


class NDivByK
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger Nfac = 1;
        BigInteger Kfac = 1;
        BigInteger result;

        for (int i = 1; i <= n; i++)
        {
            Nfac = Nfac * i;
        }


        for (int i = 1; i <= k; i++)
        {
            Kfac = Kfac * i;
        }

       
        result = Nfac / Kfac;
        Console.WriteLine(result);
    
    }
}

