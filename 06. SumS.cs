using System;

////Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

class SumS
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        decimal resultTemp = 1;
        decimal NFactorial = 1;
        decimal sumS = 0;
        for (int i = 1; i <= n; i++)
        {
            NFactorial *= i;
            resultTemp *= x;
            sumS += (NFactorial / resultTemp);
        }
        Console.WriteLine(1 + sumS);
    }
}

