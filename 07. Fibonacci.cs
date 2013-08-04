using System;
using System.Numerics;
//Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …


class Fibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger temp = 0;
        BigInteger firstNum = 0;
        BigInteger secondNum = 1;
        BigInteger sum = 0;
        if (n == 0 || n == 1)
        {
            Console.WriteLine(0);
        }
        else
        {
            for (int i = 0; i < (n - 2); i++)
            {
                temp = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = temp;
                sum += temp;
            }
            Console.WriteLine(1 + sum);
        }
    }
}

