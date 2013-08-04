using System;

class SimpleMatrix
{
    static void Main(string[] args)
    {
        Console.Write("Enter matrix size: ");
        int matrix = int.Parse(Console.ReadLine());
        Console.WriteLine();

       
        for (int rows = 1; rows <= matrix; rows++)
        {
            Console.WriteLine();

            for (int col = rows; col < rows + matrix; col++)
            {
                Console.Write("{0,3} ", col);
            }

            Console.WriteLine();
        }
     
    }
}
