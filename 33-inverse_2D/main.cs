using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix = {{6, 16}, {5, 2}};

        foreach (var item in MatrixMath.Inverse2D(matrix))
        {
            Console.WriteLine(item);
        }
    }
}
