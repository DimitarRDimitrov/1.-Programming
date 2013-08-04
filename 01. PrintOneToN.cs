using System;

//Write a program that prints all the numbers from 1 to N.

class PrintOneToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine(i);
        }


    }
}

