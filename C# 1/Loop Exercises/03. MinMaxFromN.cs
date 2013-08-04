using System;

class MinMaxFromN
{
    static void Main()
    {
        Console.Write("How many numbers will you compare? ");
        int lastNumber = int.Parse(Console.ReadLine());
        int currentNumber;
        int smallest;
        int biggest;
        Console.Write("Enter the 1 number: ");
        currentNumber = int.Parse(Console.ReadLine());
        smallest = biggest = currentNumber;
        for (int i = 1; i < lastNumber; i++)
        {
            Console.Write("Enter the {0} number: ", i + 1);
            currentNumber = int.Parse(Console.ReadLine());
            if (biggest < currentNumber)
            {
                biggest = currentNumber;
            }
            if (smallest > currentNumber)
            {
                smallest = currentNumber;
            }
        }
        Console.WriteLine("The smallest is {0}", smallest);
        Console.WriteLine("The biggest is {0}", biggest);
    }
}

