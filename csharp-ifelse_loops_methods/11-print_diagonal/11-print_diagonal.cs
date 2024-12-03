using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length > 0)
        {
            for (int i = 0; i < length; i++)
                Console.WriteLine("{0}\\", new string(' ', i));
            Console.WriteLine();
        }
        else
            Console.WriteLine();
    }
}